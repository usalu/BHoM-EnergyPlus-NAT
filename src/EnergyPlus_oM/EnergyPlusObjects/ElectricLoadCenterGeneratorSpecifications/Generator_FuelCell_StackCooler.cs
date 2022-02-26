using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This object is optional and is used to define details needed to model the stack c" +
                 "ooler on PEMFC.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_StackCooler : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="nominal_stack_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalStackTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="actual_stack_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ActualStackTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_r0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoefficientR0 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_r1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoefficientR1 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_r2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoefficientR2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_r3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoefficientR3 { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_coolant_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCoolantFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cooler_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCoolerUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty(PropertyName="fs_cogen_adjustment_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FsCogenAdjustmentFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cogeneration_exchanger_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCogenerationExchangerArea { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cogeneration_exchanger_nominal_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCogenerationExchangerNominalFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cogeneration_exchanger_nominal_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCogenerationExchangerNominalHeatTransferCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cogeneration_exchanger_nominal_heat_transfer_coefficient_exponent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCogenerationExchangerNominalHeatTransferCoefficientExponent { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cooler_pump_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCoolerPumpPower { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_cooler_pump_heat_loss_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackCoolerPumpHeatLossFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_air_cooler_fan_coefficient_f0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackAirCoolerFanCoefficientF0 { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_air_cooler_fan_coefficient_f1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackAirCoolerFanCoefficientF1 { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_air_cooler_fan_coefficient_f2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackAirCoolerFanCoefficientF2 { get; set; } = null;
    }
}