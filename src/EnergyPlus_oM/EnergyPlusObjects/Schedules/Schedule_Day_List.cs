using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("Schedule:Day:List will allow the user to list 24 hours worth of values, which can" +
                 " be sub-hourly in nature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_Day_List : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_type_limits_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [Description(@"when the interval does not match the user specified timestep a ""Average"" choice will average between the intervals request (to timestep resolution. A ""No"" choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not. A ""Linear"" choice will interpolate linearly between successive values.")]
        [JsonProperty(PropertyName="interpolate_to_timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Schedule_Day_List_InterpolateToTimestep InterpolateToTimestep { get; set; } = (Schedule_Day_List_InterpolateToTimestep)Enum.Parse(typeof(Schedule_Day_List_InterpolateToTimestep), "No");
        

        [Description("Must be evenly divisible into 60")]
        [JsonProperty(PropertyName="minutes_per_item", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinutesPerItem { get; set; } = null;
        

        [JsonProperty(PropertyName="extensions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Extensions { get; set; } = "";
    }
}