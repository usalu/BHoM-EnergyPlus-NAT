using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description(@"This object sets the temperature and humidity conditions for an outdoor air node. It allows the height above ground to be specified. This object may be used more than once. The same node name may not appear in both an OutdoorAir:Node object and an OutdoorAir:NodeList object. This object defines local outdoor air environmental conditions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutdoorAir_Node : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("A value less than zero indicates that the height will be ignored and the weather " +
                     "file conditions will be used.")]
        [JsonProperty(PropertyName="height_above_ground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightAboveGround { get; set; } = Double.Parse("-1", CultureInfo.InvariantCulture);
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
        [JsonProperty(PropertyName="drybulb_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DrybulbTemperatureScheduleName { get; set; } = "";
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C")]
        [JsonProperty(PropertyName="wetbulb_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WetbulbTemperatureScheduleName { get; set; } = "";
        

        [Description("Schedule values are real numbers, 0.0 to 40.0, units m/s")]
        [JsonProperty(PropertyName="wind_speed_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindSpeedScheduleName { get; set; } = "";
        

        [Description("Schedule values are real numbers, 0.0 to 360.0, units degree")]
        [JsonProperty(PropertyName="wind_direction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindDirectionScheduleName { get; set; } = "";
        

        [Description("The name of the AirflowNetwork:MultiZone:WindPressureCoefficientValues, curve, or" +
                     " table object specifying the wind pressure coefficient.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindPressureCoefficientCurveName { get; set; } = "";
        

        [Description("Specify whether the pressure curve is symmetric or not. Specify Yes for curves th" +
                     "at should be evaluated from 0 to 180 degrees Specify No for curves that should b" +
                     "e evaluated from 0 to 360 degrees")]
        [JsonProperty(PropertyName="symmetric_wind_pressure_coefficient_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SymmetricWindPressureCoefficientCurve { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Specify whether the angle used to compute the wind pressure coefficient is absolu" +
                     "te or relative Specify Relative to compute the angle between the wind direction " +
                     "and the surface azimuth Specify Absolute to use the wind direction angle directl" +
                     "y")]
        [JsonProperty(PropertyName="wind_angle_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutdoorAir_Node_WindAngleType WindAngleType { get; set; } = (OutdoorAir_Node_WindAngleType)Enum.Parse(typeof(OutdoorAir_Node_WindAngleType), "Absolute");
    }
}