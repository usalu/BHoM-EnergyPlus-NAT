using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneProperty_UserViewFactors_BySurfaceName_ViewFactors_Item
    {
        

        [JsonProperty(PropertyName="from_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FromSurface { get; set; } = "";
        

        [JsonProperty(PropertyName="to_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ToSurface { get; set; } = "";
        

        [JsonProperty(PropertyName="view_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ViewFactor { get; set; } = null;
    }
}