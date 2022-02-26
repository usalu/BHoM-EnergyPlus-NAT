using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("AutoGrid only necessary when EquivalentSlab option not chosen. Not normally neede" +
                 "d by EnergyPlus users. This object permits user selection of rectangular slab di" +
                 "mensions. NO SLAB DIMENSIONS LESS THAN 6 m.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_AutoGrid : BHoMObject
    {
        

        [Description("typical values= 6 to 60.0")]
        [JsonProperty(PropertyName="slabx_x_dimension_of_the_building_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabxXDimensionOfTheBuildingSlab { get; set; } = null;
        

        [Description("typical values= 6 to 60.0")]
        [JsonProperty(PropertyName="slaby_y_dimension_of_the_building_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabyYDimensionOfTheBuildingSlab { get; set; } = null;
        

        [JsonProperty(PropertyName="slabdepth_thickness_of_slab_on_grade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabdepthThicknessOfSlabOnGrade { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="clearance_distance_from_edge_of_slab_to_domain_edge", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ClearanceDistanceFromEdgeOfSlabToDomainEdge { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zclearance_distance_from_bottom_of_slab_to_domain_bottom", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZclearanceDistanceFromBottomOfSlabToDomainBottom { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
    }
}