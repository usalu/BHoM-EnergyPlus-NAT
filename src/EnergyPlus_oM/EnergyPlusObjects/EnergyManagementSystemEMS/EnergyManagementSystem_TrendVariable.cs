using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS
{
    [Description("This object sets up an EMS trend variable from an Erl variable A trend variable l" +
                 "ogs values across timesteps")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnergyManagementSystem_TrendVariable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("must be a global scope EMS variable")]
        [JsonProperty(PropertyName="ems_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmsVariableName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_timesteps_to_be_logged", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfTimestepsToBeLogged { get; set; } = null;
    }
}