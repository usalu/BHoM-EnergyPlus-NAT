using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_SystemModel_SpeedFractions_Item
    {
        

        [JsonProperty(PropertyName="speed_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpeedFlowFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_electric_power_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpeedElectricPowerFraction { get; set; } = null;
    }
}