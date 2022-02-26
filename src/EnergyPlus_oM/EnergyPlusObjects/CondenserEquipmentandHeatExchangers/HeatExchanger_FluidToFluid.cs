using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("A fluid/fluid heat exchanger designed to couple the supply side of one loop to th" +
                 "e demand side of another loop Loops can be either plant or condenser loops but n" +
                 "o air side connections are allowed")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatExchanger_FluidToFluid : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available. default is " +
                     "that heat exchanger is on")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This connection is to the demand side of a loop and is the inlet to the heat exch" +
                     "anger")]
        [JsonProperty(PropertyName="loop_demand_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoopDemandSideInletNodeName { get; set; } = "";
        

        [Description("This connection is to the demand side of a loop")]
        [JsonProperty(PropertyName="loop_demand_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoopDemandSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="loop_demand_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> LoopDemandSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="loop_supply_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoopSupplySideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="loop_supply_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoopSupplySideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="loop_supply_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> LoopSupplySideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_exchange_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_FluidToFluid_HeatExchangeModelType HeatExchangeModelType { get; set; } = (HeatExchanger_FluidToFluid_HeatExchangeModelType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_HeatExchangeModelType), "Ideal");
        

        [JsonProperty(PropertyName="heat_exchanger_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatExchangerUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_FluidToFluid_ControlType ControlType { get; set; } = (HeatExchanger_FluidToFluid_ControlType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_ControlType), "UncontrolledOn");
        

        [Description("Setpoint node is needed with any Control Type that is \"*Setpoint*\"")]
        [JsonProperty(PropertyName="heat_exchanger_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatExchangerSetpointNodeName { get; set; } = "";
        

        [Description("Tolerance between control temperatures used to determine if heat exchanger should" +
                     " run.")]
        [JsonProperty(PropertyName="minimum_temperature_difference_to_activate_heat_exchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumTemperatureDifferenceToActivateHeatExchanger { get; set; } = Double.Parse("0.01", CultureInfo.InvariantCulture);
        

        [Description("This field controls end use reporting for heat transfer meters")]
        [JsonProperty(PropertyName="heat_transfer_metering_end_use_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType HeatTransferMeteringEndUseType { get; set; } = (HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType)Enum.Parse(typeof(HeatExchanger_FluidToFluid_HeatTransferMeteringEndUseType), "LoopToLoop");
        

        [Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
                     "ntOverride")]
        [JsonProperty(PropertyName="component_override_loop_supply_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentOverrideLoopSupplySideInletNodeName { get; set; } = "";
        

        [Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
                     "ntOverride")]
        [JsonProperty(PropertyName="component_override_loop_demand_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentOverrideLoopDemandSideInletNodeName { get; set; } = "";
        

        [Description("This field is only used if Control Type is set to CoolingSetpointOnOffWithCompone" +
                     "ntOverride")]
        [JsonProperty(PropertyName="component_override_cooling_control_temperature_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode ComponentOverrideCoolingControlTemperatureMode { get; set; } = (HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode)Enum.Parse(typeof(HeatExchanger_FluidToFluid_ComponentOverrideCoolingControlTemperatureMode), "Loop");
        

        [Description("Multiplies the autosized flow rates for this device")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Lower limit on inlet temperatures, heat exchanger will not operate if either inle" +
                     "t is below this limit")]
        [JsonProperty(PropertyName="operation_minimum_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OperationMinimumTemperatureLimit { get; set; } = null;
        

        [Description("Upper limit on inlet temperatures, heat exchanger will not operate if either inle" +
                     "t is above this limit")]
        [JsonProperty(PropertyName="operation_maximum_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OperationMaximumTemperatureLimit { get; set; } = null;
    }
}