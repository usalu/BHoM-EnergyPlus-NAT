using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Week_Compact_Data_Item
    {
        

        [JsonProperty(PropertyName="daytype_list", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DaytypeList { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleDayName { get; set; } = "";
    }
}