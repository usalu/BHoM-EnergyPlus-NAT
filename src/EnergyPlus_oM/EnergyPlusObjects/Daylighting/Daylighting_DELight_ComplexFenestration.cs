using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Used for DElight Complex Fenestration of all types")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_DELight_ComplexFenestration : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Used to select the appropriate Complex Fenestration BTDF data")]
        [JsonProperty(PropertyName="complex_fenestration_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComplexFenestrationType { get; set; } = "";
        

        [Description("This is a reference to a valid surface object (such as BuildingSurface:Detailed) " +
                     "hosting this complex fenestration, analogous to the base surface Name field for " +
                     "subsurfaces such as Windows.")]
        [JsonProperty(PropertyName="building_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description("This is a reference to a valid FenestrationSurface:Detailed window object used to" +
                     " account for the geometry, and the solar and thermal gains/losses, of the Comple" +
                     "x Fenestration")]
        [JsonProperty(PropertyName="window_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowName { get; set; } = "";
        

        [Description(@"In-plane counter-clockwise rotation angle of the Complex Fenestration optical reference direction and the base edge of the Complex Fenestration. The Rotation will typically be zero when the host and CFS surfaces are rectangular and height and width edges are aligned.")]
        [JsonProperty(PropertyName="fenestration_rotation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FenestrationRotation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}