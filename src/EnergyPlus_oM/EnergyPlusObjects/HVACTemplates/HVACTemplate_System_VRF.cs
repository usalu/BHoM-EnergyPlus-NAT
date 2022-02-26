using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Variable refrigerant flow (VRF) heat pump condensing unit. Serves one or more VRF" +
                 " zone terminal units (HVACTemplate:Zone:VRF).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_VRF : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the total cooling capacity in watts at rated conditions or set to autosize." +
                     " Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossRatedTotalCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the coefficient of performance at rated conditions or leave blank to use de" +
                     "fault. COP includes compressor and condenser fan electrical energy input COP doe" +
                     "s not include supply fan heat or supply fan electric power input")]
        [JsonProperty(PropertyName="gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GrossRatedCoolingCop { get; set; } = Double.Parse("3.3", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for cooling operation. Cooling is d" +
                     "isabled below this temperature.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorTemperatureInCoolingMode { get; set; } = Double.Parse("-6", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for cooling operation. Cooling is d" +
                     "isabled above this temperature.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorTemperatureInCoolingMode { get; set; } = Double.Parse("43", CultureInfo.InvariantCulture);
        

        [Description("Enter the heating capacity in watts at rated conditions or set to autosize. Heati" +
                     "ng capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="gross_rated_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossRatedHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"If the Gross Rated Heating Capacity is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. The zone terminal unit heating coils are also sized using this ratio unless the sizing ratio input in the ZoneHVAC:TerminalUnit:VariableRefrigerantFlow object is entered.")]
        [JsonProperty(PropertyName="rated_heating_capacity_sizing_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedHeatingCapacitySizingRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("COP includes compressor and condenser fan electrical energy input COP does not in" +
                     "clude supply fan heat or supply fan electrical energy input")]
        [JsonProperty(PropertyName="gross_rated_heating_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GrossRatedHeatingCop { get; set; } = Double.Parse("3.4", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum outdoor temperature allowed for heating operation.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorTemperatureInHeatingMode { get; set; } = Double.Parse("-20", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature allowed for heating operation.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorTemperatureInHeatingMode { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum heat pump part-load ratio (PLR). When the cooling or heating PL" +
                     "R is below this value, the heat pump compressor will cycle to meet the cooling o" +
                     "r heating demand.")]
        [JsonProperty(PropertyName="minimum_heat_pump_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumHeatPumpPartLoadRatio { get; set; } = Double.Parse("0.15", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of the zone where the master thermostat is located.")]
        [JsonProperty(PropertyName="zone_name_for_master_thermostat_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneNameForMasterThermostatLocation { get; set; } = "";
        

        [Description("Choose a thermostat control logic scheme. If these control types fail to control " +
                     "zone temperature within a reasonable limit, consider using multiple VRF systems")]
        [JsonProperty(PropertyName="master_thermostat_priority_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VRF_MasterThermostatPriorityControlType MasterThermostatPriorityControlType { get; set; } = (HVACTemplate_System_VRF_MasterThermostatPriorityControlType)Enum.Parse(typeof(HVACTemplate_System_VRF_MasterThermostatPriorityControlType), "MasterThermostatPriority");
        

        [Description("this field is required if Master Thermostat Priority Control Type is Scheduled. S" +
                     "chedule values of 0 denote cooling, 1 for heating, and all other values disable " +
                     "the system.")]
        [JsonProperty(PropertyName="thermostat_priority_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermostatPriorityScheduleName { get; set; } = "";
        

        [Description("This field is reserved for future use. The only valid choice is No.")]
        [JsonProperty(PropertyName="heat_pump_waste_heat_recovery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes HeatPumpWasteHeatRecovery { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
        [JsonProperty(PropertyName="equivalent_piping_length_used_for_piping_correction_factor_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EquivalentPipingLengthUsedForPipingCorrectionFactorInCoolingMode { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Enter the height difference between the highest and lowest terminal unit")]
        [JsonProperty(PropertyName="vertical_height_used_for_piping_correction_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VerticalHeightUsedForPipingCorrectionFactor { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Enter the equivalent length of the farthest terminal unit from the condenser")]
        [JsonProperty(PropertyName="equivalent_piping_length_used_for_piping_correction_factor_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EquivalentPipingLengthUsedForPipingCorrectionFactorInHeatingMode { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Enter the value of the resistive heater located in the compressor(s). This heater" +
                     " is used to warm the refrigerant and oil when the compressor is off.")]
        [JsonProperty(PropertyName="crankcase_heater_power_per_compressor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrankcaseHeaterPowerPerCompressor { get; set; } = Double.Parse("33", CultureInfo.InvariantCulture);
        

        [Description("Enter the total number of compressor. This input is used only for crankcase heate" +
                     "r calculations.")]
        [JsonProperty(PropertyName="number_of_compressors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCompressors { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Enter the ratio of the first stage compressor to total compressor capacity. All o" +
                     "ther compressors are assumed to be equally sized. This inputs is used only for c" +
                     "rankcase heater calculations.")]
        [JsonProperty(PropertyName="ratio_of_compressor_size_to_total_compressor_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfCompressorSizeToTotalCompressorCapacity { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature above which the crankcase heaters are disab" +
                     "led.")]
        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_crankcase_heater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForCrankcaseHeater { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Select a defrost strategy. Reverse cycle reverses the operating mode from heating" +
                     " to cooling to melt frost formation on the condenser coil. The resistive strateg" +
                     "y uses a resistive heater to melt the frost.")]
        [JsonProperty(PropertyName="defrost_strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VRF_DefrostStrategy DefrostStrategy { get; set; } = (HVACTemplate_System_VRF_DefrostStrategy)Enum.Parse(typeof(HVACTemplate_System_VRF_DefrostStrategy), "Resistive");
        

        [Description("Choose a defrost control type. Either use a fixed Timed defrost period or select " +
                     "OnDemand to defrost only when necessary.")]
        [JsonProperty(PropertyName="defrost_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VRF_DefrostControl DefrostControl { get; set; } = (HVACTemplate_System_VRF_DefrostControl)Enum.Parse(typeof(HVACTemplate_System_VRF_DefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode. Only applicable if timed defrost control is spe" +
                     "cified.")]
        [JsonProperty(PropertyName="defrost_time_period_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DefrostTimePeriodFraction { get; set; } = Double.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("Enter the size of the resistive defrost heating element. Only applicable if resis" +
                     "tive defrost strategy is specified")]
        [JsonProperty(PropertyName="resistive_defrost_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ResistiveDefrostHeaterCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the maximum outdoor temperature above which defrost operation is disabled.")]
        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_defrost_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Select either an air cooled or evaporatively cooled condenser.")]
        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VRF_CondenserType CondenserType { get; set; } = (HVACTemplate_System_VRF_CondenserType)Enum.Parse(typeof(HVACTemplate_System_VRF_CondenserType), "AirCooled");
        

        [Description("Only used when Condenser Type = WaterCooled.")]
        [JsonProperty(PropertyName="water_condenser_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> WaterCondenserVolumeFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the effectiveness of the evaporatively cooled condenser. This field is only" +
                     " used when the Condenser Type = EvaporativelyCooled.")]
        [JsonProperty(PropertyName="evaporative_condenser_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserEffectiveness { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Used to calculate evaporative condenser water use. This field is only used when t" +
                     "he Condenser Type = EvaporativelyCooled.")]
        [JsonProperty(PropertyName="evaporative_condenser_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> EvaporativeCondenserAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump. This field is onl" +
                     "y used when the Condenser Type = EvaporativelyCooled.")]
        [JsonProperty(PropertyName="evaporative_condenser_pump_rated_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty(PropertyName="basin_heater_operating_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_VRF_FuelType FuelType { get; set; } = (HVACTemplate_System_VRF_FuelType)Enum.Parse(typeof(HVACTemplate_System_VRF_FuelType), "Electricity");
        

        [Description("The minimum outdoor temperature below which heat recovery mode will not operate.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_in_heat_recovery_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorTemperatureInHeatRecoveryMode { get; set; } = Double.Parse("-15", CultureInfo.InvariantCulture);
        

        [Description("The maximum outdoor temperature above which heat recovery mode will not operate.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_in_heat_recovery_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorTemperatureInHeatRecoveryMode { get; set; } = Double.Parse("45", CultureInfo.InvariantCulture);
    }
}