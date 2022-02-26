using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies the surface and gravel thicknesses used for the Basement preprocessor g" +
                 "round heat transfer simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_BldgData : BHoMObject
    {
        

        [JsonProperty(PropertyName="dwall_wall_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DwallWallThickness { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dslab_floor_slab_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DslabFloorSlabThickness { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dgravxy_width_of_gravel_pit_beside_basement_wall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DgravxyWidthOfGravelPitBesideBasementWall { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dgravzn_gravel_depth_extending_above_the_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DgravznGravelDepthExtendingAboveTheFloorSlab { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dgravzp_gravel_depth_below_the_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DgravzpGravelDepthBelowTheFloorSlab { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
    }
}