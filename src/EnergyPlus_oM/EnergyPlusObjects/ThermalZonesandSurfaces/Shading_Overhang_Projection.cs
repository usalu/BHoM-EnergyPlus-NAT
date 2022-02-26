using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Overhangs are typically flat shading surfaces that reference a window or door.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Shading_Overhang_Projection : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="window_or_door_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowOrDoorName { get; set; } = "";
        

        [JsonProperty(PropertyName="height_above_window_or_door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightAboveWindowOrDoor { get; set; } = null;
        

        [JsonProperty(PropertyName="tilt_angle_from_window_door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TiltAngleFromWindowDoor { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="left_extension_from_window_door_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeftExtensionFromWindowDoorWidth { get; set; } = null;
        

        [Description("N3 + N4 + Window/Door Width is Overhang Length")]
        [JsonProperty(PropertyName="right_extension_from_window_door_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RightExtensionFromWindowDoorWidth { get; set; } = null;
        

        [JsonProperty(PropertyName="depth_as_fraction_of_window_door_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DepthAsFractionOfWindowDoorHeight { get; set; } = null;
    }
}