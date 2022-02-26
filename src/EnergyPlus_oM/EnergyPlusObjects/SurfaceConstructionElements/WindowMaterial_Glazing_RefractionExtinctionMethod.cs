using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Glass material properties for Windows or Glass Doors Index of Refraction/Extincti" +
                 "on Coefficient input method Not to be used for coated glass")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Glazing_RefractionExtinctionMethod : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = null;
        

        [JsonProperty(PropertyName="solar_index_of_refraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarIndexOfRefraction { get; set; } = null;
        

        [JsonProperty(PropertyName="solar_extinction_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarExtinctionCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="visible_index_of_refraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleIndexOfRefraction { get; set; } = null;
        

        [JsonProperty(PropertyName="visible_extinction_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleExtinctionCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="infrared_transmittance_at_normal_incidence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InfraredTransmittanceAtNormalIncidence { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Emissivity of front and back side assumed equal")]
        [JsonProperty(PropertyName="infrared_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InfraredHemisphericalEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Conductivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dirt_correction_factor_for_solar_and_visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DirtCorrectionFactorForSolarAndVisibleTransmittance { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="solar_diffusing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SolarDiffusing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}