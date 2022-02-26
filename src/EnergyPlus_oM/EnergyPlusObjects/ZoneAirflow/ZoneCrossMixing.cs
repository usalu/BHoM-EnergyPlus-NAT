using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("ZoneCrossMixing exchanges an equal amount of air between two zones. Note that thi" +
                 "s statement affects the energy balance of both zones.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneCrossMixing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
        [JsonProperty(PropertyName="design_flow_rate_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneCrossMixing_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneCrossMixing_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneCrossMixing_DesignFlowRateCalculationMethod), "Empty");
        

        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="flow_rate_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlowRatePerZoneFloorArea { get; set; } = null;
        

        [JsonProperty(PropertyName="flow_rate_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlowRatePerPerson { get; set; } = null;
        

        [JsonProperty(PropertyName="air_changes_per_hour", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirChangesPerHour { get; set; } = null;
        

        [JsonProperty(PropertyName="source_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceZoneName { get; set; } = "";
        

        [Description("This field contains the constant temperature differential between source and rece" +
                     "iving zones below which cross mixing is shutoff. This value must be greater than" +
                     " or equal to zero.")]
        [JsonProperty(PropertyName="delta_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeltaTemperature { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between source and receiving " +
                     "zones versus time below which cross mixing is shutoff.")]
        [JsonProperty(PropertyName="delta_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the indoor temperature versus time below which cross mixin" +
                     "g is shutoff.")]
        [JsonProperty(PropertyName="minimum_zone_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the indoor temperature versus time above which cross mixin" +
                     "g is shutoff.")]
        [JsonProperty(PropertyName="maximum_zone_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the source zone dry-bulb temperature versus time below whi" +
                     "ch cross mixing is shutoff.")]
        [JsonProperty(PropertyName="minimum_source_zone_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumSourceZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the source zone dry-bulb temperature versus time above whi" +
                     "ch cross mixing is shutoff.")]
        [JsonProperty(PropertyName="maximum_source_zone_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumSourceZoneTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the outdoor temperature versus time below which cross mixi" +
                     "ng is shutoff.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("This schedule contains the outdoor temperature versus time above which cross mixi" +
                     "ng is shutoff.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
    }
}