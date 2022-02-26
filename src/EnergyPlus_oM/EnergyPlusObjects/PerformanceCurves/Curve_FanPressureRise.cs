using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description(@"Special curve type with two independent variables. Input for the fan total pressure rise curve consists of the curve name, the four coefficients, and the maximum and minimum valid independent variable values. Optional inputs for the curve minimum and maximum may be used to limit the output of the performance curve. curve = C1*Qfan**2+C2*Qfan+C3*Qfan*(Psm-Po)**0.5+C4*(Psm-Po) Po assumed to be zero See InputOut Reference for curve details")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_FanPressureRise : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty(PropertyName="minimum_value_of_qfan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfQfan { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_qfan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfQfan { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_value_of_psm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumValueOfPsm { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_value_of_psm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumValueOfPsm { get; set; } = null;
        

        [Description("Specify the minimum value calculated by this curve object")]
        [JsonProperty(PropertyName="minimum_curve_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCurveOutput { get; set; } = null;
        

        [Description("Specify the maximum value calculated by this curve object")]
        [JsonProperty(PropertyName="maximum_curve_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCurveOutput { get; set; } = null;
    }
}