using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager is used to place a temperature setpoint on a system node that is derived from the current temperatures at a separate system node. The current value of the temperature at a reference node is obtained and used to generate setpoint on a second system node. If the reference node is also designated to be an outdoor air (intake) node, then this setpoint manager can be used to follow outdoor air conditions that are adjusted for altitude.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_FollowSystemNodeTemperature : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_FollowSystemNodeTemperature_ControlVariable ControlVariable { get; set; } = (SetpointManager_FollowSystemNodeTemperature_ControlVariable)Enum.Parse(typeof(SetpointManager_FollowSystemNodeTemperature_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="reference_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReferenceNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_temperature_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType ReferenceTemperatureType { get; set; } = (SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType)Enum.Parse(typeof(SetpointManager_FollowSystemNodeTemperature_ReferenceTemperatureType), "NodeDryBulb");
        

        [JsonProperty(PropertyName="offset_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffsetTemperatureDifference { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_limit_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumLimitSetpointTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_limit_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumLimitSetpointTemperature { get; set; } = null;
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}