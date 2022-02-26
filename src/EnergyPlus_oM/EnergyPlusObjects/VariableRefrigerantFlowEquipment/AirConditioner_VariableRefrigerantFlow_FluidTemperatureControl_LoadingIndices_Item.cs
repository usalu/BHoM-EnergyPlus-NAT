using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirConditioner_VariableRefrigerantFlow_FluidTemperatureControl_LoadingIndices_Item
    {
        

        [JsonProperty(PropertyName="compressor_speed_at_loading_index", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorSpeedAtLoadingIndex { get; set; } = null;
        

        [JsonProperty(PropertyName="loading_index_evaporative_capacity_multiplier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadingIndexEvaporativeCapacityMultiplierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="loading_index_compressor_power_multiplier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadingIndexCompressorPowerMultiplierFunctionOfTemperatureCurveName { get; set; } = "";
    }
}