using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("RoomAir modeling using Airflow pressure network solver")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_AirflowNetwork : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of Zone being described. Any existing zone name")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_point_roomairflownetwork_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlPointRoomairflownetworkNodeName { get; set; } = "";
        

        [Description("This list is the RoomAirflowNetworkNodes object-list")]
        [JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Nodes { get; set; } = null;
    }
}