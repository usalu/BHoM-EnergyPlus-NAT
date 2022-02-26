using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_HybridUnitaryHVAC_Modes_Item
    {
        

        [JsonProperty(PropertyName="mode_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_supply_air_temperature_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSupplyAirTemperatureLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_supply_air_humidity_ratio_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSupplyAirHumidityRatioLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_system_electric_power_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSystemElectricPowerLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_supply_fan_electric_power_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSupplyFanElectricPowerLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_external_static_pressure_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeExternalStaticPressureLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_system_second_fuel_consumption_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSystemSecondFuelConsumptionLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_system_third_fuel_consumption_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSystemThirdFuelConsumptionLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_system_water_use_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModeSystemWaterUseLookupTableName { get; set; } = "";
        

        [JsonProperty(PropertyName="mode_minimum_outdoor_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumOutdoorAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_outdoor_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumOutdoorAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_outdoor_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumOutdoorAirHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_outdoor_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumOutdoorAirHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_outdoor_air_relative_humidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumOutdoorAirRelativeHumidity { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_outdoor_air_relative_humidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumOutdoorAirRelativeHumidity { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_return_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumReturnAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_return_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumReturnAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_return_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumReturnAirHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_return_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumReturnAirHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_return_air_relative_humidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumReturnAirRelativeHumidity { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_return_air_relative_humidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumReturnAirRelativeHumidity { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_outdoor_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumOutdoorAirFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_outdoor_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumOutdoorAirFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_minimum_supply_air_mass_flow_rate_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMinimumSupplyAirMassFlowRateRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="mode_maximum_supply_air_mass_flow_rate_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModeMaximumSupplyAirMassFlowRateRatio { get; set; } = null;
    }
}