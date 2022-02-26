using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Unit ventilator. Forced-convection ventilation unit with supply fan (constant-vol" +
                 "ume or variable-volume), optional chilled water cooling coil, optional heating c" +
                 "oil (gas, electric, hot water, or steam) and controllable outdoor air mixer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_UnitVentilator : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_air_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_OutdoorAirControlType OutdoorAirControlType { get; set; } = (ZoneHVAC_UnitVentilator_OutdoorAirControlType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_OutdoorAirControlType), "FixedAmount");
        

        [JsonProperty(PropertyName="minimum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("schedule values multiply the minimum outdoor air flow rate")]
        [JsonProperty(PropertyName="minimum_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("that this depends on the control type as to whether it is a fraction or temperatu" +
                     "re")]
        [JsonProperty(PropertyName="maximum_outdoor_air_fraction_or_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = "";
        

        [Description("Inlet node name must be zone exhaust node name if there is no DOA Mixer, or if th" +
                     "e unit ventilator is connected DOA, then the air inlet node name must be the mix" +
                     "er outlet air node name for InletSide mixer connection.")]
        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Outlet node name must be zone inlet node name if there is no DOA Mixer, or if the" +
                     " unit ventilator is connected DOA, then the air outlet node name must be the mix" +
                     "er secondary air inlet node name for SupplySide mixer connection.")]
        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("this field is left blank only if the Unit Ventilator is connected to a central de" +
                     "dicated outdoor air (DOA) via AirTerminal:SingleDuct:Mixer object")]
        [JsonProperty(PropertyName="outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("this field is left blank only if the Unit Ventilator is connected to a central de" +
                     "dicated outdoor air (DOA) via AirTerminal:SingleDuct:Mixer object")]
        [JsonProperty(PropertyName="exhaust_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirNodeName { get; set; } = "";
        

        [Description("inlet to coils this field is left blank only if the Unit Ventilator is connected " +
                     "to a central dedicated outdoor air (DOA) via AirTerminal:SingleDuct:Mixer object" +
                     "")]
        [JsonProperty(PropertyName="mixed_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedAirNodeName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:ConstantVolume, Fan:OnOff, Fan:VariableVolume, and Fa" +
                     "n:SystemModel")]
        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_UnitVentilator_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_SupplyAirFanObjectType), "FanConstantVolume");
        

        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_option", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_CoilOption CoilOption { get; set; } = (ZoneHVAC_UnitVentilator_CoilOption)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_CoilOption), "Cooling");
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule name values of 0 denote cycling fan operation (fan cycles with cooling/heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this input field is left blank.")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_UnitVentilator_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_convergence_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingConvergenceTolerance { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitVentilator_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_UnitVentilator_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_UnitVentilator_CoolingCoilObjectType), "CoilCoolingWater");
        

        [JsonProperty(PropertyName="cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_convergence_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingConvergenceTolerance { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}