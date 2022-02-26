using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Unitary Equipment")]
    public class UnitaryEquipment_Objects : BHoMObject
    {
        
        public bool ShouldSerializeAirLoopHVAC_UnitarySystem_List()
        {
            return (AirLoopHVAC_UnitarySystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitarySystem> AirLoopHVAC_UnitarySystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitarySystem> ();
        
        public bool ShouldSerializeUnitarySystemPerformance_Multispeed_List()
        {
            return (UnitarySystemPerformance_Multispeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UnitarySystemPerformance:Multispeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.UnitarySystemPerformance_Multispeed> UnitarySystemPerformance_Multispeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.UnitarySystemPerformance_Multispeed> ();
        
        public bool ShouldSerializeAirLoopHVAC_Unitary_Furnace_HeatOnly_List()
        {
            return (AirLoopHVAC_Unitary_Furnace_HeatOnly_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:Unitary:Furnace:HeatOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatOnly> AirLoopHVAC_Unitary_Furnace_HeatOnly_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatOnly> ();
        
        public bool ShouldSerializeAirLoopHVAC_Unitary_Furnace_HeatCool_List()
        {
            return (AirLoopHVAC_Unitary_Furnace_HeatCool_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:Unitary:Furnace:HeatCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatCool> AirLoopHVAC_Unitary_Furnace_HeatCool_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_Unitary_Furnace_HeatCool> ();
        
        public bool ShouldSerializeAirLoopHVAC_UnitaryHeatOnly_List()
        {
            return (AirLoopHVAC_UnitaryHeatOnly_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatOnly> AirLoopHVAC_UnitaryHeatOnly_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatOnly> ();
        
        public bool ShouldSerializeAirLoopHVAC_UnitaryHeatCool_List()
        {
            return (AirLoopHVAC_UnitaryHeatCool_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool> AirLoopHVAC_UnitaryHeatCool_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool> ();
        
        public bool ShouldSerializeAirLoopHVAC_UnitaryHeatPump_AirToAir_List()
        {
            return (AirLoopHVAC_UnitaryHeatPump_AirToAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatPump:AirToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir> AirLoopHVAC_UnitaryHeatPump_AirToAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir> ();
        
        public bool ShouldSerializeAirLoopHVAC_UnitaryHeatPump_WaterToAir_List()
        {
            return (AirLoopHVAC_UnitaryHeatPump_WaterToAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatPump:WaterToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_WaterToAir> AirLoopHVAC_UnitaryHeatPump_WaterToAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_WaterToAir> ();
        
        public bool ShouldSerializeAirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_List()
        {
            return (AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatCool:VAVChangeoverBypass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass> AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatCool_VAVChangeoverBypass> ();
        
        public bool ShouldSerializeAirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_List()
        {
            return (AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:UnitaryHeatPump:AirToAir:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed> AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.UnitaryEquipment.AirLoopHVAC_UnitaryHeatPump_AirToAir_MultiSpeed> ();
    }
}