using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"These temperatures are specifically for those surfaces that have the outside environment of ""Ground"". Documentation about what values these should be is located in the Auxiliary programs document (Ground Heat Transfer) as well as the InputOutput Reference. CAUTION - Do not use the ""undisturbed"" ground temperatures from the weather data. These values are too extreme for the soil under a conditioned building. For best results, use the Slab or Basement program to calculate custom monthly average ground temperatures (see Auxiliary Programs). For typical commercial buildings in the USA, a reasonable default value is 2C less than the average indoor space temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_BuildingSurface : BHoMObject
    {
        

        [JsonProperty(PropertyName="january_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuaryGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="february_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruaryGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="march_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="april_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="may_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MayGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="june_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="july_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulyGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="august_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="september_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="october_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="november_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="december_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberGroundTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
    }
}