using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Specifies the properties of equivalent layer window shade material Shades are con" +
                 "sidered to be perfect diffusers (all transmitted and reflected radiation is hemi" +
                 "spherically-diffuse) independent of angle of incidence. Shade represents roller " +
                 "blinds.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Shade_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
                     "the openness area fraction of the shade material. Assumed to be the same for fro" +
                     "nt and back sides.")]
        [JsonProperty(PropertyName="shade_beam_beam_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadeBeamBeamSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
                     " the entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="front_side_shade_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
                     "the entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="back_side_shade_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideShadeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
                     "he entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="front_side_shade_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
                     "e entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="back_side_shade_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideShadeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
                     " spectrum range of solar radiation. Assumed to be the same for front and back si" +
                     "des of the shade.")]
        [JsonProperty(PropertyName="shade_beam_beam_visible_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadeBeamBeamVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
                     "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
                     " sides of the shade.")]
        [JsonProperty(PropertyName="shade_beam_diffuse_visible_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadeBeamDiffuseVisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("The beam-diffuse visible reflectance at normal incidence averaged over the visibl" +
                     "e spectrum range of solar radiation. Assumed to be the same for front and back s" +
                     "ides of the shade.")]
        [JsonProperty(PropertyName="shade_beam_diffuse_visible_reflectance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadeBeamDiffuseVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("The long-wave transmittance of the shade material at zero shade openness. Assumed" +
                     " to be the same for front and back sides of the shade.")]
        [JsonProperty(PropertyName="shade_material_infrared_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadeMaterialInfraredTransmittance { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("The front side long-wave emissivity of the shade material at zero shade openness." +
                     " Openness fraction is used to calculate the effective emissivity value.")]
        [JsonProperty(PropertyName="front_side_shade_material_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideShadeMaterialInfraredEmissivity { get; set; } = Double.Parse("0.91", CultureInfo.InvariantCulture);
        

        [Description("The back side long-wave emissivity of the shade material at zero shade openness. " +
                     "Openness fraction is used to calculate the effective emissivity value.")]
        [JsonProperty(PropertyName="back_side_shade_material_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideShadeMaterialInfraredEmissivity { get; set; } = Double.Parse("0.91", CultureInfo.InvariantCulture);
    }
}