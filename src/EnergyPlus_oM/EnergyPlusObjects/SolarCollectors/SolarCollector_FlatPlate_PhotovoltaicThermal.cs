using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("Models hybrid photovoltaic-thermal (PVT) solar collectors that convert incident s" +
                 "olar energy into both electricity and useful thermal energy by heating air or wa" +
                 "ter.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollector_FlatPlate_PhotovoltaicThermal : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="photovoltaic_thermal_model_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhotovoltaicThermalModelPerformanceName { get; set; } = "";
        

        [Description("Enter the name of a Generator:Photovoltaic object.")]
        [JsonProperty(PropertyName="photovoltaic_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PhotovoltaicName { get; set; } = "";
        

        [JsonProperty(PropertyName="thermal_working_fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType ThermalWorkingFluidType { get; set; } = (SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType)Enum.Parse(typeof(SolarCollector_FlatPlate_PhotovoltaicThermal_ThermalWorkingFluidType), "Air");
        

        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}