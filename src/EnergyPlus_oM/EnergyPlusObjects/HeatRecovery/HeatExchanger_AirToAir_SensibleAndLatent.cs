using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    [Description("This object models an air-to-air heat exchanger using effectiveness relationships" +
                 ". The heat exchanger can transfer sensible energy, latent energy, or both betwee" +
                 "n the supply (primary) and exhaust (secondary) air streams.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatExchanger_AirToAir_SensibleAndLatent : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="nominal_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="sensible_effectiveness_at_100_heating_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleEffectivenessAt100HeatingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="latent_effectiveness_at_100_heating_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentEffectivenessAt100HeatingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="sensible_effectiveness_at_75_heating_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleEffectivenessAt75HeatingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="latent_effectiveness_at_75_heating_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentEffectivenessAt75HeatingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="sensible_effectiveness_at_100_cooling_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleEffectivenessAt100CoolingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="latent_effectiveness_at_100_cooling_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentEffectivenessAt100CoolingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="sensible_effectiveness_at_75_cooling_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SensibleEffectivenessAt75CoolingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="latent_effectiveness_at_75_cooling_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentEffectivenessAt75CoolingAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="exhaust_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="exhaust_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="nominal_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalElectricPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_air_outlet_temperature_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SupplyAirOutletTemperatureControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="heat_exchanger_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType HeatExchangerType { get; set; } = (HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType)Enum.Parse(typeof(HeatExchanger_AirToAir_SensibleAndLatent_HeatExchangerType), "Plate");
        

        [JsonProperty(PropertyName="frost_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType FrostControlType { get; set; } = (HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType)Enum.Parse(typeof(HeatExchanger_AirToAir_SensibleAndLatent_FrostControlType), "None");
        

        [Description("Supply (outdoor) air inlet temp threshold for exhaust air recirculation and exhau" +
                     "st only frost control types. Exhaust air outlet threshold Temperature for minimu" +
                     "m exhaust temperature frost control type.")]
        [JsonProperty(PropertyName="threshold_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThresholdTemperature { get; set; } = Double.Parse("1.7", CultureInfo.InvariantCulture);
        

        [Description("Fraction of the time when frost control will be invoked at the threshold temperat" +
                     "ure. This field only used for exhaust air recirc and exhaust-only frost control " +
                     "types.")]
        [JsonProperty(PropertyName="initial_defrost_time_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialDefrostTimeFraction { get; set; } = Double.Parse("0.083", CultureInfo.InvariantCulture);
        

        [Description("Rate of increase in defrost time fraction as actual temp falls below threshold te" +
                     "mperature. This field only used for exhaust air recirc and exhaust-only frost co" +
                     "ntrol types.")]
        [JsonProperty(PropertyName="rate_of_defrost_time_fraction_increase", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RateOfDefrostTimeFractionIncrease { get; set; } = Double.Parse("0.012", CultureInfo.InvariantCulture);
        

        [Description("Yes means that the heat exchanger will be locked out (off) when the economizer is" +
                     " operating or high humidity control is active")]
        [JsonProperty(PropertyName="economizer_lockout", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes EconomizerLockout { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}