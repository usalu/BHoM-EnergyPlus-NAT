using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Used to describe the amount of water precipitation at the building site. Precipit" +
                 "ation includes both rain and the equivalent water content of snow.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_Precipitation : BHoMObject
    {
        

        [JsonProperty(PropertyName="precipitation_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_Precipitation_PrecipitationModelType PrecipitationModelType { get; set; } = (Site_Precipitation_PrecipitationModelType)Enum.Parse(typeof(Site_Precipitation_PrecipitationModelType), "ScheduleAndDesignLevel");
        

        [Description("meters of water per year used for design level")]
        [JsonProperty(PropertyName="design_level_for_total_annual_precipitation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignLevelForTotalAnnualPrecipitation { get; set; } = null;
        

        [Description("Schedule values in meters of water per hour values should be non-negative")]
        [JsonProperty(PropertyName="precipitation_rates_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrecipitationRatesScheduleName { get; set; } = "";
        

        [Description("meters of water per year from average weather statistics")]
        [JsonProperty(PropertyName="average_total_annual_precipitation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageTotalAnnualPrecipitation { get; set; } = null;
    }
}