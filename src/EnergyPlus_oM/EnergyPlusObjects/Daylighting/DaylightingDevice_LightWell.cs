using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Applies only to exterior windows in daylighting-controlled zones or in zones that" +
                 " share an interior window with a daylighting-controlled  zone. Generally used wi" +
                 "th skylights.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_LightWell : BHoMObject
    {
        

        [JsonProperty(PropertyName="exterior_window_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExteriorWindowName { get; set; } = "";
        

        [Description("Distance from Bottom of Window to Bottom of Well")]
        [JsonProperty(PropertyName="height_of_well", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightOfWell { get; set; } = null;
        

        [JsonProperty(PropertyName="perimeter_of_bottom_of_well", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PerimeterOfBottomOfWell { get; set; } = null;
        

        [JsonProperty(PropertyName="area_of_bottom_of_well", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AreaOfBottomOfWell { get; set; } = null;
        

        [JsonProperty(PropertyName="visible_reflectance_of_well_walls", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleReflectanceOfWellWalls { get; set; } = null;
    }
}