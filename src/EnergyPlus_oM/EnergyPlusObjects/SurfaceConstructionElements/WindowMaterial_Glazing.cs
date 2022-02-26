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
    public class WindowMaterial_Glazing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="optical_data_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Glazing_OpticalDataType OpticalDataType { get; set; } = (WindowMaterial_Glazing_OpticalDataType)Enum.Parse(typeof(WindowMaterial_Glazing_OpticalDataType), "BSDF");
        

        [Description("Used only when Optical Data Type = Spectral")]
        [JsonProperty(PropertyName="window_glass_spectral_data_set_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowGlassSpectralDataSetName { get; set; } = "";
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="solar_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Front Side is side closest to " +
                     "outdoor air")]
        [JsonProperty(PropertyName="front_side_solar_reflectance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage Back Side is side closest to z" +
                     "one air")]
        [JsonProperty(PropertyName="back_side_solar_reflectance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideSolarReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="visible_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleTransmittanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="front_side_visible_reflectance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

        [Description("Used only when Optical Data Type = SpectralAverage")]
        [JsonProperty(PropertyName="back_side_visible_reflectance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideVisibleReflectanceAtNormalIncidence { get; set; } = null;
        

        [JsonProperty(PropertyName="infrared_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InfraredTransmittanceAtNormalIncidence { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="front_side_infrared_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSideInfraredHemisphericalEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="back_side_infrared_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackSideInfraredHemisphericalEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Conductivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dirt_correction_factor_for_solar_and_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="solar_diffusing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("coefficient used for deflection calculations. Used only with complex fenestration" +
                     " when deflection model is set to TemperatureAndPressureInput")]
        [JsonProperty(PropertyName="young_s_modulus", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YoungSModulus { get; set; } = Double.Parse("72000000000", CultureInfo.InvariantCulture);
        

        [Description("coefficient used for deflection calculations. Used only with complex fenestration" +
                     " when deflection model is set to TemperatureAndPressureInput")]
        [JsonProperty(PropertyName="poisson_s_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PoissonSRatio { get; set; } = Double.Parse("0.22", CultureInfo.InvariantCulture);
        

        [Description("Used only when Optical Data Type = SpectralAndAngle")]
        [JsonProperty(PropertyName="window_glass_spectral_and_incident_angle_transmittance_data_set_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowGlassSpectralAndIncidentAngleTransmittanceDataSetTableName { get; set; } = "";
        

        [Description("Used only when Optical Data Type = SpectralAndAngle")]
        [JsonProperty(PropertyName="window_glass_spectral_and_incident_angle_front_reflectance_data_set_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowGlassSpectralAndIncidentAngleFrontReflectanceDataSetTableName { get; set; } = "";
        

        [Description("Used only when Optical Data Type = SpectralAndAngle")]
        [JsonProperty(PropertyName="window_glass_spectral_and_incident_angle_back_reflectance_data_set_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowGlassSpectralAndIncidentAngleBackReflectanceDataSetTableName { get; set; } = "";
    }
}