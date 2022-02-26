using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("Declares EMS variable as an internal data variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_InternalVariable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="internal_data_index_key_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalDataIndexKeyName { get; set; } = "";
        

        [JsonProperty(PropertyName="internal_data_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InternalDataType { get; set; } = "";
    }
}