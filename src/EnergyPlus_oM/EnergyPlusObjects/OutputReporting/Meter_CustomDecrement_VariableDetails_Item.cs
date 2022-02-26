using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Meter_CustomDecrement_VariableDetails_Item
    {
        

        [JsonProperty(PropertyName="key_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KeyName { get; set; } = "";
        

        [JsonProperty(PropertyName="output_variable_or_meter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutputVariableOrMeterName { get; set; } = "";
    }
}