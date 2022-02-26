using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Zone Airflow")]
    public class ZoneAirflow_Objects : BHoMObject
    {
        
        public bool ShouldSerializeZoneInfiltration_DesignFlowRate_List()
        {
            return (ZoneInfiltration_DesignFlowRate_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneInfiltration:DesignFlowRate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_DesignFlowRate> ZoneInfiltration_DesignFlowRate_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_DesignFlowRate> ();
        
        public bool ShouldSerializeZoneInfiltration_EffectiveLeakageArea_List()
        {
            return (ZoneInfiltration_EffectiveLeakageArea_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneInfiltration:EffectiveLeakageArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_EffectiveLeakageArea> ZoneInfiltration_EffectiveLeakageArea_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_EffectiveLeakageArea> ();
        
        public bool ShouldSerializeZoneInfiltration_FlowCoefficient_List()
        {
            return (ZoneInfiltration_FlowCoefficient_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneInfiltration:FlowCoefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_FlowCoefficient> ZoneInfiltration_FlowCoefficient_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneInfiltration_FlowCoefficient> ();
        
        public bool ShouldSerializeZoneVentilation_DesignFlowRate_List()
        {
            return (ZoneVentilation_DesignFlowRate_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneVentilation:DesignFlowRate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_DesignFlowRate> ZoneVentilation_DesignFlowRate_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_DesignFlowRate> ();
        
        public bool ShouldSerializeZoneVentilation_WindandStackOpenArea_List()
        {
            return (ZoneVentilation_WindandStackOpenArea_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneVentilation:WindandStackOpenArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_WindandStackOpenArea> ZoneVentilation_WindandStackOpenArea_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneVentilation_WindandStackOpenArea> ();
        
        public bool ShouldSerializeZoneAirBalance_OutdoorAir_List()
        {
            return (ZoneAirBalance_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneAirBalance:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneAirBalance_OutdoorAir> ZoneAirBalance_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneAirBalance_OutdoorAir> ();
        
        public bool ShouldSerializeZoneMixing_List()
        {
            return (ZoneMixing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneMixing> ZoneMixing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneMixing> ();
        
        public bool ShouldSerializeZoneCrossMixing_List()
        {
            return (ZoneCrossMixing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneCrossMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCrossMixing> ZoneCrossMixing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCrossMixing> ();
        
        public bool ShouldSerializeZoneRefrigerationDoorMixing_List()
        {
            return (ZoneRefrigerationDoorMixing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneRefrigerationDoorMixing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneRefrigerationDoorMixing> ZoneRefrigerationDoorMixing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneRefrigerationDoorMixing> ();
        
        public bool ShouldSerializeZoneEarthtube_List()
        {
            return (ZoneEarthtube_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneEarthtube", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneEarthtube> ZoneEarthtube_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneEarthtube> ();
        
        public bool ShouldSerializeZoneCoolTower_Shower_List()
        {
            return (ZoneCoolTower_Shower_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneCoolTower:Shower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCoolTower_Shower> ZoneCoolTower_Shower_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneCoolTower_Shower> ();
        
        public bool ShouldSerializeZoneThermalChimney_List()
        {
            return (ZoneThermalChimney_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneThermalChimney", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneThermalChimney> ZoneThermalChimney_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneAirflow.ZoneThermalChimney> ();
    }
}