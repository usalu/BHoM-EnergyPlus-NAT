using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("This object should only be used for non-standard weather data. Standard weather d" +
                 "ata such as TMY2, IWEC, and ASHRAE design day data are all measured at the defau" +
                 "lt conditions and do not require this object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_WeatherStation : BHoMObject
    {
        

        [JsonProperty(PropertyName="wind_sensor_height_above_ground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSensorHeightAboveGround { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="wind_speed_profile_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSpeedProfileExponent { get; set; } = Double.Parse("0.14", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="wind_speed_profile_boundary_layer_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSpeedProfileBoundaryLayerThickness { get; set; } = Double.Parse("270", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="air_temperature_sensor_height_above_ground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirTemperatureSensorHeightAboveGround { get; set; } = Double.Parse("1.5", CultureInfo.InvariantCulture);
    }
}