using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("These temperatures are specifically for underground walls and ground floors defin" +
                 "ed with the C-factor and F-factor methods, and should be close to the monthly av" +
                 "erage outdoor air temperature delayed by 3 months for the location.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_FCfactorMethod : BHoMObject
    {
        

        [JsonProperty(PropertyName="january_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuaryGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="february_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruaryGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="march_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="april_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="may_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MayGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="june_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="july_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulyGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="august_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="september_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="october_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="november_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="december_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
    }
}