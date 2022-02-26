using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Complex window shading layer thermal properties")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_ComplexShade : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_ComplexShade_LayerType LayerType { get; set; } = (WindowMaterial_ComplexShade_LayerType)Enum.Parse(typeof(WindowMaterial_ComplexShade_LayerType), "OtherShadingType");
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = Double.Parse("0.002", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Conductivity { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="ir_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IrTransmittance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="front_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="back_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackEmissivity { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="top_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TopOpeningMultiplier { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="bottom_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BottomOpeningMultiplier { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="left_side_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftSideOpeningMultiplier { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="right_side_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightSideOpeningMultiplier { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="front_opening_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontOpeningMultiplier { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slat_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatWidth { get; set; } = Double.Parse("0.016", CultureInfo.InvariantCulture);
        

        [Description("Distance between adjacent slat faces")]
        [JsonProperty(PropertyName="slat_spacing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatSpacing { get; set; } = Double.Parse("0.012", CultureInfo.InvariantCulture);
        

        [Description("Distance between top and bottom surfaces of slat Slat is assumed to be rectangula" +
                     "r in cross section and flat")]
        [JsonProperty(PropertyName="slat_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatThickness { get; set; } = Double.Parse("0.0006", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slat_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatAngle { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slat_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatConductivity { get; set; } = Double.Parse("160", CultureInfo.InvariantCulture);
        

        [Description("this value represents curvature radius of the slat. if the slat is flat use zero." +
                     " if this value is not zero, then it must be > SlatWidth/2.")]
        [JsonProperty(PropertyName="slat_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlatCurve { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}