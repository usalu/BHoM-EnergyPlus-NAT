using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Defines a daylighting which can have an inside shelf, an outside shelf, or both. " +
                 "The inside shelf is defined as a building surface and the outside shelf is defin" +
                 "ed as a shading surface.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_Shelf : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="window_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowName { get; set; } = "";
        

        [Description("This must refer to a BuildingSurface:Detailed or equivalent object This surface m" +
                     "ust be its own Surface for other side boundary conditions.")]
        [JsonProperty(PropertyName="inside_shelf_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsideShelfName { get; set; } = "";
        

        [Description("This must refer to a Shading:Zone:Detailed object")]
        [JsonProperty(PropertyName="outside_shelf_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideShelfName { get; set; } = "";
        

        [Description("Required if outside shelf is specified")]
        [JsonProperty(PropertyName="outside_shelf_construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideShelfConstructionName { get; set; } = "";
        

        [JsonProperty(PropertyName="view_factor_to_outside_shelf", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ViewFactorToOutsideShelf { get; set; } = null;
    }
}