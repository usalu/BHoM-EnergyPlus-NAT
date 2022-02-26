using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Additional properties for moisture using EMPD procedure HeatBalanceAlgorithm choi" +
                 "ce=MoisturePenetrationDepthConductionTransferFunction only Has no effect with ot" +
                 "her HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_MoisturePenetrationDepth_Settings : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Ratio of water vapor permeability of stagnant air to water vapor permeability of " +
                     "material")]
        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_equation_coefficient_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureEquationCoefficientA { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_equation_coefficient_b", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureEquationCoefficientB { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_equation_coefficient_c", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureEquationCoefficientC { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_equation_coefficient_d", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureEquationCoefficientD { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_layer_penetration_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> SurfaceLayerPenetrationDepth { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="deep_layer_penetration_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DeepLayerPenetrationDepth { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coating_layer_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoatingLayerThickness { get; set; } = null;
        

        [Description("The coating\'s resistance to water vapor diffusion relative to the resistance to w" +
                     "ater vapor diffusion in stagnant air (see Water Vapor Diffusion Resistance Facto" +
                     "r above).")]
        [JsonProperty(PropertyName="coating_layer_water_vapor_diffusion_resistance_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoatingLayerWaterVaporDiffusionResistanceFactor { get; set; } = null;
    }
}