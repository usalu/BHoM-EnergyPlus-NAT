using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Fins are usually shading surfaces that are perpendicular to a window or door.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Shading_Fin_Projection : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="window_or_door_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowOrDoorName { get; set; } = "";
        

        [JsonProperty(PropertyName="left_extension_from_window_door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftExtensionFromWindowDoor { get; set; } = null;
        

        [JsonProperty(PropertyName="left_distance_above_top_of_window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftDistanceAboveTopOfWindow { get; set; } = null;
        

        [Description("N2 + N3 + height of Window/Door is height of Fin")]
        [JsonProperty(PropertyName="left_distance_below_bottom_of_window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftDistanceBelowBottomOfWindow { get; set; } = null;
        

        [JsonProperty(PropertyName="left_tilt_angle_from_window_door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftTiltAngleFromWindowDoor { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="left_depth_as_fraction_of_window_door_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftDepthAsFractionOfWindowDoorWidth { get; set; } = null;
        

        [JsonProperty(PropertyName="right_extension_from_window_door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightExtensionFromWindowDoor { get; set; } = null;
        

        [JsonProperty(PropertyName="right_distance_above_top_of_window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightDistanceAboveTopOfWindow { get; set; } = null;
        

        [Description("N7 + N8 + height of Window/Door is height of Fin")]
        [JsonProperty(PropertyName="right_distance_below_bottom_of_window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightDistanceBelowBottomOfWindow { get; set; } = null;
        

        [JsonProperty(PropertyName="right_tilt_angle_from_window_door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightTiltAngleFromWindowDoor { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="right_depth_as_fraction_of_window_door_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightDepthAsFractionOfWindowDoorWidth { get; set; } = null;
    }
}