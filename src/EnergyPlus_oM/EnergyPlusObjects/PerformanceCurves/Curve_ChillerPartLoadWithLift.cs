using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"This chiller part-load performance curve has three independent variables. Input consists of the curve name, the twelve coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1 + C2*x + C3*x**2 + C4*y + C5*y**2 + C6*x*y + C7*x**3 + C8*y**3 + C9*x**2*y + C10*x*y**2 + C11*x**2*y**2 + C12*z*y**3 x = dT* = normalized fractional Lift = dT / dTref y = PLR = part load ratio (cooling load/steady state capacity) z = Tdev* = normalized Tdev = Tdev / dTref Where: dT = Lift = Leaving Condenser Water Temperature - Leaving Chilled Water Temperature dTref = dT at the reference condition Tdev = Leaving Chilled Water Temperature - Reference Chilled Water Temperature")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_ChillerPartLoadWithLift : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="coefficient1_c1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1C1 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient2_c2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2C2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient3_c3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3C3 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient4_c4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient4C4 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient5_c5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient5C5 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient6_c6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient6C6 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient7_c7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient7C7 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient8_c8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient8C8 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient9_c9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient9C9 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient10_c10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient10C10 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient11_c11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient11C11 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient12_c12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient12C12 { get; set; } = null;
        

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
        public Curve_ChillerPartLoadWithLift_InputUnitTypeForX InputUnitTypeForX { get; set; } = (Curve_ChillerPartLoadWithLift_InputUnitTypeForX)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_InputUnitTypeForX), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_y", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_ChillerPartLoadWithLift_InputUnitTypeForY InputUnitTypeForY { get; set; } = (Curve_ChillerPartLoadWithLift_InputUnitTypeForY)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_InputUnitTypeForY), "Dimensionless");
        

        [JsonProperty(PropertyName="input_unit_type_for_z", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_ChillerPartLoadWithLift_InputUnitTypeForZ InputUnitTypeForZ { get; set; } = (Curve_ChillerPartLoadWithLift_InputUnitTypeForZ)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_InputUnitTypeForZ), "Dimensionless");
        

        [JsonProperty(PropertyName="output_unit_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Curve_ChillerPartLoadWithLift_OutputUnitType OutputUnitType { get; set; } = (Curve_ChillerPartLoadWithLift_OutputUnitType)Enum.Parse(typeof(Curve_ChillerPartLoadWithLift_OutputUnitType), "Dimensionless");
    }
}