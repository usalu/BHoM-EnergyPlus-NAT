using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: HVAC Design Objects")]
    public class HVACDesignObjects_Objects : BHoMObject
    {
        
        public bool ShouldSerializeDesignSpecification_OutdoorAir_List()
        {
            return (DesignSpecification_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DesignSpecification:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_OutdoorAir> DesignSpecification_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_OutdoorAir> ();
        
        public bool ShouldSerializeDesignSpecification_ZoneAirDistribution_List()
        {
            return (DesignSpecification_ZoneAirDistribution_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DesignSpecification:ZoneAirDistribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneAirDistribution> DesignSpecification_ZoneAirDistribution_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneAirDistribution> ();
        

        [JsonProperty(PropertyName="Sizing:Parameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Parameters Sizing_Parameters { get; set; } = null;
        
        public bool ShouldSerializeSizing_Zone_List()
        {
            return (Sizing_Zone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Sizing:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Zone> Sizing_Zone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Zone> ();
        
        public bool ShouldSerializeDesignSpecification_ZoneHVAC_Sizing_List()
        {
            return (DesignSpecification_ZoneHVAC_Sizing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DesignSpecification:ZoneHVAC:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneHVAC_Sizing> DesignSpecification_ZoneHVAC_Sizing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_ZoneHVAC_Sizing> ();
        
        public bool ShouldSerializeDesignSpecification_AirTerminal_Sizing_List()
        {
            return (DesignSpecification_AirTerminal_Sizing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DesignSpecification:AirTerminal:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_AirTerminal_Sizing> DesignSpecification_AirTerminal_Sizing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.DesignSpecification_AirTerminal_Sizing> ();
        
        public bool ShouldSerializeSizing_System_List()
        {
            return (Sizing_System_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Sizing:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_System> Sizing_System_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_System> ();
        
        public bool ShouldSerializeSizing_Plant_List()
        {
            return (Sizing_Plant_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Sizing:Plant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Plant> Sizing_Plant_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACDesignObjects.Sizing_Plant> ();
        

        [JsonProperty(PropertyName="OutputControl:Sizing:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.HVACDesignObjects.OutputControl_Sizing_Style OutputControl_Sizing_Style { get; set; } = null;
    }
}