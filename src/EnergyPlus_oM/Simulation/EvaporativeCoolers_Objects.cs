using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Evaporative Coolers")]
    public class EvaporativeCoolers_Objects : BHoMObject
    {
        
        public bool ShouldSerializeEvaporativeCooler_Direct_CelDekPad_List()
        {
            return (EvaporativeCooler_Direct_CelDekPad_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeCooler:Direct:CelDekPad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_CelDekPad> EvaporativeCooler_Direct_CelDekPad_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_CelDekPad> ();
        
        public bool ShouldSerializeEvaporativeCooler_Indirect_CelDekPad_List()
        {
            return (EvaporativeCooler_Indirect_CelDekPad_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeCooler:Indirect:CelDekPad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_CelDekPad> EvaporativeCooler_Indirect_CelDekPad_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_CelDekPad> ();
        
        public bool ShouldSerializeEvaporativeCooler_Indirect_WetCoil_List()
        {
            return (EvaporativeCooler_Indirect_WetCoil_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeCooler:Indirect:WetCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_WetCoil> EvaporativeCooler_Indirect_WetCoil_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_WetCoil> ();
        
        public bool ShouldSerializeEvaporativeCooler_Indirect_ResearchSpecial_List()
        {
            return (EvaporativeCooler_Indirect_ResearchSpecial_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeCooler:Indirect:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_ResearchSpecial> EvaporativeCooler_Indirect_ResearchSpecial_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Indirect_ResearchSpecial> ();
        
        public bool ShouldSerializeEvaporativeCooler_Direct_ResearchSpecial_List()
        {
            return (EvaporativeCooler_Direct_ResearchSpecial_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeCooler:Direct:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_ResearchSpecial> EvaporativeCooler_Direct_ResearchSpecial_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EvaporativeCoolers.EvaporativeCooler_Direct_ResearchSpecial> ();
    }
}