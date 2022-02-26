using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_ResponseFactors_GFunctions_Item
    {
        

        [JsonProperty(PropertyName="g_function_ln_t_ts_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GFunctionLnTTsValue { get; set; } = null;
        

        [JsonProperty(PropertyName="g_function_g_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GFunctionGValue { get; set; } = null;
    }
}