using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("If this object is not defined for a shading surface the default values listed in " +
                 "following fields will be used in the solar reflection calculation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ShadingProperty_Reflectance : BHoMObject
    {
        

        [JsonProperty(PropertyName="shading_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShadingSurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="diffuse_solar_reflectance_of_unglazed_part_of_shading_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiffuseSolarReflectanceOfUnglazedPartOfShadingSurface { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="diffuse_visible_reflectance_of_unglazed_part_of_shading_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiffuseVisibleReflectanceOfUnglazedPartOfShadingSurface { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_of_shading_surface_that_is_glazed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfShadingSurfaceThatIsGlazed { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Required if Fraction of Shading Surface That Is Glazed > 0.0")]
        [JsonProperty(PropertyName="glazing_construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GlazingConstructionName { get; set; } = "";
    }
}