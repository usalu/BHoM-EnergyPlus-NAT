using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:Week:Daily contains 12 Schedule:Day:Hourly objects, one for each day t" +
                 "ype.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Week_Daily : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="sunday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SundayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="monday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MondayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="tuesday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TuesdayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="wednesday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WednesdayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="thursday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThursdayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="friday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FridayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="saturday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SaturdayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="holiday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HolidayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="summerdesignday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SummerdesigndayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="winterdesignday_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WinterdesigndayScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="customday1_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Customday1ScheduleDayName { get; set; } = "";
        

        [JsonProperty(PropertyName="customday2_schedule_day_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Customday2ScheduleDayName { get; set; } = "";
    }
}