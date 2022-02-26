using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("The ground domain object for underground piping system simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_Domain : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Domain extent in the local \'X\' direction")]
        [JsonProperty(PropertyName="xmax", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Xmax { get; set; } = null;
        

        [Description("Domain extent in the local \'Y\' direction")]
        [JsonProperty(PropertyName="ymax", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Ymax { get; set; } = null;
        

        [Description("Domain extent in the local \'Y\' direction")]
        [JsonProperty(PropertyName="zmax", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Zmax { get; set; } = null;
        

        [Description("If mesh type is symmetric geometric, this should be an even number.")]
        [JsonProperty(PropertyName="x_direction_mesh_density_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> XDirectionMeshDensityParameter { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="x_direction_mesh_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_XDirectionMeshType XDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_XDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_XDirectionMeshType), "SymmetricGeometric");
        

        [Description("optional Only used if mesh type is symmetric geometric")]
        [JsonProperty(PropertyName="x_direction_geometric_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> XDirectionGeometricCoefficient { get; set; } = Double.Parse("1.3", CultureInfo.InvariantCulture);
        

        [Description("If mesh type is symmetric geometric, this should be an even number.")]
        [JsonProperty(PropertyName="y_direction_mesh_density_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YDirectionMeshDensityParameter { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="y_direction_mesh_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_YDirectionMeshType YDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_YDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_YDirectionMeshType), "SymmetricGeometric");
        

        [Description("optional Only used if mesh type is symmetric geometric")]
        [JsonProperty(PropertyName="y_direction_geometric_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YDirectionGeometricCoefficient { get; set; } = Double.Parse("1.3", CultureInfo.InvariantCulture);
        

        [Description("If mesh type is symmetric geometric, this should be an even number.")]
        [JsonProperty(PropertyName="z_direction_mesh_density_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZDirectionMeshDensityParameter { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="z_direction_mesh_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_ZDirectionMeshType ZDirectionMeshType { get; set; } = (PipingSystem_Underground_Domain_ZDirectionMeshType)Enum.Parse(typeof(PipingSystem_Underground_Domain_ZDirectionMeshType), "SymmetricGeometric");
        

        [Description("optional Only used if mesh type is symmetric geometric")]
        [JsonProperty(PropertyName="z_direction_geometric_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZDirectionGeometricCoefficient { get; set; } = Double.Parse("1.3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilDensity { get; set; } = null;
        

        [Description("This is a dry soil property, which is adjusted for freezing effects by the simula" +
                     "tion algorithm.")]
        [JsonProperty(PropertyName="soil_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSpecificHeat { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_moisture_content_volume_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilMoistureContentVolumeFraction { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_moisture_content_volume_fraction_at_saturation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(PipingSystem_Underground_Domain_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description("if Yes, then the following basement inputs are used if No, then the following bas" +
                     "ement inputs are *ignored*")]
        [JsonProperty(PropertyName="this_domain_includes_basement_surface_interaction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ThisDomainIncludesBasementSurfaceInteraction { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty(PropertyName="width_of_basement_floor_in_ground_domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WidthOfBasementFloorInGroundDomain { get; set; } = null;
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty(PropertyName="depth_of_basement_wall_in_ground_domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DepthOfBasementWallInGroundDomain { get; set; } = null;
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty(PropertyName="shift_pipe_x_coordinates_by_basement_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth ShiftPipeXCoordinatesByBasementWidth { get; set; } = (PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth)Enum.Parse(typeof(PipingSystem_Underground_Domain_ShiftPipeXCoordinatesByBasementWidth), "No");
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty(PropertyName="name_of_basement_wall_boundary_condition_model", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NameOfBasementWallBoundaryConditionModel { get; set; } = "";
        

        [Description("Required only if Domain Has Basement Interaction")]
        [JsonProperty(PropertyName="name_of_basement_floor_boundary_condition_model", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NameOfBasementFloorBoundaryConditionModel { get; set; } = "";
        

        [JsonProperty(PropertyName="convergence_criterion_for_the_outer_cartesian_domain_iteration_loop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConvergenceCriterionForTheOuterCartesianDomainIterationLoop { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_iterations_in_the_outer_cartesian_domain_iteration_loop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumIterationsInTheOuterCartesianDomainIterationLoop { get; set; } = Double.Parse("500", CultureInfo.InvariantCulture);
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty(PropertyName="evapotranspiration_ground_cover_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvapotranspirationGroundCoverParameter { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="number_of_pipe_circuits_entered_for_this_domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfPipeCircuitsEnteredForThisDomain { get; set; } = null;
        

        [Description("This list is the PipingSystemUndergroundCircuitNames object-list")]
        [JsonProperty(PropertyName="pipe_circuits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> PipeCircuits { get; set; } = null;
    }
}