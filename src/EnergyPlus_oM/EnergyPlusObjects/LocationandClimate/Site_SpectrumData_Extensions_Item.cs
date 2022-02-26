using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_SpectrumData_Extensions_Item
    {
        

        [JsonProperty(PropertyName="wavelength", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength { get; set; } = null;
        

        [JsonProperty(PropertyName="spectrum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Spectrum { get; set; } = null;
    }
}