using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Controllers")]
    public class Controllers_Objects : BHoMObject
    {
        
        public bool ShouldSerializeController_WaterCoil_List()
        {
            return (Controller_WaterCoil_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Controller:WaterCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_WaterCoil> Controller_WaterCoil_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_WaterCoil> ();
        
        public bool ShouldSerializeController_OutdoorAir_List()
        {
            return (Controller_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Controller:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_OutdoorAir> Controller_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_OutdoorAir> ();
        
        public bool ShouldSerializeController_MechanicalVentilation_List()
        {
            return (Controller_MechanicalVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Controller:MechanicalVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_MechanicalVentilation> Controller_MechanicalVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_MechanicalVentilation> ();
        
        public bool ShouldSerializeAirLoopHVAC_ControllerList_List()
        {
            return (AirLoopHVAC_ControllerList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:ControllerList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.AirLoopHVAC_ControllerList> AirLoopHVAC_ControllerList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.AirLoopHVAC_ControllerList> ();
    }
}