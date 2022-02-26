using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describes an array of photovoltaic (PV) modules. A series of different PV arrays can be connected to a single electric load center (and inverter) by listing them all in an ElectricLoadCenter:Generator object. PV performance is taken from the referenced PhotovoltaicPerformance:* object. Array tilt, azimuth, and gross area are taken from the referenced building surface or shading surface. The array surface participates normally in all shading calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_Photovoltaic : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="photovoltaic_performance_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_Photovoltaic_PhotovoltaicPerformanceObjectType PhotovoltaicPerformanceObjectType { get; set; } = (Generator_Photovoltaic_PhotovoltaicPerformanceObjectType)Enum.Parse(typeof(Generator_Photovoltaic_PhotovoltaicPerformanceObjectType), "PhotovoltaicPerformanceEquivalentOneDiode");
        

        [Description("PV array modeling details")]
        [JsonProperty(PropertyName="module_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModulePerformanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_transfer_integration_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_Photovoltaic_HeatTransferIntegrationMode HeatTransferIntegrationMode { get; set; } = (Generator_Photovoltaic_HeatTransferIntegrationMode)Enum.Parse(typeof(Generator_Photovoltaic_HeatTransferIntegrationMode), "Decoupled");
        

        [Description("number of series-wired strings of PV modules that are in parallel")]
        [JsonProperty(PropertyName="number_of_series_strings_in_parallel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfSeriesStringsInParallel { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Number of PV modules wired in series for each string.")]
        [JsonProperty(PropertyName="number_of_modules_in_series", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfModulesInSeries { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}