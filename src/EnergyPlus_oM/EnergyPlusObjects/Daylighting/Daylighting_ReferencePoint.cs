using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Used by Daylighting:Controls to identify the reference point coordinates for each" +
                 " sensor. Reference points are given in coordinates specified in the GlobalGeomet" +
                 "ryRules object Daylighting Reference Point CoordinateSystem field")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Daylighting_ReferencePoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="x_coordinate_of_reference_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> XCoordinateOfReferencePoint { get; set; } = null;
        

        [JsonProperty(PropertyName="y_coordinate_of_reference_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YCoordinateOfReferencePoint { get; set; } = null;
        

        [JsonProperty(PropertyName="z_coordinate_of_reference_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZCoordinateOfReferencePoint { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
    }
}