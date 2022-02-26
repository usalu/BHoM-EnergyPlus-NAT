using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes the exhaust gas heat exchanger subsystem of a fuel cell power generator" +
                 " used to recovery thermal energy")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_ExhaustGasToWaterHeatExchanger : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryWaterMaximumFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="exhaust_outlet_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustOutletAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_exchanger_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod HeatExchangerCalculationMethod { get; set; } = (Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod)Enum.Parse(typeof(Generator_FuelCell_ExhaustGasToWaterHeatExchanger_HeatExchangerCalculationMethod), "Condensing");
        

        [JsonProperty(PropertyName="method_1_heat_exchanger_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method1HeatExchangerEffectiveness { get; set; } = null;
        

        [JsonProperty(PropertyName="method_2_parameter_hxs0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method2ParameterHxs0 { get; set; } = null;
        

        [JsonProperty(PropertyName="method_2_parameter_hxs1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method2ParameterHxs1 { get; set; } = null;
        

        [JsonProperty(PropertyName="method_2_parameter_hxs2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method2ParameterHxs2 { get; set; } = null;
        

        [JsonProperty(PropertyName="method_2_parameter_hxs3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method2ParameterHxs3 { get; set; } = null;
        

        [JsonProperty(PropertyName="method_2_parameter_hxs4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method2ParameterHxs4 { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_h0gas_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3H0gasCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_ndotgasref_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3NdotgasrefCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_n_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3NCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_gas_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3GasArea { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_h0_water_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3H0WaterCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_n_dot_water_ref_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3NDotWaterRefCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_m_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3MCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_water_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3WaterArea { get; set; } = null;
        

        [JsonProperty(PropertyName="method_3_f_adjustment_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method3FAdjustmentFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="method_4_hxl1_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method4Hxl1Coefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_4_hxl2_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method4Hxl2Coefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="method_4_condensation_threshold", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Method4CondensationThreshold { get; set; } = null;
    }
}