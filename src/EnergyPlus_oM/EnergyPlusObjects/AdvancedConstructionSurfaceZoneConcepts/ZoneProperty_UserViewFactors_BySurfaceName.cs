using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("View factors for Surface to Surface in a zone. (Number of Surfaces)**2 are expect" +
                 "ed. Any omitted surface pairs will be assumed to have a view factor of zero.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneProperty_UserViewFactors_BySurfaceName : BHoMObject
    {
        

        [Description("View factors may be entered for a single zone or for a group of zones connected b" +
                     "y Construction:AirBoundary")]
        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty(PropertyName="view_factors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_UserViewFactors_BySurfaceName_ViewFactors_Item> ViewFactors { get; set; } = null;
    }
}