using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [Description("used for demand limiting ZoneControl:Thermostat objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DemandManager_Thermostats : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="reset_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DemandManager_Thermostats_ResetControl ResetControl { get; set; } = (DemandManager_Thermostats_ResetControl)Enum.Parse(typeof(DemandManager_Thermostats_ResetControl), "Fixed");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty(PropertyName="minimum_reset_duration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumResetDuration { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_heating_setpoint_reset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumHeatingSetpointReset { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_cooling_setpoint_reset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCoolingSetpointReset { get; set; } = null;
        

        [Description("Not yet implemented")]
        [JsonProperty(PropertyName="reset_step_change", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ResetStepChange { get; set; } = null;
        

        [JsonProperty(PropertyName="selection_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DemandManager_Thermostats_SelectionControl SelectionControl { get; set; } = (DemandManager_Thermostats_SelectionControl)Enum.Parse(typeof(DemandManager_Thermostats_SelectionControl), "All");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty(PropertyName="rotation_duration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RotationDuration { get; set; } = null;
        

        [Description("This list is the ZoneControlThermostaticNames object-list")]
        [JsonProperty(PropertyName="thermostats", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Thermostats { get; set; } = null;
    }
}