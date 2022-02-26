using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_WalkIn_ZoneData_Item
    {
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="total_insulated_surface_area_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalInsulatedSurfaceAreaFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="insulated_surface_u_value_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsulatedSurfaceUValueFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="area_of_glass_reach_in_doors_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AreaOfGlassReachInDoorsFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="height_of_glass_reach_in_doors_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightOfGlassReachInDoorsFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="glass_reach_in_door_u_value_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GlassReachInDoorUValueFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="glass_reach_in_door_opening_schedule_name_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GlassReachInDoorOpeningScheduleNameFacingZone { get; set; } = "";
        

        [JsonProperty(PropertyName="area_of_stocking_doors_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AreaOfStockingDoorsFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="height_of_stocking_doors_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightOfStockingDoorsFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="stocking_door_u_value_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StockingDoorUValueFacingZone { get; set; } = null;
        

        [JsonProperty(PropertyName="stocking_door_opening_schedule_name_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StockingDoorOpeningScheduleNameFacingZone { get; set; } = "";
        

        [JsonProperty(PropertyName="stocking_door_opening_protection_type_facing_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StockingDoorOpeningProtectionTypeFacingZone { get; set; } = "";
    }
}