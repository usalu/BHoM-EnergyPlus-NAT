using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManagerAssignmentList_Managers_Item
    {
        

        [JsonProperty(PropertyName="availability_manager_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerName { get; set; } = "";
    }
}