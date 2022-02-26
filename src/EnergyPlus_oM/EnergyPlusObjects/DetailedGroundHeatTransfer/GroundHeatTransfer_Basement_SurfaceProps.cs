using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies the soil surface properties for the Basement preprocessor ground heat t" +
                 "ransfer simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_SurfaceProps : BHoMObject
    {
        

        [JsonProperty(PropertyName="albedo_surface_albedo_for_no_snow_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AlbedoSurfaceAlbedoForNoSnowConditions { get; set; } = Double.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="albedo_surface_albedo_for_snow_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AlbedoSurfaceAlbedoForSnowConditions { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="epsln_surface_emissivity_no_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EpslnSurfaceEmissivityNoSnow { get; set; } = Double.Parse("0.94", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="epsln_surface_emissivity_with_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EpslnSurfaceEmissivityWithSnow { get; set; } = Double.Parse("0.86", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="veght_surface_roughness_no_snow_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VeghtSurfaceRoughnessNoSnowConditions { get; set; } = Double.Parse("6", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="veght_surface_roughness_snow_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VeghtSurfaceRoughnessSnowConditions { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [Description("Typically, PET is False")]
        [JsonProperty(PropertyName="pet_flag_potential_evapotranspiration_on_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn PetFlagPotentialEvapotranspirationOn { get; set; } = (GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn)Enum.Parse(typeof(GroundHeatTransfer_Basement_SurfaceProps_PetFlagPotentialEvapotranspirationOn), "FALSE");
    }
}