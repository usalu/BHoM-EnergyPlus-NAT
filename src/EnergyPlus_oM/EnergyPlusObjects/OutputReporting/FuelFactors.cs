using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Provides Fuel Factors for Emissions as well as Source=>Site conversions. OtherFue" +
                 "l1, OtherFuel2 provide options for users who want to create and use fuels that m" +
                 "ay not be mainstream (biomass, wood, pellets).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FuelFactors : BHoMObject
    {
        

        [JsonProperty(PropertyName="existing_fuel_resource_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FuelFactors_ExistingFuelResourceName ExistingFuelResourceName { get; set; } = (FuelFactors_ExistingFuelResourceName)Enum.Parse(typeof(FuelFactors_ExistingFuelResourceName), "Coal");
        

        [JsonProperty(PropertyName="units_of_measure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitsOfMeasure { get; set; } = "";
        

        [JsonProperty(PropertyName="energy_per_unit_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EnergyPerUnitFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="source_energy_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceEnergyFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="source_energy_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceEnergyScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="co2_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Co2EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="co2_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Co2EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="co_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="co_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="ch4_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Ch4EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="ch4_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ch4EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="nox_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NoxEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="nox_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NoxEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="n2o_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> N2oEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="n2o_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string N2oEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="so2_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> So2EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="so2_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string So2EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="pm_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PmEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="pm_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PmEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="pm10_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Pm10EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="pm10_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pm10EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="pm2_5_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Pm25EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="pm2_5_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pm25EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="nh3_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Nh3EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="nh3_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Nh3EmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="nmvoc_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NmvocEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="nmvoc_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NmvocEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="hg_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HgEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="hg_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HgEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="pb_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PbEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="pb_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PbEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="water_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="nuclear_high_level_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NuclearHighLevelEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="nuclear_high_level_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NuclearHighLevelEmissionFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="nuclear_low_level_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NuclearLowLevelEmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="nuclear_low_level_emission_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NuclearLowLevelEmissionFactorScheduleName { get; set; } = "";
    }
}