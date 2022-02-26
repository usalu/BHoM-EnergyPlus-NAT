using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to provide advanced thermal comfort control of window opening" +
                 " and closing for both exterior and interior windows.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_OccupantVentilationControl : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_opening_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOpeningTime { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_closing_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumClosingTime { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Enter a curve name that represents thermal comfort temperature as a function of outdoor dry-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. The following two fields are used if two curves are required.")]
        [JsonProperty(PropertyName="thermal_comfort_low_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalComfortLowTemperatureCurveName { get; set; } = "";
        

        [Description("This point is used to allow separate low and high thermal comfort temperature cur" +
                     "ves. If a single performance curve is used, leave this field blank.")]
        [JsonProperty(PropertyName="thermal_comfort_temperature_boundary_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalComfortTemperatureBoundaryPoint { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description(@"Enter a curve name that represents thermal comfort temperature as a function of outdoor dry-bulb temperature. Up to two curves are allowed if the performance cannot be represented by a single curve. If a single performance curve is used, leave this field blank.")]
        [JsonProperty(PropertyName="thermal_comfort_high_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalComfortHighTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_threshold_for_persons_dissatisfied_ppd", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumThresholdForPersonsDissatisfiedPpd { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("If Yes, occupancy check will be performed as part of the opening probability chec" +
                     "k.")]
        [JsonProperty(PropertyName="occupancy_check", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes OccupancyCheck { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("If this field is blank, the opening probability check is bypassed and opening is " +
                     "true.")]
        [JsonProperty(PropertyName="opening_probability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OpeningProbabilityScheduleName { get; set; } = "";
        

        [Description("If this field is blank, the closing probability check is bypassed and closing is " +
                     "true.")]
        [JsonProperty(PropertyName="closing_probability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ClosingProbabilityScheduleName { get; set; } = "";
    }
}