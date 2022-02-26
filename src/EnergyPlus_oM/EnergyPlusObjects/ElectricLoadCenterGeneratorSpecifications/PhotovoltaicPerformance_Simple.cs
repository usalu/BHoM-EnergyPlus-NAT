using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describes a simple model of photovoltaics that may be useful for early phase design analysis. In this model the user has direct access to the efficiency with which surfaces convert incident solar radiation to electricity and need not specify arrays of specific modules.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PhotovoltaicPerformance_Simple : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_surface_area_with_active_solar_cells", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfSurfaceAreaWithActiveSolarCells { get; set; } = null;
        

        [JsonProperty(PropertyName="conversion_efficiency_input_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PhotovoltaicPerformance_Simple_ConversionEfficiencyInputMode ConversionEfficiencyInputMode { get; set; } = (PhotovoltaicPerformance_Simple_ConversionEfficiencyInputMode)Enum.Parse(typeof(PhotovoltaicPerformance_Simple_ConversionEfficiencyInputMode), "Fixed");
        

        [Description("Efficiency = (power generated [W])/(incident solar[W])")]
        [JsonProperty(PropertyName="value_for_cell_efficiency_if_fixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ValueForCellEfficiencyIfFixed { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EfficiencyScheduleName { get; set; } = "";
    }
}