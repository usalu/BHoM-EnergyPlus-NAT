using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("simple water-water heat pump curve-fit model")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatPump_WaterToWater_EquationFit_Cooling : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_load_side_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ReferenceLoadSideFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_source_side_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ReferenceSourceSideFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ReferenceCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_cooling_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ReferenceCoolingPowerConsumption { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_capacity_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCapacityCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_compressor_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCompressorPowerCurveName { get; set; } = "";
        

        [Description("This optional field is used to autosize Reference Cooling Power Consumption COP =" +
                     " Rated Cooling Capacity / Rated Cooling Power Consumption")]
        [JsonProperty(PropertyName="reference_coefficient_of_performance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCoefficientOfPerformance { get; set; } = Double.Parse("8", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This optional field is used to coordinate sizing calculations between heating and" +
                     " cooling modes.")]
        [JsonProperty(PropertyName="companion_heating_heat_pump_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanionHeatingHeatPumpName { get; set; } = "";
    }
}