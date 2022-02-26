using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic single duct air terminal unit for custom modeling using Energy " +
                 "Management System or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="overall_model_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="model_setup_and_sizing_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

        [Description("Air inlet node for the unit must be a zone splitter outlet.")]
        [JsonProperty(PropertyName="primary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrimaryAirInletNodeName { get; set; } = "";
        

        [Description("Air outlet node for the unit must be a zone air inlet node.")]
        [JsonProperty(PropertyName="primary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrimaryAirOutletNodeName { get; set; } = "";
        

        [Description("Inlet air used for heat rejection or air source")]
        [JsonProperty(PropertyName="secondary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondaryAirInletNodeName { get; set; } = "";
        

        [Description("Outlet air used for heat rejection or air source")]
        [JsonProperty(PropertyName="secondary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondaryAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_plant_loop_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfPlantLoopConnections { get; set; } = null;
        

        [JsonProperty(PropertyName="plant_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection1InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection1OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection2InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnection2OutletNodeName { get; set; } = "";
        

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