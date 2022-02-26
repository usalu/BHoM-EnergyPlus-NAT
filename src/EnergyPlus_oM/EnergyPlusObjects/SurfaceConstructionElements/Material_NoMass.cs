using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Regular materials properties described whose principal description is R (Thermal " +
                 "Resistance)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Material_NoMass : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="roughness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Material_NoMass_Roughness Roughness { get; set; } = (Material_NoMass_Roughness)Enum.Parse(typeof(Material_NoMass_Roughness), "MediumRough");
        

        [JsonProperty(PropertyName="thermal_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalResistance { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalAbsorptance { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="solar_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarAbsorptance { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="visible_absorptance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleAbsorptance { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
    }
}