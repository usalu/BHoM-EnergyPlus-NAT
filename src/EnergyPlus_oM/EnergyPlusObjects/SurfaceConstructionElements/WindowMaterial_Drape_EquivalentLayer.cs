using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Specifies the properties of equivalent layer drape fabric materials. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence. unpleated drape fabric is treated as thin and flat layer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Drape_EquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The beam-beam solar transmittance at normal incidence. This value is the same as " +
                     "the openness area fraction of the drape fabric. Assumed to be same for front and" +
                     " back sides.")]
        [JsonProperty(PropertyName="drape_beam_beam_solar_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DrapeBeamBeamSolarTransmittanceAtNormalIncidence { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The front side beam-diffuse solar transmittance at normal incidence averaged over" +
                     " the entire spectrum of solar radiation. Assumed to be the same for front and ba" +
                     "ck sides.")]
        [JsonProperty(PropertyName="front_side_drape_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar transmittance at normal incidence averaged over " +
                     "the entire spectrum of solar radiation. Assumed to be the same for front and bac" +
                     "k sides.")]
        [JsonProperty(PropertyName="back_side_drape_beam_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideDrapeBeamDiffuseSolarTransmittance { get; set; } = null;
        

        [Description("The front side beam-diffuse solar reflectance at normal incidence averaged over t" +
                     "he entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="front_side_drape_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The back side beam-diffuse solar reflectance at normal incidence averaged over th" +
                     "e entire spectrum of solar radiation.")]
        [JsonProperty(PropertyName="back_side_drape_beam_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideDrapeBeamDiffuseSolarReflectance { get; set; } = null;
        

        [Description("The beam-beam visible transmittance at normal incidence averaged over the visible" +
                     " spectrum of solar radiation. Assumed same for front and back sides.")]
        [JsonProperty(PropertyName="drape_beam_beam_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DrapeBeamBeamVisibleTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse visible transmittance at normal incidence averaged over the visi" +
                     "ble spectrum range of solar radiation. Assumed to be the same for front and back" +
                     " sides.")]
        [JsonProperty(PropertyName="drape_beam_diffuse_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DrapeBeamDiffuseVisibleTransmittance { get; set; } = null;
        

        [Description("The beam-diffuse visible reflectance at normal incidence average over the visible" +
                     " spectrum range of solar radiation. Assumed to be the same for front and back si" +
                     "des.")]
        [JsonProperty(PropertyName="drape_beam_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DrapeBeamDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Long-wave transmittance of the drape fabric at zero openness fraction. Assumed sa" +
                     "me for front and back sides.")]
        [JsonProperty(PropertyName="drape_material_infrared_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DrapeMaterialInfraredTransmittance { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("Front side long-wave emissivity of the drape fabric at zero shade openness. Openn" +
                     "ess fraction specified above is used to calculate the effective emissivity value" +
                     ".")]
        [JsonProperty(PropertyName="front_side_drape_material_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideDrapeMaterialInfraredEmissivity { get; set; } = Double.Parse("0.87", CultureInfo.InvariantCulture);
        

        [Description("Back side long-wave emissivity of the drape fabric at zero shade openness. Openne" +
                     "ss fraction specified above is used to calculate the effective emissivity value." +
                     "")]
        [JsonProperty(PropertyName="back_side_drape_material_infrared_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideDrapeMaterialInfraredEmissivity { get; set; } = Double.Parse("0.87", CultureInfo.InvariantCulture);
        

        [Description("Width of the pleated section of the draped fabric. If the drape fabric is unpleat" +
                     "ed or is flat, then the pleated section width is set to zero.")]
        [JsonProperty(PropertyName="width_of_pleated_fabric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WidthOfPleatedFabric { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Length of the pleated section of the draped fabric. If the drape fabric is unplea" +
                     "ted or is flat, then the pleated section length is set to zero.")]
        [JsonProperty(PropertyName="length_of_pleated_fabric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LengthOfPleatedFabric { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}