using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("used for shading elements such as trees, other buildings, parts of this building " +
                 "not being modeled these items are relative to the current building and would mov" +
                 "e with relative geometry")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Shading_Building : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Facing direction of outside of shading device (S=180,N=0,E=90,W=270)")]
        [JsonProperty(PropertyName="azimuth_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AzimuthAngle { get; set; } = null;
        

        [JsonProperty(PropertyName="tilt_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TiltAngle { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

        [Description("Starting coordinate is the Lower Left Corner of the Shade")]
        [JsonProperty(PropertyName="starting_x_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingXCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="starting_y_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingYCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="starting_z_coordinate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartingZCoordinate { get; set; } = null;
        

        [JsonProperty(PropertyName="length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Length { get; set; } = null;
        

        [JsonProperty(PropertyName="height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Height { get; set; } = null;
    }
}