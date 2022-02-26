using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: User Defined HVAC and Plant Component" +
                 " Models")]
    public class UserDefinedHVACandPlantComponentModels_Objects : BHoMObject
    {
        
        public bool ShouldSerializeZoneHVAC_ForcedAir_UserDefined_List()
        {
            return (ZoneHVAC_ForcedAir_UserDefined_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:ForcedAir:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.ZoneHVAC_ForcedAir_UserDefined> ZoneHVAC_ForcedAir_UserDefined_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.ZoneHVAC_ForcedAir_UserDefined> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_UserDefined_List()
        {
            return (AirTerminal_SingleDuct_UserDefined_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.AirTerminal_SingleDuct_UserDefined> AirTerminal_SingleDuct_UserDefined_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.AirTerminal_SingleDuct_UserDefined> ();
        
        public bool ShouldSerializeCoil_UserDefined_List()
        {
            return (Coil_UserDefined_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.Coil_UserDefined> Coil_UserDefined_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.Coil_UserDefined> ();
        
        public bool ShouldSerializePlantComponent_UserDefined_List()
        {
            return (PlantComponent_UserDefined_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantComponent:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantComponent_UserDefined> PlantComponent_UserDefined_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantComponent_UserDefined> ();
        
        public bool ShouldSerializePlantEquipmentOperation_UserDefined_List()
        {
            return (PlantEquipmentOperation_UserDefined_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantEquipmentOperation_UserDefined> PlantEquipmentOperation_UserDefined_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels.PlantEquipmentOperation_UserDefined> ();
    }
}