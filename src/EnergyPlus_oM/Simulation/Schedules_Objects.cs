using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Schedules")]
    public class Schedules_Objects : BHoMObject
    {
        
        public bool ShouldSerializeScheduleTypeLimits_List()
        {
            return (ScheduleTypeLimits_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ScheduleTypeLimits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.ScheduleTypeLimits> ScheduleTypeLimits_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.ScheduleTypeLimits> ();
        
        public bool ShouldSerializeSchedule_Day_Hourly_List()
        {
            return (Schedule_Day_Hourly_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Day:Hourly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Hourly> Schedule_Day_Hourly_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Hourly> ();
        
        public bool ShouldSerializeSchedule_Day_Interval_List()
        {
            return (Schedule_Day_Interval_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Day:Interval", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Interval> Schedule_Day_Interval_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_Interval> ();
        
        public bool ShouldSerializeSchedule_Day_List_List()
        {
            return (Schedule_Day_List_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Day:List", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_List> Schedule_Day_List_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Day_List> ();
        
        public bool ShouldSerializeSchedule_Week_Daily_List()
        {
            return (Schedule_Week_Daily_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Week:Daily", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Daily> Schedule_Week_Daily_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Daily> ();
        
        public bool ShouldSerializeSchedule_Week_Compact_List()
        {
            return (Schedule_Week_Compact_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Week:Compact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Compact> Schedule_Week_Compact_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Week_Compact> ();
        
        public bool ShouldSerializeSchedule_Year_List()
        {
            return (Schedule_Year_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Year", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Year> Schedule_Year_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Year> ();
        
        public bool ShouldSerializeSchedule_Compact_List()
        {
            return (Schedule_Compact_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Compact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Compact> Schedule_Compact_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Compact> ();
        
        public bool ShouldSerializeSchedule_Constant_List()
        {
            return (Schedule_Constant_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:Constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Constant> Schedule_Constant_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_Constant> ();
        

        [JsonProperty(PropertyName="Schedule:File:Shading", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File_Shading Schedule_File_Shading { get; set; } = null;
        
        public bool ShouldSerializeSchedule_File_List()
        {
            return (Schedule_File_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Schedule:File", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File> Schedule_File_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Schedules.Schedule_File> ();
    }
}