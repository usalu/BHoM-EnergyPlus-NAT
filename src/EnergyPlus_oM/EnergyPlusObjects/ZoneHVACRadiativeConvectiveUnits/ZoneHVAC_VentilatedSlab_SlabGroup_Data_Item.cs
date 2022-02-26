using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_VentilatedSlab_SlabGroup_Data_Item
    {
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="core_diameter_for_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoreDiameterForSurface { get; set; } = null;
        

        [JsonProperty(PropertyName="core_length_for_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoreLengthForSurface { get; set; } = null;
        

        [JsonProperty(PropertyName="core_numbers_for_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoreNumbersForSurface { get; set; } = null;
        

        [JsonProperty(PropertyName="slab_inlet_node_name_for_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlabInletNodeNameForSurface { get; set; } = "";
        

        [JsonProperty(PropertyName="slab_outlet_node_name_for_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlabOutletNodeNameForSurface { get; set; } = "";
    }
}