using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Unitary HVAC system with optional cooling and heating. Supports DX and chilled wa" +
                 "ter, cooling, gas, electric, and hot water heating, air-to-air and water-to-air " +
                 "heat pumps.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_UnitarySystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always available. Also see Supply Fan Operating Mode Schedule Name fiel" +
                     "d.")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Load control requires a Controlling Zone name. SetPoint control requires set poin" +
                     "ts at coil outlet nodes. The user must add appropriate SetpointManager objects t" +
                     "o the idf file.")]
        [JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_ControlType ControlType { get; set; } = (HVACTemplate_System_UnitarySystem_ControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_ControlType), "Load");
        

        [Description("This field is required if Control Type is Load.")]
        [JsonProperty(PropertyName="control_zone_or_thermostat_location_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

        [Description(@"Supply air flow rate during cooling operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Supply air flow rate during heating operation This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is Continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. This field may be set to ""autosize"". If a value is entered, it will *not* be multiplied by any sizing factor or by zone multipliers. If using zone multipliers a value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty(PropertyName="supply_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_UnitarySystem_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SupplyFanPlacement), "BlowThrough");
        

        [JsonProperty(PropertyName="supply_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanDeltaPressure { get; set; } = Double.Parse("600", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_in_air_stream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorInAirStreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_CoolingCoilType), "SingleSpeedDX");
        

        [Description("Used only for Cooling Coil Type = MultiSpeedDX.")]
        [JsonProperty(PropertyName="number_of_speeds_for_cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfSpeedsForCooling { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="cooling_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty(PropertyName="cooling_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignSupplyAirTemperature { get; set; } = Double.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
                     "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
                     "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty(PropertyName="dx_cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DxCoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty(PropertyName="dx_cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DxCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electric power input")]
        [JsonProperty(PropertyName="dx_cooling_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DxCoolingCoilGrossRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatingCoilType), "Gas");
        

        [Description("Used only for Heating Coil Type = MultiSpeedDXHeatPumpAirSource), MultiStageElect" +
                     "ric, or MultiStageGas.")]
        [JsonProperty(PropertyName="number_of_speeds_or_stages_for_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfSpeedsOrStagesForHeating { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty(PropertyName="heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingDesignSupplyAirTemperature { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity excluding the effect of supply air fan heat Rating point o" +
                     "utdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating c" +
                     "oil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="heating_coil_gross_rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingCoilGrossRatedCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="gas_heating_coil_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasHeatingCoilEfficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="gas_heating_coil_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasHeatingCoilParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, does not include supply air fan heat or supply air fan electrical energy. Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C Applies only to DX coils")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpHeatingCoilGrossRatedCop { get; set; } = Double.Parse("2.75", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_heating_minimum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = Double.Parse("-8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_defrost_maximum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_defrost_strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatPumpDefrostStrategy), "ReverseCycle");
        

        [JsonProperty(PropertyName="heat_pump_defrost_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatPumpDefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
                     "ified")]
        [JsonProperty(PropertyName="heat_pump_defrost_time_period_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpDefrostTimePeriodFraction { get; set; } = Double.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supplemental_heating_or_reheat_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType SupplementalHeatingOrReheatCoilType { get; set; } = (HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SupplementalHeatingOrReheatCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="supplemental_heating_or_reheat_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementalHeatingOrReheatCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supplemental_heating_or_reheat_coil_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplementalHeatingOrReheatCoilCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty(PropertyName="supplemental_heating_or_reheat_coil_maximum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplementalHeatingOrReheatCoilMaximumOutdoorDryBulbTemperature { get; set; } = Double.Parse("21", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty(PropertyName="supplemental_gas_heating_or_reheat_coil_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplementalGasHeatingOrReheatCoilEfficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty(PropertyName="supplemental_gas_heating_or_reheat_coil_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplementalGasHeatingOrReheatCoilParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Schedule values multiply the minimum outdoor air flow rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty(PropertyName="minimum_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="economizer_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_UnitarySystem_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_EconomizerType), "NoEconomizer");
        

        [JsonProperty(PropertyName="economizer_lockout", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_UnitarySystem_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_EconomizerLockout), "NoLockout");
        

        [Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
                     "control type. No input or blank input means this limit is not operative. Limit i" +
                     "s applied regardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

        [Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
                     "e. No input or blank input means this limit is not operative Limit is applied re" +
                     "gardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_enthalpy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_dewpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
                     "nput or blank input means this limit is not operative Limit is applied regardles" +
                     "s of economizer control type.")]
        [JsonProperty(PropertyName="economizer_minimum_limit_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty(PropertyName="supply_plenum_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
        [JsonProperty(PropertyName="return_plenum_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryType), "None");
        

        [JsonProperty(PropertyName="sensible_heat_recovery_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleHeatRecoveryEffectiveness { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Heat Recovery Type is Enthalpy.")]
        [JsonProperty(PropertyName="latent_heat_recovery_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentHeatRecoveryEffectiveness { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_recovery_heat_exchanger_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryHeatExchangerType), "Plate");
        

        [JsonProperty(PropertyName="heat_recovery_frost_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HeatRecoveryFrostControlType), "None");
        

        [Description(@"None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint, reheat with reheat coil If no reheat coil specified, cold supply temps may occur. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only for Cooling Coil Type = TwoStageHumidityControlDX or HeatExchangerAssistedDX")]
        [JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_UnitarySystem_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_DehumidificationControlType), "None");
        

        [Description("Zone relative humidity setpoint in percent (0 to 100) Ignored if Dehumidification" +
                     " Relative Humidity Setpoint Schedule specified below")]
        [JsonProperty(PropertyName="dehumidification_relative_humidity_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DehumidificationRelativeHumiditySetpoint { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

        [Description("Leave blank to use constant setpoint specified in Dehumidification Relative Humid" +
                     "ity Setpoint above. Schedule values must be in percent relative humidity (0 to 1" +
                     "00).")]
        [JsonProperty(PropertyName="dehumidification_relative_humidity_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DehumidificationRelativeHumiditySetpointScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="humidifier_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_UnitarySystem_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_HumidifierType), "None");
        

        [Description("If blank, always available")]
        [JsonProperty(PropertyName="humidifier_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidifierAvailabilityScheduleName { get; set; } = "";
        

        [Description("Moisture output rate at full rated power input. The humidifier does not currently" +
                     " autosize, so the default is very large to allow for adequate capacity.")]
        [JsonProperty(PropertyName="humidifier_rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidifierRatedCapacity { get; set; } = Double.Parse("1E-06", CultureInfo.InvariantCulture);
        

        [Description("Electric power input at rated capacity moisture output. Power consumption is prop" +
                     "ortional to moisture output with no part-load penalty.")]
        [JsonProperty(PropertyName="humidifier_rated_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HumidifierRatedElectricPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Zone name where humidistat is located")]
        [JsonProperty(PropertyName="humidifier_control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidifierControlZoneName { get; set; } = "";
        

        [Description("Zone relative humidity setpoint in percent (0 to 100). Ignored if Humidifier Rela" +
                     "tive Humidity Setpoint Schedule specified below")]
        [JsonProperty(PropertyName="humidifier_relative_humidity_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidifierRelativeHumiditySetpoint { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Leave blank to use constant setpoint specified in Humidifier Relative Humidity Se" +
                     "tpoint above. Schedule values must be in percent relative humidity (0 to 100).")]
        [JsonProperty(PropertyName="humidifier_relative_humidity_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidifierRelativeHumiditySetpointScheduleName { get; set; } = "";
        

        [Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
                     "oincident zone air flow rates.")]
        [JsonProperty(PropertyName="sizing_option", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_UnitarySystem_SizingOption SizingOption { get; set; } = (HVACTemplate_System_UnitarySystem_SizingOption)Enum.Parse(typeof(HVACTemplate_System_UnitarySystem_SizingOption), "NonCoincident");
        

        [Description("Specifies if the system has a return fan.")]
        [JsonProperty(PropertyName="return_fan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="return_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="return_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanDeltaPressure { get; set; } = Double.Parse("300", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="return_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="return_fan_motor_in_air_stream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanMotorInAirStreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}