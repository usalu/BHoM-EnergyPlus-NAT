using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"This object is used to set colors for reporting on various building elements particularly for the DXF reports. We know the user can enter 0 to 255 and the color map is available in DXF output. Therefore, we are limiting the colors in that range. You can extend by editing the IDD but you do so on your own. Colors not changed in any scheme will remain as the default scheme uses.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_SurfaceColorScheme : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="drawing_element_1_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement1Type DrawingElement1Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement1Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement1Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement1 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_2_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement2Type DrawingElement2Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement2Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement2Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement2 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_3_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement3Type DrawingElement3Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement3Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement3Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement3 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_4_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement4Type DrawingElement4Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement4Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement4Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement4 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_5_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement5Type DrawingElement5Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement5Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement5Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement5 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_6_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement6Type DrawingElement6Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement6Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement6Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement6 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_7_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement7Type DrawingElement7Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement7Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement7Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement7 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_8_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement8Type DrawingElement8Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement8Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement8Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement8 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_9_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement9Type DrawingElement9Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement9Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement9Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement9 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_10_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement10Type DrawingElement10Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement10Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement10Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement10 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_11_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement11Type DrawingElement11Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement11Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement11Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement11 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_12_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement12Type DrawingElement12Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement12Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement12Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement12 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_13_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement13Type DrawingElement13Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement13Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement13Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement13 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_14_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement14Type DrawingElement14Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement14Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement14Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement14 { get; set; } = null;
        

        [JsonProperty(PropertyName="drawing_element_15_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_SurfaceColorScheme_DrawingElement15Type DrawingElement15Type { get; set; } = (OutputControl_SurfaceColorScheme_DrawingElement15Type)Enum.Parse(typeof(OutputControl_SurfaceColorScheme_DrawingElement15Type), "AttachedBuildingShades");
        

        [Description("use color number for output assignment (e.g. DXF)")]
        [JsonProperty(PropertyName="color_for_drawing_element_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColorForDrawingElement15 { get; set; } = null;
    }
}