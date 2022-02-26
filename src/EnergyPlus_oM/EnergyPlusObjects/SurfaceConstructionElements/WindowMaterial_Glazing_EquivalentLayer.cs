using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Glass material properties for Windows or Glass Doors Transmittance/Reflectance in" +
                 "put method.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Glazing_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Spectral is not currently supported and SpectralAverage is the default.")]
        [JsonProperty(PropertyName="optical_data_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Glazing_EquivalentLayer_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_EquivalentLayer_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_EquivalentLayer_OpticalDataType), "SpectralAverage");
        

        [Description("Spectral data is not currently supported. Used only when Optical Data Type = Spec" +
                     "tral")]
        [JsonProperty(PropertyName="window_glass_spectral_data_set_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowGlassSpectralDataSetName { get; set; } = "";
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="front_side_beam_beam_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamBeamSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="back_side_beam_beam_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamBeamSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty(PropertyName="front_side_beam_beam_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamBeamSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty(PropertyName="back_side_beam_beam_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamBeamSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="front_side_beam_beam_visible_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="back_side_beam_beam_visible_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamBeamVisibleSolarTransmittance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty(PropertyName="front_side_beam_beam_visible_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty(PropertyName="back_side_beam_beam_visible_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamBeamVisibleSolarReflectance { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="front_side_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamDiffuseSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="back_side_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamDiffuseSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty(PropertyName="front_side_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamDiffuseSolarReflectance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty(PropertyName="back_side_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamDiffuseSolarReflectance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="front_side_beam_diffuse_visible_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamDiffuseVisibleSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="back_side_beam_diffuse_visible_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamDiffuseVisibleSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty(PropertyName="front_side_beam_diffuse_visible_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideBeamDiffuseVisibleSolarReflectance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty(PropertyName="back_side_beam_diffuse_visible_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideBeamDiffuseVisibleSolarReflectance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the diffuse-diffuse solar transmittance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used.")]
        [JsonProperty(PropertyName="diffuse_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DiffuseDiffuseSolarTransmittance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the front diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Front Side is side closest to outdoor air.")]
        [JsonProperty(PropertyName="front_side_diffuse_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> FrontSideDiffuseDiffuseSolarReflectance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Used only when Optical Data Type = SpectralAverage If this field is autocalculate, then the back diffuse-diffuse solar reflectance is automatically estimated from other inputs and used in subsequent calculations. If this field is zero or positive, then the value entered here will be used. Back side is side closest to indoor air.")]
        [JsonProperty(PropertyName="back_side_diffuse_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> BackSideDiffuseDiffuseSolarReflectance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
                     "urrently.")]
        [JsonProperty(PropertyName="diffuse_diffuse_visible_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DiffuseDiffuseVisibleSolarTransmittance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
                     "urrently.")]
        [JsonProperty(PropertyName="front_side_diffuse_diffuse_visible_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> FrontSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAverage This input field is not used c" +
                     "urrently.")]
        [JsonProperty(PropertyName="back_side_diffuse_diffuse_visible_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> BackSideDiffuseDiffuseVisibleSolarReflectance { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("The long-wave hemispherical transmittance of the glazing. Assumed to be the same " +
                     "for both sides of the glazing.")]
        [JsonProperty(PropertyName="infrared_transmittance_applies_to_front_and_back_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InfraredTransmittanceAppliesToFrontAndBack { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side long-wave hemispherical emissivity of the glazing.")]
        [JsonProperty(PropertyName="front_side_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideInfraredEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [Description("The back side long-wave hemispherical emissivity of the glazing.")]
        [JsonProperty(PropertyName="back_side_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideInfraredEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [Description("This is the R-Value in SI for the glass. The default value is an approximation fo" +
                     "r a single layer of glass at 1/4\" inch thickness. This field is used only for mo" +
                     "vable insulation defined with this material type.")]
        [JsonProperty(PropertyName="thermal_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalResistance { get; set; } = Double.Parse("0.158", CultureInfo.InvariantCulture);
    }
}