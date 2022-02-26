using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Fans")]
    public class Fans_Objects : BHoMObject
    {
        
        public bool ShouldSerializeFan_SystemModel_List()
        {
            return (Fan_SystemModel_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Fan:SystemModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_SystemModel> Fan_SystemModel_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_SystemModel> ();
        
        public bool ShouldSerializeFan_ConstantVolume_List()
        {
            return (Fan_ConstantVolume_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Fan:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ConstantVolume> Fan_ConstantVolume_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ConstantVolume> ();
        
        public bool ShouldSerializeFan_VariableVolume_List()
        {
            return (Fan_VariableVolume_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Fan:VariableVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_VariableVolume> Fan_VariableVolume_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_VariableVolume> ();
        
        public bool ShouldSerializeFan_OnOff_List()
        {
            return (Fan_OnOff_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Fan:OnOff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_OnOff> Fan_OnOff_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_OnOff> ();
        
        public bool ShouldSerializeFan_ZoneExhaust_List()
        {
            return (Fan_ZoneExhaust_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Fan:ZoneExhaust", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ZoneExhaust> Fan_ZoneExhaust_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ZoneExhaust> ();
        
        public bool ShouldSerializeFanPerformance_NightVentilation_List()
        {
            return (FanPerformance_NightVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FanPerformance:NightVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.FanPerformance_NightVentilation> FanPerformance_NightVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.FanPerformance_NightVentilation> ();
        
        public bool ShouldSerializeFan_ComponentModel_List()
        {
            return (Fan_ComponentModel_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Fan:ComponentModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ComponentModel> Fan_ComponentModel_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Fans.Fan_ComponentModel> ();
    }
}