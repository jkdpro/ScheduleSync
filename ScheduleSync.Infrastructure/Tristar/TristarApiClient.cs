using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using ScheduleSync.Infrastructure.Tristar.Models;

namespace ScheduleSync.Infrastructure.Tristar
{
    public sealed class TristarApiClient
    {
        private static readonly HttpClient SharedHttpClient = new HttpClient();
        private static readonly Uri DefaultStopsEndpoint = new Uri("https://api.zdiz.gdynia.pl/gtfs/stops");

        private readonly HttpClient _httpClient;
        private readonly Uri _stopsEndpoint;

        public TristarApiClient()
            : this(SharedHttpClient, DefaultStopsEndpoint)
        {
        }

        public TristarApiClient(HttpClient httpClient, Uri stopsEndpoint)
        {
            if (httpClient == null)
            {
                throw new ArgumentNullException("httpClient");
            }

            if (stopsEndpoint == null)
            {
                throw new ArgumentNullException("stopsEndpoint");
            }

            if (!stopsEndpoint.IsAbsoluteUri)
            {
                throw new ArgumentException("The stops endpoint must be an absolute URI.", "stopsEndpoint");
            }

            _httpClient = httpClient;
            _stopsEndpoint = stopsEndpoint;
        }

        public Uri StopsEndpoint
        {
            get { return _stopsEndpoint; }
        }

        public async Task<IList<Stop>> GetStopsAsync()
        {
            using (HttpResponseMessage response = await _httpClient.GetAsync(_stopsEndpoint).ConfigureAwait(false))
            {
                string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (!response.IsSuccessStatusCode)
                {
                    throw new TristarApiException(_stopsEndpoint, response.StatusCode, response.ReasonPhrase, responseBody);
                }

                using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(responseBody)))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Stop>));
                    List<Stop> stops = serializer.ReadObject(stream) as List<Stop>;
                    if (stops == null)
                    {
                        throw new SerializationException("The Tristar stops response was not a JSON array.");
                    }

                    return stops;
                }
            }
        }
    }

    public sealed class TristarApiException : Exception
    {
        public TristarApiException(Uri requestUri, HttpStatusCode statusCode, string reasonPhrase, string responseBody)
            : base("The Tristar API returned HTTP " + (int)statusCode + " " + reasonPhrase + ".")
        {
            RequestUri = requestUri;
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
            ResponseBody = responseBody;
        }

        public Uri RequestUri { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public string ReasonPhrase { get; private set; }

        public string ResponseBody { get; private set; }
    }
}
