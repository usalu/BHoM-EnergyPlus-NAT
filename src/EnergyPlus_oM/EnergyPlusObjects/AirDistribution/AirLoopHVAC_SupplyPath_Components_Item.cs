using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_SupplyPath_Components_Item
    {
        

        [JsonProperty(PropertyName="component_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="component_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentName { get; set; } = "";
    }
}