using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("This object is used in places where lists of nodes may be needed, e.g. ZoneHVAC:E" +
                 "quipmentConnections field Zone Air Inlet Node or NodeList Name")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class NodeList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="nodes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Nodes { get; set; } = null;
    }
}