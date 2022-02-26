using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description(@"Unglazed transpired solar collector (UTSC) used to condition outdoor air. This type of collector is generally used to heat air drawn through perforated absorbers and also recover heat conducted out through the underlying surface. This object represents a single collector attached to one or more building or shading surfaces and to one or more outdoor air systems.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollector_UnglazedTranspired : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object")]
        [JsonProperty(PropertyName="boundary_conditions_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BoundaryConditionsModelName { get; set; } = "";
        

        [Description("Availability schedule name for this collector. Schedule value > 0 means it is ava" +
                     "ilable. If this field is blank, the collector is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("required field if no SolarCollector:UnglazedTranspired:Multisystem")]
        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [Description("required field if no SolarCollector:UnglazedTranspired:Multisystem")]
        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [Description("This node is where the mixed air setpoint is determined. required field if no Sol" +
                     "arCollector:UnglazedTranspired:Multisystem")]
        [JsonProperty(PropertyName="setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeName { get; set; } = "";
        

        [Description("This node is used to identify the affected zone required field if no SolarCollect" +
                     "or:UnglazedTranspired:Multisystem")]
        [JsonProperty(PropertyName="zone_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="free_heating_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FreeHeatingSetpointScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="diameter_of_perforations_in_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiameterOfPerforationsInCollector { get; set; } = null;
        

        [JsonProperty(PropertyName="distance_between_perforations_in_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceBetweenPerforationsInCollector { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_emissivity_of_collector_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalEmissivityOfCollectorSurface { get; set; } = null;
        

        [JsonProperty(PropertyName="solar_absorbtivity_of_collector_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarAbsorbtivityOfCollectorSurface { get; set; } = null;
        

        [JsonProperty(PropertyName="effective_overall_height_of_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveOverallHeightOfCollector { get; set; } = null;
        

        [Description("if corrugated, use average depth")]
        [JsonProperty(PropertyName="effective_gap_thickness_of_plenum_behind_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveGapThicknessOfPlenumBehindCollector { get; set; } = null;
        

        [Description("if corrugated, use average depth")]
        [JsonProperty(PropertyName="effective_cross_section_area_of_plenum_behind_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveCrossSectionAreaOfPlenumBehindCollector { get; set; } = null;
        

        [JsonProperty(PropertyName="hole_layout_pattern_for_pitch", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollector_UnglazedTranspired_HoleLayoutPatternForPitch HoleLayoutPatternForPitch { get; set; } = (SolarCollector_UnglazedTranspired_HoleLayoutPatternForPitch)Enum.Parse(typeof(SolarCollector_UnglazedTranspired_HoleLayoutPatternForPitch), "Square");
        

        [JsonProperty(PropertyName="heat_exchange_effectiveness_correlation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollector_UnglazedTranspired_HeatExchangeEffectivenessCorrelation HeatExchangeEffectivenessCorrelation { get; set; } = (SolarCollector_UnglazedTranspired_HeatExchangeEffectivenessCorrelation)Enum.Parse(typeof(SolarCollector_UnglazedTranspired_HeatExchangeEffectivenessCorrelation), "Kutscher1994");
        

        [Description("This parameter is used to help account for corrugations in the collector")]
        [JsonProperty(PropertyName="ratio_of_actual_collector_surface_area_to_projected_surface_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfActualCollectorSurfaceAreaToProjectedSurfaceArea { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="roughness_of_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollector_UnglazedTranspired_RoughnessOfCollector RoughnessOfCollector { get; set; } = (SolarCollector_UnglazedTranspired_RoughnessOfCollector)Enum.Parse(typeof(SolarCollector_UnglazedTranspired_RoughnessOfCollector), "MediumRough");
        

        [Description("Collector thickness is not required for Kutscher correlation Collector thickness " +
                     "is required for Van Decker et al. correlation")]
        [JsonProperty(PropertyName="collector_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CollectorThickness { get; set; } = null;
        

        [Description("Cv")]
        [JsonProperty(PropertyName="effectiveness_for_perforations_with_respect_to_wind", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectivenessForPerforationsWithRespectToWind { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [Description("Cd")]
        [JsonProperty(PropertyName="discharge_coefficient_for_openings_with_respect_to_buoyancy_driven_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeCoefficientForOpeningsWithRespectToBuoyancyDrivenFlow { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("This list is the AllShadingAndHTSurfNames object-list")]
        [JsonProperty(PropertyName="surfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Surfaces { get; set; } = null;
    }
}