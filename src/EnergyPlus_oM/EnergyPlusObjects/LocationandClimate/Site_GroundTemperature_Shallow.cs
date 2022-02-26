using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("These temperatures are specifically for the Surface Ground Heat Exchanger and sho" +
                 "uld probably be close to the average outdoor air temperature for the location. T" +
                 "hey are not used in other models.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Shallow : BHoMObject
    {
        

        [JsonProperty(PropertyName="january_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuarySurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="february_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruarySurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="march_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="april_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="may_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaySurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="june_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="july_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulySurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="august_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="september_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="october_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="november_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="december_surface_ground_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberSurfaceGroundTemperature { get; set; } = Double.Parse("13", CultureInfo.InvariantCulture);
    }
}