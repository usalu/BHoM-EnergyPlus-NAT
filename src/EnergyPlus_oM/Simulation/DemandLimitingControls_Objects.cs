using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Demand Limiting Controls")]
    public class DemandLimitingControls_Objects : BHoMObject
    {
        
        public bool ShouldSerializeDemandManagerAssignmentList_List()
        {
            return (DemandManagerAssignmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DemandManagerAssignmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManagerAssignmentList> DemandManagerAssignmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManagerAssignmentList> ();
        
        public bool ShouldSerializeDemandManager_ExteriorLights_List()
        {
            return (DemandManager_ExteriorLights_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DemandManager:ExteriorLights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ExteriorLights> DemandManager_ExteriorLights_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ExteriorLights> ();
        
        public bool ShouldSerializeDemandManager_Lights_List()
        {
            return (DemandManager_Lights_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DemandManager:Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Lights> DemandManager_Lights_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Lights> ();
        
        public bool ShouldSerializeDemandManager_ElectricEquipment_List()
        {
            return (DemandManager_ElectricEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DemandManager:ElectricEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ElectricEquipment> DemandManager_ElectricEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_ElectricEquipment> ();
        
        public bool ShouldSerializeDemandManager_Thermostats_List()
        {
            return (DemandManager_Thermostats_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DemandManager:Thermostats", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Thermostats> DemandManager_Thermostats_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Thermostats> ();
        
        public bool ShouldSerializeDemandManager_Ventilation_List()
        {
            return (DemandManager_Ventilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DemandManager:Ventilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Ventilation> DemandManager_Ventilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DemandLimitingControls.DemandManager_Ventilation> ();
    }
}