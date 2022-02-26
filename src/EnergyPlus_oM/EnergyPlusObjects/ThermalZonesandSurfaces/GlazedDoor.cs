using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of glass Doors.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GlazedDoor : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("Name of Surface (Wall, usually) the Door is on (i.e., Base Surface) Door assumes " +
                     "the azimuth and tilt angles of the surface it is on.")]
        [JsonProperty(PropertyName="building_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
        [JsonProperty(PropertyName="frame_and_divider_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FrameAndDividerName { get; set; } = "";
        

        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
                     " truncated to integer")]
        [JsonProperty(PropertyName="multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Multiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Door starting coordinate is specified relative to the Base Surface origin.")]
        [JsonProperty(PropertyName="starting_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingXCoordinate { get; set; } = null;
        

        [Description("How far up the wall the Door starts. (in 2-d, this would be a Y Coordinate)")]
        [JsonProperty(PropertyName="starting_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingZCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Length { get; set; } = null;
        

        [JsonProperty(PropertyName="height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Height { get; set; } = null;
    }
}