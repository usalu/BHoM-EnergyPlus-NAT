using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Daylighting
{
    [Description("Defines a tubular daylighting device (TDD) consisting of three components: a dome" +
                 ", a pipe, and a diffuser. The dome and diffuser are defined separately using the" +
                 " FenestrationSurface:Detailed object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DaylightingDevice_Tubular : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This must refer to a subsurface object of type TubularDaylightDome")]
        [JsonProperty(PropertyName="dome_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DomeName { get; set; } = "";
        

        [Description("This must refer to a subsurface object of type TubularDaylightDiffuser Delivery z" +
                     "one is specified in the diffuser object")]
        [JsonProperty(PropertyName="diffuser_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DiffuserName { get; set; } = "";
        

        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty(PropertyName="diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Diameter { get; set; } = null;
        

        [Description("The exterior exposed length is the difference between total and sum of zone lengt" +
                     "hs")]
        [JsonProperty(PropertyName="total_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalLength { get; set; } = null;
        

        [Description("R value between TubularDaylightDome and TubularDaylightDiffuser")]
        [JsonProperty(PropertyName="effective_thermal_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveThermalResistance { get; set; } = Double.Parse("0.28", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="transition_lengths", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Tubular_TransitionLengths_Item> TransitionLengths { get; set; } = null;
    }
}