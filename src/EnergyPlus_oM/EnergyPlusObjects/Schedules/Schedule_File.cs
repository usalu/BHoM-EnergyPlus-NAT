using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:File points to a text computer file that has 8760-8784 hours of data.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_File : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_type_limits_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleTypeLimitsName { get; set; } = "";
        

        [JsonProperty(PropertyName="file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; } = "";
        

        [JsonProperty(PropertyName="column_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColumnNumber { get; set; } = null;
        

        [JsonProperty(PropertyName="rows_to_skip_at_top", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RowsToSkipAtTop { get; set; } = null;
        

        [Description("8760 hours does not account for leap years, 8784 does. should be either 8760 or 8" +
                     "784")]
        [JsonProperty(PropertyName="number_of_hours_of_data", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfHoursOfData { get; set; } = Double.Parse("8760", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="column_separator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Schedule_File_ColumnSeparator ColumnSeparator { get; set; } = (Schedule_File_ColumnSeparator)Enum.Parse(typeof(Schedule_File_ColumnSeparator), "Comma");
        

        [Description(@"when the interval does not match the user specified timestep a ""Yes"" choice will average between the intervals request (to timestep resolution. a ""No"" choice will use the interval value at the simulation timestep without regard to if it matches the boundary or not.")]
        [JsonProperty(PropertyName="interpolate_to_timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes InterpolateToTimestep { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Must be evenly divisible into 60")]
        [JsonProperty(PropertyName="minutes_per_item", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinutesPerItem { get; set; } = null;
    }
}