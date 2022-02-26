using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to define supply and return air leaks with respect to the fan" +
                 "\'s maximum air flow rate.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_LeakageRatio : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Defined as a ratio of leak flow rate to the maximum flow rate.")]
        [JsonProperty(PropertyName="effective_leakage_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveLeakageRatio { get; set; } = null;
        

        [Description("Enter the maximum air flow rate in this air loop.")]
        [JsonProperty(PropertyName="maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFlowRate { get; set; } = null;
        

        [Description("Enter the pressure corresponding to the Effective leakage ratio entered above.")]
        [JsonProperty(PropertyName="reference_pressure_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferencePressureDifference { get; set; } = null;
        

        [Description("Enter the exponent used in the air mass flow equation.")]
        [JsonProperty(PropertyName="air_mass_flow_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowExponent { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
    }
}