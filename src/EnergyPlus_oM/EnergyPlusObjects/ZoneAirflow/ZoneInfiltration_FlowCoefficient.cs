using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("Infiltration is specified as flow coefficient, schedule fraction, stack and wind " +
                 "coefficients, and is a function of temperature difference and wind speed: Infilt" +
                 "ration=FSchedule * SQRT( (c * Cs*|(Tzone-Todb)|**n)**2 + (c* Cw*(s * WindSpd)**2" +
                 "n)**2 )")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneInfiltration_FlowCoefficient : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description("\"c\" in Equation")]
        [JsonProperty(PropertyName="flow_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlowCoefficient { get; set; } = null;
        

        [Description("\"Cs\" in Equation")]
        [JsonProperty(PropertyName="stack_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCoefficient { get; set; } = null;
        

        [Description("\"n\" in Equation")]
        [JsonProperty(PropertyName="pressure_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PressureExponent { get; set; } = Double.Parse("0.67", CultureInfo.InvariantCulture);
        

        [Description("\"Cw\" in Equation")]
        [JsonProperty(PropertyName="wind_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindCoefficient { get; set; } = null;
        

        [Description("\"s\" in Equation")]
        [JsonProperty(PropertyName="shelter_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShelterFactor { get; set; } = null;
    }
}