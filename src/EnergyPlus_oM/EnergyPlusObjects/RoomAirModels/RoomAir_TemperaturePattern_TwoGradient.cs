using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Used to model room air with two temperature gradients in the vertical direction. " +
                 "Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_TwoGradient : BHoMObject
    {
        

        [JsonProperty(PropertyName="room_air_temperature_pattern_two_gradient_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomAirTemperaturePatternTwoGradientName { get; set; } = "";
        

        [Description("reference this entry in Schedule Name")]
        [JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= Distance from floor of zone")]
        [JsonProperty(PropertyName="thermostat_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermostatHeight { get; set; } = null;
        

        [Description("= Distance from floor of zone")]
        [JsonProperty(PropertyName="return_air_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnAirHeight { get; set; } = null;
        

        [Description("= Distance from floor of zone")]
        [JsonProperty(PropertyName="exhaust_air_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExhaustAirHeight { get; set; } = null;
        

        [Description("Slope of temperature change in vertical direction")]
        [JsonProperty(PropertyName="temperature_gradient_lower_bound", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureGradientLowerBound { get; set; } = null;
        

        [Description("Slope of temperature change in vertical direction")]
        [JsonProperty(PropertyName="temperature_gradient_upper_bound", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureGradientUpperBound { get; set; } = null;
        

        [JsonProperty(PropertyName="gradient_interpolation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode GradientInterpolationMode { get; set; } = (RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode)Enum.Parse(typeof(RoomAir_TemperaturePattern_TwoGradient_GradientInterpolationMode), "OutdoorDryBulbTemperature");
        

        [JsonProperty(PropertyName="upper_temperature_bound", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UpperTemperatureBound { get; set; } = null;
        

        [JsonProperty(PropertyName="lower_temperature_bound", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowerTemperatureBound { get; set; } = null;
        

        [JsonProperty(PropertyName="upper_heat_rate_bound", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UpperHeatRateBound { get; set; } = null;
        

        [JsonProperty(PropertyName="lower_heat_rate_bound", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowerHeatRateBound { get; set; } = null;
    }
}