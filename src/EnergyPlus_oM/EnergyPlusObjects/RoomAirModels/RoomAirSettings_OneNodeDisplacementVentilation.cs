using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("The Mundt model for displacement ventilation")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAirSettings_OneNodeDisplacementVentilation : BHoMObject
    {
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_convective_internal_loads_added_to_floor_air", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfConvectiveInternalLoadsAddedToFloorAir { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_of_infiltration_internal_loads_added_to_floor_air", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfInfiltrationInternalLoadsAddedToFloorAir { get; set; } = null;
    }
}