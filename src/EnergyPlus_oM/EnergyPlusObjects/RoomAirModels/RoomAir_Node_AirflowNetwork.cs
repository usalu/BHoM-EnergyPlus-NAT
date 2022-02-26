using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("define an air node for some types of nodal air models")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_zone_air_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfZoneAirVolume { get; set; } = null;
        

        [JsonProperty(PropertyName="roomair_node_airflownetwork_adjacentsurfacelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomairNodeAirflownetworkAdjacentsurfacelistName { get; set; } = "";
        

        [JsonProperty(PropertyName="roomair_node_airflownetwork_internalgains_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomairNodeAirflownetworkInternalgainsName { get; set; } = "";
        

        [JsonProperty(PropertyName="roomair_node_airflownetwork_hvacequipment_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomairNodeAirflownetworkHvacequipmentName { get; set; } = "";
    }
}