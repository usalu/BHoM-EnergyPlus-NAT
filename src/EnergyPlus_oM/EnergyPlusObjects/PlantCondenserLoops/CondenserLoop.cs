using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserLoops
{
    [Description("Defines a central plant condenser loop. CondenserLoop and PlantLoop are nearly id" +
                 "entical except some components and operation schemes are applicable to only one " +
                 "loop type or the other.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CondenserLoop : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CondenserLoop_FluidType FluidType { get; set; } = (CondenserLoop_FluidType)Enum.Parse(typeof(CondenserLoop_FluidType), "Water");
        

        [Description("This field is only required when Fluid Type is UserDefinedFluidType")]
        [JsonProperty(PropertyName="user_defined_fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserDefinedFluidType { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_equipment_operation_scheme_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserEquipmentOperationSchemeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_loop_temperature_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserLoopTemperatureSetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_loop_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumLoopTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_loop_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumLoopTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_loop_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumLoopFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_loop_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumLoopFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condenser_loop_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CondenserLoopVolume { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condenser_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_side_branch_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserSideBranchListName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_side_connector_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserSideConnectorListName { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_demand_side_branch_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserDemandSideBranchListName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_demand_side_connector_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserDemandSideConnectorListName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_distribution_scheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CondenserLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (CondenserLoop_LoadDistributionScheme)Enum.Parse(typeof(CondenserLoop_LoadDistributionScheme), "SequentialLoad");
        

        [JsonProperty(PropertyName="pressure_simulation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CondenserLoop_PressureSimulationType PressureSimulationType { get; set; } = (CondenserLoop_PressureSimulationType)Enum.Parse(typeof(CondenserLoop_PressureSimulationType), "None");
        

        [Description("This field is only used to autocalulate the Condenser Loop Volume. Loop Volume = " +
                     "Loop Circulation Time * Maximum Loop Flow Rate")]
        [JsonProperty(PropertyName="loop_circulation_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoopCirculationTime { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
    }
}