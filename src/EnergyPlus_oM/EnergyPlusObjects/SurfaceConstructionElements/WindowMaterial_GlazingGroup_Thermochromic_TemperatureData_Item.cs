using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_GlazingGroup_Thermochromic_TemperatureData_Item
    {
        

        [JsonProperty(PropertyName="optical_data_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OpticalDataTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="window_material_glazing_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowMaterialGlazingName { get; set; } = "";
    }
}