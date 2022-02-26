using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Branch_Components_Item
    {
        

        [JsonProperty(PropertyName="component_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentOutletNodeName { get; set; } = "";
    }
}