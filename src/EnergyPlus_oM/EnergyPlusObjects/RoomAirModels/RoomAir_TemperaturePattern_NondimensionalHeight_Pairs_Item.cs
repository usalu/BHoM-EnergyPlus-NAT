using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_NondimensionalHeight_Pairs_Item
    {
        

        [JsonProperty(PropertyName="pair_zeta_nondimensional_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PairZetaNondimensionalHeight { get; set; } = null;
        

        [JsonProperty(PropertyName="pair_delta_adjacent_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PairDeltaAdjacentAirTemperature { get; set; } = null;
    }
}