using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between water vapor diffusion and relative humidity fraction Ha" +
                 "s no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Diffusion : BHoMObject
    {
        

        [Description("Moisture Material Name that the moisture properties will be added to.")]
        [JsonProperty(PropertyName="material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaterialName { get; set; } = "";
        

        [Description("Water Vapor Diffusion Resistance Factor")]
        [JsonProperty(PropertyName="number_of_data_pairs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfDataPairs { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction1 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor1 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction2 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor2 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction3 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor3 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction4 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor4 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction5 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor5 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction6 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor6 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction7 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor7 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction8 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor8 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction9 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor9 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction10 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor10 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction11 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor11 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction12 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor12 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction13 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor13 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction14 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor14 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction15 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor15 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction16 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor16 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction17 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor17 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction18 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor18 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction19 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor19 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction20 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor20 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction21 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor21 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction22 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor22 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction23 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor23 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction24 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor24 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction25 { get; set; } = null;
        

        [JsonProperty(PropertyName="water_vapor_diffusion_resistance_factor_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterVaporDiffusionResistanceFactor25 { get; set; } = null;
    }
}