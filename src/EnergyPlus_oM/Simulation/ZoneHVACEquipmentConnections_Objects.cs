using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Zone HVAC Equipment Connections")]
    public class ZoneHVACEquipmentConnections_Objects : BHoMObject
    {
        
        public bool ShouldSerializeZoneHVAC_EquipmentList_List()
        {
            return (ZoneHVAC_EquipmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentList> ZoneHVAC_EquipmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentList> ();
        
        public bool ShouldSerializeZoneHVAC_EquipmentConnections_List()
        {
            return (ZoneHVAC_EquipmentConnections_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:EquipmentConnections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentConnections> ZoneHVAC_EquipmentConnections_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections.ZoneHVAC_EquipmentConnections> ();
    }
}