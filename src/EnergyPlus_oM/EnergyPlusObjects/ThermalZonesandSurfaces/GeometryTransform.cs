using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Provides a simple method of altering the footprint geometry of a model. The inten" +
                 "t is to provide a single parameter that can be used to reshape the building desc" +
                 "ription contained in the rest of the input file.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GeometryTransform : BHoMObject
    {
        

        [Description("only current allowed value is \"XY\"")]
        [JsonProperty(PropertyName="plane_of_transform", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GeometryTransform_PlaneOfTransform PlaneOfTransform { get; set; } = (GeometryTransform_PlaneOfTransform)Enum.Parse(typeof(GeometryTransform_PlaneOfTransform), "XY");
        

        [Description("Aspect ratio of building as described in idf")]
        [JsonProperty(PropertyName="current_aspect_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CurrentAspectRatio { get; set; } = null;
        

        [Description("Aspect ratio to transform to during run")]
        [JsonProperty(PropertyName="new_aspect_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NewAspectRatio { get; set; } = null;
    }
}