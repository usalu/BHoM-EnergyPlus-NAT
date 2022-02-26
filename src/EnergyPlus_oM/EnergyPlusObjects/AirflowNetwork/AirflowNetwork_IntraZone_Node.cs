using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object represents a node in a zone in the combination of RoomAir and Airflow" +
                 "Network model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_IntraZone_Node : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a RoomAir:Node object defined in a RoomAirSettings:AirflowNetwo" +
                     "rk object.")]
        [JsonProperty(PropertyName="roomair_node_airflownetwork_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomairNodeAirflownetworkName { get; set; } = "";
        

        [Description("Enter the name of a zone object defined in a AirflowNetwork:MultiZone:Zone object" +
                     ".")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the reference height used to calculate the relative pressure")]
        [JsonProperty(PropertyName="node_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NodeHeight { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}