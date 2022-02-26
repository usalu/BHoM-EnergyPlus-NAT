using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Object gives an overall description of the slab ground heat transfer model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_Materials : BHoMObject
    {
        

        [Description("This field specifies the number of different materials that will be used in the m" +
                     "odel. Typically only a ground material and a slab material are used. (2 material" +
                     "s)")]
        [JsonProperty(PropertyName="nmat_number_of_materials", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NmatNumberOfMaterials { get; set; } = null;
        

        [Description(@"Two fields specify the albedo value of the surface: first for no snow coverage days; second for days with snow coverage. The albedo is the solar reflectivity of the surface, and can vary from 0.05 for blacktop to 0.95 for fresh snow. Typical values for North America reported by Bahnfleth range from 0.16 to 0.4.")]
        [JsonProperty(PropertyName="albedo_surface_albedo_no_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AlbedoSurfaceAlbedoNoSnow { get; set; } = Double.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="albedo_surface_albedo_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AlbedoSurfaceAlbedoSnow { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description("EPSLW (No Snow and Snow) specifies the long wavelength (thermal) emissivity of th" +
                     "e ground surface. primarily important for nighttime radiation to sky. typical va" +
                     "lue .95")]
        [JsonProperty(PropertyName="epslw_surface_emissivity_no_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EpslwSurfaceEmissivityNoSnow { get; set; } = Double.Parse("0.94", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="epslw_surface_emissivity_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EpslwSurfaceEmissivitySnow { get; set; } = Double.Parse("0.86", CultureInfo.InvariantCulture);
        

        [Description("fields Z0 (No Snow and Snow) describe the height at which an experimentally veloc" +
                     "ity profile goes to zero. typical value= .75 cm")]
        [JsonProperty(PropertyName="z0_surface_roughness_no_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Z0SurfaceRoughnessNoSnow { get; set; } = Double.Parse("0.75", CultureInfo.InvariantCulture);
        

        [Description("typical value= .05 cm")]
        [JsonProperty(PropertyName="z0_surface_roughness_snow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Z0SurfaceRoughnessSnow { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [Description(@"These fields specify the combined convective and radiative heat transfer coefficient between the slab top inside surface and the room air for the cases where heat is flowing downward, and upward. The program toggles between the two if the direction of the heat flux changes. Typical values can be found in the ASHRAE Handbook of Fundamentals, but should be about 6 W/(m2-K) for downward heat flow and 9 W/(m2-K) for upward heat flow. typical value= 4-10")]
        [JsonProperty(PropertyName="hin_indoor_hconv_downward_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinIndoorHconvDownwardFlow { get; set; } = Double.Parse("6.13", CultureInfo.InvariantCulture);
        

        [Description("typical value= 4-10")]
        [JsonProperty(PropertyName="hin_indoor_hconv_upward", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinIndoorHconvUpward { get; set; } = Double.Parse("9.26", CultureInfo.InvariantCulture);
    }
}