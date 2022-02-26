using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Foundation_Kiva_Blocks_Item
    {
        

        [JsonProperty(PropertyName="custom_block_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomBlockMaterialName { get; set; } = "";
        

        [JsonProperty(PropertyName="custom_block_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CustomBlockDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="custom_block_x_position", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CustomBlockXPosition { get; set; } = null;
        

        [JsonProperty(PropertyName="custom_block_z_position", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CustomBlockZPosition { get; set; } = null;
    }
}