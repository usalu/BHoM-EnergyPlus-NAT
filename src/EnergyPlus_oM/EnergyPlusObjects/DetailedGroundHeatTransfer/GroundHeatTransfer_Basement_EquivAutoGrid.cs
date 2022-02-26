using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("EquivAutoGrid necessary when EquivSizing=TRUE, TRUE is is the normal case.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_EquivAutoGrid : BHoMObject
    {
        

        [JsonProperty(PropertyName="clearance_distance_from_outside_of_wall_to_edge_of_3_d_ground_domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ClearanceDistanceFromOutsideOfWallToEdgeOf3DGroundDomain { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slabdepth_thickness_of_the_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabdepthThicknessOfTheFloorSlab { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="basedepth_depth_of_the_basement_wall_below_grade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasedepthDepthOfTheBasementWallBelowGrade { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
    }
}