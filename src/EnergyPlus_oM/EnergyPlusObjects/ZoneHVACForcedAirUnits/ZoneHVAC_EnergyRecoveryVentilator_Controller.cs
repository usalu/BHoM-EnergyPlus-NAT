using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("This controller is used exclusively by the ZoneHVAC:EnergyRecoveryVentilator obje" +
                 "ct to allow economizer (free cooling) operation when possible.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_EnergyRecoveryVentilator_Controller : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the maximum outdoor dry-bulb temperature limit for economizer operation. No" +
                     " input or blank input means this limit is not operative")]
        [JsonProperty(PropertyName="temperature_high_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureHighLimit { get; set; } = null;
        

        [Description("Enter the minimum outdoor dry-bulb temperature limit for economizer operation. No" +
                     " input or blank input means this limit is not operative")]
        [JsonProperty(PropertyName="temperature_low_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureLowLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor enthalpy limit for economizer operation. No input or bl" +
                     "ank input means this limit is not operative")]
        [JsonProperty(PropertyName="enthalpy_high_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EnthalpyHighLimit { get; set; } = null;
        

        [Description("Enter the maximum outdoor dew point temperature limit for economizer operation. N" +
                     "o input or blank input means this limit is not operative")]
        [JsonProperty(PropertyName="dewpoint_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureLimit { get; set; } = null;
        

        [Description("Enter the name of a quadratic or cubic curve which defines the maximum outdoor hu" +
                     "midity ratio (function of outdoor dry-bulb temperature) for economizer operation" +
                     ". No input or blank input means this limit is not operative")]
        [JsonProperty(PropertyName="electronic_enthalpy_limit_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectronicEnthalpyLimitCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="exhaust_air_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit ExhaustAirTemperatureLimit { get; set; } = (ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit)Enum.Parse(typeof(ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirTemperatureLimit), "NoExhaustAirTemperatureLimit");
        

        [JsonProperty(PropertyName="exhaust_air_enthalpy_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit ExhaustAirEnthalpyLimit { get; set; } = (ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit)Enum.Parse(typeof(ZoneHVAC_EnergyRecoveryVentilator_Controller_ExhaustAirEnthalpyLimit), "NoExhaustAirEnthalpyLimit");
        

        [Description("Schedule values greater than 0 indicate economizer operation is active. This sche" +
                     "dule may be used with or without the High Humidity Control option. When used tog" +
                     "ether, high humidity control has priority over economizer control.")]
        [JsonProperty(PropertyName="time_of_day_economizer_flow_control_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeOfDayEconomizerFlowControlScheduleName { get; set; } = "";
        

        [Description("Select Yes to modify air flow rates based on a zone humidistat. Select No to disa" +
                     "ble this feature.")]
        [JsonProperty(PropertyName="high_humidity_control_flag", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes HighHumidityControlFlag { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Enter the name of the zone where the humidistat is located.")]
        [JsonProperty(PropertyName="humidistat_control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidistatControlZoneName { get; set; } = "";
        

        [Description("Enter the ratio of supply (outdoor) air to the maximum supply air flow rate when " +
                     "modified air flow rates are active based on high indoor humidity.")]
        [JsonProperty(PropertyName="high_humidity_outdoor_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighHumidityOutdoorAirFlowRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"If NO is selected, the air flow rate is modified any time indoor relative humidity is above humidistat setpoint. If YES is selected, outdoor air flow rate is modified any time indoor relative humidity is above the humidistat setpoint AND the outdoor humidity ratio is less than the indoor humidity ratio.")]
        [JsonProperty(PropertyName="control_high_indoor_humidity_based_on_outdoor_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}