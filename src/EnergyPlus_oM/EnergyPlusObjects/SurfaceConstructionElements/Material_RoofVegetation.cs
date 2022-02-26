using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"EcoRoof model, plant layer plus soil layer Implemented by Portland State University (Sailor et al., January, 2007) only one material must be referenced per simulation though the same EcoRoof material could be used in multiple constructions. New moisture redistribution scheme (2010) requires higher number of timesteps per hour (minimum 12 recommended).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_RoofVegetation : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The ecoroof module is designed for short plants and shrubs.")]
        [JsonProperty(PropertyName="height_of_plants", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightOfPlants { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Entire surface is assumed covered, so decrease LAI accordingly.")]
        [JsonProperty(PropertyName="leaf_area_index", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeafAreaIndex { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Leaf reflectivity (albedo) is typically 0.18-0.25")]
        [JsonProperty(PropertyName="leaf_reflectivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeafReflectivity { get; set; } = Double.Parse("0.22", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="leaf_emissivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeafEmissivity { get; set; } = Double.Parse("0.95", CultureInfo.InvariantCulture);
        

        [Description("This depends upon plant type")]
        [JsonProperty(PropertyName="minimum_stomatal_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumStomatalResistance { get; set; } = Double.Parse("180", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_layer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SoilLayerName { get; set; } = "Green Roof Soil";
        

        [JsonProperty(PropertyName="roughness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Material_RoofVegetation_Roughness Roughness { get; set; } = (Material_RoofVegetation_Roughness)Enum.Parse(typeof(Material_RoofVegetation_Roughness), "MediumRough");
        

        [Description("thickness of the soil layer of the EcoRoof Soil depths of 0.15m (6in) and 0.30m (" +
                     "12in) are common.")]
        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("Thermal conductivity of dry soil. Typical ecoroof soils range from 0.3 to 0.5")]
        [JsonProperty(PropertyName="conductivity_of_dry_soil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConductivityOfDrySoil { get; set; } = Double.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Density of dry soil (the code modifies this as the soil becomes moist) Typical ec" +
                     "oroof soils range from 400 to 1000 (dry to wet)")]
        [JsonProperty(PropertyName="density_of_dry_soil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityOfDrySoil { get; set; } = Double.Parse("1100", CultureInfo.InvariantCulture);
        

        [Description("Specific heat of dry soil")]
        [JsonProperty(PropertyName="specific_heat_of_dry_soil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatOfDrySoil { get; set; } = Double.Parse("1200", CultureInfo.InvariantCulture);
        

        [Description("Soil emissivity is typically in range of 0.90 to 0.98")]
        [JsonProperty(PropertyName="thermal_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalAbsorptance { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Solar absorptance of dry soil (1-albedo) is typically 0.60 to 0.85 corresponding " +
                     "to a dry albedo of 0.15 to 0.40")]
        [JsonProperty(PropertyName="solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarAbsorptance { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="visible_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleAbsorptance { get; set; } = Double.Parse("0.75", CultureInfo.InvariantCulture);
        

        [Description("Maximum moisture content is typically less than 0.5")]
        [JsonProperty(PropertyName="saturation_volumetric_moisture_content_of_the_soil_layer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SaturationVolumetricMoistureContentOfTheSoilLayer { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="residual_volumetric_moisture_content_of_the_soil_layer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ResidualVolumetricMoistureContentOfTheSoilLayer { get; set; } = Double.Parse("0.01", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="initial_volumetric_moisture_content_of_the_soil_layer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialVolumetricMoistureContentOfTheSoilLayer { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("Advanced calculation requires increased number of timesteps (recommended >20).")]
        [JsonProperty(PropertyName="moisture_diffusion_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Material_RoofVegetation_MoistureDiffusionCalculationMethod MoistureDiffusionCalculationMethod { get; set; } = (Material_RoofVegetation_MoistureDiffusionCalculationMethod)Enum.Parse(typeof(Material_RoofVegetation_MoistureDiffusionCalculationMethod), "Advanced");
    }
}