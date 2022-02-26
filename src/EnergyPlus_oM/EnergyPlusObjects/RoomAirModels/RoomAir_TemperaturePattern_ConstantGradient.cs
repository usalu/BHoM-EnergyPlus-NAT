using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Used to model room air with a fixed temperature gradient in the vertical directio" +
                 "n. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_ConstantGradient : BHoMObject
    {
        

        [JsonProperty(PropertyName="room_air_temperature_pattern_constant_gradient_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomAirTemperaturePatternConstantGradientName { get; set; } = "";
        

        [Description("reference this entry in Schedule Name")]
        [JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= (Temp at thermostat- Mean Air Temp)")]
        [JsonProperty(PropertyName="thermostat_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermostatOffset { get; set; } = null;
        

        [Description("= (Tleaving - Mean Air Temp )")]
        [JsonProperty(PropertyName="return_air_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnAirOffset { get; set; } = null;
        

        [Description("= (Texhaust - Mean Air Temp) deg C")]
        [JsonProperty(PropertyName="exhaust_air_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExhaustAirOffset { get; set; } = null;
        

        [Description("Slope of temperature change in vertical direction")]
        [JsonProperty(PropertyName="temperature_gradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureGradient { get; set; } = null;
    }
}