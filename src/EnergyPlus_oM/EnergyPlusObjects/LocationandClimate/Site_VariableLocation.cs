using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Captures the scheduling of a moving/reorienting building, or more likely a vessel" +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_VariableLocation : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The name of a schedule that defines the latitude of the building at any time. If " +
                     "not entered, the latitude defined in the Site:Location, or the default latitude," +
                     " will be used for the entirety of the simulation")]
        [JsonProperty(PropertyName="building_location_latitude_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingLocationLatitudeSchedule { get; set; } = "";
        

        [Description("The name of a schedule that defines the longitude of the building at any time. If" +
                     " not entered, the longitude defined in the Site:Location, or the default longitu" +
                     "de, will be used for the entirety of the simulation")]
        [JsonProperty(PropertyName="building_location_longitude_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingLocationLongitudeSchedule { get; set; } = "";
        

        [Description(@"The name of a schedule that defines the orientation of the building at any time. This orientation is based on a change from the original orientation. -- NEED TO REFINE THIS If not entered, the original orientation will be used for the entirety of the simulation")]
        [JsonProperty(PropertyName="building_location_orientation_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingLocationOrientationSchedule { get; set; } = "";
    }
}