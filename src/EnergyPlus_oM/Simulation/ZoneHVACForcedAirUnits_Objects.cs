using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Zone HVAC Forced Air Units")]
    public class ZoneHVACForcedAirUnits_Objects : BHoMObject
    {
        
        public bool ShouldSerializeZoneHVAC_IdealLoadsAirSystem_List()
        {
            return (ZoneHVAC_IdealLoadsAirSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:IdealLoadsAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_IdealLoadsAirSystem> ZoneHVAC_IdealLoadsAirSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_IdealLoadsAirSystem> ();
        
        public bool ShouldSerializeZoneHVAC_FourPipeFanCoil_List()
        {
            return (ZoneHVAC_FourPipeFanCoil_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:FourPipeFanCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_FourPipeFanCoil> ZoneHVAC_FourPipeFanCoil_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_FourPipeFanCoil> ();
        
        public bool ShouldSerializeZoneHVAC_WindowAirConditioner_List()
        {
            return (ZoneHVAC_WindowAirConditioner_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:WindowAirConditioner", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WindowAirConditioner> ZoneHVAC_WindowAirConditioner_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WindowAirConditioner> ();
        
        public bool ShouldSerializeZoneHVAC_PackagedTerminalAirConditioner_List()
        {
            return (ZoneHVAC_PackagedTerminalAirConditioner_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:PackagedTerminalAirConditioner", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalAirConditioner> ZoneHVAC_PackagedTerminalAirConditioner_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalAirConditioner> ();
        
        public bool ShouldSerializeZoneHVAC_PackagedTerminalHeatPump_List()
        {
            return (ZoneHVAC_PackagedTerminalHeatPump_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:PackagedTerminalHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalHeatPump> ZoneHVAC_PackagedTerminalHeatPump_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_PackagedTerminalHeatPump> ();
        
        public bool ShouldSerializeZoneHVAC_WaterToAirHeatPump_List()
        {
            return (ZoneHVAC_WaterToAirHeatPump_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:WaterToAirHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WaterToAirHeatPump> ZoneHVAC_WaterToAirHeatPump_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_WaterToAirHeatPump> ();
        
        public bool ShouldSerializeZoneHVAC_Dehumidifier_DX_List()
        {
            return (ZoneHVAC_Dehumidifier_DX_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Dehumidifier:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_Dehumidifier_DX> ZoneHVAC_Dehumidifier_DX_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_Dehumidifier_DX> ();
        
        public bool ShouldSerializeZoneHVAC_EnergyRecoveryVentilator_List()
        {
            return (ZoneHVAC_EnergyRecoveryVentilator_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:EnergyRecoveryVentilator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator> ZoneHVAC_EnergyRecoveryVentilator_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator> ();
        
        public bool ShouldSerializeZoneHVAC_EnergyRecoveryVentilator_Controller_List()
        {
            return (ZoneHVAC_EnergyRecoveryVentilator_Controller_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:EnergyRecoveryVentilator:Controller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator_Controller> ZoneHVAC_EnergyRecoveryVentilator_Controller_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EnergyRecoveryVentilator_Controller> ();
        
        public bool ShouldSerializeZoneHVAC_UnitVentilator_List()
        {
            return (ZoneHVAC_UnitVentilator_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:UnitVentilator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitVentilator> ZoneHVAC_UnitVentilator_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitVentilator> ();
        
        public bool ShouldSerializeZoneHVAC_UnitHeater_List()
        {
            return (ZoneHVAC_UnitHeater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:UnitHeater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitHeater> ZoneHVAC_UnitHeater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_UnitHeater> ();
        
        public bool ShouldSerializeZoneHVAC_EvaporativeCoolerUnit_List()
        {
            return (ZoneHVAC_EvaporativeCoolerUnit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:EvaporativeCoolerUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EvaporativeCoolerUnit> ZoneHVAC_EvaporativeCoolerUnit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_EvaporativeCoolerUnit> ();
        
        public bool ShouldSerializeZoneHVAC_HybridUnitaryHVAC_List()
        {
            return (ZoneHVAC_HybridUnitaryHVAC_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:HybridUnitaryHVAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_HybridUnitaryHVAC> ZoneHVAC_HybridUnitaryHVAC_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_HybridUnitaryHVAC> ();
        
        public bool ShouldSerializeZoneHVAC_OutdoorAirUnit_List()
        {
            return (ZoneHVAC_OutdoorAirUnit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:OutdoorAirUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit> ZoneHVAC_OutdoorAirUnit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit> ();
        
        public bool ShouldSerializeZoneHVAC_OutdoorAirUnit_EquipmentList_List()
        {
            return (ZoneHVAC_OutdoorAirUnit_EquipmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:OutdoorAirUnit:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit_EquipmentList> ZoneHVAC_OutdoorAirUnit_EquipmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_OutdoorAirUnit_EquipmentList> ();
        
        public bool ShouldSerializeZoneHVAC_TerminalUnit_VariableRefrigerantFlow_List()
        {
            return (ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:TerminalUnit:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_TerminalUnit_VariableRefrigerantFlow> ZoneHVAC_TerminalUnit_VariableRefrigerantFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_TerminalUnit_VariableRefrigerantFlow> ();
    }
}