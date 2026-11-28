using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleSync.Infrastructure.Tristar;

namespace ScheduleSync.Presentation.WinForms
{
    public partial class StopListTestForm : Form
    {
        private readonly TristarApiClient _tristarApiClient;

        public StopListTestForm()
        {
            InitializeComponent();
            _tristarApiClient = new TristarApiClient();
            AppendLog("Gotowe do pobrania listy przystanków.");
        }

        private async void retrieveStopsButton_Click(object sender, EventArgs e)
        {
            retrieveStopsButton.Enabled = false;
            stopsGrid.DataSource = null;
            AppendLog("Wysłano zapytanie do " + _tristarApiClient.StopsEndpoint);

            try
            {
                IList<Stop> stops = await _tristarApiClient.GetStopsAsync();
                stopsGrid.DataSource = stops;
                SetStopColumnHeaders();
                AppendLog("Odpowiedź: HTTP 200 OK.");
                AppendLog("Pobrano przystanków: " + stops.Count + ".");
            }
            catch (TristarApiException exception)
            {
                AppendLog("Błąd odpowiedzi API: HTTP " + (int)exception.StatusCode + " " + exception.ReasonPhrase + ".");
                if (!string.IsNullOrWhiteSpace(exception.ResponseBody))
                {
                    AppendLog("Treść odpowiedzi: " + exception.ResponseBody);
                }
            }
            catch (HttpRequestException exception)
            {
                AppendLog("Błąd połączenia z API: " + exception.Message);
            }
            catch (SerializationException exception)
            {
                AppendLog("Nie udało się odczytać odpowiedzi API: " + exception.Message);
            }
            catch (TaskCanceledException)
            {
                AppendLog("Zapytanie do API przekroczyło limit czasu.");
            }
            finally
            {
                retrieveStopsButton.Enabled = true;
            }
        }

        private void SetStopColumnHeaders()
        {
            SetColumnHeader("StopId", "ID");
            SetColumnHeader("StopName", "Nazwa");
            SetColumnHeader("StopDescription", "Opis");
            SetColumnHeader("StopLatitude", "Szerokość geograficzna");
            SetColumnHeader("StopLongitude", "Długość geograficzna");
            SetColumnHeader("ZoneId", "Strefa");
            SetColumnHeader("StopUrl", "Adres przystanku");
            SetColumnHeader("LocationType", "Typ lokalizacji");
            SetColumnHeader("ParentStation", "Stacja nadrzędna");
            SetColumnHeader("StopTimezone", "Strefa czasowa");
            SetColumnHeader("WheelchairBoarding", "Dostęp dla wózków");
            SetColumnHeader("TicketZoneBorder", "Granica strefy taryfowej");
            SetColumnHeader("OnDemand", "Na żądanie");
        }

        private void SetColumnHeader(string columnName, string headerText)
        {
            if (stopsGrid.Columns.Contains(columnName))
            {
                stopsGrid.Columns[columnName].HeaderText = headerText;
            }
        }

        private void AppendLog(string message)
        {
            logTextBox.AppendText(DateTime.Now.ToString("HH:mm:ss") + "  " + message + Environment.NewLine);
        }
    }
}
