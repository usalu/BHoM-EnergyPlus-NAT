using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description(@"Object provides information about the building and its operating conditions Monthly Average Temperature SetPoint fields specify the average indoor building set point temperatures for each month of the year. These fields are useful for simulating a building that is not temperature controlled for some of the year. In such a case, the average indoor set point temperatures can be obtained by first running the model in EnergyPlus with an insulated floor boundary condition, and then using the resulting monthly average zone temperatures in these fields.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_BldgProps : BHoMObject
    {
        

        [Description(@"This field specifies the number of years to iterate. Either the ground heat transfer calculations come to an an annual steady periodic condition by converging to a tolerance (see ConvTol field) or it runs for this number of years. A ten year maximum is usually sufficient.")]
        [JsonProperty(PropertyName="iyrs_number_of_years_to_iterate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IyrsNumberOfYearsToIterate { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Use only the value 0 here. Only a rectangular shape is implemented.")]
        [JsonProperty(PropertyName="shape_slab_shape", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShapeSlabShape { get; set; } = null;
        

        [Description("This field supplies the building height. This is used to calculate the building s" +
                     "hadowing on the ground. typical value= 0-20")]
        [JsonProperty(PropertyName="hbldg_building_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HbldgBuildingHeight { get; set; } = null;
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin1_january_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin1JanuaryIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin2_february_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin2FebruaryIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin3_march_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin3MarchIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin4_april_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin4AprilIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin5_may_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin5MayIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin6_june_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin6JuneIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin7_july_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin7JulyIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin8_august_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin8AugustIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin9_september_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin9SeptemberIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin10_october_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin10OctoberIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin11_november_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin11NovemberIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("see memo on object for more information")]
        [JsonProperty(PropertyName="tin12_december_indoor_average_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Tin12DecemberIndoorAverageTemperatureSetpoint { get; set; } = Double.Parse("22", CultureInfo.InvariantCulture);
        

        [Description("This field permits imposing a daily sinusoidal variation in the indoor setpoint t" +
                     "emperature to simulate the effect of a setback profile. The value specified is t" +
                     "he amplitude of the sine wave.")]
        [JsonProperty(PropertyName="tinamp_daily_indoor_sine_wave_variation_amplitude", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TinampDailyIndoorSineWaveVariationAmplitude { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field specifies the convergence tolerance used to control the iteration. Whe" +
                     "n the temperature change of all nodes is less than the convergence value, iterat" +
                     "ion ceases.")]
        [JsonProperty(PropertyName="convtol_convergence_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConvtolConvergenceTolerance { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
    }
}