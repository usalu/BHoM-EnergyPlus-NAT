using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies certain parameters that control the Basement preprocessor ground heat t" +
                 "ransfer simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_SimParameters : BHoMObject
    {
        

        [Description("0<F<1.0, typically 0.1 (0.3 for high k soil - saturated sand is about 2.6 w/m-K)")]
        [JsonProperty(PropertyName="f_multiplier_for_the_adi_solution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FMultiplierForTheAdiSolution { get; set; } = null;
        

        [Description("typically 15-30]")]
        [JsonProperty(PropertyName="iyrs_maximum_number_of_yearly_iterations_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IyrsMaximumNumberOfYearlyIterations { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
    }
}