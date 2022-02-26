using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the properties of airflow through a crack.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Surface_Crack : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the air mass flow coefficient at the conditions defined in the Reference Cr" +
                     "ack Conditions object. Defined at 1 Pa pressure difference across this crack.")]
        [JsonProperty(PropertyName="air_mass_flow_coefficient_at_reference_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowCoefficientAtReferenceConditions { get; set; } = null;
        

        [Description("Enter the air mass flow exponent for the surface crack.")]
        [JsonProperty(PropertyName="air_mass_flow_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowExponent { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Select a AirflowNetwork:MultiZone:ReferenceCrackConditions name associated with t" +
                     "he air mass flow coefficient entered above.")]
        [JsonProperty(PropertyName="reference_crack_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReferenceCrackConditions { get; set; } = "";
    }
}