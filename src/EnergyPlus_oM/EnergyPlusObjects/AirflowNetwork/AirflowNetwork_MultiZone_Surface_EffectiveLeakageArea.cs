using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to define surface air leakage.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the effective leakage area.")]
        [JsonProperty(PropertyName="effective_leakage_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveLeakageArea { get; set; } = null;
        

        [Description("Enter the coefficient used in the air mass flow equation.")]
        [JsonProperty(PropertyName="discharge_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeCoefficient { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Enter the pressure difference used to define the air mass flow coefficient and ex" +
                     "ponent.")]
        [JsonProperty(PropertyName="reference_pressure_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferencePressureDifference { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("Enter the exponent used in the air mass flow equation.")]
        [JsonProperty(PropertyName="air_mass_flow_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowExponent { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
    }
}