using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Allows for the direct entry of monthly values into a utility tariff variable.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UtilityCost_Variable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Varia" +
                     "ble.")]
        [JsonProperty(PropertyName="tariff_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TariffName { get; set; } = "";
        

        [JsonProperty(PropertyName="variable_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Variable_VariableType VariableType { get; set; } = (UtilityCost_Variable_VariableType)Enum.Parse(typeof(UtilityCost_Variable_VariableType), "Dimensionless");
        

        [JsonProperty(PropertyName="january_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuaryValue { get; set; } = null;
        

        [JsonProperty(PropertyName="february_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruaryValue { get; set; } = null;
        

        [JsonProperty(PropertyName="march_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchValue { get; set; } = null;
        

        [JsonProperty(PropertyName="april_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilValue { get; set; } = null;
        

        [JsonProperty(PropertyName="may_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MayValue { get; set; } = null;
        

        [JsonProperty(PropertyName="june_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneValue { get; set; } = null;
        

        [JsonProperty(PropertyName="july_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulyValue { get; set; } = null;
        

        [JsonProperty(PropertyName="august_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustValue { get; set; } = null;
        

        [JsonProperty(PropertyName="september_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberValue { get; set; } = null;
        

        [JsonProperty(PropertyName="october_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberValue { get; set; } = null;
        

        [JsonProperty(PropertyName="november_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberValue { get; set; } = null;
        

        [JsonProperty(PropertyName="december_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberValue { get; set; } = null;
    }
}