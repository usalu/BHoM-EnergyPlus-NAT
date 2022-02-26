using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Parametrics")]
    public class Parametrics_Objects : BHoMObject
    {
        
        public bool ShouldSerializeParametric_SetValueForRun_List()
        {
            return (Parametric_SetValueForRun_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Parametric:SetValueForRun", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_SetValueForRun> Parametric_SetValueForRun_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_SetValueForRun> ();
        

        [JsonProperty(PropertyName="Parametric:Logic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_Logic Parametric_Logic { get; set; } = null;
        

        [JsonProperty(PropertyName="Parametric:RunControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_RunControl Parametric_RunControl { get; set; } = null;
        

        [JsonProperty(PropertyName="Parametric:FileNameSuffix", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Parametrics.Parametric_FileNameSuffix Parametric_FileNameSuffix { get; set; } = null;
    }
}