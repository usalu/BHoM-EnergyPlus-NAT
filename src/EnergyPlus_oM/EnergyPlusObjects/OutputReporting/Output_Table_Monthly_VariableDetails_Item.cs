using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_Monthly_VariableDetails_Item
    {
        

        [JsonProperty(PropertyName="variable_or_meter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VariableOrMeterName { get; set; } = "";
        

        [JsonProperty(PropertyName="aggregation_type_for_variable_or_meter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AggregationTypeForVariableOrMeter { get; set; } = "";
    }
}