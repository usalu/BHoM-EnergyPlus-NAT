using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("ComBldg contains the monthly average temperatures (C) and possibility of daily va" +
                 "riation amplitude")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_ComBldg : BHoMObject
    {
        

        [JsonProperty(PropertyName="january_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuaryAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="february_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruaryAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="march_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="april_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="may_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MayAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="june_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="july_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulyAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="august_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="september_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="october_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="november_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="december_average_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberAverageTemperature { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("(Normally zero, just for checking)")]
        [JsonProperty(PropertyName="daily_variation_sine_wave_amplitude", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DailyVariationSineWaveAmplitude { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}