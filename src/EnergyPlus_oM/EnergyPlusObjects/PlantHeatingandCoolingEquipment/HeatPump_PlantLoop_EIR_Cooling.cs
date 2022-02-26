using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("An EIR formulated water to water heat pump model, cooling operation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatPump_PlantLoop_EIR_Cooling : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatPump_PlantLoop_EIR_Cooling_CondenserType CondenserType { get; set; } = (HeatPump_PlantLoop_EIR_Cooling_CondenserType)Enum.Parse(typeof(HeatPump_PlantLoop_EIR_Cooling_CondenserType), "WaterSource");
        

        [JsonProperty(PropertyName="source_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [Description("This field allows the user to specify a companion heating object for this cooling" +
                     " object. The companion is used in sizing the heat pump as well as to allow check" +
                     "s for unexpected simultaneous operation of the two objects.")]
        [JsonProperty(PropertyName="companion_heat_pump_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanionHeatPumpName { get; set; } = "";
        

        [Description("This component is currently a constant-flow device, meaning it will always try to" +
                     " request the full design flow from the central plant manager.")]
        [JsonProperty(PropertyName="load_side_reference_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> LoadSideReferenceFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="source_side_reference_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SourceSideReferenceFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ReferenceCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_coefficient_of_performance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCoefficientOfPerformance { get; set; } = Double.Parse("7.5", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Cooling capacity modifier as a function of CW supply temp and entering condenser " +
                     "temp curve = a + b*CWS + c*CWS**2 + d*ECT + e*ECT**2 + f*CWS*ECT CWS = supply (l" +
                     "eaving) chilled water temperature(C) ECT = entering condenser fluid temperature(" +
                     "C)")]
        [JsonProperty(PropertyName="capacity_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CapacityModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Electric Input Ratio (EIR) modifier as a function of temperature EIR = 1/COP curv" +
                     "e = a + b*CWS + c*CWS**2 + d*ECT + e*ECT**2 + f*CWS*ECT CWS = supply (leaving) c" +
                     "hilled water temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="electric_input_to_output_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricInputToOutputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Electric Input Ratio (EIR) modifier as a function of Part Load Ratio (PLR) EIR = " +
                     "1/COP quadratic curve = a + b*PLR + c*PLR**2 is typical, other univariate curves" +
                     " may be used PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="electric_input_to_output_ratio_modifier_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricInputToOutputRatioModifierFunctionOfPartLoadRatioCurveName { get; set; } = "";
    }
}