using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Humidifiers and Dehumidifiers")]
    public class HumidifiersandDehumidifiers_Objects : BHoMObject
    {
        
        public bool ShouldSerializeHumidifier_Steam_Electric_List()
        {
            return (Humidifier_Steam_Electric_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Humidifier:Steam:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Electric> Humidifier_Steam_Electric_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Electric> ();
        
        public bool ShouldSerializeHumidifier_Steam_Gas_List()
        {
            return (Humidifier_Steam_Gas_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Humidifier:Steam:Gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Gas> Humidifier_Steam_Gas_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Humidifier_Steam_Gas> ();
        
        public bool ShouldSerializeDehumidifier_Desiccant_NoFans_List()
        {
            return (Dehumidifier_Desiccant_NoFans_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Dehumidifier:Desiccant:NoFans", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_NoFans> Dehumidifier_Desiccant_NoFans_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_NoFans> ();
        
        public bool ShouldSerializeDehumidifier_Desiccant_System_List()
        {
            return (Dehumidifier_Desiccant_System_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Dehumidifier:Desiccant:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_System> Dehumidifier_Desiccant_System_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers.Dehumidifier_Desiccant_System> ();
    }
}