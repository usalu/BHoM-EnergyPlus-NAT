using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Quadratic curve with three independent variables. Input consists of the curve name, the twenty seven coefficients, and min and max values for each of the independent variables. Optional inputs for curve minimum and maximum may be used to limit the output of the performance curve. curve = a0 + a1*x**2 + a2*x + a3*y**2 + a4*y + a5*z**2 + a6*z + a7*x**2*y**2 + a8*x*y + a9*x*y**2 + a10*x**2*y + a11*x**2*z**2 + a12*x*z + a13*x*z**2 + a14*x**2*z + a15*y**2*z**2 + a16*y*z + a17*y*z**2 + a18*y**2*z + a19*x**2*y**2*z**2 + a20*x**2*y**2*z + a21*x**2*y*z**2 + a22*x*y**2*z**2 + a23*x**2*y*z + a24*x*y**2*z + a25*x*y*z**2 +a26*x*y*z")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Triquadratic : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="coefficient1_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1Constant { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient2_x_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2X2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient3_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3X { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient4_y_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient4Y2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient5_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient5Y { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient6_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient6Z2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient7_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient7Z { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient8_x_2_y_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient8X2Y2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient9_x_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient9XY { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient10_x_y_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient10XY2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient11_x_2_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient11X2Y { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient12_x_2_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient12X2Z2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient13_x_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient13XZ { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient14_x_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient14XZ2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient15_x_2_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient15X2Z { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient16_y_2_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient16Y2Z2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient17_y_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient17YZ { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient18_y_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient18YZ2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient19_y_2_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient19Y2Z { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient20_x_2_y_2_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient20X2Y2Z2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient21_x_2_y_2_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient21X2Y2Z { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient22_x_2_y_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient22X2YZ2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient23_x_y_2_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient23XY2Z2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient24_x_2_y_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient24X2YZ { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient25_x_y_2_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient25XY2Z { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient26_x_y_z_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient26XYZ2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient27_x_y_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient27XYZ { get; set; } = null;
        

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
        

        [JsonProperty(PropertyName="input_unit_type_for_x", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_Triquadratic_InputUnitTypeForX)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_Triquadratic_InputUnitTypeForY)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_Triquadratic_InputUnitTypeForZ)Enum.Parse(typeof(Curve_Triquadratic_InputUnitTypeForZ), "Dimensionless");
        

        [JsonProperty(PropertyName="output_unit_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_Triquadratic_OutputUnitType OutputUnitType { get; set; } = (Curve_Triquadratic_OutputUnitType)Enum.Parse(typeof(Curve_Triquadratic_OutputUnitType), "Dimensionless");
    }
}