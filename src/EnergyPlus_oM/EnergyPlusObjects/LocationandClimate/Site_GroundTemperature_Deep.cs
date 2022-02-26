using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("These temperatures are specifically for the ground heat exchangers that would use" +
                 " \"deep\" (3-4 m depth) ground temperatures for their heat source. They are not us" +
                 "ed in other models.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Deep : BHoMObject
    {
        

        [JsonProperty(PropertyName="january_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuaryDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="february_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruaryDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="march_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="april_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="may_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MayDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="june_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="july_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulyDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="august_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="september_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="october_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="november_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="december_deep_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberDeepGroundTemperature { get; set; } = Double.Parse("16", CultureInfo.InvariantCulture);
    }
}