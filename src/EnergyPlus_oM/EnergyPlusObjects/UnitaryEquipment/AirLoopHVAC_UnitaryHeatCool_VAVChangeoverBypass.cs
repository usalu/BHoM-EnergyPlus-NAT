using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, steam, or DX air-to-air heat pump) and bypass damper for variable volume flow to terminal units. Used with AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat or AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Enter the availability schedule name. Schedule values of zero denote system is Off. Non-zero schedule values denote system is available to operate.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the system air flow rate during cooling operation or specify autosize.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the system air flow rate during heating operation or specify autosize.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Only used when the supply air fan operating mode is continuous (see field Supply air fan operating mode schedule name). This system air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the system air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor air flow rate during cooling operation or specify autosize.")]
        [JsonProperty(PropertyName="cooling_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor air flow rate during heating operation or specify autosize.")]
        [JsonProperty(PropertyName="heating_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Only used when the supply air fan operating mode is continuous (see field Supply air fan operating mode schedule name). This outdoor air flow rate is used when no heating or cooling is required and the coils are off. If this field is left blank or zero, the outdoor air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty(PropertyName="no_load_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of a schedule that contains multipliers for the outdoor air flow r" +
                     "ates. Schedule values must be from 0 to 1. If field is left blank, model assumes" +
                     " multiplier is 1 for the entire simulation period.")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_multiplier_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirFlowRateMultiplierScheduleName { get; set; } = "";
        

        [Description("Enter the name of the unitary system\'s air inlet node.")]
        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Enter the name of the bypass duct mixer node. This name should be the name of the" +
                     " return air node for the outdoor air mixer associated with this system. This nod" +
                     "e name must be different from the air inlet node name.")]
        [JsonProperty(PropertyName="bypass_duct_mixer_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BypassDuctMixerNodeName { get; set; } = "";
        

        [Description(@"Enter the name of the bypass duct splitter node. This splitter air node is the outlet node of the last component in this unitary system. For blow through fan placement, the splitter air node is the outlet node of the heating coil. For draw through fan placement, the splitter node is the outlet node of the supply air fan.")]
        [JsonProperty(PropertyName="bypass_duct_splitter_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BypassDuctSplitterNodeName { get; set; } = "";
        

        [Description("Enter the name of the unitary system\'s air outlet node.")]
        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("currently only one type OutdoorAir:Mixer object is available.")]
        [JsonProperty(PropertyName="outdoor_air_mixer_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [Description("Enter the name of the outdoor air mixer used with this unitary system.")]
        [JsonProperty(PropertyName="outdoor_air_mixer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description("Specify the type of supply air fan used in this unitary system.")]
        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Enter the name of the supply air fan used in this unitary system.")]
        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description("Specify supply air fan placement as either blow through or draw through. BlowThro" +
                     "ugh means the supply air fan is located before the cooling coil. DrawThrough mea" +
                     "ns the supply air fan is located after the heating coil.")]
        [JsonProperty(PropertyName="supply_air_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_SupplyAirFanPlacement), "BlowThrough");
        

        [Description(@"Enter the name of a schedule to control the supply air fan. Schedule Name values of zero mean that the supply air fan will cycle off if there is no cooling or heating load in any of the zones being served by this system. Non-zero schedule values mean that the supply air fan will operate continuously even if there is no cooling or heating load in any of the zones being served. If this field is left blank, the supply air fan will operate continuously for the entire simulation period.")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Specify the type of cooling coil used in this unitary system.")]
        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [Description("Enter the name of the cooling coil used in this unitary system.")]
        [JsonProperty(PropertyName="cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilName { get; set; } = "";
        

        [Description("works with DX, gas, electric, hot water and steam heating coils Specify the type " +
                     "of heating coil used in this unitary system.")]
        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_HeatingCoilObjectType), "CoilHeatingDXSingleSpeed");
        

        [Description("Enter the name of the heating coil used in this unitary system.")]
        [JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilName { get; set; } = "";
        

        [Description(@"CoolingPriority = system provides cooling if any zone requires cooling. HeatingPriority = system provides heating if any zone requires heating. ZonePriority = system controlled based on the total number of zones requiring cooling or heating (highest number of zones in cooling or heating determines the system's operating mode). LoadPriority = system provides cooling or heating based on total zone loads.")]
        [JsonProperty(PropertyName="priority_control_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode PriorityControlMode { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_PriorityControlMode), "ZonePriority");
        

        [Description("Specify the minimum outlet air temperature allowed for this unitary system during" +
                     " cooling operation. This value should be less than the maximum outlet air temper" +
                     "ature during heating operation.")]
        [JsonProperty(PropertyName="minimum_outlet_air_temperature_during_cooling_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutletAirTemperatureDuringCoolingOperation { get; set; } = Double.Parse("8", CultureInfo.InvariantCulture);
        

        [Description("Specify the maximum outlet air temperature allowed for this unitary system during" +
                     " heating operation. This value should be greater than the minimum outlet air tem" +
                     "perature during cooling operation.")]
        [JsonProperty(PropertyName="maximum_outlet_air_temperature_during_heating_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutletAirTemperatureDuringHeatingOperation { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"None = meet sensible load only. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode. CoolReheat = cool beyond the Dry-Bulb temperature setpoint as required to meet the humidity setpoint. Valid only with Coil:Cooling:DX:TwoStageWithHumidityControlMode. For all dehumidification controls, the max humidity setpoint on this unitary system's air outlet node is used. This must be set using ZoneControl:Humidistat and SetpointManager:SingleZone:Humidity:Maximum, SetpointManager:MultiZone:Humidity:Maximum or SetpointManager:MultiZone:MaximumHumidity:Average objects.")]
        [JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_DehumidificationControlType), "None");
        

        [Description("Enter the name of the bypass duct node connected to a plenum or mixer. This field" +
                     " is required when this HVAC System is connected to a plenum or mixer. This is a " +
                     "different node name than that entered in the Bypass Duct Splitter Node Name fiel" +
                     "d.")]
        [JsonProperty(PropertyName="plenum_or_mixer_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlenumOrMixerInletNodeName { get; set; } = "";
        

        [Description("This is the minimum amount of time the unit operates in cooling or heating mode b" +
                     "efore changing modes.")]
        [JsonProperty(PropertyName="minimum_runtime_before_operating_mode_change", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRuntimeBeforeOperatingModeChange { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
    }
}