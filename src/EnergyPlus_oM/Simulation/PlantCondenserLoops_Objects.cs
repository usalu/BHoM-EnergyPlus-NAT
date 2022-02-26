using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Plant-Condenser Loops")]
    public class PlantCondenserLoops_Objects : BHoMObject
    {
        
        public bool ShouldSerializePlantLoop_List()
        {
            return (PlantLoop_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.PlantLoop> PlantLoop_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.PlantLoop> ();
        
        public bool ShouldSerializeCondenserLoop_List()
        {
            return (CondenserLoop_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CondenserLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.CondenserLoop> CondenserLoop_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserLoops.CondenserLoop> ();
    }
}