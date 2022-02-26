using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [Description(@"This is a key object in the new physics based VRF Heat Recovery (HR) model applicable for Fluid Temperature Control. It describes the VRF HR system excluding the performance of indoor units. Indoor units are modeled separately in the ZoneHVAC:TerminalUnit:VariableRefrigerantFlow object")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a schedule that defines the availability of the unit Schedule v" +
                     "alues of 0 denote the unit is off. All other values denote the unit is available" +
                     " If this field is left blank, the unit is available the entire simulation")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of a ZoneTerminalUnitList. This list connects zone terminal units " +
                     "to this heat pump")]
        [JsonProperty(PropertyName="zone_terminal_unit_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneTerminalUnitListName { get; set; } = "";
        

        [JsonProperty(PropertyName="refrigerant_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerantType { get; set; } = "R410A";
        

        [Description(@"Enter the total evaporative capacity in watts at rated conditions This is the capacity corresponding to the max compressor speed at rated conditions The actual evaporative capacity is obtained by multiplying the rated capacity with the modification factor calculated by Evaporative Capacity Multiplier Function of Temperature Curve")]
        [JsonProperty(PropertyName="rated_evaporative_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedEvaporativeCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the rated compressor power per Watt of rated evaporative capacity [W/W] Rated compressor power corresponds to the max compressor speed at rated conditions The actual compressor power is obtained by multiplying the rated power with the modification factor calculated by Compressor Power Multiplier Function of Temperature Curve")]
        [JsonProperty(PropertyName="rated_compressor_power_per_unit_of_rated_evaporative_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCompressorPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = Double.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for cooling operation Cooling is di" +
                     "sabled below this temperature")]
        [JsonProperty(PropertyName="minimum_outdoor_air_temperature_in_cooling_only_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorAirTemperatureInCoolingOnlyMode { get; set; } = Double.Parse("-6", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for cooling operation Cooling is di" +
                     "sabled above this temperature")]
        [JsonProperty(PropertyName="maximum_outdoor_air_temperature_in_cooling_only_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorAirTemperatureInCoolingOnlyMode { get; set; } = Double.Parse("43", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty(PropertyName="minimum_outdoor_air_temperature_in_heating_only_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorAirTemperatureInHeatingOnlyMode { get; set; } = Double.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty(PropertyName="maximum_outdoor_air_temperature_in_heating_only_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorAirTemperatureInHeatingOnlyMode { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [Description("The minimum outdoor temperature below which heat recovery mode will not operate.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_in_heat_recovery_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = Double.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("The maximum outdoor temperature above which heat recovery mode will not operate.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_in_heat_recovery_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = Double.Parse("43", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="refrigerant_temperature_control_algorithm_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_RefrigerantTemperatureControlAlgorithmForIndoorUnit RefrigerantTemperatureControlAlgorithmForIndoorUnit { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_RefrigerantTemperatureControlAlgorithmForIndoorUnit)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_RefrigerantTemperatureControlAlgorithmForIndoorUnit), "VariableTemp");
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is ConstantTemp E" +
                     "vaporating temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty(PropertyName="reference_evaporating_temperature_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceEvaporatingTemperatureForIndoorUnit { get; set; } = Double.Parse("6", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is ConstantTemp C" +
                     "ondensing temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty(PropertyName="reference_condensing_temperature_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCondensingTemperatureForIndoorUnit { get; set; } = Double.Parse("44", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp E" +
                     "vaporating temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty(PropertyName="variable_evaporating_temperature_minimum_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VariableEvaporatingTemperatureMinimumForIndoorUnit { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp E" +
                     "vaporating temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty(PropertyName="variable_evaporating_temperature_maximum_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VariableEvaporatingTemperatureMaximumForIndoorUnit { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp C" +
                     "ondensing temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty(PropertyName="variable_condensing_temperature_minimum_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VariableCondensingTemperatureMinimumForIndoorUnit { get; set; } = Double.Parse("42", CultureInfo.InvariantCulture);
        

        [Description("This field is used if Refrigerant Temperature Control Algorithm is VariableTemp C" +
                     "ondensing temperature is the refrigerant temperature, not air temperature")]
        [JsonProperty(PropertyName="variable_condensing_temperature_maximum_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VariableCondensingTemperatureMaximumForIndoorUnit { get; set; } = Double.Parse("46", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_unit_evaporator_reference_superheating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitEvaporatorReferenceSuperheating { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_unit_condenser_reference_subcooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitCondenserReferenceSubcooling { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_unit_evaporator_rated_bypass_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitEvaporatorRatedBypassFactor { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_unit_condenser_rated_bypass_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitCondenserRatedBypassFactor { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="difference_between_outdoor_unit_evaporating_temperature_and_outdoor_air_temperatu" +
                                   "re_in_heat_recovery_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DifferenceBetweenOutdoorUnitEvaporatingTemperatureAndOutdoorAirTemperatureInHeatRecoveryMode { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Enter the rated capacity ratio between the main and supplementary outdoor unit he" +
                     "at exchangers [W/W]")]
        [JsonProperty(PropertyName="outdoor_unit_heat_exchanger_capacity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitHeatExchangerCapacityRatio { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor unit fan power per Watt of rated evaporative capacity [W/W]")]
        [JsonProperty(PropertyName="outdoor_unit_fan_power_per_unit_of_rated_evaporative_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitFanPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = Double.Parse("0.00425", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor unit fan flow rate per Watt of rated evaporative capacity [W/W]" +
                     "")]
        [JsonProperty(PropertyName="outdoor_unit_fan_flow_rate_per_unit_of_rated_evaporative_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitFanFlowRatePerUnitOfRatedEvaporativeCapacity { get; set; } = Double.Parse("7.5E-05", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_unit_evaporating_temperature_function_of_superheating_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="outdoor_unit_condensing_temperature_function_of_subcooling_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
        

        [Description("used to calculate the piping loss")]
        [JsonProperty(PropertyName="diameter_of_main_pipe_for_suction_gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiameterOfMainPipeForSuctionGas { get; set; } = Double.Parse("0.0762", CultureInfo.InvariantCulture);
        

        [Description("used to calculate the piping loss")]
        [JsonProperty(PropertyName="diameter_of_main_pipe_for_discharge_gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiameterOfMainPipeForDischargeGas { get; set; } = Double.Parse("0.0762", CultureInfo.InvariantCulture);
        

        [Description("used to calculate the heat loss of the main pipe")]
        [JsonProperty(PropertyName="length_of_main_pipe_connecting_outdoor_unit_to_the_first_branch_joint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LengthOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("used to calculate the refrigerant pressure drop of the main pipe")]
        [JsonProperty(PropertyName="equivalent_length_of_main_pipe_connecting_outdoor_unit_to_the_first_branch_joint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EquivalentLengthOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = Double.Parse("36", CultureInfo.InvariantCulture);
        

        [Description("Difference between outdoor unit height and indoor unit height Positive means outd" +
                     "oor unit is higher than indoor unit Negative means outdoor unit is lower than in" +
                     "door unit")]
        [JsonProperty(PropertyName="height_difference_between_outdoor_unit_and_indoor_units", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightDifferenceBetweenOutdoorUnitAndIndoorUnits { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="main_pipe_insulation_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MainPipeInsulationThickness { get; set; } = Double.Parse("0.02", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="main_pipe_insulation_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MainPipeInsulationThermalConductivity { get; set; } = Double.Parse("0.032", CultureInfo.InvariantCulture);
        

        [Description("Enter the value of the resistive heater located in the compressor(s). This heater" +
                     " is used to warm the refrigerant and oil when the compressor is off")]
        [JsonProperty(PropertyName="crankcase_heater_power_per_compressor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrankcaseHeaterPowerPerCompressor { get; set; } = Double.Parse("33", CultureInfo.InvariantCulture);
        

        [Description("Enter the total number of compressor. This input is used only for crankcase heate" +
                     "r calculations.")]
        [JsonProperty(PropertyName="number_of_compressors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCompressors { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Enter the ratio of the first stage compressor to total compressor capacity All ot" +
                     "her compressors are assumed to be equally sized. This inputs is used only for cr" +
                     "ankcase heater calculations")]
        [JsonProperty(PropertyName="ratio_of_compressor_size_to_total_compressor_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature above which the crankcase heaters are disab" +
                     "led")]
        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_crankcase_heater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForCrankcaseHeater { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating" +
                     " to cooling to melt frost formation on the condenser coil The resistive strategy" +
                     " uses a resistive heater to melt the frost.")]
        [JsonProperty(PropertyName="defrost_strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy DefrostStrategy { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostStrategy), "Resistive");
        

        [Description("Choose a defrost control type Either use a fixed Timed defrost period or select O" +
                     "nDemand to defrost only when necessary")]
        [JsonProperty(PropertyName="defrost_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostControl DefrostControl { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostControl)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_DefrostControl), "Timed");
        

        [Description("A valid performance curve must be used if ReverseCycle defrost strategy is select" +
                     "ed")]
        [JsonProperty(PropertyName="defrost_energy_input_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefrostEnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Fraction of time in defrost mode Only applicable if timed defrost control is spec" +
                     "ified")]
        [JsonProperty(PropertyName="defrost_time_period_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DefrostTimePeriodFraction { get; set; } = Double.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("Enter the size of the resistive defrost heating element Only applicable if resist" +
                     "ive defrost strategy is specified")]
        [JsonProperty(PropertyName="resistive_defrost_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ResistiveDefrostHeaterCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature above which the defrost operation is disabl" +
                     "ed")]
        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_defrost_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Cooling Only mode to Heat Recovery mode Enter the fractional capacity available at the start of heat recovery mode. The capacity exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Capacity Modifier and Heat Recovery Cooling Capacity Time Constant")]
        [JsonProperty(PropertyName="initial_heat_recovery_cooling_capacity_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialHeatRecoveryCoolingCapacityFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Cooling Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty(PropertyName="heat_recovery_cooling_capacity_time_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryCoolingCapacityTimeConstant { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Cooling Only mode to Heat Recovery mode Enter the fractional electric consumption rate at the start of heat recovery mode. The electric consumption rate exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Energy Modifier and Heat Recovery Cooling Energy Time Constant")]
        [JsonProperty(PropertyName="initial_heat_recovery_cooling_energy_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialHeatRecoveryCoolingEnergyFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Cooling Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty(PropertyName="heat_recovery_cooling_energy_time_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryCoolingEnergyTimeConstant { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Heating Only mode to Heat Recovery mode Enter the fractional capacity available at the start of heat recovery mode. The capacity exponentially approaches the steady-state value according to the inputs for Heat Recovery Heating Capacity Modifier and Heat Recovery Heating Capacity Time Constant")]
        [JsonProperty(PropertyName="initial_heat_recovery_heating_capacity_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialHeatRecoveryHeatingCapacityFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Heating Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty(PropertyName="heat_recovery_heating_capacity_time_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryHeatingCapacityTimeConstant { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This is used to describe the transition from Heating Only mode to Heat Recovery mode Enter the fractional electric consumption rate at the start of heat recovery mode. The electric consumption rate exponentially approaches the steady-state value according to the inputs for Heat Recovery Cooling Energy Modifier and Heat Recovery Cooling Energy Time Constant")]
        [JsonProperty(PropertyName="initial_heat_recovery_heating_energy_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialHeatRecoveryHeatingEnergyFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This is used to describe the transition from Heating Only mode to Heat Recovery m" +
                     "ode Enter the time constant used to model the transition from cooling only mode " +
                     "to heat recovery mode")]
        [JsonProperty(PropertyName="heat_recovery_heating_energy_time_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryHeatingEnergyTimeConstant { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="compressor_maximum_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorMaximumDeltaPressure { get; set; } = Double.Parse("4500000", CultureInfo.InvariantCulture);
        

        [Description("Efficiency of the compressor inverter")]
        [JsonProperty(PropertyName="compressor_inverter_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorInverterEfficiency { get; set; } = Double.Parse("0.95", CultureInfo.InvariantCulture);
        

        [Description("Describe the evaporative capacity difference because of system configuration diff" +
                     "erence between test bed and real system.")]
        [JsonProperty(PropertyName="compressor_evaporative_capacity_correction_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorEvaporativeCapacityCorrectionFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Load index describe the compressor operational state, either a single compressor " +
                     "or multiple compressors, at different load levels. First index represents minima" +
                     "l capacity operation Last index represents full capacity operation")]
        [JsonProperty(PropertyName="number_of_compressor_loading_index_entries", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCompressorLoadingIndexEntries { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="loading_indices", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_LoadingIndices_Item> LoadingIndices { get; set; } = null;
    }
}