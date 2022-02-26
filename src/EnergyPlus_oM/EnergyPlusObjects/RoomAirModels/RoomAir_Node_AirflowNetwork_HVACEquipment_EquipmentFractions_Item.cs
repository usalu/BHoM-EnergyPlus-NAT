using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node_AirflowNetwork_HVACEquipment_EquipmentFractions_Item
    {
        

        [JsonProperty(PropertyName="zonehvac_or_air_terminal_equipment_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZonehvacOrAirTerminalEquipmentObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="zonehvac_or_air_terminal_equipment_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZonehvacOrAirTerminalEquipmentObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_output_or_supply_air_from_hvac_equipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfOutputOrSupplyAirFromHvacEquipment { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_of_input_or_return_air_to_hvac_equipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfInputOrReturnAirToHvacEquipment { get; set; } = null;
    }
}