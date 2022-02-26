using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Unitary furnace with air conditioner")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_Unitary : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always on; Unitary System always on. Schedule is used in availability m" +
                     "anager and fan scheduling. Also see \"Night Cycle Control\" field.")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_zone_or_thermostat_location_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneOrThermostatLocationName { get; set; } = "";
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will *not* be mult" +
                     "iplied by any sizing factor or by zone multipliers. If using zone multipliers a " +
                     "value entered here must be large enough to serve the multiplied zones.")]
        [JsonProperty(PropertyName="supply_fan_maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplyFanMaximumFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty(PropertyName="supply_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

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
        public HVACTemplate_System_Unitary_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_Unitary_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_Unitary_CoolingCoilType), "SingleSpeedDX");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="cooling_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty(PropertyName="cooling_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignSupplyAirTemperature { get; set; } = Double.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross SHR")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electric power")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilGrossRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_Unitary_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HeatingCoilType), "Electric");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Used for sizing.")]
        [JsonProperty(PropertyName="heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingDesignSupplyAirTemperature { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

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
        

        [Description("Schedule values multiply the minimum outdoor air flow rate If blank, always one")]
        [JsonProperty(PropertyName="minimum_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="economizer_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_EconomizerType EconomizerType { get; set; } = (HVACTemplate_System_Unitary_EconomizerType)Enum.Parse(typeof(HVACTemplate_System_Unitary_EconomizerType), "NoEconomizer");
        

        [JsonProperty(PropertyName="economizer_lockout", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_EconomizerLockout EconomizerLockout { get; set; } = (HVACTemplate_System_Unitary_EconomizerLockout)Enum.Parse(typeof(HVACTemplate_System_Unitary_EconomizerLockout), "NoLockout");
        

        [Description("Outdoor temperature above which economizer is disabled and heat recovery is enabl" +
                     "ed (if available). Blank means no limit.")]
        [JsonProperty(PropertyName="economizer_upper_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerUpperTemperatureLimit { get; set; } = null;
        

        [Description("Outdoor temperature below which economizer is disabled and heat recovery is enabl" +
                     "ed (if available). Blank means no limit.")]
        [JsonProperty(PropertyName="economizer_lower_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerLowerTemperatureLimit { get; set; } = null;
        

        [Description("Outdoor enthalpy above which economizer is disabled and heat recovery is enabled " +
                     "(if available). Blank means no limit.")]
        [JsonProperty(PropertyName="economizer_upper_enthalpy_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerUpperEnthalpyLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_dewpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description("Plenum zone name. Supply plenum serves all zones on this system. Blank if none.")]
        [JsonProperty(PropertyName="supply_plenum_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyPlenumName { get; set; } = "";
        

        [Description("Plenum zone name. Return plenum serves all zones on this system. Blank if none.")]
        [JsonProperty(PropertyName="return_plenum_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnPlenumName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_Unitary_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_Unitary_SupplyFanPlacement), "BlowThrough");
        

        [JsonProperty(PropertyName="night_cycle_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_NightCycleControl NightCycleControl { get; set; } = (HVACTemplate_System_Unitary_NightCycleControl)Enum.Parse(typeof(HVACTemplate_System_Unitary_NightCycleControl), "StayOff");
        

        [Description("Applicable only if Night Cycle Control is Cycle On Control Zone.")]
        [JsonProperty(PropertyName="night_cycle_control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NightCycleControlZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_Unitary_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HeatRecoveryType), "None");
        

        [JsonProperty(PropertyName="sensible_heat_recovery_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleHeatRecoveryEffectiveness { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Heat Recovery Type is Enthalpy.")]
        [JsonProperty(PropertyName="latent_heat_recovery_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentHeatRecoveryEffectiveness { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description(@"None = meet sensible cooling load only CoolReheatHeatingCoil = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with main heating coil. CoolReheatDesuperheater = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with desuperheater coil.")]
        [JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_Unitary_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_Unitary_DehumidificationControlType), "None");
        

        [Description("Zone relative humidity setpoint in percent (0 to 100)")]
        [JsonProperty(PropertyName="dehumidification_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DehumidificationSetpoint { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="humidifier_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_Unitary_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_Unitary_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_Unitary_HumidifierType), "None");
        

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
    }
}