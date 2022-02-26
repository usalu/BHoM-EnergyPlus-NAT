using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object defines the local environment properties of an exterior surface. One " +
                 "or more environment properties have to be defined and linked to the exterior sur" +
                 "face.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_LocalEnvironment : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of an exterior surface object")]
        [JsonProperty(PropertyName="exterior_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExteriorSurfaceName { get; set; } = "";
        

        [Description("Enter the name of a Schedule object")]
        [JsonProperty(PropertyName="external_shading_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalShadingFractionScheduleName { get; set; } = "";
        

        [Description("Enter the name of a SurfaceProperty:SurroundingSurfaces object")]
        [JsonProperty(PropertyName="surrounding_surfaces_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurroundingSurfacesObjectName { get; set; } = "";
        

        [Description("Enter the name of an OutdoorAir:Node object")]
        [JsonProperty(PropertyName="outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirNodeName { get; set; } = "";
    }
}