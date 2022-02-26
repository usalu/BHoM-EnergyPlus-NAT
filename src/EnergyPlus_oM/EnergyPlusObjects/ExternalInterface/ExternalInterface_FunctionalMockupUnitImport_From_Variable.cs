using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This object declares an FMU input variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitImport_From_Variable : BHoMObject
    {
        

        [JsonProperty(PropertyName="output_variable_index_key_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutputVariableIndexKeyName { get; set; } = "";
        

        [JsonProperty(PropertyName="output_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutputVariableName { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuFileName { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_instance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuInstanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuVariableName { get; set; } = "";
    }
}