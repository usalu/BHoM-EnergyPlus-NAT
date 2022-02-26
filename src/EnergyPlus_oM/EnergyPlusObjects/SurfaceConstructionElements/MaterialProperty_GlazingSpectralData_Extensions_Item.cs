using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_GlazingSpectralData_Extensions_Item
    {
        

        [JsonProperty(PropertyName="wavelength", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength { get; set; } = null;
        

        [JsonProperty(PropertyName="transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Transmittance { get; set; } = null;
        

        [JsonProperty(PropertyName="front_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontReflectance { get; set; } = null;
        

        [JsonProperty(PropertyName="back_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackReflectance { get; set; } = null;
    }
}