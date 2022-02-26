using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Manual Grid only necessary when using manual gridding (not recommended) Used only" +
                 " in special cases when previous two objects are not used. User must input comple" +
                 "te gridding information.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_ManualGrid : BHoMObject
    {
        

        [JsonProperty(PropertyName="nx_number_of_cells_in_the_x_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NxNumberOfCellsInTheXDirection { get; set; } = null;
        

        [JsonProperty(PropertyName="ny_number_of_cells_in_the_y_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NyNumberOfCellsInTheYDirection { get; set; } = null;
        

        [JsonProperty(PropertyName="nz_number_of_cells_in_the_z_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NzNumberOfCellsInTheZDirection { get; set; } = null;
        

        [Description("typical values= 1-10")]
        [JsonProperty(PropertyName="ibox_x_direction_cell_indicator_of_slab_edge", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IboxXDirectionCellIndicatorOfSlabEdge { get; set; } = null;
        

        [Description("typical values= 1-10")]
        [JsonProperty(PropertyName="jbox_y_direction_cell_indicator_of_slab_edge", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> JboxYDirectionCellIndicatorOfSlabEdge { get; set; } = null;
    }
}