using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Use a weather file period for design sizing calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SizingPeriod_WeatherFileDays : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="begin_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeginMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="begin_day_of_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeginDayOfMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="end_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndMonth { get; set; } = null;
        

        [JsonProperty(PropertyName="end_day_of_month", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EndDayOfMonth { get; set; } = null;
        

        [Description(@"=[|Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|SummerDesignDay|WinterDesignDay| |CustomDay1|CustomDay2]; if you use SummerDesignDay or WinterDesignDay or the CustomDays then this will apply to the whole period; other days (i.e., Monday) will signify a start day and normal sequence of subsequent days")]
        [JsonProperty(PropertyName="day_of_week_for_start_day", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SizingPeriod_WeatherFileDays_DayOfWeekForStartDay DayOfWeekForStartDay { get; set; } = (SizingPeriod_WeatherFileDays_DayOfWeekForStartDay)Enum.Parse(typeof(SizingPeriod_WeatherFileDays_DayOfWeekForStartDay), "Monday");
        

        [Description("If yes or blank, use daylight saving period as specified on Weatherfile. If no, d" +
                     "o not use the daylight saving period as specified on the Weatherfile.")]
        [JsonProperty(PropertyName="use_weather_file_daylight_saving_period", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileDaylightSavingPeriod { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty(PropertyName="use_weather_file_rain_and_snow_indicators", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileRainAndSnowIndicators { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}