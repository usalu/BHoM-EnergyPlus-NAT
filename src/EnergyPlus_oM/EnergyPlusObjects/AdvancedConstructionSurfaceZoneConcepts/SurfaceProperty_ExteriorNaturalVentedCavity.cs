using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to describe the decoupled layer, or baffle, and the characteristics of the c" +
                 "avity and openings for naturally ventilated exterior surfaces. This object is al" +
                 "so used in conjunction with the OtherSideConditionsModel.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_ExteriorNaturalVentedCavity : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object")]
        [JsonProperty(PropertyName="boundary_conditions_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BoundaryConditionsModelName { get; set; } = "";
        

        [JsonProperty(PropertyName="area_fraction_of_openings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AreaFractionOfOpenings { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_emissivity_of_exterior_baffle_material", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalEmissivityOfExteriorBaffleMaterial { get; set; } = null;
        

        [JsonProperty(PropertyName="solar_absorbtivity_of_exterior_baffle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarAbsorbtivityOfExteriorBaffle { get; set; } = null;
        

        [JsonProperty(PropertyName="height_scale_for_buoyancy_driven_ventilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightScaleForBuoyancyDrivenVentilation { get; set; } = null;
        

        [Description("if corrugated, use average depth")]
        [JsonProperty(PropertyName="effective_thickness_of_cavity_behind_exterior_baffle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveThicknessOfCavityBehindExteriorBaffle { get; set; } = null;
        

        [Description("this parameter is used to help account for corrugations in the collector")]
        [JsonProperty(PropertyName="ratio_of_actual_surface_area_to_projected_surface_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfActualSurfaceAreaToProjectedSurfaceArea { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="roughness_of_exterior_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface RoughnessOfExteriorSurface { get; set; } = (SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface)Enum.Parse(typeof(SurfaceProperty_ExteriorNaturalVentedCavity_RoughnessOfExteriorSurface), "MediumRough");
        

        [JsonProperty(PropertyName="effectiveness_for_perforations_with_respect_to_wind", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectivenessForPerforationsWithRespectToWind { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="discharge_coefficient_for_openings_with_respect_to_buoyancy_driven_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeCoefficientForOpeningsWithRespectToBuoyancyDrivenFlow { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("This list is the AllShadingAndHTSurfNames object-list")]
        [JsonProperty(PropertyName="surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Surface { get; set; } = null;
    }
}