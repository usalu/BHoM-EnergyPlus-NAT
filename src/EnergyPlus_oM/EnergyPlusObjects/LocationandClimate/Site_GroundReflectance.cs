using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Specifies the ground reflectance values used to calculate ground reflected solar." +
                 " The ground reflectance can be further modified when snow is on the ground by Si" +
                 "te:GroundReflectance:SnowModifier.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundReflectance : BHoMObject
    {
        

        [JsonProperty(PropertyName="january_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JanuaryGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="february_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FebruaryGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="march_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MarchGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="april_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AprilGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="may_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MayGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="june_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JuneGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="july_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JulyGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="august_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AugustGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="september_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SeptemberGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="october_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OctoberGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="november_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NovemberGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="december_ground_reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DecemberGroundReflectance { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
    }
}