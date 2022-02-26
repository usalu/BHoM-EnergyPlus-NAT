using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Used to calculate water mains temperatures delivered by underground water main pi" +
                 "pes. Water mains temperatures are a function of outdoor climate conditions and v" +
                 "ary with time of year.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_WaterMainsTemperature : BHoMObject
    {
        

        [Description("If calculation method is CorrelationFromWeatherFile, the two numeric input fields" +
                     " are ignored. Instead, EnergyPlus calculates them from weather file.")]
        [JsonProperty(PropertyName="calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_WaterMainsTemperature_CalculationMethod CalculationMethod { get; set; } = (Site_WaterMainsTemperature_CalculationMethod)Enum.Parse(typeof(Site_WaterMainsTemperature_CalculationMethod), "CorrelationFromWeatherFile");
        

        [JsonProperty(PropertyName="temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemperatureScheduleName { get; set; } = "";
        

        [Description("If calculation method is CorrelationFromWeatherFile or Schedule, this input field" +
                     " is ignored.")]
        [JsonProperty(PropertyName="annual_average_outdoor_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AnnualAverageOutdoorAirTemperature { get; set; } = null;
        

        [Description("If calculation method is CorrelationFromWeatherFile or Schedule, this input field" +
                     " is ignored.")]
        [JsonProperty(PropertyName="maximum_difference_in_monthly_average_outdoor_air_temperatures", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumDifferenceInMonthlyAverageOutdoorAirTemperatures { get; set; } = null;
    }
}