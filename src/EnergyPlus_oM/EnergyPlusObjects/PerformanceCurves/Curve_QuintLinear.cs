using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Linear curve with five independent variables. Input for the linear curve consists of a curve name, the two coefficients, and the maximum and minimum valid independent variable values. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*v + C3*w + C4*x + C5*y + C6*z")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_QuintLinear : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="coefficient1_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient2_v", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2V { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient3_w", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3W { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient4_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient4X { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient5_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient5Y { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient6_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient6Z { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_v", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfV { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_v", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfV { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_w", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfW { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_w", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfW { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfX { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfX { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfY { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfY { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfZ { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfZ { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty(PropertyName="minimum_curve_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty(PropertyName="maximum_curve_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCurveOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="input_unit_type_for_v", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuintLinear_InputUnitTypeForV InputUnitTypeForV { get; set; } = (Curve_QuintLinear_InputUnitTypeForV)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForV), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_w", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuintLinear_InputUnitTypeForW InputUnitTypeForW { get; set; } = (Curve_QuintLinear_InputUnitTypeForW)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForW), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuintLinear_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_QuintLinear_InputUnitTypeForX)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuintLinear_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_QuintLinear_InputUnitTypeForY)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_QuintLinear_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_QuintLinear_InputUnitTypeForZ)Enum.Parse(typeof(Curve_QuintLinear_InputUnitTypeForZ), "Dimensionless");
    }
}