using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_Controls_ControlData_Item
    {
        

        [JsonProperty(PropertyName="daylighting_reference_point_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DaylightingReferencePointName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_zone_controlled_by_reference_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfZoneControlledByReferencePoint { get; set; } = null;
        

        [JsonProperty(PropertyName="illuminance_setpoint_at_reference_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IlluminanceSetpointAtReferencePoint { get; set; } = null;
    }
}