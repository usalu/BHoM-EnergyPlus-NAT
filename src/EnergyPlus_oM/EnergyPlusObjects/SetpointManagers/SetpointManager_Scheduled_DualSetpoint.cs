using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager places a high and low schedule value on one or more nodes.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_Scheduled_DualSetpoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_Scheduled_DualSetpoint_ControlVariable ControlVariable { get; set; } = (SetpointManager_Scheduled_DualSetpoint_ControlVariable)Enum.Parse(typeof(SetpointManager_Scheduled_DualSetpoint_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="high_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HighSetpointScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="low_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LowSetpointScheduleName { get; set; } = "";
        

        [Description("Node(s) at which temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}