using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This object is referenced by a Generator:MicroCHP object and provides the non-nor" +
                 "malized parameters for the MicroCHP generator model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_MicroCHP_NonNormalizedParameters : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumElectricPower { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumElectricPower { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_cooling_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCoolingWaterFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_cooling_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCoolingWaterTemperature { get; set; } = null;
        

        [Description("TriQuadratic")]
        [JsonProperty(PropertyName="electrical_efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricalEfficiencyCurveName { get; set; } = "";
        

        [Description("TriQuadratic")]
        [JsonProperty(PropertyName="thermal_efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalEfficiencyCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_water_flow_rate_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode CoolingWaterFlowRateMode { get; set; } = (Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode)Enum.Parse(typeof(Generator_MicroCHP_NonNormalizedParameters_CoolingWaterFlowRateMode), "InternalControl");
        

        [JsonProperty(PropertyName="cooling_water_flow_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingWaterFlowRateCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_flow_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirFlowRateCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_net_electrical_power_rate_of_change", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumNetElectricalPowerRateOfChange { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_fuel_flow_rate_of_change", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFuelFlowRateOfChange { get; set; } = null;
        

        [JsonProperty(PropertyName="heat_exchanger_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatExchangerUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossRadiativeFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="aggregated_thermal_mass_of_energy_conversion_portion_of_generator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AggregatedThermalMassOfEnergyConversionPortionOfGenerator { get; set; } = null;
        

        [JsonProperty(PropertyName="aggregated_thermal_mass_of_heat_recovery_portion_of_generator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AggregatedThermalMassOfHeatRecoveryPortionOfGenerator { get; set; } = null;
        

        [JsonProperty(PropertyName="standby_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StandbyPower { get; set; } = null;
        

        [Description("Stirling engines use Nominal Engine Temperature Internal combustion engines use T" +
                     "ime Delay")]
        [JsonProperty(PropertyName="warm_up_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_MicroCHP_NonNormalizedParameters_WarmUpMode WarmUpMode { get; set; } = (Generator_MicroCHP_NonNormalizedParameters_WarmUpMode)Enum.Parse(typeof(Generator_MicroCHP_NonNormalizedParameters_WarmUpMode), "NominalEngineTemperature");
        

        [JsonProperty(PropertyName="warm_up_fuel_flow_rate_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WarmUpFuelFlowRateCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_engine_operating_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalEngineOperatingTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="warm_up_power_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WarmUpPowerCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="warm_up_fuel_flow_rate_limit_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WarmUpFuelFlowRateLimitRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="warm_up_delay_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WarmUpDelayTime { get; set; } = null;
        

        [JsonProperty(PropertyName="cool_down_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolDownPower { get; set; } = null;
        

        [JsonProperty(PropertyName="cool_down_delay_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolDownDelayTime { get; set; } = null;
        

        [JsonProperty(PropertyName="restart_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_MicroCHP_NonNormalizedParameters_RestartMode RestartMode { get; set; } = (Generator_MicroCHP_NonNormalizedParameters_RestartMode)Enum.Parse(typeof(Generator_MicroCHP_NonNormalizedParameters_RestartMode), "MandatoryCoolDown");
    }
}