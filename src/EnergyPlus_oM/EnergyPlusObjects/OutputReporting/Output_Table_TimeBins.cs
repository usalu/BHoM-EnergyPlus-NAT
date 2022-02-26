using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Produces a bin report in the table output file which shows the amount of time in " +
                 "hours that occurs in different bins for a single specific output variable or met" +
                 "er. Two different types of binning are reported: by month and by hour of the day" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Table_TimeBins : BHoMObject
    {
        

        [Description("use \'*\' (without quotes) to apply this variable to all keys")]
        [JsonProperty(PropertyName="key_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KeyValue { get; set; } = "*";
        

        [JsonProperty(PropertyName="variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VariableName { get; set; } = "";
        

        [Description("The lowest value for the intervals being binned into.")]
        [JsonProperty(PropertyName="interval_start", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IntervalStart { get; set; } = null;
        

        [Description("The size of the bins starting with Interval start.")]
        [JsonProperty(PropertyName="interval_size", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IntervalSize { get; set; } = null;
        

        [Description("The number of bins used. The number of hours below the start of the Lowest bin an" +
                     "d above the value of the last bin are also shown.")]
        [JsonProperty(PropertyName="interval_count", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IntervalCount { get; set; } = null;
        

        [Description("Optional schedule name. Binning is performed for non-zero hours. Binning always p" +
                     "erformed if left blank.")]
        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description("Optional input on the type of units for the variable used by other fields in the " +
                     "object.")]
        [JsonProperty(PropertyName="variable_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Table_TimeBins_VariableType VariableType { get; set; } = (Output_Table_TimeBins_VariableType)Enum.Parse(typeof(Output_Table_TimeBins_VariableType), "Energy");
    }
}