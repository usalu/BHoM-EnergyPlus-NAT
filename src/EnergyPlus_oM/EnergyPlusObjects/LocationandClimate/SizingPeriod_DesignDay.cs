using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"The design day object creates the parameters for the program to create the 24 hour weather profile that can be used for sizing as well as running to test the other simulation parameters. Parameters in this include a date (month and day), a day type (which uses the appropriate schedules for either sizing or simple tests), min/max temperatures, wind speeds, and solar radiation values.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SizingPeriod_DesignDay : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Month { get; set; } = null;
        

        [Description("must be valid for Month field")]
        [JsonProperty(PropertyName="day_of_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DayOfMonth { get; set; } = null;
        

        [Description("Day Type selects the schedules appropriate for this design day")]
        [JsonProperty(PropertyName="day_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_DayType DayType { get; set; } = (SizingPeriod_DesignDay_DayType)Enum.Parse(typeof(SizingPeriod_DesignDay_DayType), "CustomDay1");
        

        [Description("This field is required when field \"Dry-Bulb Temperature Range Modifier Type\" is n" +
                     "ot \"TemperatureProfileSchedule\".")]
        [JsonProperty(PropertyName="maximum_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumDryBulbTemperature { get; set; } = null;
        

        [Description("Must still produce appropriate maximum dry-bulb (within range) This field is not " +
                     "needed if Dry-Bulb Temperature Range Modifier Type is \"delta\".")]
        [JsonProperty(PropertyName="daily_dry_bulb_temperature_range", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DailyDryBulbTemperatureRange { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Type of modifier to the dry-bulb temperature calculated for the timestep")]
        [JsonProperty(PropertyName="dry_bulb_temperature_range_modifier_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType DryBulbTemperatureRangeModifierType { get; set; } = (SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType)Enum.Parse(typeof(SizingPeriod_DesignDay_DryBulbTemperatureRangeModifierType), "DefaultMultipliers");
        

        [Description(@"Only used when previous field is ""MultiplierSchedule"", ""DifferenceSchedule"" or ""TemperatureProfileSchedule"". For type ""MultiplierSchedule""  the hour/time interval values should specify the fraction (0-1) of the dry-bulb temperature range to be subtracted from the maximum dry-bulb temperature for each timestep in the day For type ""DifferenceSchedule"" the values should specify a number to be subtracted from the maximum dry-bulb temperature for each timestep in the day. Note that numbers in the difference schedule cannot be negative as that would result in a higher maximum than the maximum previously specified. For type ""TemperatureProfileSchedule"" the values should specify the actual dry-bulb temperature for each timestep in the day.")]
        [JsonProperty(PropertyName="dry_bulb_temperature_range_modifier_day_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DryBulbTemperatureRangeModifierDayScheduleName { get; set; } = "";
        

        [Description("values/schedules indicated here and in subsequent fields create the humidity valu" +
                     "es in the 24 hour design day conditions profile.")]
        [JsonProperty(PropertyName="humidity_condition_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_HumidityConditionType HumidityConditionType { get; set; } = (SizingPeriod_DesignDay_HumidityConditionType)Enum.Parse(typeof(SizingPeriod_DesignDay_HumidityConditionType), "WetBulb");
        

        [Description("Wetbulb or dewpoint temperature coincident with the maximum temperature. Required" +
                     " only if field Humidity Condition Type is \"Wetbulb\", \"Dewpoint\", \"WetBulbProfile" +
                     "MultiplierSchedule\", \"WetBulbProfileDifferenceSchedule\", or \"WetBulbProfileDefau" +
                     "ltMultipliers\"")]
        [JsonProperty(PropertyName="wetbulb_or_dewpoint_at_maximum_dry_bulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WetbulbOrDewpointAtMaximumDryBulb { get; set; } = null;
        

        [Description(@"Only used when Humidity Condition Type is ""RelativeHumiditySchedule"", ""WetBulbProfileMultiplierSchedule"", or ""WetBulbProfileDifferenceSchedule"" For type ""RelativeHumiditySchedule"", the hour/time interval values should specify relative humidity (percent) from 0.0 to 100.0. For type ""WetBulbProfileMultiplierSchedule"" the hour/time interval values should specify the fraction (0-1) of the wet-bulb temperature range to be subtracted from the maximum wet-bulb temperature for each timestep in the day (units = Fraction) For type ""WetBulbProfileDifferenceSchedule"" the values should specify a number to be subtracted from the maximum wet-bulb temperature for each timestep in the day. (units = deltaC)")]
        [JsonProperty(PropertyName="humidity_condition_day_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidityConditionDayScheduleName { get; set; } = "";
        

        [Description("Humidity ratio coincident with the maximum temperature (constant humidity ratio t" +
                     "hroughout day). Required only if field Humidity Condition Type is \"HumidityRatio" +
                     "\".")]
        [JsonProperty(PropertyName="humidity_ratio_at_maximum_dry_bulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioAtMaximumDryBulb { get; set; } = null;
        

        [Description("Enthalpy coincident with the maximum temperature. Required only if field Humidity" +
                     " Condition Type is \"Enthalpy\".")]
        [JsonProperty(PropertyName="enthalpy_at_maximum_dry_bulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EnthalpyAtMaximumDryBulb { get; set; } = null;
        

        [Description("Required only if Humidity Condition Type = \"WetbulbProfileMultiplierSchedule\" or " +
                     "\"WetBulbProfileDefaultMultipliers\"")]
        [JsonProperty(PropertyName="daily_wet_bulb_temperature_range", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DailyWetBulbTemperatureRange { get; set; } = null;
        

        [Description("This field\'s value is also checked against the calculated \"standard barometric pr" +
                     "essure\" for the location. If out of range (>10%) or blank, then is replaced by s" +
                     "tandard value.")]
        [JsonProperty(PropertyName="barometric_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BarometricPressure { get; set; } = null;
        

        [JsonProperty(PropertyName="wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSpeed { get; set; } = null;
        

        [Description("North=0.0 East=90.0 0 and 360 are the same direction.")]
        [JsonProperty(PropertyName="wind_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection { get; set; } = null;
        

        [Description("Yes is raining (all day), No is not raining")]
        [JsonProperty(PropertyName="rain_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes RainIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Yes is Snow on Ground, No is no Snow on Ground")]
        [JsonProperty(PropertyName="snow_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SnowIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Yes -- use schedules modified for Daylight Saving Time Schedules. No - do not use" +
                     " schedules modified for Daylight Saving Time Schedules")]
        [JsonProperty(PropertyName="daylight_saving_time_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DaylightSavingTimeIndicator { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="solar_model_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_SolarModelIndicator SolarModelIndicator { get; set; } = (SizingPeriod_DesignDay_SolarModelIndicator)Enum.Parse(typeof(SizingPeriod_DesignDay_SolarModelIndicator), "ASHRAEClearSky");
        

        [Description("if Solar Model Indicator = Schedule, then beam schedule name (for day)")]
        [JsonProperty(PropertyName="beam_solar_day_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BeamSolarDayScheduleName { get; set; } = "";
        

        [Description("if Solar Model Indicator = Schedule, then diffuse schedule name (for day)")]
        [JsonProperty(PropertyName="diffuse_solar_day_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DiffuseSolarDayScheduleName { get; set; } = "";
        

        [Description("Required if Solar Model Indicator = ASHRAETau or ASHRAETau2017 ASHRAETau2017 sola" +
                     "r model can be used with 2013 and 2017 HOF matching taub")]
        [JsonProperty(PropertyName="ashrae_clear_sky_optical_depth_for_beam_irradiance_taub_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AshraeClearSkyOpticalDepthForBeamIrradianceTaub { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Required if Solar Model Indicator = ASHRAETau or ASHRAETau2017 ASHRAETau2017 sola" +
                     "r model can be used with 2013 and 2017 HOF matching taud")]
        [JsonProperty(PropertyName="ashrae_clear_sky_optical_depth_for_diffuse_irradiance_taud_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AshraeClearSkyOpticalDepthForDiffuseIrradianceTaud { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used if Sky Model Indicator = ASHRAEClearSky or ZhangHuang 0.0 is totally unclear" +
                     ", 1.0 is totally clear")]
        [JsonProperty(PropertyName="sky_clearness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkyClearness { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If used this design day will be run with a custom limit on the maximum number of " +
                     "days that are repeated for warmup. Limiting the number of warmup days can improv" +
                     "e run time.")]
        [JsonProperty(PropertyName="maximum_number_warmup_days", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumNumberWarmupDays { get; set; } = null;
        

        [Description("If used this can control if you want the thermal history to be reset at the begin" +
                     "ning of the design day. When using a series of similiar design days, this field " +
                     "can be used to retain warmup state from the previous design day.")]
        [JsonProperty(PropertyName="begin_environment_reset_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_DesignDay_BeginEnvironmentResetMode BeginEnvironmentResetMode { get; set; } = (SizingPeriod_DesignDay_BeginEnvironmentResetMode)Enum.Parse(typeof(SizingPeriod_DesignDay_BeginEnvironmentResetMode), "FullResetAtBeginEnvironment");
    }
}