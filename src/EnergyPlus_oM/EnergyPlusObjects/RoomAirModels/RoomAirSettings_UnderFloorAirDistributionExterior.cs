using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"Applicable to exterior spaces that are served by an underfloor air distribution system. The dominant sources of heat gain should be from people, equipment, and other localized sources located in the occupied part of the room, as well as convective gain coming from a warm window. Used with RoomAirModelType = CrossVentilation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_UnderFloorAirDistributionExterior : BHoMObject
    {
        

        [Description("Name of Zone being described. Any existing zone name")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_diffusers_per_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> NumberOfDiffusersPerZone { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="power_per_plume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> PowerPerPlume { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_effective_area_of_diffuser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DesignEffectiveAreaOfDiffuser { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="diffuser_slot_angle_from_vertical", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DiffuserSlotAngleFromVertical { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Height of thermostat/temperature control sensor above floor")]
        [JsonProperty(PropertyName="thermostat_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermostatHeight { get; set; } = Double.Parse("1.2", CultureInfo.InvariantCulture);
        

        [Description("Height at which Air temperature is calculated for comfort purposes")]
        [JsonProperty(PropertyName="comfort_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ComfortHeight { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"Minimum temperature difference between upper and lower layer temperatures above which UFAD auxiliary outputs are calculated. These outputs are 'UF Transition Height' and 'UF Average Temp Gradient'. They are set to zero values when the temperature difference is less than the threshold and the output 'UF Zone Is Mixed' is set to 1")]
        [JsonProperty(PropertyName="temperature_difference_threshold_for_reporting", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureDifferenceThresholdForReporting { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="floor_diffuser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType FloorDiffuserType { get; set; } = (RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType)Enum.Parse(typeof(RoomAirSettings_UnderFloorAirDistributionExterior_FloorDiffuserType), "Swirl");
        

        [Description("User-specified height above floor of boundary between occupied and upper subzones" +
                     "")]
        [JsonProperty(PropertyName="transition_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> TransitionHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_a_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientAInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_b_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientBInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_c_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientCInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_d_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientDInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Kc is the fraction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_e_in_formula_kc_a_gamma_b_c_d_gamma_e_gamma_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientEInFormulaKcAGammaBCDGammaEGamma2 { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}