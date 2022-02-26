using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Window blind thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Blind : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="slat_orientation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Blind_SlatOrientation SlatOrientation { get; set; } = (WindowMaterial_Blind_SlatOrientation)Enum.Parse(typeof(WindowMaterial_Blind_SlatOrientation), "Horizontal");
        

        [JsonProperty(PropertyName="slat_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatWidth { get; set; } = null;
        

        [Description("Distance between adjacent slat faces")]
        [JsonProperty(PropertyName="slat_separation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatSeparation { get; set; } = null;
        

        [Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
                     "r in cross section and flat")]
        [JsonProperty(PropertyName="slat_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatThickness { get; set; } = Double.Parse("0.00025", CultureInfo.InvariantCulture);
        

        [Description(@"If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = FixedSlatAngle, then this is the fixed value of the slat angle; If WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = BlockBeamSolar, then this is the slat angle when slat angle control is not in effect (e.g., when there is no beam solar on the blind); Not used if WindowShadingControl referencing the window that incorporates this blind has Type of Slat Angle Control for Blinds = ScheduledSlatAngle.")]
        [JsonProperty(PropertyName="slat_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatAngle { get; set; } = Double.Parse("45", CultureInfo.InvariantCulture);
        

        [Description("default is for aluminum")]
        [JsonProperty(PropertyName="slat_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatConductivity { get; set; } = Double.Parse("221", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slat_beam_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatBeamSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="front_side_slat_beam_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatBeamSolarReflectance { get; set; } = null;
        

        [JsonProperty(PropertyName="back_side_slat_beam_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatBeamSolarReflectance { get; set; } = null;
        

        [Description("Must equal \"Slat beam solar transmittance\"")]
        [JsonProperty(PropertyName="slat_diffuse_solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatDiffuseSolarTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Must equal \"Front Side Slat Beam Solar Reflectance\"")]
        [JsonProperty(PropertyName="front_side_slat_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatDiffuseSolarReflectance { get; set; } = null;
        

        [Description("Must equal \"Back Side Slat Beam Solar Reflectance\"")]
        [JsonProperty(PropertyName="back_side_slat_diffuse_solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatDiffuseSolarReflectance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation")]
        [JsonProperty(PropertyName="slat_beam_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatBeamVisibleTransmittance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation")]
        [JsonProperty(PropertyName="front_side_slat_beam_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatBeamVisibleReflectance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation")]
        [JsonProperty(PropertyName="back_side_slat_beam_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatBeamVisibleReflectance { get; set; } = null;
        

        [Description("Used only for detailed daylighting calculation Must equal \"Slat Beam Visible Tran" +
                     "smittance\"")]
        [JsonProperty(PropertyName="slat_diffuse_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatDiffuseVisibleTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Required for detailed daylighting calculation Must equal \"Front Side Slat Beam Vi" +
                     "sible Reflectance\"")]
        [JsonProperty(PropertyName="front_side_slat_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

        [Description("Required for detailed daylighting calculation Must equal \"Back Side Slat Beam Vis" +
                     "ible Reflectance\"")]
        [JsonProperty(PropertyName="back_side_slat_diffuse_visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatDiffuseVisibleReflectance { get; set; } = null;
        

        [JsonProperty(PropertyName="slat_infrared_hemispherical_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatInfraredHemisphericalTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="front_side_slat_infrared_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSlatInfraredHemisphericalEmissivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="back_side_slat_infrared_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSlatInfraredHemisphericalEmissivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blind_to_glass_distance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlindToGlassDistance { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blind_top_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlindTopOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blind_bottom_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlindBottomOpeningMultiplier { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blind_left_side_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlindLeftSideOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blind_right_side_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlindRightSideOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
                     "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
                     "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
        [JsonProperty(PropertyName="minimum_slat_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSlatAngle { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only if WindowShadingControl referencing the window that incorporates this b" +
                     "lind varies the slat angle (i.e., WindowShadingControl with Type of Slat Angle C" +
                     "ontrol for Blinds = ScheduledSlatAngle or BlockBeamSolar)")]
        [JsonProperty(PropertyName="maximum_slat_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSlatAngle { get; set; } = Double.Parse("180", CultureInfo.InvariantCulture);
    }
}