using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Day_Interval_Data_Item
    {
        

        [JsonProperty(PropertyName="time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Time { get; set; } = "";
        

        [JsonProperty(PropertyName="value_until_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ValueUntilTime { get; set; } = null;
    }
}