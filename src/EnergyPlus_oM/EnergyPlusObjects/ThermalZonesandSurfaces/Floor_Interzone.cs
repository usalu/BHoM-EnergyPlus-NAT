using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of floors using adjacent zone (interzone) heat transf" +
                 "er - adjacent surface should be a ceiling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Floor_Interzone : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone for the inside of the surface")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Specify a surface name in an adjacent zone for known interior ceilings. Specify a" +
                     " zone name of an adjacent zone to automatically generate the interior ceiling in" +
                     " the adjacent zone.")]
        [JsonProperty(PropertyName="outside_boundary_condition_object", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideBoundaryConditionObject { get; set; } = "";
        

        [JsonProperty(PropertyName="azimuth_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AzimuthAngle { get; set; } = null;
        

        [Description("Floors are usually tilted 180 degrees")]
        [JsonProperty(PropertyName="tilt_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TiltAngle { get; set; } = Double.Parse("180", CultureInfo.InvariantCulture);
        

        [Description("If not Flat, should be Lower Left Corner (from outside)")]
        [JsonProperty(PropertyName="starting_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingXCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="starting_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingYCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="starting_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingZCoordinate { get; set; } = null;
        

        [Description("Along X Axis")]
        [JsonProperty(PropertyName="length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Length { get; set; } = null;
        

        [Description("Along Y Axis")]
        [JsonProperty(PropertyName="width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Width { get; set; } = null;
    }
}