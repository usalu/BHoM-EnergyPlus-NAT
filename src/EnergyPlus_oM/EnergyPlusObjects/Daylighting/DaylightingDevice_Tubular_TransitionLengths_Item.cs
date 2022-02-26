using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_Tubular_TransitionLengths_Item
    {
        

        [JsonProperty(PropertyName="transition_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransitionZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="transition_zone_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TransitionZoneLength { get; set; } = null;
    }
}