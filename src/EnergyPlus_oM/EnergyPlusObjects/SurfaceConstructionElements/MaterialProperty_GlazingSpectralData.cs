using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Name is followed by up to 800 sets of normal-incidence measured values of [wavele" +
                 "ngth, transmittance, front reflectance, back reflectance] for wavelengths coveri" +
                 "ng the solar spectrum (from about 0.25 to 2.5 microns)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_GlazingSpectralData : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="wavelength_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength1 { get; set; } = null;
        

        [JsonProperty(PropertyName="transmittance_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Transmittance1 { get; set; } = null;
        

        [JsonProperty(PropertyName="front_reflectance_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontReflectance1 { get; set; } = null;
        

        [JsonProperty(PropertyName="back_reflectance_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackReflectance1 { get; set; } = null;
        

        [JsonProperty(PropertyName="wavelength_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength2 { get; set; } = null;
        

        [JsonProperty(PropertyName="transmittance_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Transmittance2 { get; set; } = null;
        

        [JsonProperty(PropertyName="front_reflectance_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontReflectance2 { get; set; } = null;
        

        [JsonProperty(PropertyName="back_reflectance_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackReflectance2 { get; set; } = null;
        

        [JsonProperty(PropertyName="wavelength_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength3 { get; set; } = null;
        

        [JsonProperty(PropertyName="transmittance_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Transmittance3 { get; set; } = null;
        

        [JsonProperty(PropertyName="front_reflectance_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontReflectance3 { get; set; } = null;
        

        [JsonProperty(PropertyName="back_reflectance_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackReflectance3 { get; set; } = null;
        

        [JsonProperty(PropertyName="wavelength_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength4 { get; set; } = null;
        

        [JsonProperty(PropertyName="transmittance_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Transmittance4 { get; set; } = null;
        

        [JsonProperty(PropertyName="front_reflectance_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontReflectance4 { get; set; } = null;
        

        [JsonProperty(PropertyName="back_reflectance_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackReflectance4 { get; set; } = null;
        

        [JsonProperty(PropertyName="extensions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_GlazingSpectralData_Extensions_Item> Extensions { get; set; } = null;
    }
}