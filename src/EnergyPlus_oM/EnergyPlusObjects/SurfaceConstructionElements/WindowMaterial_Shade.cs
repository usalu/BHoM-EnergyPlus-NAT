using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Specifies the properties of window shade materials. Reflectance and emissivity properties are assumed to be the same on both sides of the shade. Shades are considered to be perfect diffusers (all transmitted and reflected radiation is hemispherically-diffuse) independent of angle of incidence.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Shade : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Assumed independent of incidence angle")]
        [JsonProperty(PropertyName="solar_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarTransmittance { get; set; } = null;
        

        [Description("Assumed same for both sides Assumed independent of incidence angle")]
        [JsonProperty(PropertyName="solar_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarReflectance { get; set; } = null;
        

        [Description("Assumed independent of incidence angle")]
        [JsonProperty(PropertyName="visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleTransmittance { get; set; } = null;
        

        [Description("Assumed same for both sides Assumed independent of incidence angle")]
        [JsonProperty(PropertyName="visible_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleReflectance { get; set; } = null;
        

        [JsonProperty(PropertyName="infrared_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InfraredHemisphericalEmissivity { get; set; } = null;
        

        [JsonProperty(PropertyName="infrared_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InfraredTransmittance { get; set; } = null;
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = null;
        

        [JsonProperty(PropertyName="conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Conductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="shade_to_glass_distance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadeToGlassDistance { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="top_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TopOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="bottom_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BottomOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="left_side_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftSideOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="right_side_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightSideOpeningMultiplier { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="airflow_permeability", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirflowPermeability { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}