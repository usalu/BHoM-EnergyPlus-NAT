using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_Annual_VariableDetails_Item
    {
        

        [JsonProperty(PropertyName="variable_or_meter_or_ems_variable_or_field_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VariableOrMeterOrEmsVariableOrFieldName { get; set; } = "";
        

        [JsonProperty(PropertyName="aggregation_type_for_variable_or_meter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AggregationTypeForVariableOrMeter { get; set; } = "";
        

        [JsonProperty(PropertyName="digits_after_decimal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DigitsAfterDecimal { get; set; } = null;
    }
}