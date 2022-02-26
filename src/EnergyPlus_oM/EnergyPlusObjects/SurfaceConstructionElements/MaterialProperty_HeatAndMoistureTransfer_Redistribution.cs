using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between liquid transport coefficient and moisture content Has n" +
                 "o effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Redistribution : BHoMObject
    {
        

        [Description("Moisture Material Name that the moisture properties will be added to.")]
        [JsonProperty(PropertyName="material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaterialName { get; set; } = "";
        

        [Description("number of data points")]
        [JsonProperty(PropertyName="number_of_redistribution_points", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfRedistributionPoints { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent1 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient1 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent2 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient2 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent3 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient3 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent4 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient4 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent5 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient5 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent6 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient6 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent7 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient7 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent8 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient8 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent9 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient9 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent10 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient10 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent11 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient11 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent12 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient12 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent13 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient13 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent14 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient14 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent15 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient15 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent16 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient16 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent17 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient17 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent18 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient18 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent19 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient19 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent20 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient20 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent21 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient21 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent22 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient22 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent23 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient23 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent24 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient24 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent25 { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_transport_coefficient_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidTransportCoefficient25 { get; set; } = null;
    }
}