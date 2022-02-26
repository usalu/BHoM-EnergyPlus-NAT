using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description(@"Determines which Heat Balance Algorithm will be used ie. CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: ConductionFiniteDifferenceSimplified Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatBalanceAlgorithm : BHoMObject
    {
        

        [JsonProperty(PropertyName="algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatBalanceAlgorithm_Algorithm Algorithm { get; set; } = (HeatBalanceAlgorithm_Algorithm)Enum.Parse(typeof(HeatBalanceAlgorithm_Algorithm), "ConductionTransferFunction");
        

        [JsonProperty(PropertyName="surface_temperature_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SurfaceTemperatureUpperLimit { get; set; } = Double.Parse("200", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_surface_convection_heat_transfer_coefficient_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_surface_convection_heat_transfer_coefficient_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSurfaceConvectionHeatTransferCoefficientValue { get; set; } = Double.Parse("1000", CultureInfo.InvariantCulture);
    }
}