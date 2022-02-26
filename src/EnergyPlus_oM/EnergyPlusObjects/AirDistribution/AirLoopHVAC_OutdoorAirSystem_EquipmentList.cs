using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("List equipment in simulation order")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_OutdoorAirSystem_EquipmentList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component1ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component2ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component3ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component4ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_5_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component5ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_6_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component6ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_7_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component7ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_8_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component8ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_9_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component9ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component9Name { get; set; } = "";
    }
}