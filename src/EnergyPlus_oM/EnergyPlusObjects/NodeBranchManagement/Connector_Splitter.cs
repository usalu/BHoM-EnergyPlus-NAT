using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Split one air/water stream into N outlet streams. Branch names cannot be duplicat" +
                 "ed within a single Splitter list.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Connector_Splitter : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="inlet_branch_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletBranchName { get; set; } = "";
        

        [Description("This list is the Branches object-list")]
        [JsonProperty(PropertyName="branches", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Branches { get; set; } = null;
    }
}