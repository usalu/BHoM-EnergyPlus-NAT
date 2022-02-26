using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Allow user settable interior and/or exterior convection coefficients. Note that some other factors may limit the lower bounds for these values, such as for windows, the interior convection coefficient must be >.28, for trombe wall algorithm selection (zone), the interior convection coefficient must be >.1 for TARP interior convection, the lower limit is also .1 Minimum and maximum limits are set in HeatBalanceAlgorithm object. Defaults in HeatBalanceAlgorithm object are [.1,1000].")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_ConvectionCoefficients : BHoMObject
    {
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="convection_coefficient_1_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location ConvectionCoefficient1Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Location), "Inside");
        

        [JsonProperty(PropertyName="convection_coefficient_1_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type ConvectionCoefficient1Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient1Type), "ASHRAEVerticalWall");
        

        [Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
                     " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty(PropertyName="convection_coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConvectionCoefficient1 { get; set; } = null;
        

        [Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
                     "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty(PropertyName="convection_coefficient_1_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectionCoefficient1ScheduleName { get; set; } = "";
        

        [Description("used if Convection Type = UserCurve")]
        [JsonProperty(PropertyName="convection_coefficient_1_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectionCoefficient1UserCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="convection_coefficient_2_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location ConvectionCoefficient2Location { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Location), "Inside");
        

        [JsonProperty(PropertyName="convection_coefficient_2_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type ConvectionCoefficient2Type { get; set; } = (SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type)Enum.Parse(typeof(SurfaceProperty_ConvectionCoefficients_ConvectionCoefficient2Type), "ASHRAEVerticalWall");
        

        [Description("used if Convection Type=Value, min and max limits are set in HeatBalanceAlgorithm" +
                     " object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty(PropertyName="convection_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConvectionCoefficient2 { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("used if Convection Type=Schedule,  min and max limits are set in HeatBalanceAlgor" +
                     "ithm object. Default limits are Minimum >= 0.1 and Maximum <= 1000")]
        [JsonProperty(PropertyName="convection_coefficient_2_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectionCoefficient2ScheduleName { get; set; } = "";
        

        [Description("used if Convection Type = UserCurve")]
        [JsonProperty(PropertyName="convection_coefficient_2_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectionCoefficient2UserCurveName { get; set; } = "";
    }
}