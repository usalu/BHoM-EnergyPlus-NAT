using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This models a horizontal heat exchanger placed in a series of trenches The model " +
                 "uses the PipingSystem:Underground underlying algorithms, but provides a more usa" +
                 "ble input interface.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_HorizontalTrench : BHoMObject, IEnergyPlusNode
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
        public System.Nullable<double> DesignFlowRate { get; set; } = null;
        

        [Description("This is the total pipe axial length of the heat exchanger If all pipe trenches ar" +
                     "e parallel, this is the length of a single trench. If a single, long run of pipe" +
                     " is used with one trench, this is the full length of the pipe run.")]
        [JsonProperty(PropertyName="trench_length_in_pipe_axial_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TrenchLengthInPipeAxialDirection { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("This is the number of horizontal legs that will be used in the entire heat exchan" +
                     "ger, one pipe per trench")]
        [JsonProperty(PropertyName="number_of_trenches", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfTrenches { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This represents the average horizontal spacing between any two trenches for heat " +
                     "exchangers that have multiple trenches")]
        [JsonProperty(PropertyName="horizontal_spacing_between_pipes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HorizontalSpacingBetweenPipes { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_inner_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeInnerDiameter { get; set; } = Double.Parse("0.016", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_outer_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeOuterDiameter { get; set; } = Double.Parse("0.026", CultureInfo.InvariantCulture);
        

        [Description("This is the burial depth of the pipes, or the trenches containing the pipes")]
        [JsonProperty(PropertyName="burial_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BurialDepth { get; set; } = Double.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilThermalConductivity { get; set; } = Double.Parse("1.08", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilDensity { get; set; } = Double.Parse("962", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSpecificHeat { get; set; } = Double.Parse("2576", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThermalConductivity { get; set; } = Double.Parse("0.3895", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeDensity { get; set; } = Double.Parse("641", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeSpecificHeat { get; set; } = Double.Parse("2405", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_moisture_content_percent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilMoistureContentPercent { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_moisture_content_percent_at_saturation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilMoistureContentPercentAtSaturation { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_HorizontalTrench_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty(PropertyName="evapotranspiration_ground_cover_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvapotranspirationGroundCoverParameter { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
    }
}