using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description(@"This Room Air Model is applicable to interior spaces that are served by an underfloor air distribution system. The dominant sources of heat gain should be from people, equipment, and other localized sources located in the occupied part of the room. The model should be used with caution in zones which have large heat gains or losses through exterior walls or windows or which have considerable direct solar gain. Used with RoomAirModelType = UnderFloorAirDistributionInterior.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_UnderFloorAirDistributionInterior : BHoMObject
    {
        

        [Description("Name of Zone with underfloor air distribution")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Total number of diffusers in this zone")]
        [JsonProperty(PropertyName="number_of_diffusers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> NumberOfDiffusers { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

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
        

        [Description("Height at which air temperature is calculated for comfort purposes")]
        [JsonProperty(PropertyName="comfort_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ComfortHeight { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"Minimum temperature difference between predicted upper and lower layer temperatures above which UFAD auxiliary outputs are calculated. These outputs are 'UF Transition Height' and 'UF Average Temp Gradient'. They are set to zero values when the temperature difference is less than the threshold and the output 'UF Zone Is Mixed' is set to 1")]
        [JsonProperty(PropertyName="temperature_difference_threshold_for_reporting", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureDifferenceThresholdForReporting { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="floor_diffuser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType FloorDiffuserType { get; set; } = (RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType)Enum.Parse(typeof(RoomAirSettings_UnderFloorAirDistributionInterior_FloorDiffuserType), "Swirl");
        

        [Description("user-specified height above floor of boundary between occupied and upper subzones" +
                     "")]
        [JsonProperty(PropertyName="transition_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> TransitionHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Coefficient A in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientA { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Coefficient B in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_b", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientB { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Coefficient C in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_c", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientC { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Coefficient D in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_d", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientD { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Coefficient E in Formula Kc = A*Gamma**B + C + D*Gamma + E*Gamma**2 Kc is the fra" +
                     "ction of the total zone load attributable to the lower subzone")]
        [JsonProperty(PropertyName="coefficient_e", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientE { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}