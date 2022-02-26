using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Exterior Equipment")]
    public class ExteriorEquipment_Objects : BHoMObject
    {
        
        public bool ShouldSerializeExterior_Lights_List()
        {
            return (Exterior_Lights_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Exterior:Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_Lights> Exterior_Lights_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_Lights> ();
        
        public bool ShouldSerializeExterior_FuelEquipment_List()
        {
            return (Exterior_FuelEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Exterior:FuelEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_FuelEquipment> Exterior_FuelEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_FuelEquipment> ();
        
        public bool ShouldSerializeExterior_WaterEquipment_List()
        {
            return (Exterior_WaterEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Exterior:WaterEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_WaterEquipment> Exterior_WaterEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExteriorEquipment.Exterior_WaterEquipment> ();
    }
}