using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Plant-Condenser Flow Control")]
    public class PlantCondenserFlowControl_Objects : BHoMObject
    {
        
        public bool ShouldSerializeTemperingValve_List()
        {
            return (TemperingValve_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="TemperingValve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl.TemperingValve> TemperingValve_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl.TemperingValve> ();
    }
}