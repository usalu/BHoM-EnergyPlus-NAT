using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Specify a range of dates and other parameters for a simulation. Multiple run peri" +
                 "ods may be input, but they may not overlap.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RunPeriod : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="begin_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeginMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="begin_day_of_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeginDayOfMonth { get; set; } = null;
        

        [Description("Start year of the simulation, if this field is specified it must agree with the D" +
                     "ay of Week for Start Day If this field is blank, the year will be selected to ma" +
                     "tch the weekday, which is Sunday if not specified")]
        [JsonProperty(PropertyName="begin_year", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeginYear { get; set; } = null;
        

        [JsonProperty(PropertyName="end_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="end_day_of_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndDayOfMonth { get; set; } = null;
        

        [Description("end year of simulation, if specified")]
        [JsonProperty(PropertyName="end_year", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndYear { get; set; } = null;
        

        [Description("=[Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday]; If no year is input," +
                     " this field will default to Sunday If a year is input and this field is blank, t" +
                     "he correct weekday is determined")]
        [JsonProperty(PropertyName="day_of_week_for_start_day", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RunPeriod_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (RunPeriod_DayOfWeekForStartDay)Enum.Parse(typeof(RunPeriod_DayOfWeekForStartDay), "Friday");
        

        [Description("If yes or blank, use holidays as specified on Weatherfile. If no, do not use the " +
                     "holidays specified on the Weatherfile. Note: You can still specify holidays/spec" +
                     "ial days using the RunPeriodControl:SpecialDays object(s).")]
        [JsonProperty(PropertyName="use_weather_file_holidays_and_special_days", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileHolidaysAndSpecialDays { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
                     "o not use the daylight saving period as specified on the Weatherfile.")]
        [JsonProperty(PropertyName="use_weather_file_daylight_saving_period", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("if yes and single day holiday falls on weekend, \"holiday\" occurs on following Mon" +
                     "day")]
        [JsonProperty(PropertyName="apply_weekend_holiday_rule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ApplyWeekendHolidayRule { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="use_weather_file_rain_indicators", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileRainIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty(PropertyName="use_weather_file_snow_indicators", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty(PropertyName="treat_weather_as_actual", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes TreatWeatherAsActual { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}