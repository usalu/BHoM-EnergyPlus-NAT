using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("Ventilated slab system where outdoor air flows through hollow cores in a building" +
                 " surface (wall, ceiling, or floor).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_VentilatedSlab : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("(name of zone system is serving)")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("(name of surface system is embedded in) or list of surfaces")]
        [JsonProperty(PropertyName="surface_name_or_radiant_surface_group_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_air_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_VentilatedSlab_OutdoorAirControlType OutdoorAirControlType { get; set; } = (ZoneHVAC_VentilatedSlab_OutdoorAirControlType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_OutdoorAirControlType), "FixedAmount");
        

        [JsonProperty(PropertyName="minimum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [Description("schedule values multiply the minimum outdoor air flow rate")]
        [JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Note that this depends on the control type as to whether schedule values are a fr" +
                     "action or temperature")]
        [JsonProperty(PropertyName="maximum_outdoor_air_fraction_or_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumOutdoorAirFractionOrTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="system_configuration_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_VentilatedSlab_SystemConfigurationType SystemConfigurationType { get; set; } = (ZoneHVAC_VentilatedSlab_SystemConfigurationType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_SystemConfigurationType), "SlabOnly");
        

        [JsonProperty(PropertyName="hollow_core_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HollowCoreInsideDiameter { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("(length of core cavity embedded in surface)")]
        [JsonProperty(PropertyName="hollow_core_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HollowCoreLength { get; set; } = null;
        

        [Description("flow will be divided evenly among the cores")]
        [JsonProperty(PropertyName="number_of_cores", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCores { get; set; } = null;
        

        [Description("(temperature on which unit is controlled)")]
        [JsonProperty(PropertyName="temperature_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_VentilatedSlab_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_VentilatedSlab_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_TemperatureControlType), "OutdoorDryBulbTemperature");
        

        [Description(@"Air and control temperatures for heating work together to provide a linear function that determines the air temperature sent to the radiant system. The current control temperature (see A14) is compared to the high and low control temperatures at the current time. If the control temperature is above the high temperature, then the inlet air temperature is set to the low air temperature. If the control temperature is below the low temperature, then the inlet air temperature is set to the high air temperature. If the control temperature is between the high and low value, then the inlet air temperature is linearly interpolated between the low and high air temperature values.")]
        [JsonProperty(PropertyName="heating_high_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingHighAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_low_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingLowAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_high_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingHighControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_low_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingLowControlTemperatureScheduleName { get; set; } = "";
        

        [Description("See note for heating high air temperature schedule above for interpretation infor" +
                     "mation (or see the Input/Output Reference).")]
        [JsonProperty(PropertyName="cooling_high_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingHighAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_low_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingLowAirTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_high_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingHighControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_low_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingLowControlTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the zone return air inlet to the ventilated slab system outdoor air mixer" +
                     ". This node is typically a zone exhaust node (do not connect to \"Zone Return Air" +
                     " Node\").")]
        [JsonProperty(PropertyName="return_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnAirNodeName { get; set; } = "";
        

        [Description("This is the node entering the slab or series of slabs after the fan and coil(s).")]
        [JsonProperty(PropertyName="slab_in_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SlabInNodeName { get; set; } = "";
        

        [Description("This is the node name exiting the slab. This node is typically a zone inlet node." +
                     " Leave blank when the system configuration is SlabOnly or SeriesSlabs.")]
        [JsonProperty(PropertyName="zone_supply_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneSupplyAirNodeName { get; set; } = "";
        

        [Description("This node is the outdoor air inlet to the ventilated slab oa mixer. This node sho" +
                     "uld also be specified in an OutdoorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty(PropertyName="outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("This node is the relief air node from the ventilated slab outdoor air mixer.")]
        [JsonProperty(PropertyName="relief_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReliefAirNodeName { get; set; } = "";
        

        [Description("This is the node name leaving the outdoor air mixer and entering the fan and coil" +
                     "(s).")]
        [JsonProperty(PropertyName="outdoor_air_mixer_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirMixerOutletNodeName { get; set; } = "";
        

        [Description("This is the node name of the fan outlet.")]
        [JsonProperty(PropertyName="fan_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanOutletNodeName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume")]
        [JsonProperty(PropertyName="fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanName { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_option_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_VentilatedSlab_CoilOptionType CoilOptionType { get; set; } = (ZoneHVAC_VentilatedSlab_CoilOptionType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_CoilOptionType), "Cooling");
        

        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_VentilatedSlab_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_VentilatedSlab_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilName { get; set; } = "";
        

        [JsonProperty(PropertyName="hot_water_or_steam_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotWaterOrSteamInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_VentilatedSlab_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_VentilatedSlab_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_VentilatedSlab_CoolingCoilObjectType), "CoilCoolingWater");
        

        [JsonProperty(PropertyName="cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilName { get; set; } = "";
        

        [JsonProperty(PropertyName="cold_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColdWaterInletNodeName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}