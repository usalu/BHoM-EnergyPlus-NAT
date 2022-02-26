using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"This object is specified as natural ventilation driven by wind and stack effect only: Ventilation Wind = Cw * Opening Area * Schedule * WindSpd Ventilation Stack = Cd * Opening Area * Schedule * SQRT(2*g*DH*(|(Tzone-Todb)|/Tzone)) Total Ventilation = SQRT((Ventilation Wind)^2 + (Ventilation Stack)^2)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneVentilation_WindandStackOpenArea : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("This is the opening area used to calculate stack effect and wind driven ventilati" +
                     "on.")]
        [JsonProperty(PropertyName="opening_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OpeningArea { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the fraction values applied to the opening area given in t" +
                     "he previous input field (0.0 - 1.0).")]
        [JsonProperty(PropertyName="opening_area_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OpeningAreaFractionScheduleName { get; set; } = "";
        

        [Description(@"This field is used to calculate wind driven ventilation. ""Cw"" in the wind-driven equation and the maximum value is 1.0. When the input is Autocalculate, the program calculates Cw based on an angle between wind direction and effective angle Cw = 0.55 at angle = 0, and Cw = 0.3 at angle=180 Linear interpolation is used to calculate Cw based on the above two values.")]
        [JsonProperty(PropertyName="opening_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> OpeningEffectiveness { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is defined as normal angle of the opening area and is used when input " +
                     "field Opening Effectiveness = Autocalculate.")]
        [JsonProperty(PropertyName="effective_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveAngle { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This is the height difference between the midpoint of an opening and the neutral " +
                     "pressure level. \"DH\" in the stack equation.")]
        [JsonProperty(PropertyName="height_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This is the discharge coefficient used to calculate stack effect. \"Cd\" in the sta" +
                     "ck equation and the maximum value is 1.0. When the input is Autocalculate, the f" +
                     "ollowing equation is used to calculate the coefficient: Cd = 0.4 + 0.0045*|(Tzon" +
                     "e-Todb)|")]
        [JsonProperty(PropertyName="discharge_coefficient_for_opening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DischargeCoefficientForOpening { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This is the indoor temperature below which ventilation is shutoff.")]
        [JsonProperty(PropertyName="minimum_indoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumIndoorTemperature { get; set; } = Double.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time below which ventilation" +
                     " is shutoff.")]
        [JsonProperty(PropertyName="minimum_indoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the indoor temperature above which ventilation is shutoff.")]
        [JsonProperty(PropertyName="maximum_indoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumIndoorTemperature { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time above which ventilation" +
                     " is shutoff.")]
        [JsonProperty(PropertyName="maximum_indoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the temperature differential between indoor and outdoor below which venti" +
                     "lation is shutoff.")]
        [JsonProperty(PropertyName="delta_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeltaTemperature { get; set; } = Double.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between indoor and outdoor ve" +
                     "rsus time below which ventilation is shutoff.")]
        [JsonProperty(PropertyName="delta_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the outdoor temperature below which ventilation is shutoff.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorTemperature { get; set; } = Double.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time below which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the outdoor temperature above which ventilation is shutoff.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorTemperature { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time above which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This is the outdoor wind speed above which ventilation is shutoff.")]
        [JsonProperty(PropertyName="maximum_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumWindSpeed { get; set; } = Double.Parse("40", CultureInfo.InvariantCulture);
    }
}