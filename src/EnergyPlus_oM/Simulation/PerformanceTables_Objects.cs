using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Performance Tables")]
    public class PerformanceTables_Objects : BHoMObject
    {
        
        public bool ShouldSerializeTable_IndependentVariable_List()
        {
            return (Table_IndependentVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Table:IndependentVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariable> Table_IndependentVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariable> ();
        
        public bool ShouldSerializeTable_IndependentVariableList_List()
        {
            return (Table_IndependentVariableList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Table:IndependentVariableList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariableList> Table_IndependentVariableList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_IndependentVariableList> ();
        
        public bool ShouldSerializeTable_Lookup_List()
        {
            return (Table_Lookup_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Table:Lookup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_Lookup> Table_Lookup_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PerformanceTables.Table_Lookup> ();
    }
}