using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the availability of a loop or system: whether it is on or off. Dependi" +
                 "ng on zone temperatures, overrides Schedules and forces system Fans on.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManager_NightCycle : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="applicability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanScheduleName { get; set; } = "";
        

        [Description("When AvailabilityManager:NightCycle is used in the zone component availability ma" +
                     "nager assignment list, the key choices for Control Type would only be StayOff an" +
                     "d CycleOnControlZone")]
        [JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AvailabilityManager_NightCycle_ControlType ControlType { get; set; } = (AvailabilityManager_NightCycle_ControlType)Enum.Parse(typeof(AvailabilityManager_NightCycle_ControlType), "StayOff");
        

        [JsonProperty(PropertyName="thermostat_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermostatTolerance { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cycling_run_time_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AvailabilityManager_NightCycle_CyclingRunTimeControlType CyclingRunTimeControlType { get; set; } = (AvailabilityManager_NightCycle_CyclingRunTimeControlType)Enum.Parse(typeof(AvailabilityManager_NightCycle_CyclingRunTimeControlType), "FixedRunTime");
        

        [JsonProperty(PropertyName="cycling_run_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CyclingRunTime { get; set; } = Double.Parse("3600", CultureInfo.InvariantCulture);
        

        [Description("When AvailabilityManager:NightCycle is used in the zone component availability ma" +
                     "nager assignment list, the Control Zone Name should be the name of the zone in w" +
                     "hich the zone component is.")]
        [JsonProperty(PropertyName="control_zone_or_zone_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneOrZoneListName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_control_zone_or_zone_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingControlZoneOrZoneListName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_control_zone_or_zone_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingControlZoneOrZoneListName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_zone_fans_only_zone_or_zone_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingZoneFansOnlyZoneOrZoneListName { get; set; } = "";
    }
}