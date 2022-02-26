using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Settings applied across all Kiva foundation calculations. Object is not required." +
                 " If not defined, defaults will be applied.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Foundation_Kiva_Settings : BHoMObject
    {
        

        [JsonProperty(PropertyName="soil_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilConductivity { get; set; } = Double.Parse("1.73", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilDensity { get; set; } = Double.Parse("1842", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSpecificHeat { get; set; } = Double.Parse("419", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="ground_solar_absorptivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundSolarAbsorptivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="ground_thermal_absorptivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundThermalAbsorptivity { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="ground_surface_roughness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundSurfaceRoughness { get; set; } = Double.Parse("0.03", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="far_field_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FarFieldWidth { get; set; } = Double.Parse("40", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="deep_ground_boundary_condition", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Foundation_Kiva_Settings_DeepGroundBoundaryCondition DeepGroundBoundaryCondition { get; set; } = (Foundation_Kiva_Settings_DeepGroundBoundaryCondition)Enum.Parse(typeof(Foundation_Kiva_Settings_DeepGroundBoundaryCondition), "Autoselect");
        

        [JsonProperty(PropertyName="deep_ground_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DeepGroundDepth { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_cell_dimension", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCellDimension { get; set; } = Double.Parse("0.02", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_cell_growth_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCellGrowthCoefficient { get; set; } = Double.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="simulation_timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Foundation_Kiva_Settings_SimulationTimestep SimulationTimestep { get; set; } = (Foundation_Kiva_Settings_SimulationTimestep)Enum.Parse(typeof(Foundation_Kiva_Settings_SimulationTimestep), "Hourly");
    }
}