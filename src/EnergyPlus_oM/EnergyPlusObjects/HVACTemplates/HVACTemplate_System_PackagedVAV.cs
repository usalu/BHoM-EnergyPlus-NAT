using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Packaged Variable Air Volume (PVAV) air loop with optional heating coil and optio" +
                 "nal preheat.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_PackagedVAV : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always on; PVAV System always on. Schedule is used in availability mana" +
                     "ger and fan scheduling. Also see \"Night Cycle Control\" field.")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty(PropertyName="supply_fan_maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplyFanMaximumFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is only used to set a minimum part load on the VAV fan power curve. Au" +
                     "tosize or zero is recommended.")]
        [JsonProperty(PropertyName="supply_fan_minimum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplyFanMinimumFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_PackagedVAV_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty(PropertyName="supply_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanDeltaPressure { get; set; } = Double.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_in_air_stream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorInAirStreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_PackagedVAV_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_CoolingCoilType), "TwoSpeedDX");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="cooling_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty(PropertyName="cooling_coil_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty(PropertyName="cooling_coil_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilDesignSetpoint { get; set; } = Double.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross SHR")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electric power input")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilGrossRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_PackagedVAV_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HeatingCoilType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty(PropertyName="heating_coil_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty(PropertyName="heating_coil_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingCoilDesignSetpoint { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_coil_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingCoilCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="gas_heating_coil_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasHeatingCoilEfficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="gas_heating_coil_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasHeatingCoilParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_outdoor_air_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType MinimumOutdoorAirControlType { get; set; } = (HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_MinimumOutdoorAirControlType), "ProportionalMinimum");
        

        [Description("Schedule values multiply the Minimum Outdoor Air Flow Rate If blank, multiplier i" +
                     "s always one")]
        [JsonProperty(PropertyName="minimum_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="economizer_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_PackagedVAV_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_EconomizerType), "NoEconomizer");
        

        [JsonProperty(PropertyName="economizer_lockout", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_PackagedVAV_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_EconomizerLockout), "NoLockout");
        

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
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty(PropertyName="return_plenum_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnPlenumName { get; set; } = "";
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty(PropertyName="supply_fan_part_load_power_coefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients SupplyFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_SupplyFanPartLoadPowerCoefficients), "InletVaneDampers");
        

        [JsonProperty(PropertyName="night_cycle_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_PackagedVAV_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_NightCycleControl), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty(PropertyName="night_cycle_control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_PackagedVAV_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HeatRecoveryType), "None");
        

        [JsonProperty(PropertyName="sensible_heat_recovery_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleHeatRecoveryEffectiveness { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="latent_heat_recovery_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentHeatRecoveryEffectiveness { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description(@"Overrides Cooling Coil Setpoint Schedule Name None = no reset, control to Cooling Coil Design Setpoint Temperature or Schedule Warmest = reset as warm as possible yet meet all zone cooling loads at max supply air flow rate OutdoorAirTemperatureReset = reset based on outdoor air temperature (18.0C at 15.6C ODB, to the Cooling Design Setpoint at 26.7C) WarmestTemperatureFirst = reset as warm as possible yet meet all zone cooling loads at min supply air flow rate")]
        [JsonProperty(PropertyName="cooling_coil_setpoint_reset_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType CoolingCoilSetpointResetType { get; set; } = (HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_CoolingCoilSetpointResetType), "None");
        

        [Description(@"Overrides Heating Coil Setpoint Schedule Name None = no reset, control to Heating Coil Design Setpoint Temperature or Schedule OutdoorAirTemperatureReset = reset based on outdoor air temperature (Heating Design Setpoint at -6.7C ODB to Heating Design Setpoint minus 5.2C at 10C ODB) min supply air flow rate")]
        [JsonProperty(PropertyName="heating_coil_setpoint_reset_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType HeatingCoilSetpointResetType { get; set; } = (HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HeatingCoilSetpointResetType), "None");
        

        [Description("None = meet sensible load only CoolReheat = cool beyond the dry-bulb setpoint as " +
                     "required to meet the humidity setpoint.")]
        [JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_PackagedVAV_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_DehumidificationControlType), "None");
        

        [Description("Zone name where humidistat is located")]
        [JsonProperty(PropertyName="dehumidification_control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DehumidificationControlZoneName { get; set; } = "";
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty(PropertyName="dehumidification_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DehumidificationSetpoint { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="humidifier_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_PackagedVAV_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_HumidifierType), "None");
        

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
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty(PropertyName="humidifier_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidifierSetpoint { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Select whether autosized system supply flow rate is the sum of Coincident or NonC" +
                     "oincident zone air flow rates.")]
        [JsonProperty(PropertyName="sizing_option", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_SizingOption SizingOption { get; set; } = (HVACTemplate_System_PackagedVAV_SizingOption)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_SizingOption), "NonCoincident");
        

        [Description("Specifies if the system has a return fan.")]
        [JsonProperty(PropertyName="return_fan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ReturnFan { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="return_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="return_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanDeltaPressure { get; set; } = Double.Parse("500", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="return_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="return_fan_motor_in_air_stream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnFanMotorInAirStreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field selects a predefined set of fan power coefficients. The ASHRAE 90.1-20" +
                     "04 Appendix G coefficients are from TABLE G3.1.3.15, Method 2. The other sets of" +
                     " coefficients are from the EnergyPlus Input Output Reference, Fan Coefficient Va" +
                     "lues table.")]
        [JsonProperty(PropertyName="return_fan_part_load_power_coefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients ReturnFanPartLoadPowerCoefficients { get; set; } = (HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients)Enum.Parse(typeof(HVACTemplate_System_PackagedVAV_ReturnFanPartLoadPowerCoefficients), "InletVaneDampers");
    }
}