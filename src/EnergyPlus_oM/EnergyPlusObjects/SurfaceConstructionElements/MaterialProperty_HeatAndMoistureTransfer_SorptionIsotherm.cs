using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between moisture content and relative humidity fraction. Has no" +
                 " effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm : BHoMObject
    {
        

        [Description("The Material Name that the moisture sorption isotherm will be added to.")]
        [JsonProperty(PropertyName="material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaterialName { get; set; } = "";
        

        [Description("Number of data Coordinates")]
        [JsonProperty(PropertyName="number_of_isotherm_coordinates", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfIsothermCoordinates { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction1 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent1 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction2 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent2 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction3 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent3 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction4 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent4 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction5 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent5 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction6 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent6 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction7 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent7 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction8 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent8 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction9 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent9 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction10 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent10 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction11 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent11 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction12 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent12 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction13 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent13 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction14 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent14 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction15 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent15 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction16 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent16 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction17 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent17 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction18 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent18 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction19 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent19 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction20 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent20 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction21 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent21 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction22 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent22 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction23 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent23 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction24 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent24 { get; set; } = null;
        

        [Description("The relative humidity is entered as a fraction.")]
        [JsonProperty(PropertyName="relative_humidity_fraction_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeHumidityFraction25 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent25 { get; set; } = null;
    }
}