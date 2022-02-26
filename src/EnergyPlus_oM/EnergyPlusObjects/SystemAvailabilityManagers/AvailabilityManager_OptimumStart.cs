using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Determines the optimal start of HVAC systems before occupancy.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManager_OptimumStart : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="applicability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplicabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AvailabilityManager_OptimumStart_ControlType ControlType { get; set; } = (AvailabilityManager_OptimumStart_ControlType)Enum.Parse(typeof(AvailabilityManager_OptimumStart_ControlType), "ControlZone");
        

        [JsonProperty(PropertyName="control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneListName { get; set; } = "";
        

        [Description("this is the maximum number of hours that a system can start before occupancy")]
        [JsonProperty(PropertyName="maximum_value_for_optimum_start_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueForOptimumStartTime { get; set; } = Double.Parse("6", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="control_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AvailabilityManager_OptimumStart_ControlAlgorithm ControlAlgorithm { get; set; } = (AvailabilityManager_OptimumStart_ControlAlgorithm)Enum.Parse(typeof(AvailabilityManager_OptimumStart_ControlAlgorithm), "AdaptiveASHRAE");
        

        [JsonProperty(PropertyName="constant_temperature_gradient_during_cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantTemperatureGradientDuringCooling { get; set; } = null;
        

        [JsonProperty(PropertyName="constant_temperature_gradient_during_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantTemperatureGradientDuringHeating { get; set; } = null;
        

        [JsonProperty(PropertyName="initial_temperature_gradient_during_cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialTemperatureGradientDuringCooling { get; set; } = null;
        

        [JsonProperty(PropertyName="initial_temperature_gradient_during_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialTemperatureGradientDuringHeating { get; set; } = null;
        

        [Description("this is the number of hours before occupancy for a system")]
        [JsonProperty(PropertyName="constant_start_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantStartTime { get; set; } = null;
        

        [Description("this is the number of days that their actual temperature gradients will be used i" +
                     "n the AdaptiveTemperatureGradient method")]
        [JsonProperty(PropertyName="number_of_previous_days", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfPreviousDays { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
    }
}