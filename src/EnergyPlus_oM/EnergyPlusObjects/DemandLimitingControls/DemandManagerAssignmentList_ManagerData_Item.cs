using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DemandManagerAssignmentList_ManagerData_Item
    {
        

        [JsonProperty(PropertyName="demandmanager_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandmanagerObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="demandmanager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandmanagerName { get; set; } = "";
    }
}