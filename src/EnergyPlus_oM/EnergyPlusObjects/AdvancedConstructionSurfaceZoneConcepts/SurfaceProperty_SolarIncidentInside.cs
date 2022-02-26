using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to provide incident solar radiation on the inside of the surface. Reference " +
                 "surface-construction pair and if that pair is used in a simulation, then program" +
                 " will use value provided in schedule instead of calculating it.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_SolarIncidentInside : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty(PropertyName="inside_surface_incident_sun_solar_radiation_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsideSurfaceIncidentSunSolarRadiationScheduleName { get; set; } = "";
    }
}