using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Generators_GeneratorOutputs_Item
    {
        

        [JsonProperty(PropertyName="generator_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorName { get; set; } = "";
        

        [JsonProperty(PropertyName="generator_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="generator_rated_electric_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GeneratorRatedElectricPowerOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="generator_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="generator_rated_thermal_to_electrical_power_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GeneratorRatedThermalToElectricalPowerRatio { get; set; } = null;
    }
}