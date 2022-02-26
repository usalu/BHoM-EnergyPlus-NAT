using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Unit heater. Forced-convection heating-only unit with supply fan, heating coil (g" +
                 "as, electric, hot water, or steam) and fixed-position outdoor air mixer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_UnitHeater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:ConstantVolume, Fan:OnOff, Fan:VariableVolume and Fan" +
                     ":SystemModel")]
        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitHeater_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_UnitHeater_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_UnitHeater_SupplyAirFanObjectType), "FanConstantVolume");
        

        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitHeater_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_UnitHeater_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_UnitHeater_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilName { get; set; } = "";
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule name values of 0 denote cycling fan operation (fan cycles with the heating coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this input field is left blank.")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description(@"This choice field allows the user to define how the unit heater will operate under ""no heating load"" or cooling conditions. If the ""No"" is selected, then the fan will not run unless there is a heating load. If the fan does not run, this effectively shuts the unit heater system off when there is no heating load. If the ""Yes"" is selected, the unit heater is available and has a ConstantVolume fan, or has an OnOff fan with ""Supply Air Fan Operating Mode Schedule"" value greater than zero, then the fan will always run regardless of the zone load.")]
        [JsonProperty(PropertyName="supply_air_fan_operation_during_no_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating SupplyAirFanOperationDuringNoHeating { get; set; } = (ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating)Enum.Parse(typeof(ZoneHVAC_UnitHeater_SupplyAirFanOperationDuringNoHeating), "No");
        

        [Description("Not used when heating coil is gas or electric")]
        [JsonProperty(PropertyName="maximum_hot_water_or_steam_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumHotWaterOrSteamFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Not used when heating coil is gas or electric")]
        [JsonProperty(PropertyName="minimum_hot_water_or_steam_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumHotWaterOrSteamFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_convergence_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingConvergenceTolerance { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}