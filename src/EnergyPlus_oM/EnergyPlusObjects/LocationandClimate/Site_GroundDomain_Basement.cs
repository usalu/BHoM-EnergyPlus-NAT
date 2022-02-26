using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Ground-coupled basement model for simulating basements or other underground zones" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundDomain_Basement : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The depth from ground surface to the deep ground boundary of the domain.")]
        [JsonProperty(PropertyName="ground_domain_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundDomainDepth { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("This defines the height to width ratio of the basement zone.")]
        [JsonProperty(PropertyName="aspect_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AspectRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The distance from the basement wall edge to the edge of the ground domain")]
        [JsonProperty(PropertyName="perimeter_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PerimeterOffset { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilThermalConductivity { get; set; } = Double.Parse("1.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilDensity { get; set; } = Double.Parse("2800", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSpecificHeat { get; set; } = Double.Parse("850", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_moisture_content_volume_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilMoistureContentVolumeFraction { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="soil_moisture_content_volume_fraction_at_saturation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilMoistureContentVolumeFractionAtSaturation { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Site_GroundDomain_Basement_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [Description(@"This specifies the ground cover effects during evapotranspiration calculations. The value roughly represents the following cases: = 0   : concrete or other solid, non-permeable ground surface material = 0.5 : short grass, much like a manicured lawn = 1   : standard reference state (12 cm grass) = 1.5 : wild growth")]
        [JsonProperty(PropertyName="evapotranspiration_ground_cover_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvapotranspirationGroundCoverParameter { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="basement_floor_boundary_condition_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasementFloorBoundaryConditionModelName { get; set; } = "";
        

        [Description("This field specifies the presence of insulation beneath the basement floor.")]
        [JsonProperty(PropertyName="horizontal_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes HorizontalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="horizontal_insulation_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("This field specifies whether the horizontal insulation fully insulates the surfac" +
                     "e or is perimeter only insulation")]
        [JsonProperty(PropertyName="horizontal_insulation_extents", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_GroundDomain_Basement_HorizontalInsulationExtents HorizontalInsulationExtents { get; set; } = (Site_GroundDomain_Basement_HorizontalInsulationExtents)Enum.Parse(typeof(Site_GroundDomain_Basement_HorizontalInsulationExtents), "Full");
        

        [Description("Width of horizontal perimeter insulation measured from foundation wall inside sur" +
                     "face.")]
        [JsonProperty(PropertyName="perimeter_horizontal_insulation_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PerimeterHorizontalInsulationWidth { get; set; } = null;
        

        [Description("Depth measured from ground surface.")]
        [JsonProperty(PropertyName="basement_wall_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasementWallDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="basement_wall_boundary_condition_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasementWallBoundaryConditionModelName { get; set; } = "";
        

        [JsonProperty(PropertyName="vertical_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes VerticalInsulation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="basement_wall_vertical_insulation_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasementWallVerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Depth measured from the ground surface.")]
        [JsonProperty(PropertyName="vertical_insulation_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VerticalInsulationDepth { get; set; } = null;
        

        [Description("This field specifies the basement domain simulation interval.")]
        [JsonProperty(PropertyName="simulation_timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_GroundDomain_Basement_SimulationTimestep SimulationTimestep { get; set; } = (Site_GroundDomain_Basement_SimulationTimestep)Enum.Parse(typeof(Site_GroundDomain_Basement_SimulationTimestep), "Hourly");
        

        [JsonProperty(PropertyName="mesh_density_parameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MeshDensityParameter { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
    }
}