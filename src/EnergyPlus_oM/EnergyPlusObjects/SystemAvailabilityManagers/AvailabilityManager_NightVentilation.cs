using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("depending on zone and outdoor conditions overrides fan schedule to do precooling " +
                 "with outdoor air")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManager_NightVentilation : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="applicability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanScheduleName { get; set; } = "";
        

        [Description("One zone temperature must be above this scheduled temperature for night ventilati" +
                     "on to be enabled")]
        [JsonProperty(PropertyName="ventilation_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VentilationTemperatureScheduleName { get; set; } = "";
        

        [Description("The outdoor air temperature minus the control zone temperature must be greater th" +
                     "an the ventilation delta T")]
        [JsonProperty(PropertyName="ventilation_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VentilationTemperatureDifference { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Night ventilation is disabled if any conditioned zone served by the system falls " +
                     "below this temperature")]
        [JsonProperty(PropertyName="ventilation_temperature_low_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VentilationTemperatureLowLimit { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("the fraction (could be > 1) of the design system Flow Rate at which night ventila" +
                     "tion will be done")]
        [JsonProperty(PropertyName="night_venting_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NightVentingFlowFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("When AvailabilityManager:NightVentilation is used in the zone component availabil" +
                     "ity manager assignment list, the Control Zone Name should be the name of the zon" +
                     "e in which the zone component is.")]
        [JsonProperty(PropertyName="control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneName { get; set; } = "";
    }
}