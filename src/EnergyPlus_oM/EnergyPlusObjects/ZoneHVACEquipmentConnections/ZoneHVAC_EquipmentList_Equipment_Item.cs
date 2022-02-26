using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_EquipmentList_Equipment_Item
    {
        

        [JsonProperty(PropertyName="zone_equipment_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneEquipmentObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_equipment_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneEquipmentName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_equipment_cooling_sequence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneEquipmentCoolingSequence { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_equipment_heating_or_no_load_sequence", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneEquipmentHeatingOrNoLoadSequence { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_equipment_sequential_cooling_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneEquipmentSequentialCoolingFractionScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_equipment_sequential_heating_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneEquipmentSequentialHeatingFractionScheduleName { get; set; } = "";
    }
}