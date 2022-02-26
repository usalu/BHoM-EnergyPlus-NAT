using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Used to allow users to combine specific variables and/or meters into \"custom\" met" +
                 "er configurations. To access these meters by name, one must first run a simulati" +
                 "on to generate the RDD/MDD files and names.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Meter_CustomDecrement : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="resource_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Meter_CustomDecrement_ResourceType ResourceType { get; set; } = (Meter_CustomDecrement_ResourceType)Enum.Parse(typeof(Meter_CustomDecrement_ResourceType), "Coal");
        

        [JsonProperty(PropertyName="source_meter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceMeterName { get; set; } = "";
        

        [JsonProperty(PropertyName="variable_details", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_CustomDecrement_VariableDetails_Item> VariableDetails { get; set; } = null;
    }
}