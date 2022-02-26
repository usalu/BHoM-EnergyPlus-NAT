using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Performance Curves")]
    public class PerformanceCurves_Objects : BHoMObject
    {
        
        public bool ShouldSerializeCurve_Linear_List()
        {
            return (Curve_Linear_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Linear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Linear> Curve_Linear_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Linear> ();
        
        public bool ShouldSerializeCurve_QuadLinear_List()
        {
            return (Curve_QuadLinear_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:QuadLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadLinear> Curve_QuadLinear_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadLinear> ();
        
        public bool ShouldSerializeCurve_QuintLinear_List()
        {
            return (Curve_QuintLinear_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:QuintLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuintLinear> Curve_QuintLinear_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuintLinear> ();
        
        public bool ShouldSerializeCurve_Quadratic_List()
        {
            return (Curve_Quadratic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Quadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quadratic> Curve_Quadratic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quadratic> ();
        
        public bool ShouldSerializeCurve_Cubic_List()
        {
            return (Curve_Cubic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Cubic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Cubic> Curve_Cubic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Cubic> ();
        
        public bool ShouldSerializeCurve_Quartic_List()
        {
            return (Curve_Quartic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Quartic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quartic> Curve_Quartic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Quartic> ();
        
        public bool ShouldSerializeCurve_Exponent_List()
        {
            return (Curve_Exponent_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Exponent> Curve_Exponent_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Exponent> ();
        
        public bool ShouldSerializeCurve_Bicubic_List()
        {
            return (Curve_Bicubic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Bicubic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Bicubic> Curve_Bicubic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Bicubic> ();
        
        public bool ShouldSerializeCurve_Biquadratic_List()
        {
            return (Curve_Biquadratic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Biquadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Biquadratic> Curve_Biquadratic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Biquadratic> ();
        
        public bool ShouldSerializeCurve_QuadraticLinear_List()
        {
            return (Curve_QuadraticLinear_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:QuadraticLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadraticLinear> Curve_QuadraticLinear_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_QuadraticLinear> ();
        
        public bool ShouldSerializeCurve_CubicLinear_List()
        {
            return (Curve_CubicLinear_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:CubicLinear", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_CubicLinear> Curve_CubicLinear_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_CubicLinear> ();
        
        public bool ShouldSerializeCurve_Triquadratic_List()
        {
            return (Curve_Triquadratic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Triquadratic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Triquadratic> Curve_Triquadratic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Triquadratic> ();
        
        public bool ShouldSerializeCurve_Functional_PressureDrop_List()
        {
            return (Curve_Functional_PressureDrop_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Functional:PressureDrop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Functional_PressureDrop> Curve_Functional_PressureDrop_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Functional_PressureDrop> ();
        
        public bool ShouldSerializeCurve_FanPressureRise_List()
        {
            return (Curve_FanPressureRise_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:FanPressureRise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_FanPressureRise> Curve_FanPressureRise_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_FanPressureRise> ();
        
        public bool ShouldSerializeCurve_ExponentialSkewNormal_List()
        {
            return (Curve_ExponentialSkewNormal_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:ExponentialSkewNormal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialSkewNormal> Curve_ExponentialSkewNormal_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialSkewNormal> ();
        
        public bool ShouldSerializeCurve_Sigmoid_List()
        {
            return (Curve_Sigmoid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:Sigmoid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Sigmoid> Curve_Sigmoid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_Sigmoid> ();
        
        public bool ShouldSerializeCurve_RectangularHyperbola1_List()
        {
            return (Curve_RectangularHyperbola1_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:RectangularHyperbola1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola1> Curve_RectangularHyperbola1_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola1> ();
        
        public bool ShouldSerializeCurve_RectangularHyperbola2_List()
        {
            return (Curve_RectangularHyperbola2_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:RectangularHyperbola2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola2> Curve_RectangularHyperbola2_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_RectangularHyperbola2> ();
        
        public bool ShouldSerializeCurve_ExponentialDecay_List()
        {
            return (Curve_ExponentialDecay_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:ExponentialDecay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialDecay> Curve_ExponentialDecay_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ExponentialDecay> ();
        
        public bool ShouldSerializeCurve_DoubleExponentialDecay_List()
        {
            return (Curve_DoubleExponentialDecay_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:DoubleExponentialDecay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_DoubleExponentialDecay> Curve_DoubleExponentialDecay_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_DoubleExponentialDecay> ();
        
        public bool ShouldSerializeCurve_ChillerPartLoadWithLift_List()
        {
            return (Curve_ChillerPartLoadWithLift_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Curve:ChillerPartLoadWithLift", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ChillerPartLoadWithLift> Curve_ChillerPartLoadWithLift_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceCurves.Curve_ChillerPartLoadWithLift> ();
    }
}