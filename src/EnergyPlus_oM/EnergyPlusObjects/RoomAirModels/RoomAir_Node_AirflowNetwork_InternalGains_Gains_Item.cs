using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_InternalGains_Gains_Item
    {
        

        [JsonProperty(PropertyName="internal_gain_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalGainObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="internal_gain_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalGainObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_gains_to_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfGainsToNode { get; set; } = null;
    }
}