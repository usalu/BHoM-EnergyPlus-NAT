using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("Chilled water storage with a stratified, multi-node tank. The chilled water is \"u" +
                 "sed\" by drawing from the \"Use Side\" of the water tank. The tank is indirectly ch" +
                 "arged by circulating cold water through the \"Source Side\" of the water tank.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermalStorage_ChilledWater_Stratified : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="tank_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankVolume { get; set; } = null;
        

        [Description("Height is measured in the axial direction for horizontal cylinders")]
        [JsonProperty(PropertyName="tank_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankHeight { get; set; } = null;
        

        [JsonProperty(PropertyName="tank_shape", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_ChilledWater_Stratified_TankShape TankShape { get; set; } = (ThermalStorage_ChilledWater_Stratified_TankShape)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_TankShape), "VerticalCylinder");
        

        [Description("Only used if Tank Shape is Other")]
        [JsonProperty(PropertyName="tank_perimeter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankPerimeter { get; set; } = null;
        

        [JsonProperty(PropertyName="setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="deadband_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeadbandTemperatureDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="temperature_sensor_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureSensorHeight { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumTemperatureLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="ambient_temperature_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty(PropertyName="ambient_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="ambient_temperature_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [Description("required for Ambient Temperature Indicator=Outdoors")]
        [JsonProperty(PropertyName="ambient_temperature_outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="uniform_skin_loss_coefficient_per_unit_area_to_ambient_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="use_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="use_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideOutletNodeName { get; set; } = "";
        

        [Description(@"The use side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of use mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The use side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty(PropertyName="use_side_heat_transfer_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UseSideHeatTransferEffectiveness { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
                     "vailable. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="use_side_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideAvailabilityScheduleName { get; set; } = "";
        

        [Description("Defaults to top of tank")]
        [JsonProperty(PropertyName="use_side_inlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> UseSideInletHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty(PropertyName="use_side_outlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UseSideOutletHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="use_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> UseSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="source_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [Description(@"The source side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of source mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The source side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty(PropertyName="source_side_heat_transfer_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideHeatTransferEffectiveness { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
                     "vailable. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="source_side_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideAvailabilityScheduleName { get; set; } = "";
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty(PropertyName="source_side_inlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideInletHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Defaults to top of tank")]
        [JsonProperty(PropertyName="source_side_outlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> SourceSideOutletHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="source_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SourceSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Parameter for autosizing design flow rates for indirectly cooled water tanks time" +
                     " required to lower temperature of entire tank from 14.4C to 9.0C")]
        [JsonProperty(PropertyName="tank_recovery_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankRecoveryTime { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="inlet_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_ChilledWater_Stratified_InletMode InletMode { get; set; } = (ThermalStorage_ChilledWater_Stratified_InletMode)Enum.Parse(typeof(ThermalStorage_ChilledWater_Stratified_InletMode), "Fixed");
        

        [JsonProperty(PropertyName="number_of_nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfNodes { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="additional_destratification_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AdditionalDestratificationConductivity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_1_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node1AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_2_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node2AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_3_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node3AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_4_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node4AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_5_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node5AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_6_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node6AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_7_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node7AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_8_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node8AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_9_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node9AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_10_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node10AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}