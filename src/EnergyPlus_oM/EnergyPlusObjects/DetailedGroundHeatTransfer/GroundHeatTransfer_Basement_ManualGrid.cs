using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Manual Grid only necessary using manual gridding (not recommended)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_ManualGrid : BHoMObject
    {
        

        [JsonProperty(PropertyName="nx_number_of_cells_in_the_x_direction_20_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NxNumberOfCellsInTheXDirection20 { get; set; } = null;
        

        [JsonProperty(PropertyName="ny_number_of_cells_in_the_y_direction_20_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NyNumberOfCellsInTheYDirection20 { get; set; } = null;
        

        [JsonProperty(PropertyName="nzag_number_of_cells_in_the_z_direction_above_grade_4_always_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NzagNumberOfCellsInTheZDirectionAboveGrade4Always { get; set; } = null;
        

        [JsonProperty(PropertyName="nzbg_number_of_cells_in_z_direction_below_grade_10_35_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NzbgNumberOfCellsInZDirectionBelowGrade1035 { get; set; } = null;
        

        [JsonProperty(PropertyName="ibase_x_direction_cell_indicator_of_slab_edge_5_20_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IbaseXDirectionCellIndicatorOfSlabEdge520 { get; set; } = null;
        

        [JsonProperty(PropertyName="jbase_y_direction_cell_indicator_of_slab_edge_5_20_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JbaseYDirectionCellIndicatorOfSlabEdge520 { get; set; } = null;
        

        [JsonProperty(PropertyName="kbase_z_direction_cell_indicator_of_the_top_of_the_floor_slab_5_20_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> KbaseZDirectionCellIndicatorOfTheTopOfTheFloorSlab520 { get; set; } = null;
    }
}