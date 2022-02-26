using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Water Systems")]
    public class WaterSystems_Objects : BHoMObject
    {
        
        public bool ShouldSerializeWaterUse_Equipment_List()
        {
            return (WaterUse_Equipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterUse:Equipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Equipment> WaterUse_Equipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Equipment> ();
        
        public bool ShouldSerializeWaterUse_Connections_List()
        {
            return (WaterUse_Connections_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterUse:Connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Connections> WaterUse_Connections_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Connections> ();
        
        public bool ShouldSerializeWaterUse_Storage_List()
        {
            return (WaterUse_Storage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterUse:Storage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Storage> WaterUse_Storage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Storage> ();
        
        public bool ShouldSerializeWaterUse_Well_List()
        {
            return (WaterUse_Well_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterUse:Well", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Well> WaterUse_Well_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_Well> ();
        
        public bool ShouldSerializeWaterUse_RainCollector_List()
        {
            return (WaterUse_RainCollector_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterUse:RainCollector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_RainCollector> WaterUse_RainCollector_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterSystems.WaterUse_RainCollector> ();
    }
}