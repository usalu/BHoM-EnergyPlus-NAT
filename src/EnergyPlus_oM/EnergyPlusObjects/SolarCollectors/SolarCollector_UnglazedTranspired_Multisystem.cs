using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("quad-tuples of inlet, outlet, control, and zone nodes for multiple different outd" +
                 "oor air systems attached to same collector")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollector_UnglazedTranspired_Multisystem : BHoMObject
    {
        

        [Description("Enter the name of a SolarCollector:UnglazedTranspired object.")]
        [JsonProperty(PropertyName="solar_collector_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SolarCollectorName { get; set; } = "";
        

        [JsonProperty(PropertyName="systems", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired_Multisystem_Systems_Item> Systems { get; set; } = null;
    }
}