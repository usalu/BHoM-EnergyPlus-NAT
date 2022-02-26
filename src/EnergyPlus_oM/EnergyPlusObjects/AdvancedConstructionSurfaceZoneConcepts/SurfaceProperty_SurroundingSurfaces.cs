using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object defines a list of surrounding surfaces for an exterior surface.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_SurroundingSurfaces : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("optional")]
        [JsonProperty(PropertyName="sky_view_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkyViewFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C optional")]
        [JsonProperty(PropertyName="sky_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SkyTemperatureScheduleName { get; set; } = "";
        

        [Description("optional")]
        [JsonProperty(PropertyName="ground_view_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundViewFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Schedule values are real numbers, -100.0 to 100.0, units C optional")]
        [JsonProperty(PropertyName="ground_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroundTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="surfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SurroundingSurfaces_Surfaces_Item> Surfaces { get; set; } = null;
    }
}