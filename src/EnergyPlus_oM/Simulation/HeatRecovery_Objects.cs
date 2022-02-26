using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Heat Recovery")]
    public class HeatRecovery_Objects : BHoMObject
    {
        
        public bool ShouldSerializeHeatExchanger_AirToAir_FlatPlate_List()
        {
            return (HeatExchanger_AirToAir_FlatPlate_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatExchanger:AirToAir:FlatPlate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_FlatPlate> HeatExchanger_AirToAir_FlatPlate_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_FlatPlate> ();
        
        public bool ShouldSerializeHeatExchanger_AirToAir_SensibleAndLatent_List()
        {
            return (HeatExchanger_AirToAir_SensibleAndLatent_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatExchanger:AirToAir:SensibleAndLatent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_SensibleAndLatent> HeatExchanger_AirToAir_SensibleAndLatent_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_AirToAir_SensibleAndLatent> ();
        
        public bool ShouldSerializeHeatExchanger_Desiccant_BalancedFlow_List()
        {
            return (HeatExchanger_Desiccant_BalancedFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatExchanger:Desiccant:BalancedFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow> HeatExchanger_Desiccant_BalancedFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow> ();
        
        public bool ShouldSerializeHeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1_List()
        {
            return (HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatExchanger:Desiccant:BalancedFlow:PerformanceDataType1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1> HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HeatRecovery.HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1> ();
    }
}