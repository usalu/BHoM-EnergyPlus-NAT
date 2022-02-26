using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CondenserEquipmentList_Equipment_Item
    {
        

        [JsonProperty(PropertyName="equipment_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EquipmentObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EquipmentName { get; set; } = "";
    }
}