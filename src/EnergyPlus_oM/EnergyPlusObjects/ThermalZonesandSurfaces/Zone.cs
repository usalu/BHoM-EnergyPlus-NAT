using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Defines a thermal zone of the building.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Zone : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="direction_of_relative_north", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DirectionOfRelativeNorth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="x_origin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> XOrigin { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="y_origin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YOrigin { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="z_origin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZOrigin { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Type { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Multiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"If this field is 0.0, negative or autocalculate, then the average height of the zone is automatically calculated and used in subsequent calculations. If this field is positive, then the number entered here will be used. Note that the Zone Ceiling Height is the distance from the Floor to the Ceiling in the Zone, not an absolute height from the ground.")]
        [JsonProperty(PropertyName="ceiling_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CeilingHeight { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If this field is 0.0, negative or autocalculate, then the volume of the zone is a" +
                     "utomatically calculated and used in subsequent calculations. If this field is po" +
                     "sitive, then the number entered here will be used.")]
        [JsonProperty(PropertyName="volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> Volume { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If this field is 0.0, negative or autocalculate, then the floor area of the zone " +
                     "is automatically calculated and used in subsequent calculations. If this field i" +
                     "s positive, then the number entered here will be used.")]
        [JsonProperty(PropertyName="floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> FloorArea { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Will default to same value as SurfaceConvectionAlgorithm:Inside object setting this field overrides the default SurfaceConvectionAlgorithm:Inside for this zone Simple = constant natural convection (ASHRAE) TARP = variable natural convection based on temperature difference (ASHRAE) CeilingDiffuser = ACH based forced and mixed convection correlations for ceiling diffuser configuration with simple natural convection limit AdaptiveConvectionAlgorithm = dynamic selection of convection models based on conditions TrombeWall = variable natural convection in an enclosed rectangular cavity ASTMC1340 = mixed convection correlations specified for attic zone")]
        [JsonProperty(PropertyName="zone_inside_convection_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Zone_ZoneInsideConvectionAlgorithm ZoneInsideConvectionAlgorithm { get; set; } = (Zone_ZoneInsideConvectionAlgorithm)Enum.Parse(typeof(Zone_ZoneInsideConvectionAlgorithm), "Empty");
        

        [Description(@"Will default to same value as SurfaceConvectionAlgorithm:Outside object setting this field overrides the default SurfaceConvectionAlgorithm:Outside for this zone SimpleCombined = Combined radiation and convection coefficient using simple ASHRAE model TARP = correlation from models developed by ASHRAE, Walton, and Sparrow et. al. MoWiTT = correlation from measurements by Klems and Yazdanian for smooth surfaces DOE-2 = correlation from measurements by Klems and Yazdanian for rough surfaces AdaptiveConvectionAlgorithm = dynamic selection of correlations based on conditions")]
        [JsonProperty(PropertyName="zone_outside_convection_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Zone_ZoneOutsideConvectionAlgorithm ZoneOutsideConvectionAlgorithm { get; set; } = (Zone_ZoneOutsideConvectionAlgorithm)Enum.Parse(typeof(Zone_ZoneOutsideConvectionAlgorithm), "Empty");
        

        [JsonProperty(PropertyName="part_of_total_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes PartOfTotalFloorArea { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}