using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the characteristics of a supply or return air leak.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Leak : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Defined at 1 Pa pressure difference across this component. Enter the coefficient " +
                     "used in the following equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP" +
                     ")^Air Mass Flow Exponent")]
        [JsonProperty(PropertyName="air_mass_flow_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowCoefficient { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent")]
        [JsonProperty(PropertyName="air_mass_flow_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowExponent { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
    }
}