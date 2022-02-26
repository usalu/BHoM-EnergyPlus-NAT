using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: General Data Entry")]
    public class GeneralDataEntry_Objects : BHoMObject
    {
        
        public bool ShouldSerializeMatrix_TwoDimension_List()
        {
            return (Matrix_TwoDimension_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Matrix:TwoDimension", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.GeneralDataEntry.Matrix_TwoDimension> Matrix_TwoDimension_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.GeneralDataEntry.Matrix_TwoDimension> ();
    }
}