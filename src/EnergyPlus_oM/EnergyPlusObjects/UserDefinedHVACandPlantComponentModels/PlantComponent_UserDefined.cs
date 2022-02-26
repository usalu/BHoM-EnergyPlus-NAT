using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic plant component for custom modeling using Energy Management Sys" +
                 "tem or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantComponent_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="main_model_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainModelProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_plant_loop_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfPlantLoopConnections { get; set; } = null;
        

        [JsonProperty(PropertyName="plant_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection1InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection1OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_1_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection1LoadingMode PlantConnection1LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection1LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection1LoadingMode), "DemandsLoad");
        

        [JsonProperty(PropertyName="plant_connection_1_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode PlantConnection1LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection1LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

        [JsonProperty(PropertyName="plant_connection_1_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection1InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_1_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection1SimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection2InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection2OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_2_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection2LoadingMode PlantConnection2LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection2LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection2LoadingMode), "DemandsLoad");
        

        [JsonProperty(PropertyName="plant_connection_2_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode PlantConnection2LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection2LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

        [JsonProperty(PropertyName="plant_connection_2_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection2InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_2_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection2SimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_3_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection3InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_3_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection3OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_3_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection3LoadingMode PlantConnection3LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection3LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection3LoadingMode), "DemandsLoad");
        

        [JsonProperty(PropertyName="plant_connection_3_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode PlantConnection3LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection3LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

        [JsonProperty(PropertyName="plant_connection_3_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection3InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_3_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection3SimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_4_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection4InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_4_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection4OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_4_loading_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection4LoadingMode PlantConnection4LoadingMode { get; set; } = (PlantComponent_UserDefined_PlantConnection4LoadingMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection4LoadingMode), "DemandsLoad");
        

        [JsonProperty(PropertyName="plant_connection_4_loop_flow_request_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode PlantConnection4LoopFlowRequestMode { get; set; } = (PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode)Enum.Parse(typeof(PlantComponent_UserDefined_PlantConnection4LoopFlowRequestMode), "NeedsFlowAndTurnsLoopOn");
        

        [JsonProperty(PropertyName="plant_connection_4_initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection4InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_4_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection4SimulationProgramCallingManagerName { get; set; } = "";
        

        [Description("Inlet air used for heat rejection or air source")]
        [JsonProperty(PropertyName="air_connection_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirConnectionInletNodeName { get; set; } = "";
        

        [Description("Outlet air used for heat rejection or air source")]
        [JsonProperty(PropertyName="air_connection_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirConnectionOutletNodeName { get; set; } = "";
        

        [Description("Water use storage tank for alternate source of water consumed by device")]
        [JsonProperty(PropertyName="supply_inlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyInletWaterStorageTankName { get; set; } = "";
        

        [Description("Water use storage tank for collection of condensate by device")]
        [JsonProperty(PropertyName="collection_outlet_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CollectionOutletWaterStorageTankName { get; set; } = "";
        

        [Description("Used for modeling device losses to surrounding zone")]
        [JsonProperty(PropertyName="ambient_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientZoneName { get; set; } = "";
    }
}