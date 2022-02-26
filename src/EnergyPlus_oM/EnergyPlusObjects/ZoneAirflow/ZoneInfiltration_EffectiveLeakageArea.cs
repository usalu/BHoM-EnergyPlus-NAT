using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("Infiltration is specified as effective leakage area at 4 Pa, schedule fraction, s" +
                 "tack and wind coefficients, and is a function of temperature difference and wind" +
                 " speed: Infiltration=FSchedule * (AL /1000) SQRT(Cs*|(Tzone-Todb)| +  Cw*WindSpd" +
                 "**2 )")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneInfiltration_EffectiveLeakageArea : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description("\"AL\" in Equation units are cm2 (square centimeters)")]
        [JsonProperty(PropertyName="effective_air_leakage_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveAirLeakageArea { get; set; } = null;
        

        [Description("\"Cs\" in Equation")]
        [JsonProperty(PropertyName="stack_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCoefficient { get; set; } = null;
        

        [Description("\"Cw\" in Equation")]
        [JsonProperty(PropertyName="wind_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindCoefficient { get; set; } = null;
    }
}