using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager detects the control zone load, zone inlet node flow rate, and zone node temperature and calculates a setpoint temperature for the supply air that will satisfy the zone load (heating or cooling) for the control zone. This setpoint manager is not limited to reheat applications.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_SingleZone_Reheat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_SingleZone_Reheat_ControlVariable ControlVariable { get; set; } = (SetpointManager_SingleZone_Reheat_ControlVariable)Enum.Parse(typeof(SetpointManager_SingleZone_Reheat_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="minimum_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSupplyAirTemperature { get; set; } = Double.Parse("-99", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSupplyAirTemperature { get; set; } = Double.Parse("99", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneInletNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}