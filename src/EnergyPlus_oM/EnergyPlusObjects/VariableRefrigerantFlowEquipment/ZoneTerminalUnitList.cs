using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [Description("List of variable refrigerant flow (VRF) terminal units served by a given VRF cond" +
                 "ensing unit. See ZoneHVAC:TerminalUnit:VariableRefrigerantFlow and AirConditione" +
                 "r:VariableRefrigerantFlow.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneTerminalUnitList : BHoMObject
    {
        

        [JsonProperty(PropertyName="zone_terminal_unit_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneTerminalUnitListName { get; set; } = "";
        

        [Description("This list is the ZoneTerminalUnitNames object-list")]
        [JsonProperty(PropertyName="terminal_units", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> TerminalUnits { get; set; } = null;
    }
}