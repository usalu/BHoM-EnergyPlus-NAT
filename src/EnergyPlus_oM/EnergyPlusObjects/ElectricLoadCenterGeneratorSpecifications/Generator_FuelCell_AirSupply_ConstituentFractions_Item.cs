using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_AirSupply_ConstituentFractions_Item
    {
        

        [JsonProperty(PropertyName="constituent_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstituentName { get; set; } = "";
        

        [JsonProperty(PropertyName="molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MolarFraction { get; set; } = null;
    }
}