using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Variable Refrigerant Flow Equipment")]
    public class VariableRefrigerantFlowEquipment_Objects : BHoMObject
    {
        
        public bool ShouldSerializeAirConditioner_VariableRefrigerantFlow_List()
        {
            return (AirConditioner_VariableRefrigerantFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirConditioner:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow> AirConditioner_VariableRefrigerantFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow> ();
        
        public bool ShouldSerializeAirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_List()
        {
            return (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl> AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl> ();
        
        public bool ShouldSerializeAirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_List()
        {
            return (AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR> AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_HR> ();
        
        public bool ShouldSerializeZoneTerminalUnitList_List()
        {
            return (ZoneTerminalUnitList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneTerminalUnitList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.ZoneTerminalUnitList> ZoneTerminalUnitList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment.ZoneTerminalUnitList> ();
    }
}