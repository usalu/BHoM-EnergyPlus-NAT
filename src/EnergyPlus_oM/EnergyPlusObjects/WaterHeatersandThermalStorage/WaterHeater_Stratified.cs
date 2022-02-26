using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("Water heater with stratified, multi-node water tank. May be used to model a tankl" +
                 "ess water heater (small tank volume), a hot water storage tank (zero heater capa" +
                 "city), or a heat pump water heater (see WaterHeater:HeatPump:*.)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterHeater_Stratified : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [JsonProperty(PropertyName="tank_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> TankVolume { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Height is measured in the axial direction for horizontal cylinders")]
        [JsonProperty(PropertyName="tank_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> TankHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="tank_shape", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_TankShape TankShape { get; set; } = (WaterHeater_Stratified_TankShape)Enum.Parse(typeof(WaterHeater_Stratified_TankShape), "VerticalCylinder");
        

        [Description("Only used if Tank Shape is Other")]
        [JsonProperty(PropertyName="tank_perimeter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankPerimeter { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumTemperatureLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="heater_priority_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_HeaterPriorityControl HeaterPriorityControl { get; set; } = (WaterHeater_Stratified_HeaterPriorityControl)Enum.Parse(typeof(WaterHeater_Stratified_HeaterPriorityControl), "MasterSlave");
        

        [JsonProperty(PropertyName="heater_1_setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Heater1SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heater_1_deadband_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Heater1DeadbandTemperatureDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heater_1_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Heater1Capacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heater_1_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Heater1Height { get; set; } = null;
        

        [JsonProperty(PropertyName="heater_2_setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Heater2SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heater_2_deadband_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Heater2DeadbandTemperatureDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heater_2_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Heater2Capacity { get; set; } = null;
        

        [JsonProperty(PropertyName="heater_2_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Heater2Height { get; set; } = null;
        

        [JsonProperty(PropertyName="heater_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_HeaterFuelType HeaterFuelType { get; set; } = (WaterHeater_Stratified_HeaterFuelType)Enum.Parse(typeof(WaterHeater_Stratified_HeaterFuelType), "Coal");
        

        [JsonProperty(PropertyName="heater_thermal_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeaterThermalEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="off_cycle_parasitic_fuel_consumption_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleParasiticFuelConsumptionRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="off_cycle_parasitic_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_OffCycleParasiticFuelType OffCycleParasiticFuelType { get; set; } = (WaterHeater_Stratified_OffCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Stratified_OffCycleParasiticFuelType), "Coal");
        

        [JsonProperty(PropertyName="off_cycle_parasitic_heat_fraction_to_tank", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleParasiticHeatFractionToTank { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="off_cycle_parasitic_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleParasiticHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="on_cycle_parasitic_fuel_consumption_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OnCycleParasiticFuelConsumptionRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="on_cycle_parasitic_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_OnCycleParasiticFuelType OnCycleParasiticFuelType { get; set; } = (WaterHeater_Stratified_OnCycleParasiticFuelType)Enum.Parse(typeof(WaterHeater_Stratified_OnCycleParasiticFuelType), "Coal");
        

        [JsonProperty(PropertyName="on_cycle_parasitic_heat_fraction_to_tank", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OnCycleParasiticHeatFractionToTank { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="on_cycle_parasitic_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OnCycleParasiticHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="ambient_temperature_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterHeater_Stratified_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterHeater_Stratified_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty(PropertyName="ambient_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="ambient_temperature_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [Description("required for Ambient Temperature Indicator=Outdoors")]
        [JsonProperty(PropertyName="ambient_temperature_outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="uniform_skin_loss_coefficient_per_unit_area_to_ambient_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UniformSkinLossCoefficientPerUnitAreaToAmbientTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_fraction_to_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossFractionToZone { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="off_cycle_flue_loss_coefficient_to_ambient_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleFlueLossCoefficientToAmbientTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="off_cycle_flue_loss_fraction_to_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleFlueLossFractionToZone { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Only used if Use Side Node connections are blank")]
        [JsonProperty(PropertyName="peak_use_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PeakUseFlowRate { get; set; } = null;
        

        [Description("If blank, defaults to 1.0 at all times Only used if use side node connections are" +
                     " blank")]
        [JsonProperty(PropertyName="use_flow_rate_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseFlowRateFractionScheduleName { get; set; } = "";
        

        [Description("Only used if use side node connections are blank Defaults to water temperatures c" +
                     "alculated by Site:WaterMainsTemperature object")]
        [JsonProperty(PropertyName="cold_water_supply_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="use_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="use_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideOutletNodeName { get; set; } = "";
        

        [Description(@"The use side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of use mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The use side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty(PropertyName="use_side_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UseSideEffectiveness { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty(PropertyName="use_side_inlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UseSideInletHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Defaults to top of tank")]
        [JsonProperty(PropertyName="use_side_outlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> UseSideOutletHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="source_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [Description(@"The source side effectiveness in the stratified tank model is a simplified analogy of a heat exchanger's effectiveness. This effectiveness is equal to the fraction of source mass flow rate that directly mixes with the tank fluid. And one minus the effectiveness is the fraction that bypasses the tank. The source side mass flow rate that bypasses the tank is mixed with the fluid or water leaving the stratified tank.")]
        [JsonProperty(PropertyName="source_side_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideEffectiveness { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Defaults to top of tank")]
        [JsonProperty(PropertyName="source_side_inlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> SourceSideInletHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Defaults to bottom of tank")]
        [JsonProperty(PropertyName="source_side_outlet_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideOutletHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="inlet_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_InletMode InletMode { get; set; } = (WaterHeater_Stratified_InletMode)Enum.Parse(typeof(WaterHeater_Stratified_InletMode), "Fixed");
        

        [JsonProperty(PropertyName="use_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> UseSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="source_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SourceSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Parameter for autosizing design flow rates for indirectly heated water tanks time" +
                     " required to raise temperature of entire tank from 14.4C to 57.2C")]
        [JsonProperty(PropertyName="indirect_water_heating_recovery_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndirectWaterHeatingRecoveryTime { get; set; } = Double.Parse("1.5", CultureInfo.InvariantCulture);
        

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
        

        [JsonProperty(PropertyName="node_11_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node11AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="node_12_additional_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Node12AdditionalLossCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"StorageTank mode always requests flow unless tank is at its Maximum Temperature Limit IndirectHeatPrimarySetpoint mode requests flow whenever primary setpoint for heater 1 calls for heat IndirectHeatAlternateSetpoint mode requests flow whenever alternate indirect setpoint calls for heat")]
        [JsonProperty(PropertyName="source_side_flow_control_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Stratified_SourceSideFlowControlMode SourceSideFlowControlMode { get; set; } = (WaterHeater_Stratified_SourceSideFlowControlMode)Enum.Parse(typeof(WaterHeater_Stratified_SourceSideFlowControlMode), "IndirectHeatPrimarySetpoint");
        

        [Description("This field is only used if the previous is set to IndirectHeatAlternateSetpoint")]
        [JsonProperty(PropertyName="indirect_alternate_setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IndirectAlternateSetpointTemperatureScheduleName { get; set; } = "";
    }
}