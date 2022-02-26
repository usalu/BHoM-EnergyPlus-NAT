using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    [Description("A single plugin to be executed during the simulation, which can contain multiple " +
                 "calling points for the same class instance by overriding multiple calling point " +
                 "methods.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PythonPlugin_Instance : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If this field is enabled, the plugin will be executed during warmup days, otherwi" +
                     "se it will only be executed once warmup is completed and the actual run period b" +
                     "egins")]
        [JsonProperty(PropertyName="run_during_warmup_days", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes RunDuringWarmupDays { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"This is the name of the Python file, without a file extension. For ""plugin_b.py"", use just ""plugin_b"". The Python plugin file must be on the plugin system search path to be found during a simulation Additional directories can be added to the search path using the PythonPlugin:SearchPaths object")]
        [JsonProperty(PropertyName="python_module_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PythonModuleName { get; set; } = "";
        

        [Description("This is the name of the class to be executed as a plugin during a simulation The " +
                     "class must inherit the EnergyPlusPlugin base class")]
        [JsonProperty(PropertyName="plugin_class_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PluginClassName { get; set; } = "";
    }
}