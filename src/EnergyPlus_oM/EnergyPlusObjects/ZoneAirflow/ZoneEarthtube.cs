using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("Earth Tube is specified as a design level which is modified by a Schedule fractio" +
                 "n, temperature difference and wind speed: Earthtube=Edesign * Fschedule * (A + B" +
                 "*|(Tzone-Todb)| + C*WindSpd + D * WindSpd**2)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneEarthtube : BHoMObject
    {
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description("\"Edesign\" in Equation")]
        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFlowRate { get; set; } = null;
        

        [Description("this is the indoor temperature below which the earth tube is shut off")]
        [JsonProperty(PropertyName="minimum_zone_temperature_when_cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumZoneTemperatureWhenCooling { get; set; } = null;
        

        [Description("this is the indoor temperature above which the earth tube is shut off")]
        [JsonProperty(PropertyName="maximum_zone_temperature_when_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumZoneTemperatureWhenHeating { get; set; } = null;
        

        [Description("This is the temperature difference between indoor and outdoor below which the ear" +
                     "th tube is shut off")]
        [JsonProperty(PropertyName="delta_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeltaTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="earthtube_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneEarthtube_EarthtubeType EarthtubeType { get; set; } = (ZoneEarthtube_EarthtubeType)Enum.Parse(typeof(ZoneEarthtube_EarthtubeType), "Natural");
        

        [Description("pressure rise across the fan")]
        [JsonProperty(PropertyName="fan_pressure_rise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPressureRise { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanTotalEfficiency { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_radius", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeRadius { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThickness { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeLength { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThermalConductivity { get; set; } = Double.Parse("200", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pipe_depth_under_ground_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeDepthUnderGroundSurface { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_condition", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneEarthtube_SoilCondition SoilCondition { get; set; } = (ZoneEarthtube_SoilCondition)Enum.Parse(typeof(ZoneEarthtube_SoilCondition), "HeavyAndDamp");
        

        [JsonProperty(PropertyName="average_soil_surface_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageSoilSurfaceTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="amplitude_of_soil_surface_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AmplitudeOfSoilSurfaceTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="phase_constant_of_soil_surface_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PhaseConstantOfSoilSurfaceTemperature { get; set; } = null;
        

        [Description("\"A\" in Equation")]
        [JsonProperty(PropertyName="constant_term_flow_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantTermFlowCoefficient { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("\"B\" in Equation")]
        [JsonProperty(PropertyName="temperature_term_flow_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureTermFlowCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"C\" in Equation")]
        [JsonProperty(PropertyName="velocity_term_flow_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VelocityTermFlowCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("\"D\" in Equation")]
        [JsonProperty(PropertyName="velocity_squared_term_flow_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VelocitySquaredTermFlowCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}