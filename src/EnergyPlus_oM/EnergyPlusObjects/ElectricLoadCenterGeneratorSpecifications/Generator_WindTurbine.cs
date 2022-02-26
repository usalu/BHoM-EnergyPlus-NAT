using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Wind turbine generator.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_WindTurbine : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("allowed values are: Horizontal Axis Wind Turbine or Vertical Axis Wind Turbine")]
        [JsonProperty(PropertyName="rotor_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_WindTurbine_RotorType RotorType { get; set; } = (Generator_WindTurbine_RotorType)Enum.Parse(typeof(Generator_WindTurbine_RotorType), "HorizontalAxisWindTurbine");
        

        [Description("Constant power output is obtained in the last three control types when the wind s" +
                     "peed exceeds the rated wind speed. allowed values are: Fixed Speed Fixed Pitch, " +
                     "Fixed Speed Variable Pitch, Variable Speed Fixed Pitch or Variable Speed Variabl" +
                     "e Pitch")]
        [JsonProperty(PropertyName="power_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_WindTurbine_PowerControl PowerControl { get; set; } = (Generator_WindTurbine_PowerControl)Enum.Parse(typeof(Generator_WindTurbine_PowerControl), "VariableSpeedVariablePitch");
        

        [JsonProperty(PropertyName="rated_rotor_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedRotorSpeed { get; set; } = null;
        

        [Description("This field is the diameter of the perpendicular circle of the Vertical Axis Wind " +
                     "Turbine system from the upright pole on the ground.")]
        [JsonProperty(PropertyName="rotor_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RotorDiameter { get; set; } = null;
        

        [Description("This field is the height of the hub for the Horizontal Axis Wind Turbines and of " +
                     "the pole for the Vertical Axis Wind Turbines.")]
        [JsonProperty(PropertyName="overall_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OverallHeight { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_blades", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBlades { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("This field is the nominal power at the rated wind speed. Users should input maxim" +
                     "um power in case of Fixed Speed Fixed Pitch control type.")]
        [JsonProperty(PropertyName="rated_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedPower { get; set; } = null;
        

        [JsonProperty(PropertyName="rated_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedWindSpeed { get; set; } = null;
        

        [JsonProperty(PropertyName="cut_in_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CutInWindSpeed { get; set; } = null;
        

        [JsonProperty(PropertyName="cut_out_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CutOutWindSpeed { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_system_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionSystemEfficiency { get; set; } = Double.Parse("0.835", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_tip_speed_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumTipSpeedRatio { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("This field should be input if the rotor type is Horizontal Axis Wind Turbine")]
        [JsonProperty(PropertyName="maximum_power_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPowerCoefficient { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="annual_local_average_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AnnualLocalAverageWindSpeed { get; set; } = null;
        

        [JsonProperty(PropertyName="height_for_local_average_wind_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightForLocalAverageWindSpeed { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blade_chord_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BladeChordArea { get; set; } = null;
        

        [Description("This field is only for Vertical Axis Wind Turbine.. The user must input this fiel" +
                     "d if the rotor type is Vertical Axis Wind Turbine.")]
        [JsonProperty(PropertyName="blade_drag_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BladeDragCoefficient { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("This field is only for Vertical Axis Wind Turbine.. The user must input this fiel" +
                     "d if the rotor type is Vertical Axis Wind Turbine.")]
        [JsonProperty(PropertyName="blade_lift_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BladeLiftCoefficient { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only available for Horizontal Axis Wind Turbine. The user should input all six parameters so that the analytic approximation is assumed. The simple approximation will be assumed, if any field C1 through C6 is not input. Leave this field blank, if the manufacturer's data is unavailable so that the simple approximation will be assumed.")]
        [JsonProperty(PropertyName="power_coefficient_c1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerCoefficientC1 { get; set; } = Double.Parse("0.5176", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="power_coefficient_c2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerCoefficientC2 { get; set; } = Double.Parse("116", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="power_coefficient_c3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerCoefficientC3 { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="power_coefficient_c4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerCoefficientC4 { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="power_coefficient_c5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerCoefficientC5 { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="power_coefficient_c6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerCoefficientC6 { get; set; } = Double.Parse("21", CultureInfo.InvariantCulture);
    }
}