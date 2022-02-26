using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines settings for the Conduction Finite Difference algorithm for surface he" +
                 "at transfer modeling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatBalanceSettings_ConductionFiniteDifference : BHoMObject
    {
        

        [JsonProperty(PropertyName="difference_scheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme DifferenceScheme { get; set; } = (HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme)Enum.Parse(typeof(HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme), "FullyImplicitFirstOrder");
        

        [Description("increase or decrease number of nodes")]
        [JsonProperty(PropertyName="space_discretization_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpaceDiscretizationConstant { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="relaxation_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelaxationFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="inside_face_surface_temperature_convergence_criteria", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideFaceSurfaceTemperatureConvergenceCriteria { get; set; } = Double.Parse("0.002", CultureInfo.InvariantCulture);
    }
}