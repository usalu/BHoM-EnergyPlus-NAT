using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(@"This models a slinky horizontal heat exchanger placed in a series of trenches The model uses the model developed by: Xiong, Z., D.E. Fisher, and J.D. Spitler. 2015. Development and Validation of a Slinky Ground Heat Exchanger Model. Applied Energy 141: 57-69.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Slinky : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFlowRate { get; set; } = Double.Parse("0.002", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilThermalConductivity { get; set; } = Double.Parse("1.08", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilDensity { get; set; } = Double.Parse("962", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSpecificHeat { get; set; } = Double.Parse("2576", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThermalConductivity { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeDensity { get; set; } = Double.Parse("641", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeSpecificHeat { get; set; } = Double.Parse("2405", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_outer_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeOuterDiameter { get; set; } = Double.Parse("0.02667", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThickness { get; set; } = Double.Parse("0.002413", CultureInfo.InvariantCulture);
        

        [Description("This is the orientation of the heat exchanger")]
        [JsonProperty(PropertyName="heat_exchanger_configuration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_Slinky_HeatExchangerConfiguration HeatExchangerConfiguration { get; set; } = (GroundHeatExchanger_Slinky_HeatExchangerConfiguration)Enum.Parse(typeof(GroundHeatExchanger_Slinky_HeatExchangerConfiguration), "Horizontal");
        

        [Description("This is the diameter of the heat exchanger coil")]
        [JsonProperty(PropertyName="coil_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoilDiameter { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is the center-to-center distance between coils")]
        [JsonProperty(PropertyName="coil_pitch", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoilPitch { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("This is the distance from the ground surface to the trench bottom")]
        [JsonProperty(PropertyName="trench_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TrenchDepth { get; set; } = Double.Parse("1.8", CultureInfo.InvariantCulture);
        

        [Description("This is the total length of a single trench This assumes the heat exchanger runs " +
                     "the full length of the trench")]
        [JsonProperty(PropertyName="trench_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TrenchLength { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("This is the number of parallel trenches that has a heat exchanger, one per trench" +
                     "")]
        [JsonProperty(PropertyName="number_of_trenches", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfTrenches { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This represents the average horizontal spacing between any two trenches for heat " +
                     "exchangers that have multiple trenches")]
        [JsonProperty(PropertyName="horizontal_spacing_between_pipes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HorizontalSpacingBetweenPipes { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_Slinky_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_length_of_simulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumLengthOfSimulation { get; set; } = null;
    }
}