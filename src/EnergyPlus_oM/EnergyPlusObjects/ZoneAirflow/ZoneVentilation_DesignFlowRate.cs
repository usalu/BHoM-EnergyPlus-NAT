using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"Ventilation is specified as a design level which is modified by a schedule fraction, temperature difference and wind speed: Ventilation=Vdesign * Fschedule * (A + B*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2) If you use a ZoneList in the Zone or ZoneList name field then this definition applies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneVentilation_DesignFlowRate : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of ventilation for this set of attributes Choices: Flow/Zone => Design Flow Rate -- simply enter Design Flow Rate Flow/Area => Flow Rate per Zone Floor Area - Value * Floor Area (zone) = Design Flow Rate Flow/Person => Flow Rate per Person - Value * #people = Design Flow Rate AirChanges/Hour => Air Changes per Hour - Value * Floor Volume (zone) adjusted for m3/s = Design Volume Flow Rate ""Vdesign"" in Equation is the result.")]
        [JsonProperty(PropertyName="design_flow_rate_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod DesignFlowRateCalculationMethod { get; set; } = (ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod)Enum.Parse(typeof(ZoneVentilation_DesignFlowRate_DesignFlowRateCalculationMethod), "Empty");
        

        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="flow_rate_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlowRatePerZoneFloorArea { get; set; } = null;
        

        [JsonProperty(PropertyName="flow_rate_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlowRatePerPerson { get; set; } = null;
        

        [JsonProperty(PropertyName="air_changes_per_hour", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirChangesPerHour { get; set; } = null;
        

        [JsonProperty(PropertyName="ventilation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneVentilation_DesignFlowRate_VentilationType VentilationType { get; set; } = (ZoneVentilation_DesignFlowRate_VentilationType)Enum.Parse(typeof(ZoneVentilation_DesignFlowRate_VentilationType), "Natural");
        

        [Description("pressure rise across the fan")]
        [JsonProperty(PropertyName="fan_pressure_rise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPressureRise { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanTotalEfficiency { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("\"A\" in Equation")]
        [JsonProperty(PropertyName="constant_term_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantTermCoefficient { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("\"B\" in Equation")]
        [JsonProperty(PropertyName="temperature_term_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureTermCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"C\" in Equation")]
        [JsonProperty(PropertyName="velocity_term_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VelocityTermCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"D\" in Equation")]
        [JsonProperty(PropertyName="velocity_squared_term_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VelocitySquaredTermCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("this is the indoor temperature below which ventilation is shutoff")]
        [JsonProperty(PropertyName="minimum_indoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumIndoorTemperature { get; set; } = Double.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time below which ventilation" +
                     " is shutoff.")]
        [JsonProperty(PropertyName="minimum_indoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the indoor temperature above which ventilation is shutoff")]
        [JsonProperty(PropertyName="maximum_indoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumIndoorTemperature { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the indoor temperature versus time above which ventilation" +
                     " is shutoff.")]
        [JsonProperty(PropertyName="maximum_indoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumIndoorTemperatureScheduleName { get; set; } = "";
        

        [Description(@"This is the temperature differential between indoor and outdoor below which ventilation is shutoff. If ((IndoorTemp - OutdoorTemp) < DeltaTemperature) then ventilation is not allowed. For example, if delta temperature is 2C, ventilation is assumed to be available if the outside air temperature is at least 2C cooler than the zone air temperature. The values for this field can include negative numbers. This allows ventilation to occur even if the outdoor temperature is above the indoor temperature.")]
        [JsonProperty(PropertyName="delta_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeltaTemperature { get; set; } = Double.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the temperature differential between indoor and outdoor ve" +
                     "rsus time below which ventilation is shutoff.")]
        [JsonProperty(PropertyName="delta_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeltaTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the outdoor temperature below which ventilation is shutoff")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorTemperature { get; set; } = Double.Parse("-100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time below which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty(PropertyName="minimum_outdoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the outdoor temperature above which ventilation is shutoff")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorTemperature { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the outdoor temperature versus time above which ventilatio" +
                     "n is shutoff.")]
        [JsonProperty(PropertyName="maximum_outdoor_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumOutdoorTemperatureScheduleName { get; set; } = "";
        

        [Description("this is the outdoor wind speed above which ventilation is shutoff")]
        [JsonProperty(PropertyName="maximum_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumWindSpeed { get; set; } = Double.Parse("40", CultureInfo.InvariantCulture);
    }
}