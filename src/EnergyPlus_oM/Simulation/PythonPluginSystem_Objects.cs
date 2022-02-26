using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Python Plugin System")]
    public class PythonPluginSystem_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="PythonPlugin:SearchPaths", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_SearchPaths PythonPlugin_SearchPaths { get; set; } = null;
        
        public bool ShouldSerializePythonPlugin_Instance_List()
        {
            return (PythonPlugin_Instance_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PythonPlugin:Instance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Instance> PythonPlugin_Instance_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Instance> ();
        

        [JsonProperty(PropertyName="PythonPlugin:Variables", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_Variables PythonPlugin_Variables { get; set; } = null;
        
        public bool ShouldSerializePythonPlugin_TrendVariable_List()
        {
            return (PythonPlugin_TrendVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PythonPlugin:TrendVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_TrendVariable> PythonPlugin_TrendVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_TrendVariable> ();
        
        public bool ShouldSerializePythonPlugin_OutputVariable_List()
        {
            return (PythonPlugin_OutputVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PythonPlugin:OutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_OutputVariable> PythonPlugin_OutputVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PythonPluginSystem.PythonPlugin_OutputVariable> ();
    }
}