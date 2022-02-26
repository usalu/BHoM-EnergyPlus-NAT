using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"Used to allow comparing the current cost estimate to the results of a previous estimate for a reference building. This object parallels the ComponentCost:Adjustments object but adds a field for entering the cost line item model result for the reference building. The factors entered in this object are applied to the reference building while the factors listed in the ComponentCost:Adjustments object are applied to the current building model cost estimate.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ComponentCost_Reference : BHoMObject
    {
        

        [Description("should be comparable to the components in current line item cost model")]
        [JsonProperty(PropertyName="reference_building_line_item_costs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingLineItemCosts { get; set; } = null;
        

        [Description("based on conditioned floor area for cost not accounted for in reference line item" +
                     " costs")]
        [JsonProperty(PropertyName="reference_building_miscellaneous_cost_per_conditioned_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingMiscellaneousCostPerConditionedArea { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_building_design_and_engineering_fees", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingDesignAndEngineeringFees { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_building_contractor_fee", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingContractorFee { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_building_contingency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingContingency { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_building_permits_bonding_and_insurance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingPermitsBondingAndInsurance { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_building_commissioning_fee", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingCommissioningFee { get; set; } = null;
        

        [Description("for use with average data in line item and Misc cost models")]
        [JsonProperty(PropertyName="reference_building_regional_adjustment_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBuildingRegionalAdjustmentFactor { get; set; } = null;
    }
}