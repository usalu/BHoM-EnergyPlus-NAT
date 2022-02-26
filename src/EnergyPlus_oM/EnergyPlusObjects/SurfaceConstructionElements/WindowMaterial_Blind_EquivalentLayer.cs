using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Window equivalent layer blind slat optical and thermal properties. The model assu" +
                 "mes that slats are thin and flat, applies correction empirical correlation to ac" +
                 "count for curvature effect. Slats are assumed to transmit and reflect diffusely." +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Blind_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="slat_orientation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Blind_EquivalentLayer_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatOrientation), "Horizontal");
        

        [JsonProperty(PropertyName="slat_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatWidth { get; set; } = null;
        

        [Description("Distance between adjacent slat faces")]
        [JsonProperty(PropertyName="slat_separation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatSeparation { get; set; } = null;
        

        [Description("Perpendicular length between the cord and the curve. Slat is assumed to be rectan" +
                     "gular in cross section and flat. Crown=0.0625x\"Slat width\"")]
        [JsonProperty(PropertyName="slat_crown", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatCrown { get; set; } = Double.Parse("0.0015", CultureInfo.InvariantCulture);
        

        [Description("Slat angle is +ve if the tip of the slat front face is tilted upward, else the sl" +
                     "at angle is -ve if the tip of the slat front face is tilted downward. The slat a" +
                     "ngle varies between -90 to +90. The default value is 45 degrees.")]
        [JsonProperty(PropertyName="slat_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatAngle { get; set; } = Double.Parse("45", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar transmittance of the slat at normal incidence a" +
                     "veraged over the entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="front_side_slat_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatBeamDiffuseSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The back side beam-diffuse solar transmittance of the slat at normal incidence av" +
                     "eraged over the entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="back_side_slat_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatBeamDiffuseSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar reflectance of the slat at normal incidence ave" +
                     "raged over the entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="front_side_slat_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance of the slat at normal incidence aver" +
                     "aged over the entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="back_side_slat_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The front side beam-diffuse visible transmittance of the slat at normal incidence" +
                     " averaged over the visible spectrum range of solar radiation.")]
        [JsonProperty(PropertyName="front_side_slat_beam_diffuse_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatBeamDiffuseVisibleTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The back side beam-diffuse visible transmittance of the slat at normal incidence " +
                     "averaged over the visible spectrum range of solar radiation.")]
        [JsonProperty(PropertyName="back_side_slat_beam_diffuse_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatBeamDiffuseVisibleTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse visible reflectance of the slat at normal incidence a" +
                     "veraged over the visible spectrum range of solar radiation.")]
        [JsonProperty(PropertyName="front_side_slat_beam_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse visible reflectance of the slat at normal incidence av" +
                     "eraged over the visible spectrum range of solar radiation.")]
        [JsonProperty(PropertyName="back_side_slat_beam_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The beam-diffuse solar transmittance of the slat averaged over the entire solar s" +
                     "pectrum of solar radiation.")]
        [JsonProperty(PropertyName="slat_diffuse_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatDiffuseDiffuseSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar reflectance of the slat averaged over the entir" +
                     "e solar spectrum of solar radiation.")]
        [JsonProperty(PropertyName="front_side_slat_diffuse_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance of the slat averaged over the entire" +
                     " solar spectrum of solar radiation.")]
        [JsonProperty(PropertyName="back_side_slat_diffuse_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatDiffuseDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance of the slat averaged over the visible spec" +
                     "trum range of solar radiation.")]
        [JsonProperty(PropertyName="slat_diffuse_diffuse_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatDiffuseDiffuseVisibleTransmittance { get; set; } = null;
        

        [Description("The front side beam-diffuse visible reflectance of the slat averaged over the vis" +
                     "ible spectrum range of solar radiation.")]
        [JsonProperty(PropertyName="front_side_slat_diffuse_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse visible reflectance of the slat averaged over the visi" +
                     "ble spectrum range of solar radiation.")]
        [JsonProperty(PropertyName="back_side_slat_diffuse_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatDiffuseDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Long-wave hemispherical transmittance of the slat material. Assumed to be the sam" +
                     "e for both sides of the slat.")]
        [JsonProperty(PropertyName="slat_infrared_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatInfraredTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Front side long-wave hemispherical emissivity of the slat material.")]
        [JsonProperty(PropertyName="front_side_slat_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatInfraredEmissivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Back side long-wave hemispherical emissivity of the slat material.")]
        [JsonProperty(PropertyName="back_side_slat_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatInfraredEmissivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description(@"Used only if slat angle control is desired to either maximize solar gain (MaximizeSolar), maximize visibility while eliminating beam solar radiation (BlockBeamSolar), or fixed slate angle (FixedSlatAngle). If FixedSlatAngle is selected, the slat angle entered above is used.")]
        [JsonProperty(PropertyName="slat_angle_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Blind_EquivalentLayer_SlatAngleControl SlatAngleControl { get; set; } = (WindowMaterial_Blind_EquivalentLayer_SlatAngleControl)Enum.Parse(typeof(WindowMaterial_Blind_EquivalentLayer_SlatAngleControl), "FixedSlatAngle");
    }
}