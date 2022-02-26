using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Used to perform various modifications to the construction costs to arrive at an e" +
                 "stimate for total project costs. This object allows extending the line item mode" +
                 "l so that the overall costs of the project will reflect various profit and fees." +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ComponentCost_Adjustments : BHoMObject
    {
        

        [Description("based on conditioned floor area for cost not accounted for in current line item c" +
                     "ost model")]
        [JsonProperty(PropertyName="miscellaneous_cost_per_conditioned_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MiscellaneousCostPerConditionedArea { get; set; } = null;
        

        [JsonProperty(PropertyName="design_and_engineering_fees", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignAndEngineeringFees { get; set; } = null;
        

        [JsonProperty(PropertyName="contractor_fee", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ContractorFee { get; set; } = null;
        

        [JsonProperty(PropertyName="contingency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Contingency { get; set; } = null;
        

        [JsonProperty(PropertyName="permits_bonding_and_insurance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PermitsBondingAndInsurance { get; set; } = null;
        

        [JsonProperty(PropertyName="commissioning_fee", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CommissioningFee { get; set; } = null;
        

        [Description("for use with average data in line item and Misc cost models")]
        [JsonProperty(PropertyName="regional_adjustment_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RegionalAdjustmentFactor { get; set; } = null;
    }
}