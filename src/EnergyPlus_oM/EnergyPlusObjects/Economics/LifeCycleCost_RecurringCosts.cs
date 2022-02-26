using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Recurring costs are costs that repeat over time on a regular schedule during the " +
                 "study period. If costs associated with equipment do repeat but not on a regular " +
                 "schedule, use LifeCycleCost:NonrecurringCost objects instead.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class LifeCycleCost_RecurringCosts : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="category", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_RecurringCosts_Category Category { get; set; } = (LifeCycleCost_RecurringCosts_Category)Enum.Parse(typeof(LifeCycleCost_RecurringCosts_Category), "Maintenance");
        

        [Description("Enter the cost in dollars (or the appropriate monetary unit) for the recurring co" +
                     "sts. Enter the cost for each time it occurs. For example if the annual maintenan" +
                     "ce cost is 500 dollars enter 500 here.")]
        [JsonProperty(PropertyName="cost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Cost { get; set; } = null;
        

        [Description("Enter when the costs start. The First Year of Cost is based on the number of year" +
                     "s past the Start of Costs. For most maintenance costs the Start of Costs should " +
                     "be Service Period.")]
        [JsonProperty(PropertyName="start_of_costs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LifeCycleCost_RecurringCosts_StartOfCosts StartOfCosts { get; set; } = (LifeCycleCost_RecurringCosts_StartOfCosts)Enum.Parse(typeof(LifeCycleCost_RecurringCosts_StartOfCosts), "ServicePeriod");
        

        [Description(@"This field and the Months From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Costs field) that the costs start to occur. Only integers should be entered representing whole years.")]
        [JsonProperty(PropertyName="years_from_start", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YearsFromStart { get; set; } = null;
        

        [Description(@"This field and the Years From Start field together represent the time from either the start of the Service Period on the service month and year or start of the Base Period on the base month and year (depending on the Start of Costs field) that the costs start to occur. Only integers should be entered representing whole months. The Years From Start (times 12) and Months From Start are added together.")]
        [JsonProperty(PropertyName="months_from_start", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MonthsFromStart { get; set; } = null;
        

        [Description(@"This field and the Repeat Period Months field indicate how much time elapses between re-occurrences of the cost. For costs that occur every year such the Repeat Period Years should be 1 and Repeat Period Months should be 0. Only integers should be entered representing whole years.")]
        [JsonProperty(PropertyName="repeat_period_years", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RepeatPeriodYears { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field and the Repeat Period Years field indicate how much time elapses betwe" +
                     "en re-occurrences of the cost. Only integers should be entered representing whol" +
                     "e years. The Repeat Period Years (times 12) and Repeat Period Months are added t" +
                     "ogether.")]
        [JsonProperty(PropertyName="repeat_period_months", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RepeatPeriodMonths { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the annual escalation rate as a decimal. For a 1% rate enter the value 0.01" +
                     ". This input is used when the Inflation Approach is CurrentDollar. When Inflatio" +
                     "n Approach is set to ConstantDollar this input is ignored.")]
        [JsonProperty(PropertyName="annual_escalation_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AnnualEscalationRate { get; set; } = null;
    }
}