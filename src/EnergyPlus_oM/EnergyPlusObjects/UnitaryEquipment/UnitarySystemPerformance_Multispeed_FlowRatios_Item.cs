using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UnitarySystemPerformance_Multispeed_FlowRatios_Item
    {
        

        [JsonProperty(PropertyName="heating_speed_supply_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingSpeedSupplyAirFlowRatio { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_speed_supply_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingSpeedSupplyAirFlowRatio { get; set; } = "";
    }
}