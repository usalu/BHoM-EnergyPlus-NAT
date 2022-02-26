using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Year_ScheduleWeeks_Item
    {
        

        [JsonProperty(PropertyName="schedule_week_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleWeekName { get; set; } = "";
        

        [JsonProperty(PropertyName="start_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="start_day", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartDay { get; set; } = null;
        

        [JsonProperty(PropertyName="end_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="end_day", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndDay { get; set; } = null;
    }
}