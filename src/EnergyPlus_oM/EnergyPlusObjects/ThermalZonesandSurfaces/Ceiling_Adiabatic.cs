using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Allows for simplified entry of interior ceilings.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Ceiling_Adiabatic : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("To be matched with a construction in this input file")]
        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("Zone the surface is a part of")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Facing direction of outside of Ceiling")]
        [JsonProperty(PropertyName="azimuth_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AzimuthAngle { get; set; } = null;
        

        [Description("Ceilings are usually tilted 0 degrees")]
        [JsonProperty(PropertyName="tilt_angle", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TiltAngle { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If not Flat, Starting coordinate is the Lower Left Corner of the Ceiling")]
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