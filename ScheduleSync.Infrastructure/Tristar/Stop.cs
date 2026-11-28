using System.Runtime.Serialization;

namespace ScheduleSync.Infrastructure.Tristar
{
    [DataContract]
    public class Stop
    {
        [DataMember(Name = "stop_id")]
        public int StopId { get; set; }

        [DataMember(Name = "stop_name")]
        public string StopName { get; set; }

        [DataMember(Name = "stop_desc")]
        public string StopDescription { get; set; }

        [DataMember(Name = "stop_lat")]
        public double StopLatitude { get; set; }

        [DataMember(Name = "stop_lon")]
        public double StopLongitude { get; set; }

        [DataMember(Name = "zone_id")]
        public string ZoneId { get; set; }

        [DataMember(Name = "stop_url")]
        public string StopUrl { get; set; }

        [DataMember(Name = "location_type")]
        public string LocationType { get; set; }

        [DataMember(Name = "parent_station")]
        public string ParentStation { get; set; }

        [DataMember(Name = "stop_timezone")]
        public string StopTimezone { get; set; }

        [DataMember(Name = "wheelchair_boarding")]
        public string WheelchairBoarding { get; set; }

        [DataMember(Name = "ticket_zone_border")]
        public int TicketZoneBorder { get; set; }

        [DataMember(Name = "on_demand")]
        public int OnDemand { get; set; }
    }
}
