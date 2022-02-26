using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("The Single Zone Maximum Humidity Setpoint Manager allows the control of a single " +
                 "zone maximum humidity level. This setpoint manager can be used in conjunction wi" +
                 "th object ZoneControl:Humidistat to detect humidity levels.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_SingleZone_Humidity_Maximum : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Node(s) at which humidity ratio setpoint will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Name of the zone air node for the humidity control zone")]
        [JsonProperty(PropertyName="control_zone_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneAirNodeName { get; set; } = "";
    }
}