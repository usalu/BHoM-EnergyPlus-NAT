using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("A non-recurring cost happens only once during the study period. For costs that oc" +
                 "cur more than once during the study period on a regular schedule, use the LifeCy" +
                 "cleCost:RecurringCost object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class LifeCycleCost_NonrecurringCost : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="category", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_NonrecurringCost_Category Category { get; set; } = (LifeCycleCost_NonrecurringCost_Category)Enum.Parse(typeof(LifeCycleCost_NonrecurringCost_Category), "Construction");
        

        [Description(@"Enter the non-recurring cost value. For construction and other capital costs the value entered is typically a positive value. For salvage costs the value entered is typically a negative value which represents the money paid to the investor for the equipment at the end of the study period.")]
        [JsonProperty(PropertyName="cost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Cost { get; set; } = null;
        

        [Description("Enter when the costs start. The First Year of Cost is based on the number of year" +
                     "s past the Start of Costs. For most non-recurring costs the Start of Costs shoul" +
                     "d be Base Period which begins at the base month and year.")]
        [JsonProperty(PropertyName="start_of_costs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_NonrecurringCost_StartOfCosts StartOfCosts { get; set; } = (LifeCycleCost_NonrecurringCost_StartOfCosts)Enum.Parse(typeof(LifeCycleCost_NonrecurringCost_StartOfCosts), "ServicePeriod");
        

        [Description(@"This field and the Months From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Cost field) that the costs start to occur. Only integers should be entered representing whole years.")]
        [JsonProperty(PropertyName="years_from_start", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YearsFromStart { get; set; } = null;
        

        [Description(@"This field and the Years From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Cost field) that the costs start to occur. Only integers should be entered representing whole months. The Years From Start (times 12) and Months From Start are added together.")]
        [JsonProperty(PropertyName="months_from_start", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MonthsFromStart { get; set; } = null;
    }
}