using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Hybrid Model")]
    public class HybridModel_Objects : BHoMObject
    {
        
        public bool ShouldSerializeHybridModel_Zone_List()
        {
            return (HybridModel_Zone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HybridModel:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HybridModel.HybridModel_Zone> HybridModel_Zone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HybridModel.HybridModel_Zone> ();
    }
}