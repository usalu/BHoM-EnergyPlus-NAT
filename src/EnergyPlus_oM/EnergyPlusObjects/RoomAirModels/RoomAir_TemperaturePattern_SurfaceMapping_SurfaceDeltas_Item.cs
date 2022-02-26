using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_TemperaturePattern_SurfaceMapping_SurfaceDeltas_Item
    {
        

        [JsonProperty(PropertyName="surface_name_pair", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceNamePair { get; set; } = "";
        

        [JsonProperty(PropertyName="delta_adjacent_air_temperature_pair", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeltaAdjacentAirTemperaturePair { get; set; } = null;
    }
}