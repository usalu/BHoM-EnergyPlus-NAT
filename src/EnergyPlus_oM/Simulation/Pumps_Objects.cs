using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Pumps")]
    public class Pumps_Objects : BHoMObject
    {
        
        public bool ShouldSerializePump_VariableSpeed_List()
        {
            return (Pump_VariableSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pump:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed> Pump_VariableSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed> ();
        
        public bool ShouldSerializePump_ConstantSpeed_List()
        {
            return (Pump_ConstantSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pump:ConstantSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_ConstantSpeed> Pump_ConstantSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_ConstantSpeed> ();
        
        public bool ShouldSerializePump_VariableSpeed_Condensate_List()
        {
            return (Pump_VariableSpeed_Condensate_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pump:VariableSpeed:Condensate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed_Condensate> Pump_VariableSpeed_Condensate_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.Pump_VariableSpeed_Condensate> ();
        
        public bool ShouldSerializeHeaderedPumps_ConstantSpeed_List()
        {
            return (HeaderedPumps_ConstantSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeaderedPumps:ConstantSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_ConstantSpeed> HeaderedPumps_ConstantSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_ConstantSpeed> ();
        
        public bool ShouldSerializeHeaderedPumps_VariableSpeed_List()
        {
            return (HeaderedPumps_VariableSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeaderedPumps:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_VariableSpeed> HeaderedPumps_VariableSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Pumps.HeaderedPumps_VariableSpeed> ();
    }
}