using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("This object is used to control details of the solar, shading, and daylighting mod" +
                 "els")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ShadowCalculation : BHoMObject
    {
        

        [Description(@"Select between CPU-based polygon clipping method, the GPU-based pixel counting method, or importing from external shading data. If PixelCounting is selected and GPU hardware (or GPU emulation) is not available, a warning will be displayed and EnergyPlus will revert to PolygonClipping. If Scheduled is chosen, the External Shading Fraction Schedule Name is required in SurfaceProperty:LocalEnvironment. If Imported is chosen, the Schedule:File:Shading object is required.")]
        [JsonProperty(PropertyName="shading_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ShadowCalculation_ShadingCalculationMethod ShadingCalculationMethod { get; set; } = (ShadowCalculation_ShadingCalculationMethod)Enum.Parse(typeof(ShadowCalculation_ShadingCalculationMethod), "PolygonClipping");
        

        [Description("choose calculation frequency method. note that Timestep is only needed for certai" +
                     "n cases and can increase execution time significantly.")]
        [JsonProperty(PropertyName="shading_calculation_update_frequency_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ShadowCalculation_ShadingCalculationUpdateFrequencyMethod ShadingCalculationUpdateFrequencyMethod { get; set; } = (ShadowCalculation_ShadingCalculationUpdateFrequencyMethod)Enum.Parse(typeof(ShadowCalculation_ShadingCalculationUpdateFrequencyMethod), "Periodic");
        

        [Description("enter number of days this field is only used if the previous field is set to Peri" +
                     "odic warning issued if >31")]
        [JsonProperty(PropertyName="shading_calculation_update_frequency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShadingCalculationUpdateFrequency { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Number of allowable figures in shadow overlap in PolygonClipping calculations")]
        [JsonProperty(PropertyName="maximum_figures_in_shadow_overlap_calculations", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFiguresInShadowOverlapCalculations { get; set; } = Double.Parse("15000", CultureInfo.InvariantCulture);
        

        [Description("Advanced Feature. Internal default is SutherlandHodgman Refer to InputOutput Refe" +
                     "rence and Engineering Reference for more information")]
        [JsonProperty(PropertyName="polygon_clipping_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ShadowCalculation_PolygonClippingAlgorithm PolygonClippingAlgorithm { get; set; } = (ShadowCalculation_PolygonClippingAlgorithm)Enum.Parse(typeof(ShadowCalculation_PolygonClippingAlgorithm), "SutherlandHodgman");
        

        [Description("Number of pixels in both dimensions of the surface rendering")]
        [JsonProperty(PropertyName="pixel_counting_resolution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PixelCountingResolution { get; set; } = Double.Parse("512", CultureInfo.InvariantCulture);
        

        [Description("Advanced Feature. Internal default is SimpleSkyDiffuseModeling If you have shadin" +
                     "g elements that change transmittance over the year, you may wish to choose the d" +
                     "etailed method. Refer to InputOutput Reference and Engineering Reference for mor" +
                     "e information")]
        [JsonProperty(PropertyName="sky_diffuse_modeling_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ShadowCalculation_SkyDiffuseModelingAlgorithm SkyDiffuseModelingAlgorithm { get; set; } = (ShadowCalculation_SkyDiffuseModelingAlgorithm)Enum.Parse(typeof(ShadowCalculation_SkyDiffuseModelingAlgorithm), "SimpleSkyDiffuseModeling");
        

        [Description("If Yes is chosen, the calculated external shading fraction results will be saved " +
                     "to an external CSV file with surface names as the column headers.")]
        [JsonProperty(PropertyName="output_external_shading_calculation_results", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes OutputExternalShadingCalculationResults { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"If Yes, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to surfaces within the same Shading Zone Group. If both Disable Self-Shading Within Shading Zone Groups and Disable Self-Shading From Shading Zone Groups to Other Zones = Yes, then all self-shading from exterior surfaces will be disabled. If only one of these fields = Yes, then at least one Shading Zone Group must be specified, or this field will be ignored. Shading from Shading:* surfaces, overhangs, fins, and reveals will not be disabled.")]
        [JsonProperty(PropertyName="disable_self_shading_within_shading_zone_groups", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DisableSelfShadingWithinShadingZoneGroups { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description(@"If Yes, self-shading will be disabled from all exterior surfaces in a given Shading Zone Group to all other zones in the model. If both Disable Self-Shading Within Shading Zone Groups and Disable Self-Shading From Shading Zone Groups to Other Zones = Yes, then all self-shading from exterior surfaces will be disabled. If only one of these fields = Yes, then at least one Shading Zone Group must be specified, or this field will be ignored. Shading from Shading:* surfaces, overhangs, fins, and reveals will not be disabled.")]
        [JsonProperty(PropertyName="disable_self_shading_from_shading_zone_groups_to_other_zones", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DisableSelfShadingFromShadingZoneGroupsToOtherZones { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("This list is the ZoneListNames object-list")]
        [JsonProperty(PropertyName="shading_zone_groups", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> ShadingZoneGroups { get; set; } = null;
    }
}