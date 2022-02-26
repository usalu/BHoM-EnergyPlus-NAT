using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Spectrum Data Type is followed by up to 107 sets of normal-incidence measured val" +
                 "ues of [wavelength, spectrum] for wavelengths covering the solar (0.25 to 2.5 mi" +
                 "crons) or visible spectrum (0.38 to 0.78 microns)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_SpectrumData : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="spectrum_data_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Site_SpectrumData_SpectrumDataType SpectrumDataType { get; set; } = (Site_SpectrumData_SpectrumDataType)Enum.Parse(typeof(Site_SpectrumData_SpectrumDataType), "Solar");
        

        [JsonProperty(PropertyName="wavelength", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength { get; set; } = null;
        

        [JsonProperty(PropertyName="spectrum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Spectrum { get; set; } = null;
        

        [JsonProperty(PropertyName="wavelength_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Wavelength1 { get; set; } = null;
        

        [JsonProperty(PropertyName="spectrum_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Spectrum2 { get; set; } = null;
        

        [JsonProperty(PropertyName="extensions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SpectrumData_Extensions_Item> Extensions { get; set; } = null;
    }
}