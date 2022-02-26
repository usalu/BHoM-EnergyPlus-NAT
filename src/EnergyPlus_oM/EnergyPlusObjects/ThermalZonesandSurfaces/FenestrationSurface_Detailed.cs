using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for detailed entry of subsurfaces (windows, doors, glass doors, tubular da" +
                 "ylighting devices).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FenestrationSurface_Detailed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FenestrationSurface_Detailed_SurfaceType SurfaceType { get; set; } = (FenestrationSurface_Detailed_SurfaceType)Enum.Parse(typeof(FenestrationSurface_Detailed_SurfaceType), "Door");
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty(PropertyName="building_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingSurfaceName { get; set; } = "";
        

        [Description(@"Non-blank only if base surface field Outside Boundary Condition is Surface or OtherSideCoefficients If Base Surface's Surface, specify name of corresponding subsurface in adjacent zone or specify current subsurface name for internal partition separating like zones If OtherSideCoefficients, specify name of SurfaceProperty:OtherSideCoefficients or leave blank to inherit Base Surface's OtherSide Coefficients")]
        [JsonProperty(PropertyName="outside_boundary_condition_object", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [Description(@"From the exterior of the surface Unused if one uses the ""reflections"" options in Solar Distribution in Building input unless a DaylightingDevice:Shelf or DaylightingDevice:Tubular object has been specified. autocalculate will automatically calculate this value from the tilt of the surface")]
        [JsonProperty(PropertyName="view_factor_to_ground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> ViewFactorToGround { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the name of a WindowProperty:FrameAndDivider object Used only for exterior windows (rectangular) and glass doors. Unused for triangular windows. If not specified (blank), window or glass door has no frame or divider and no beam solar reflection from reveal surfaces.")]
        [JsonProperty(PropertyName="frame_and_divider_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FrameAndDividerName { get; set; } = "";
        

        [Description("Used only for Surface Type = WINDOW, GLASSDOOR or DOOR Non-integer values will be" +
                     " truncated to integer")]
        [JsonProperty(PropertyName="multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Multiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"vertices are given in GlobalGeometryRules coordinates -- if relative, all surface coordinates are ""relative"" to the Zone Origin. If world, then building and zone origins are used for some internal calculations, but all coordinates are given in an ""absolute"" system.")]
        [JsonProperty(PropertyName="number_of_vertices", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> NumberOfVertices { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="vertex_1_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex1XCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_1_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex1YCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_1_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex1ZCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_2_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex2XCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_2_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex2YCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_2_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex2ZCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_3_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex3XCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_3_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex3YCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="vertex_3_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex3ZCoordinate { get; set; } = null;
        

        [Description("Not used for triangles")]
        [JsonProperty(PropertyName="vertex_4_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex4XCoordinate { get; set; } = null;
        

        [Description("Not used for triangles")]
        [JsonProperty(PropertyName="vertex_4_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex4YCoordinate { get; set; } = null;
        

        [Description("Not used for triangles")]
        [JsonProperty(PropertyName="vertex_4_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Vertex4ZCoordinate { get; set; } = null;
    }
}