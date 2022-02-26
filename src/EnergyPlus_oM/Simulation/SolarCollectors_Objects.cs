using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Solar Collectors")]
    public class SolarCollectors_Objects : BHoMObject
    {
        
        public bool ShouldSerializeSolarCollectorPerformance_FlatPlate_List()
        {
            return (SolarCollectorPerformance_FlatPlate_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollectorPerformance:FlatPlate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_FlatPlate> SolarCollectorPerformance_FlatPlate_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_FlatPlate> ();
        
        public bool ShouldSerializeSolarCollector_FlatPlate_Water_List()
        {
            return (SolarCollector_FlatPlate_Water_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollector:FlatPlate:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_Water> SolarCollector_FlatPlate_Water_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_Water> ();
        
        public bool ShouldSerializeSolarCollector_FlatPlate_PhotovoltaicThermal_List()
        {
            return (SolarCollector_FlatPlate_PhotovoltaicThermal_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollector:FlatPlate:PhotovoltaicThermal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_PhotovoltaicThermal> SolarCollector_FlatPlate_PhotovoltaicThermal_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_FlatPlate_PhotovoltaicThermal> ();
        
        public bool ShouldSerializeSolarCollectorPerformance_PhotovoltaicThermal_Simple_List()
        {
            return (SolarCollectorPerformance_PhotovoltaicThermal_Simple_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollectorPerformance:PhotovoltaicThermal:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_PhotovoltaicThermal_Simple> SolarCollectorPerformance_PhotovoltaicThermal_Simple_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_PhotovoltaicThermal_Simple> ();
        
        public bool ShouldSerializeSolarCollector_IntegralCollectorStorage_List()
        {
            return (SolarCollector_IntegralCollectorStorage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollector:IntegralCollectorStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_IntegralCollectorStorage> SolarCollector_IntegralCollectorStorage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_IntegralCollectorStorage> ();
        
        public bool ShouldSerializeSolarCollectorPerformance_IntegralCollectorStorage_List()
        {
            return (SolarCollectorPerformance_IntegralCollectorStorage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollectorPerformance:IntegralCollectorStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_IntegralCollectorStorage> SolarCollectorPerformance_IntegralCollectorStorage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollectorPerformance_IntegralCollectorStorage> ();
        
        public bool ShouldSerializeSolarCollector_UnglazedTranspired_List()
        {
            return (SolarCollector_UnglazedTranspired_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollector:UnglazedTranspired", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired> SolarCollector_UnglazedTranspired_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired> ();
        
        public bool ShouldSerializeSolarCollector_UnglazedTranspired_Multisystem_List()
        {
            return (SolarCollector_UnglazedTranspired_Multisystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SolarCollector:UnglazedTranspired:Multisystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired_Multisystem> SolarCollector_UnglazedTranspired_Multisystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SolarCollectors.SolarCollector_UnglazedTranspired_Multisystem> ();
    }
}