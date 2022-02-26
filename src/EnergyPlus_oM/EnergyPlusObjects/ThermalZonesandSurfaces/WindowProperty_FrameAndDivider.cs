using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Specifies the dimensions of a window frame, dividers, and inside reveal surfaces." +
                 " Referenced by the surface objects for exterior windows and glass doors (ref: Fe" +
                 "nestrationSurface:Detailed, Window, and GlazedDoor).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowProperty_FrameAndDivider : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Width of frame in plane of window Frame width assumed the same on all sides of wi" +
                     "ndow")]
        [JsonProperty(PropertyName="frame_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameWidth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that frame projects outward from the outside face of the glazing")]
        [JsonProperty(PropertyName="frame_outside_projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameOutsideProjection { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that frame projects inward from the inside face of the glazing")]
        [JsonProperty(PropertyName="frame_inside_projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameInsideProjection { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective conductance of frame Excludes air films Obtained from WINDOW 5 or other" +
                     " 2-D calculation")]
        [JsonProperty(PropertyName="frame_conductance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameConductance { get; set; } = null;
        

        [Description("Excludes air films; applies only to multipane windows Obtained from WINDOW 5 or o" +
                     "ther 2-D calculation")]
        [JsonProperty(PropertyName="ratio_of_frame_edge_glass_conductance_to_center_of_glass_conductance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfFrameEdgeGlassConductanceToCenterOfGlassConductance { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of frame")]
        [JsonProperty(PropertyName="frame_solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameSolarAbsorptance { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of frame")]
        [JsonProperty(PropertyName="frame_visible_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameVisibleAbsorptance { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of frame")]
        [JsonProperty(PropertyName="frame_thermal_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrameThermalHemisphericalEmissivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="divider_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowProperty_FrameAndDivider_DividerType DividerType { get; set; } = (WindowProperty_FrameAndDivider_DividerType)Enum.Parse(typeof(WindowProperty_FrameAndDivider_DividerType), "DividedLite");
        

        [Description("Width of dividers in plane of window Width assumed the same for all dividers")]
        [JsonProperty(PropertyName="divider_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerWidth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"Horizontal\" means parallel to local window X-axis")]
        [JsonProperty(PropertyName="number_of_horizontal_dividers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfHorizontalDividers { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"Vertical\" means parallel to local window Y-axis")]
        [JsonProperty(PropertyName="number_of_vertical_dividers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfVerticalDividers { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that divider projects outward from the outside face of the glazing Outside" +
                     " projection assumed the same for all divider elements")]
        [JsonProperty(PropertyName="divider_outside_projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerOutsideProjection { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Amount that divider projects inward from the inside face of the glazing Inside pr" +
                     "ojection assumed the same for all divider elements")]
        [JsonProperty(PropertyName="divider_inside_projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerInsideProjection { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Effective conductance of divider Excludes air films Obtained from WINDOW 5 or oth" +
                     "er 2-D calculation")]
        [JsonProperty(PropertyName="divider_conductance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerConductance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Excludes air films Obtained from WINDOW 5 or other 2-D calculation")]
        [JsonProperty(PropertyName="ratio_of_divider_edge_glass_conductance_to_center_of_glass_conductance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfDividerEdgeGlassConductanceToCenterOfGlassConductance { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of divider")]
        [JsonProperty(PropertyName="divider_solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerSolarAbsorptance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of divider")]
        [JsonProperty(PropertyName="divider_visible_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerVisibleAbsorptance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Assumed same on outside and inside of divider")]
        [JsonProperty(PropertyName="divider_thermal_hemispherical_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DividerThermalHemisphericalEmissivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outside_reveal_solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutsideRevealSolarAbsorptance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="inside_sill_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideSillDepth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="inside_sill_solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideSillSolarAbsorptance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Distance from plane of inside surface of glazing to plane of inside surface of wall. Outside reveal depth is determined from the geometry of the window and the wall it is on; it is non-zero if the plane of the outside surface of the glazing is set back from the plane of the outside surface of the wall.")]
        [JsonProperty(PropertyName="inside_reveal_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideRevealDepth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="inside_reveal_solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideRevealSolarAbsorptance { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}