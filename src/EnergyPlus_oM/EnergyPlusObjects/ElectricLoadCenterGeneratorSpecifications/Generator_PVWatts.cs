using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describes a simple set of inputs for an array of photovoltaic (PV) modules as described in the PVWatts software. A series of different PVWatts arrays can be connected to a single electric load center (preferably through an ElectricLoadCenter:Inverter:PVWatts). Array tilt and azimuth can be either specified on this object or taken from a referenced building surface or shading surface. If a surface is specified, the array participates normally in all shading calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_PVWatts : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="pvwatts_version", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_PVWatts_PvwattsVersion PvwattsVersion { get; set; } = (Generator_PVWatts_PvwattsVersion)Enum.Parse(typeof(Generator_PVWatts_PvwattsVersion), "_5");
        

        [Description("Nameplate rated DC system capacity in watts")]
        [JsonProperty(PropertyName="dc_system_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DcSystemCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="module_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_PVWatts_ModuleType ModuleType { get; set; } = (Generator_PVWatts_ModuleType)Enum.Parse(typeof(Generator_PVWatts_ModuleType), "Premium");
        

        [JsonProperty(PropertyName="array_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_PVWatts_ArrayType ArrayType { get; set; } = (Generator_PVWatts_ArrayType)Enum.Parse(typeof(Generator_PVWatts_ArrayType), "FixedOpenRack");
        

        [JsonProperty(PropertyName="system_losses", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SystemLosses { get; set; } = Double.Parse("0.14", CultureInfo.InvariantCulture);
        

        [Description("TiltAzimuth - The tilt and azimuth angles are specified in the next two fields. A" +
                     "n unshaded array is assumed. Surface - The array geometry (tilt and azimuth) as " +
                     "well as shading is determined from surface referenced.")]
        [JsonProperty(PropertyName="array_geometry_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_PVWatts_ArrayGeometryType ArrayGeometryType { get; set; } = (Generator_PVWatts_ArrayGeometryType)Enum.Parse(typeof(Generator_PVWatts_ArrayGeometryType), "TiltAzimuth");
        

        [Description("The tilt angle is the angle from horizontal of the photovoltaic modules in the ar" +
                     "ray.")]
        [JsonProperty(PropertyName="tilt_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TiltAngle { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("For a fixed array, the azimuth angle is the angle clockwise from true north descr" +
                     "ibing the direction that the array faces. For an array with one-axis tracking, t" +
                     "he azimuth angle is the angle clockwise from true north of the axis of rotation." +
                     "")]
        [JsonProperty(PropertyName="azimuth_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AzimuthAngle { get; set; } = Double.Parse("180", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [Description("Applies only to arrays with one-axis tracking and is the ratio of module surface " +
                     "area to area of the ground or roof occupied by the array.")]
        [JsonProperty(PropertyName="ground_coverage_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundCoverageRatio { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
    }
}