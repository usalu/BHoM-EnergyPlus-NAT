using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Refrigeration system compressor. Data is available for many compressors in the Re" +
                 "frigerationCompressor.idf dataset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Compressor : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"the input order for the Curve:Bicubic does not match the ARI 540-2004 Eq. 1 coefficient order N1 is ARI_C1, N2 is ARI_C2, N3 is ARI_C4, N4 is ARI_C3, N5 is ARI_C6, N6 is ARI_C5, N7 is ARI_C7, N8 is ARI_C10, N9 is ARI_C8, N10 is ARI_C9, N11 is Minimum Suction dewpoint temperature, N12 is Maximum Suction dewpoint temperature, N13 is Minimum Discharge dewpoint temperature, N14 is Maximum Discharge dewpoint temperature")]
        [JsonProperty(PropertyName="refrigeration_compressor_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationCompressorPowerCurveName { get; set; } = "";
        

        [Description(@"the input order for the Curve:Bicubic does not match the ARI 540-2004 Eq. 1 coefficient order N1 is ARI_C1, N2 is ARI_C2, N3 is ARI_C4, N4 is ARI_C3, N5 is ARI_C6, N6 is ARI_C5, N7 is ARI_C7, N8 is ARI_C10, N9 is ARI_C8, N10 is ARI_C9, N11 is Minimum Suction dewpoint temperature, N12 is Maximum Suction dewpoint temperature, N13 is Minimum Discharge dewpoint temperature, N14 is Maximum Discharge dewpoint temperature")]
        [JsonProperty(PropertyName="refrigeration_compressor_capacity_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationCompressorCapacityCurveName { get; set; } = "";
        

        [Description("Use this input field OR the next, not both This is used if the compressor rating " +
                     "is based upon degrees of superheat")]
        [JsonProperty(PropertyName="rated_superheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedSuperheat { get; set; } = null;
        

        [Description("Use this input field OR the previous, not both This is used if the compressor rat" +
                     "ing is based upon rated return gas temperature (Rated Suction Temperature)")]
        [JsonProperty(PropertyName="rated_return_gas_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedReturnGasTemperature { get; set; } = null;
        

        [Description("Use this input field OR the next, not both This is used if the compressor rating " +
                     "is based upon rated liquid temperature at the expansion valve")]
        [JsonProperty(PropertyName="rated_liquid_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedLiquidTemperature { get; set; } = null;
        

        [Description("Use this input field OR the previous, not both This is used if the compressor rat" +
                     "ing is based upon degrees of subcooling")]
        [JsonProperty(PropertyName="rated_subcooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedSubcooling { get; set; } = null;
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [JsonProperty(PropertyName="mode_of_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Compressor_ModeOfOperation ModeOfOperation { get; set; } = (Refrigeration_Compressor_ModeOfOperation)Enum.Parse(typeof(Refrigeration_Compressor_ModeOfOperation), "Subcritical");
        

        [JsonProperty(PropertyName="transcritical_compressor_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TranscriticalCompressorPowerCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="transcritical_compressor_capacity_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TranscriticalCompressorCapacityCurveName { get; set; } = "";
    }
}