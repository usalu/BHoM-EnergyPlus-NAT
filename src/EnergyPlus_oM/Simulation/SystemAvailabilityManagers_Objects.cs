using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: System Availability Managers")]
    public class SystemAvailabilityManagers_Objects : BHoMObject
    {
        
        public bool ShouldSerializeAvailabilityManager_Scheduled_List()
        {
            return (AvailabilityManager_Scheduled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:Scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_Scheduled> AvailabilityManager_Scheduled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_Scheduled> ();
        
        public bool ShouldSerializeAvailabilityManager_ScheduledOn_List()
        {
            return (AvailabilityManager_ScheduledOn_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:ScheduledOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOn> AvailabilityManager_ScheduledOn_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOn> ();
        
        public bool ShouldSerializeAvailabilityManager_ScheduledOff_List()
        {
            return (AvailabilityManager_ScheduledOff_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:ScheduledOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOff> AvailabilityManager_ScheduledOff_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_ScheduledOff> ();
        
        public bool ShouldSerializeAvailabilityManager_OptimumStart_List()
        {
            return (AvailabilityManager_OptimumStart_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:OptimumStart", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_OptimumStart> AvailabilityManager_OptimumStart_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_OptimumStart> ();
        
        public bool ShouldSerializeAvailabilityManager_NightCycle_List()
        {
            return (AvailabilityManager_NightCycle_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:NightCycle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightCycle> AvailabilityManager_NightCycle_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightCycle> ();
        
        public bool ShouldSerializeAvailabilityManager_DifferentialThermostat_List()
        {
            return (AvailabilityManager_DifferentialThermostat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:DifferentialThermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_DifferentialThermostat> AvailabilityManager_DifferentialThermostat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_DifferentialThermostat> ();
        
        public bool ShouldSerializeAvailabilityManager_HighTemperatureTurnOff_List()
        {
            return (AvailabilityManager_HighTemperatureTurnOff_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:HighTemperatureTurnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOff> AvailabilityManager_HighTemperatureTurnOff_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOff> ();
        
        public bool ShouldSerializeAvailabilityManager_HighTemperatureTurnOn_List()
        {
            return (AvailabilityManager_HighTemperatureTurnOn_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:HighTemperatureTurnOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOn> AvailabilityManager_HighTemperatureTurnOn_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HighTemperatureTurnOn> ();
        
        public bool ShouldSerializeAvailabilityManager_LowTemperatureTurnOff_List()
        {
            return (AvailabilityManager_LowTemperatureTurnOff_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:LowTemperatureTurnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOff> AvailabilityManager_LowTemperatureTurnOff_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOff> ();
        
        public bool ShouldSerializeAvailabilityManager_LowTemperatureTurnOn_List()
        {
            return (AvailabilityManager_LowTemperatureTurnOn_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:LowTemperatureTurnOn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOn> AvailabilityManager_LowTemperatureTurnOn_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_LowTemperatureTurnOn> ();
        
        public bool ShouldSerializeAvailabilityManager_NightVentilation_List()
        {
            return (AvailabilityManager_NightVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:NightVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightVentilation> AvailabilityManager_NightVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_NightVentilation> ();
        
        public bool ShouldSerializeAvailabilityManager_HybridVentilation_List()
        {
            return (AvailabilityManager_HybridVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManager:HybridVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HybridVentilation> AvailabilityManager_HybridVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManager_HybridVentilation> ();
        
        public bool ShouldSerializeAvailabilityManagerAssignmentList_List()
        {
            return (AvailabilityManagerAssignmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AvailabilityManagerAssignmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManagerAssignmentList> AvailabilityManagerAssignmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers.AvailabilityManagerAssignmentList> ();
    }
}