using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [Description(@"This is a key object in the new physics based VRF model applicable for Fluid Temperature Control It describes the Variable Refrigerant Flow system excluding the performance of indoor units Indoor units are modeled separately, see ZoneHVAC:TerminalUnit:VariableRefrigerantFlow")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl : BHoMObject
    {
        

        [Description("Enter a unique name for this variable refrigerant flow heat pump")]
        [JsonProperty(PropertyName="heat_pump_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatPumpName { get; set; } = "";
        

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
        [JsonProperty(PropertyName="minimum_outdoor_air_temperature_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorAirTemperatureInCoolingMode { get; set; } = Double.Parse("-6", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for cooling operation Cooling is di" +
                     "sabled above this temperature")]
        [JsonProperty(PropertyName="maximum_outdoor_air_temperature_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorAirTemperatureInCoolingMode { get; set; } = Double.Parse("43", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty(PropertyName="minimum_outdoor_air_temperature_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorAirTemperatureInHeatingMode { get; set; } = Double.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for heating operation Heating is di" +
                     "sabled below this temperature")]
        [JsonProperty(PropertyName="maximum_outdoor_air_temperature_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorAirTemperatureInHeatingMode { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_outdoor_unit_superheating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceOutdoorUnitSuperheating { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_outdoor_unit_subcooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceOutdoorUnitSubcooling { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="refrigerant_temperature_control_algorithm_for_indoor_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_RefrigerantTemperatureControlAlgorithmForIndoorUnit RefrigerantTemperatureControlAlgorithmForIndoorUnit { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_RefrigerantTemperatureControlAlgorithmForIndoorUnit)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_RefrigerantTemperatureControlAlgorithmForIndoorUnit), "VariableTemp");
        

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
        

        [Description("Enter the outdoor unit fan power per Watt of rated evaporative capacity [W/W]")]
        [JsonProperty(PropertyName="outdoor_unit_fan_power_per_unit_of_rated_evaporative_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitFanPowerPerUnitOfRatedEvaporativeCapacity { get; set; } = Double.Parse("0.00425", CultureInfo.InvariantCulture);
        

        [Description("This field is only used if the previous is set to autocalculate and performance i" +
                     "nput method is NominalCapacity")]
        [JsonProperty(PropertyName="outdoor_unit_fan_flow_rate_per_unit_of_rated_evaporative_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorUnitFanFlowRatePerUnitOfRatedEvaporativeCapacity { get; set; } = Double.Parse("7.5E-05", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_unit_evaporating_temperature_function_of_superheating_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorUnitEvaporatingTemperatureFunctionOfSuperheatingCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="outdoor_unit_condensing_temperature_function_of_subcooling_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
        

        [Description("used to calculate the piping loss")]
        [JsonProperty(PropertyName="diameter_of_main_pipe_connecting_outdoor_unit_to_the_first_branch_joint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiameterOfMainPipeConnectingOutdoorUnitToTheFirstBranchJoint { get; set; } = Double.Parse("0.0762", CultureInfo.InvariantCulture);
        

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
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_DefrostStrategy DefrostStrategy { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_DefrostStrategy)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_DefrostStrategy), "Resistive");
        

        [Description("Choose a defrost control type Either use a fixed Timed defrost period or select O" +
                     "nDemand to defrost only when necessary")]
        [JsonProperty(PropertyName="defrost_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_DefrostControl DefrostControl { get; set; } = (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_DefrostControl)Enum.Parse(typeof(AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_DefrostControl), "Timed");
        

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
        

        [JsonProperty(PropertyName="compressor_maximum_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorMaximumDeltaPressure { get; set; } = Double.Parse("4500000", CultureInfo.InvariantCulture);
        

        [Description("First index represents minimal capacity operation Last index represents full capa" +
                     "city operation")]
        [JsonProperty(PropertyName="number_of_compressor_loading_index_entries", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCompressorLoadingIndexEntries { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="loading_indices", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_LoadingIndices_Item> LoadingIndices { get; set; } = null;
    }
}