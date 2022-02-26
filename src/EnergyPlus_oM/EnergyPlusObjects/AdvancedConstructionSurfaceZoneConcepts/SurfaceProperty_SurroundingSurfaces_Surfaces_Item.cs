using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_SurroundingSurfaces_Surfaces_Item
    {
        

        [JsonProperty(PropertyName="surrounding_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurroundingSurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="surrounding_surface_view_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SurroundingSurfaceViewFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="surrounding_surface_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurroundingSurfaceTemperatureScheduleName { get; set; } = "";
    }
}