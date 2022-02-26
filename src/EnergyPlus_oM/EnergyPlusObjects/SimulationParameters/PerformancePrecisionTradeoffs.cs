using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("This object enables users to choose certain options that speed up EnergyPlus simu" +
                 "lation, but may lead to small decreases in accuracy of results.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PerformancePrecisionTradeoffs : BHoMObject
    {
        

        [Description("If Yes, an analytical or empirical solution will be used to replace iterations in" +
                     " the coil performance calculations.")]
        [JsonProperty(PropertyName="use_coil_direct_solutions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseCoilDirectSolutions { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Determines which algorithm will be used to solve long wave radiant exchange among" +
                     " surfaces within a zone.")]
        [JsonProperty(PropertyName="zone_radiant_exchange_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm ZoneRadiantExchangeAlgorithm { get; set; } = (PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm)Enum.Parse(typeof(PerformancePrecisionTradeoffs_ZoneRadiantExchangeAlgorithm), "ScriptF");
        

        [Description("The increasing mode number roughly correspond with increased speed. A description" +
                     " of each mode are shown in the documentation. When Advanced is selected the N1 f" +
                     "ield value is used.")]
        [JsonProperty(PropertyName="override_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PerformancePrecisionTradeoffs_OverrideMode OverrideMode { get; set; } = (PerformancePrecisionTradeoffs_OverrideMode)Enum.Parse(typeof(PerformancePrecisionTradeoffs_OverrideMode), "Normal");
        

        [Description("Maximum zone temperature change before HVAC timestep is shortened. Only used when" +
                     " Override Mode is set to Advanced")]
        [JsonProperty(PropertyName="maxzonetempdiff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Maxzonetempdiff { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [Description("Maximum surface temperature change before HVAC timestep is shortened. Only used w" +
                     "hen Override Mode is set to Advanced")]
        [JsonProperty(PropertyName="maxalloweddeltemp", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Maxalloweddeltemp { get; set; } = Double.Parse("0.002", CultureInfo.InvariantCulture);
    }
}