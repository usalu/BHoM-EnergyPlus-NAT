using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("Thermal performance parameters for a hybrid photovoltaic-thermal (PVT) solar coll" +
                 "ector.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollectorPerformance_PhotovoltaicThermal_Simple : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fraction_of_surface_area_with_active_thermal_collector", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfSurfaceAreaWithActiveThermalCollector { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conversion_efficiency_input_mode_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType ThermalConversionEfficiencyInputModeType { get; set; } = (SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType)Enum.Parse(typeof(SolarCollectorPerformance_PhotovoltaicThermal_Simple_ThermalConversionEfficiencyInputModeType), "Fixed");
        

        [Description("Efficiency = (thermal power generated [W])/(incident solar[W])")]
        [JsonProperty(PropertyName="value_for_thermal_conversion_efficiency_if_fixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ValueForThermalConversionEfficiencyIfFixed { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conversion_efficiency_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalConversionEfficiencyScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="front_surface_emittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FrontSurfaceEmittance { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
    }
}