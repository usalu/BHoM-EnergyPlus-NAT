using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Zone evaporative cooler. Forced-convection cooling-only unit with supply fan, 100" +
                 "% outdoor air supply. Optional relief exhaust node")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_EvaporativeCoolerUnit : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("this is an outdoor air node")]
        [JsonProperty(PropertyName="outdoor_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [Description("this is a zone inlet node")]
        [JsonProperty(PropertyName="cooler_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolerOutletNodeName { get; set; } = "";
        

        [Description("this is a zone exhaust node, optional if flow is being balanced elsewhere")]
        [JsonProperty(PropertyName="zone_relief_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneReliefAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_SupplyAirFanObjectType), "FanComponentModel");
        

        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_FanPlacement)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_FanPlacement), "BlowThrough");
        

        [JsonProperty(PropertyName="cooler_unit_control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod CoolerUnitControlMethod { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_CoolerUnitControlMethod), "ZoneCoolingLoadOnOffCycling");
        

        [Description("used for ZoneTemperatureDeadbandOnOffCycling hystersis range for thermostatic con" +
                     "trol")]
        [JsonProperty(PropertyName="throttling_range_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThrottlingRangeTemperatureDifference { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Sign convention is that positive values indicate a cooling load")]
        [JsonProperty(PropertyName="cooling_load_control_threshold_heat_transfer_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingLoadControlThresholdHeatTransferRate { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="first_evaporative_cooler_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType FirstEvaporativeCoolerObjectType { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_FirstEvaporativeCoolerObjectType), "EvaporativeCoolerDirectCelDekPad");
        

        [JsonProperty(PropertyName="first_evaporative_cooler_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstEvaporativeCoolerObjectName { get; set; } = "";
        

        [Description("optional, used for direct/indirect configurations second cooler must be immediate" +
                     "ly downstream of first cooler, if present")]
        [JsonProperty(PropertyName="second_evaporative_cooler_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EvaporativeCoolerUnit_SecondEvaporativeCoolerObjectType SecondEvaporativeCoolerObjectType { get; set; } = (ZoneHVAC_EvaporativeCoolerUnit_SecondEvaporativeCoolerObjectType)Enum.Parse(typeof(ZoneHVAC_EvaporativeCoolerUnit_SecondEvaporativeCoolerObjectType), "EvaporativeCoolerDirectCelDekPad");
        

        [Description("optional, used for direct/indirect configurations")]
        [JsonProperty(PropertyName="second_evaporative_cooler_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondEvaporativeCoolerName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}