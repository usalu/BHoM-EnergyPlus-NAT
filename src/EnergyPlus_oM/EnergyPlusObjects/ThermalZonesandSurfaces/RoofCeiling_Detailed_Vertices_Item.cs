using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoofCeiling_Detailed_Vertices_Item
    {
        

        [JsonProperty(PropertyName="vertex_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VertexXCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VertexYCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VertexZCoordinate { get; set; } = null;
    }
}