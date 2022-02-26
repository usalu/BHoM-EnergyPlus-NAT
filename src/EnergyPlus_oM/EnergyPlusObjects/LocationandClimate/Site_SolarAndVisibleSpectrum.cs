using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("If this object is omitted, the default solar and visible spectrum data will be us" +
                 "ed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_SolarAndVisibleSpectrum : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The method specifies which of the solar and visible spectrum data to use in the c" +
                     "alculations. Choices: Default - existing hard-wired spectrum data in EnergyPlus." +
                     " UserDefined - user specified spectrum data referenced by the next two fields")]
        [JsonProperty(PropertyName="spectrum_data_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_SolarAndVisibleSpectrum_SpectrumDataMethod SpectrumDataMethod { get; set; } = (Site_SolarAndVisibleSpectrum_SpectrumDataMethod)Enum.Parse(typeof(Site_SolarAndVisibleSpectrum_SpectrumDataMethod), "Default");
        

        [JsonProperty(PropertyName="solar_spectrum_data_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SolarSpectrumDataObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="visible_spectrum_data_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VisibleSpectrumDataObjectName { get; set; } = "";
    }
}