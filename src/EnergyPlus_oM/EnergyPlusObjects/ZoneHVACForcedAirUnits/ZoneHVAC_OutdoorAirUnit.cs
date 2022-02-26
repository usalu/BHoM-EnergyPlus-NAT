using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("The zone outdoor air unit models a single-zone dedicated outdoor air system (DOAS" +
                 "). Forced-convection 100% outdoor air unit with supply fan and optional equipmen" +
                 "t including exhaust fan, heating coil, cooling coil, and heat recovery.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_OutdoorAirUnit : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty(PropertyName="outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> OutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirScheduleName { get; set; } = "";
        

        [Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume and Fan:VariableVo" +
                     "lume")]
        [JsonProperty(PropertyName="supply_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_SupplyFanPlacement SupplyFanPlacement { get; set; } = (ZoneHVAC_OutdoorAirUnit_SupplyFanPlacement)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_SupplyFanPlacement), "DrawThrough");
        

        [Description("Allowable fan types are Fan:SystemModel and Fan:ConstantVolume and Fan:VariableVo" +
                     "lume Fan:VariableVolume")]
        [JsonProperty(PropertyName="exhaust_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="exhaust_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ExhaustAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="exhaust_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="unit_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_OutdoorAirUnit_UnitControlType UnitControlType { get; set; } = (ZoneHVAC_OutdoorAirUnit_UnitControlType)Enum.Parse(typeof(ZoneHVAC_OutdoorAirUnit_UnitControlType), "NeutralControl");
        

        [Description(@"Air and control temperatures for cooling. If outdoor air temperature is above the high air control temperature, then the zone inlet air temperature is set to the high air control temperature. If the outdoor air is between high and low air control temperature, then there is no cooling/heating requirements.")]
        [JsonProperty(PropertyName="high_air_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HighAirControlTemperatureScheduleName { get; set; } = "";
        

        [Description(@"Air and control temperatures for Heating. If outdoor air temperature is below the low air control temperature, then the zone inlet air temperature is set to the low air control temperature. If the outdoor air is between high and low air control temperature, then there is no cooling/heating requirements.")]
        [JsonProperty(PropertyName="low_air_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LowAirControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="airoutlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AiroutletNodeName { get; set; } = "";
        

        [Description("air leaves zone")]
        [JsonProperty(PropertyName="airinlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirinletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fanoutlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanoutletNodeName { get; set; } = "";
        

        [Description("Enter the name of an ZoneHVAC:OutdoorAirUnit:EquipmentList object.")]
        [JsonProperty(PropertyName="outdoor_air_unit_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirUnitListName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
    }
}