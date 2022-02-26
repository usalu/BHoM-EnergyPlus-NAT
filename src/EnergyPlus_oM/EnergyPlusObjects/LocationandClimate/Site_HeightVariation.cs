using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"This object is used if the user requires advanced control over height-dependent variations in wind speed and temperature. When this object is not present, the default model for temperature dependence on height is used, and the wind speed is modeled according to the Terrain field of the BUILDING object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_HeightVariation : BHoMObject
    {
        

        [Description("Set to zero for no wind speed dependence on height.")]
        [JsonProperty(PropertyName="wind_speed_profile_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSpeedProfileExponent { get; set; } = Double.Parse("0.22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="wind_speed_profile_boundary_layer_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSpeedProfileBoundaryLayerThickness { get; set; } = Double.Parse("370", CultureInfo.InvariantCulture);
        

        [Description("Set to zero for no air temperature dependence on height.")]
        [JsonProperty(PropertyName="air_temperature_gradient_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirTemperatureGradientCoefficient { get; set; } = Double.Parse("0.0065", CultureInfo.InvariantCulture);
    }
}