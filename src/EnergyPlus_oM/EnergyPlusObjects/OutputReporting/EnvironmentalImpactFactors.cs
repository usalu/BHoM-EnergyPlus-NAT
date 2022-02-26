using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Used to help convert district and ideal energy use to a fuel type and provide tot" +
                 "al carbon equivalent with coefficients Also used in Source=>Site conversions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EnvironmentalImpactFactors : BHoMObject
    {
        

        [Description("District heating efficiency used when converted to natural gas")]
        [JsonProperty(PropertyName="district_heating_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistrictHeatingEfficiency { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [Description("District cooling COP used when converted to electricity")]
        [JsonProperty(PropertyName="district_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistrictCoolingCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Steam conversion efficiency used to convert steam usage to natural gas")]
        [JsonProperty(PropertyName="steam_conversion_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SteamConversionEfficiency { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="total_carbon_equivalent_emission_factor_from_n2o", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalCarbonEquivalentEmissionFactorFromN2o { get; set; } = Double.Parse("80.7272", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="total_carbon_equivalent_emission_factor_from_ch4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalCarbonEquivalentEmissionFactorFromCh4 { get; set; } = Double.Parse("6.2727", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="total_carbon_equivalent_emission_factor_from_co2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalCarbonEquivalentEmissionFactorFromCo2 { get; set; } = Double.Parse("0.2727", CultureInfo.InvariantCulture);
    }
}