using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object creates a dedicated outdoor air system that must be used with HVACTem" +
                 "plate:Zone:* objects for BaseboardHeat FanCoil PTAC PTHP WaterToAirHeatPump and " +
                 "VRF. Does not support HVACTemplate:Zone:VAV or other central multizone systems")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_System_DedicatedOutdoorAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always on; DOAS System always on. Schedule is used in availability mana" +
                     "ger and fan scheduling.")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_AirOutletType AirOutletType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_AirOutletType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_AirOutletType), "DirectIntoZone");
        

        [JsonProperty(PropertyName="supply_fan_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplyFanFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanDeltaPressure { get; set; } = Double.Parse("1000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_in_air_stream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorInAirStreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty(PropertyName="cooling_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType), "ChilledWater");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="cooling_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_coil_setpoint_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType CoolingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilSetpointControlType), "FixedSetpoint");
        

        [Description("Used for sizing and as constant setpoint if no Cooling Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty(PropertyName="cooling_coil_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilDesignSetpoint { get; set; } = Double.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty(PropertyName="cooling_coil_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="cooling_coil_setpoint_at_outdoor_dry_bulb_low", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilSetpointAtOutdoorDryBulbLow { get; set; } = Double.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults are 15.6C (60F) " +
                     "at 15.6C (60F) to 12.8C (55F) at 23.3C (74F)")]
        [JsonProperty(PropertyName="cooling_coil_reset_outdoor_dry_bulb_low", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilResetOutdoorDryBulbLow { get; set; } = Double.Parse("15.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="cooling_coil_setpoint_at_outdoor_dry_bulb_high", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = Double.Parse("12.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="cooling_coil_reset_outdoor_dry_bulb_high", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilResetOutdoorDryBulbHigh { get; set; } = Double.Parse("23.3", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="dx_cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DxCoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross SHR")]
        [JsonProperty(PropertyName="dx_cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DxCoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty(PropertyName="dx_cooling_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DxCoolingCoilGrossRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType HeatingCoilType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilType), "HotWater");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("When selecting OutdoorAirTemperatureReset, the Heating Coil Design Setpoint may n" +
                     "eed to be changed")]
        [JsonProperty(PropertyName="heating_coil_setpoint_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType HeatingCoilSetpointControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatingCoilSetpointControlType), "FixedSetpoint");
        

        [Description("Used for sizing and as constant setpoint if no Heating Coil Setpoint Schedule Nam" +
                     "e is specified.")]
        [JsonProperty(PropertyName="heating_coil_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingCoilDesignSetpoint { get; set; } = Double.Parse("12.2", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty(PropertyName="heating_coil_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilSetpointScheduleName { get; set; } = "";
        

        [Description("Applicable only for OutdoorAirTemperatureReset control. Defaults 15.0C (59F) at 7" +
                     ".8C (46F) to 12.2C (54F) at 12.2C (54F)")]
        [JsonProperty(PropertyName="heating_coil_setpoint_at_outdoor_dry_bulb_low", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingCoilSetpointAtOutdoorDryBulbLow { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="heating_coil_reset_outdoor_dry_bulb_low", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingCoilResetOutdoorDryBulbLow { get; set; } = Double.Parse("7.8", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="heating_coil_setpoint_at_outdoor_dry_bulb_high", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingCoilSetpointAtOutdoorDryBulbHigh { get; set; } = Double.Parse("12.2", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="heating_coil_reset_outdoor_dry_bulb_high", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingCoilResetOutdoorDryBulbHigh { get; set; } = Double.Parse("12.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="gas_heating_coil_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasHeatingCoilEfficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="gas_heating_coil_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasHeatingCoilParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_recovery_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType HeatRecoveryType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryType), "None");
        

        [JsonProperty(PropertyName="heat_recovery_sensible_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoverySensibleEffectiveness { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_recovery_latent_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryLatentEffectiveness { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_recovery_heat_exchanger_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType HeatRecoveryHeatExchangerType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryHeatExchangerType), "Plate");
        

        [JsonProperty(PropertyName="heat_recovery_frost_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType HeatRecoveryFrostControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HeatRecoveryFrostControlType), "None");
        

        [Description(@"None = meet sensible load only CoolReheatHeatingCoil = cool beyond the dry-bulb setpoint, reheat with heating coil Valid for all cooling coil types. If no heating coil specified, cold supply temps may occur. CoolReheatDesuperheater = cool beyond the dry-bulb setpoint as required to meet the humidity setpoint, reheat with desuperheater coil. Valid only for Cooling Coil Type = TwoSpeedDX, TwoStageDX, TwoStageHumidityControlDX, or HeatExchangerAssistedDX. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only for Cooling Coil Type = TwoStageHumidityControlDX or HeatExchangerAssistedDX")]
        [JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType DehumidificationControlType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_DehumidificationControlType), "None");
        

        [Description("The supply air humidity ratio for dehumidification control. Default of 0.00924 kg" +
                     "Water/kgDryAir is equivalent to 12.8C (55F) dewpoint. Ignored if Dehumidificatio" +
                     "n Setpoint Schedule specified below")]
        [JsonProperty(PropertyName="dehumidification_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DehumidificationSetpoint { get; set; } = Double.Parse("0.00924", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="humidifier_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_System_DedicatedOutdoorAir_HumidifierType HumidifierType { get; set; } = (HVACTemplate_System_DedicatedOutdoorAir_HumidifierType)Enum.Parse(typeof(HVACTemplate_System_DedicatedOutdoorAir_HumidifierType), "None");
        

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
        

        [Description("The supply air humidity ratio for humidification control. Ignored if Humidifier S" +
                     "etpoint Schedule specified below")]
        [JsonProperty(PropertyName="humidifier_constant_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidifierConstantSetpoint { get; set; } = Double.Parse("0.003", CultureInfo.InvariantCulture);
        

        [Description("Leave blank to use constant setpoint specified in Dehumidification Setpoint above" +
                     ". Schedule values must be in units of humidity ratio (kgWater/kgDryAir or lbWate" +
                     "r/lbDryAir)")]
        [JsonProperty(PropertyName="dehumidification_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DehumidificationSetpointScheduleName { get; set; } = "";
        

        [Description("Leave blank to use constant setpoint specified in Humidifier Constant Setpoint ab" +
                     "ove. Schedule values must be in units of humidity ratio (kgWater/kgDryAir or lbW" +
                     "ater/lbDryAir)")]
        [JsonProperty(PropertyName="humidifier_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidifierSetpointScheduleName { get; set; } = "";
    }
}