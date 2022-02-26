using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"The object lists a series of computations that are used to perform the utility bill calculation. The object is only used for complex tariffs that cannot be modeled any other way. For most utility tariffs, UtilityCost:Computation is unnecessary and should be avoided. If UtilityCost:Computation is used, it must contain references to all objects involved in the rate in the order that they should be computed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UtilityCost_Computation : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Varia" +
                     "ble.")]
        [JsonProperty(PropertyName="tariff_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TariffName { get; set; } = "";
        

        [Description("Contain a simple language that describes the steps used in the computation proces" +
                     "s similar to a programming language.")]
        [JsonProperty(PropertyName="compute_step_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep1 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep2 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep3 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep4 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep5 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep6 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep7 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep8 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep9 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep10 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep11 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep12 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep13 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep14 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep15 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep16 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep17 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep18 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep19 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep20 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep21 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep22 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep23 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep24 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep25 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_26", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep26 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_27", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep27 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_28", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep28 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_29", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep29 { get; set; } = "";
        

        [JsonProperty(PropertyName="compute_step_30", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComputeStep30 { get; set; } = "";
    }
}