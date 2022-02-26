using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_LowTemperatureRadiant_SurfaceGroup_SurfaceFractions_Item
    {
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="flow_fraction_for_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlowFractionForSurface { get; set; } = null;
    }
}