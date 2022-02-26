using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollector_UnglazedTranspired_Multisystem_Systems_Item
    {
        

        [JsonProperty(PropertyName="outdoor_air_system_collector_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirSystemCollectorInletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="outdoor_air_system_collector_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirSystemCollectorOutletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="outdoor_air_system_mixed_air_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirSystemMixedAirNode { get; set; } = "";
        

        [JsonProperty(PropertyName="outdoor_air_system_zone_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirSystemZoneNode { get; set; } = "";
    }
}