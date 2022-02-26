using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description(@"A terminal unit with variable refrigerant flow (VRF) DX cooling and heating coils (air-to-air heat pump). The VRF terminal units are served by an AirConditioner:VariableRefrigerantFlow or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:* system. Terminal units can be configured as zone, air loop or outside air system equipment.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_TerminalUnit_VariableRefrigerantFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The unit is available the entire simulation if this field is left blank Schedule " +
                     "values of 0 denote the unit is off.")]
        [JsonProperty(PropertyName="terminal_unit_availability_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TerminalUnitAvailabilitySchedule { get; set; } = "";
        

        [Description("the inlet node to the terminal unit")]
        [JsonProperty(PropertyName="terminal_unit_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TerminalUnitAirInletNodeName { get; set; } = "";
        

        [Description("the outlet node of the terminal unit")]
        [JsonProperty(PropertyName="terminal_unit_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TerminalUnitAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="no_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoCoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="no_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoHeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is used only when an oudoor air mixer is included. This field is set to zero flow when the VRF terminal unit is connected to central dedicated outdoor air through air terminal single duct mixer object. When this VRF terminal is used as air loop equipment the autosized flow rate will be set to 0 when an outdoor air system is connected to this air loop, otherwise the outdoor air flow rate will equal the maximum outdoor air flow rate.")]
        [JsonProperty(PropertyName="cooling_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is used only when an oudoor air mixer is included. This field is set to zero flow when the VRF terminal unit is connected to central dedicated outdoor air through air terminal single duct mixer object. When this VRF terminal is used as air loop equipment the autosized flow rate will be set to 0 when an outdoor air system is connected to this air loop, otherwise the outdoor air flow rate will equal the maximum outdoor air flow rate.")]
        [JsonProperty(PropertyName="heating_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is used only when an oudoor air mixer is included. This field is set to zero flow when the VRF terminal unit is connected to central dedicated outdoor air through air terminal single duct mixer object. When this VRF terminal is used as air loop equipment the autosized flow rate will be set to 0 when an outdoor air system is connected to this air loop, otherwise the outdoor air flow rate will equal the maximum outdoor air flow rate.")]
        [JsonProperty(PropertyName="no_load_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Required for zone equipment. Leave blank if terminal unit is used in AirLoopHVAC:" +
                     "OutdoorAirSystem:EquipmentList. Also leave blank if terminal unit is used on mai" +
                     "n AirloopHVAC branch and terminal unit has no fan.")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description(@"Select fan placement as either blow through or draw through. Required for zone equipment. This field is ignored if the VRF terminal unit is used in AirLoopHVAC:OutdoorAirSystem:EquipmentList. This field is also ignored if VRF terminal unit is used on main AirloopHVAC branch and terminal unit has no fan.")]
        [JsonProperty(PropertyName="supply_air_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanPlacement), "BlowThrough");
        

        [Description(@"Supply Air Fan Object Type must be Fan:SystemModel, Fan:OnOff, or Fan:ConstantVolume if AirConditioner:VariableRefrigerantFlow is used to model VRF outdoor unit Supply Air Fan Object Type must be Fan:SystemModel or Fan:VariableVolume if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR is used to model VRF outdoor unit Required for zone equipment. Leave blank if terminal unit is used in AirLoopHVAC:OutdoorAirSystem:EquipmentList. Also leave blank if terminal unit is used on main AirloopHVAC branch and terminal unit has no fan.")]
        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplyAirFanObjectType), "Empty");
        

        [JsonProperty(PropertyName="supply_air_fan_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanObjectName { get; set; } = "";
        

        [Description(@"Currently only one type OutdoorAir:Mixer object is available. If this field is blank, and outside air mixer is not used. This field should be left blank if the VRF terminal unit is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object. This field may also be left blank when the VRF terminal is used in the air loop or outdoor air system.")]
        [JsonProperty(PropertyName="outside_air_mixer_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType OutsideAirMixerObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_OutsideAirMixerObjectType), "OutdoorAirMixer");
        

        [Description(@"If this field is blank, the OutdoorAir:Mixer is not used. This optional field specifies the name of the OutdoorAir:Mixer object. When used, this name needs to match name of the OutdoorAir:Mixer object. This field should be left blank if the VRF terminal unit is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object. This field may also be left blank when the VRF terminal is used in the air loop or outdoor air system.")]
        [JsonProperty(PropertyName="outside_air_mixer_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideAirMixerObjectName { get; set; } = "";
        

        [Description(@"Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow if AirConditioner:VariableRefrigerantFlow is used to model VRF outdoor unit Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR is used to model VRF outdoor unit This field may be left blank if heating-only mode is used")]
        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_CoolingCoilObjectType), "CoilCoolingDXVariableRefrigerantFlow");
        

        [Description("Cooling Coil Type must be Coil:Cooling:DX:VariableRefrigerantFlow This field may " +
                     "be left blank if heating-only mode is used")]
        [JsonProperty(PropertyName="cooling_coil_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilObjectName { get; set; } = "";
        

        [Description(@"Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow if AirConditioner:VariableRefrigerantFlow is used to model VRF outdoor unit Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or if AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR is used to model VRF outdoor unit This field may be left blank if cooling-only mode is used")]
        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_HeatingCoilObjectType), "CoilHeatingDXVariableRefrigerantFlow");
        

        [Description("Heating Coil Type must be Coil:Heating:DX:VariableRefrigerantFlow This field may " +
                     "be left blank if cooling-only mode is used")]
        [JsonProperty(PropertyName="heating_coil_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_terminal_unit_on_parasitic_electric_energy_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneTerminalUnitOnParasiticElectricEnergyUse { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_terminal_unit_off_parasitic_electric_energy_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneTerminalUnitOffParasiticElectricEnergyUse { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"If this terminal unit's heating coil is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. This input applies to the terminal unit heating coil and overrides the sizing ratio entered in the AirConditioner:VariableRefrigerantFlow object.")]
        [JsonProperty(PropertyName="rated_heating_capacity_sizing_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedHeatingCapacitySizingRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
        

        [Description("works with gas, electric, hot water and steam heating coil.")]
        [JsonProperty(PropertyName="supplemental_heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_SupplementalHeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the supplemental heating coil object.")]
        [JsonProperty(PropertyName="supplemental_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementalHeatingCoilName { get; set; } = "";
        

        [Description("Supply air temperature from the supplemental heater will not exceed this value.")]
        [JsonProperty(PropertyName="maximum_supply_air_temperature_from_supplemental_heater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSupplyAirTemperatureFromSupplementalHeater { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = Double.Parse("21", CultureInfo.InvariantCulture);
        

        [Description(@"Used only for AirloopHVAC equipment on a main branch and defines zone name where thermostat is located. Not required for zone equipment. Leave blank if terminal unit is used in AirLoopHVAC:OutdoorAirSystem:EquipmentList. Required when terminal unit is used on main AirloopHVAC branch and coils are not set point controlled. When terminal unit is used in air loop and is load controlled, this zone's thermostat will control operation.")]
        [JsonProperty(PropertyName="controlling_zone_or_thermostat_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
    }
}