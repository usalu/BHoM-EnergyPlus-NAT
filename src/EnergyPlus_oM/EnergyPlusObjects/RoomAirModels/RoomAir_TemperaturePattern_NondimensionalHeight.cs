using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"Defines a distribution pattern for air temperatures relative to the current mean air temperature as a function of height. The height, referred to as Zeta, is nondimensional by normalizing with the zone ceiling height. Used in combination with RoomAir:TemperaturePattern:UserDefined.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_NondimensionalHeight : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("this value should appear in as a schedule value")]
        [JsonProperty(PropertyName="control_integer_for_pattern_control_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ControlIntegerForPatternControlScheduleName { get; set; } = null;
        

        [Description("= (Temp at thermostat- Mean Air Temp)")]
        [JsonProperty(PropertyName="thermostat_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermostatOffset { get; set; } = null;
        

        [Description("= (Temp leaving - Mean Air Temp ) deg C")]
        [JsonProperty(PropertyName="return_air_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnAirOffset { get; set; } = null;
        

        [Description(@"= (Temp exhaust - Mean Air Temp) deg C the remaining fields have pairs that describe the relative temperature pattern in the vertical direction of a zone Zeta is the nondimensional height (in z-direction). on [0..1] DeltaTai =  (Tai - MAT) in units of deg. C relative deg C on [-10.0 .. 20.0 ]")]
        [JsonProperty(PropertyName="exhaust_air_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExhaustAirOffset { get; set; } = null;
        

        [JsonProperty(PropertyName="pairs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_NondimensionalHeight_Pairs_Item> Pairs { get; set; } = null;
    }
}