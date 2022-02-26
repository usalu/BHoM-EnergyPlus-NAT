using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Branches MUST be listed in Flow order: Inlet branch, then parallel branches, then" +
                 " Outlet branch. Branches are simulated in the order listed. Branch names cannot " +
                 "be duplicated within a single branch list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class BranchList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This list is the Branches object-list")]
        [JsonProperty(PropertyName="branches", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Branches { get; set; } = null;
    }
}