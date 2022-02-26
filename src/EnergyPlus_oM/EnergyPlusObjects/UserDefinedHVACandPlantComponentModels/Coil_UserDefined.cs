using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic air system component for custom modeling using Energy Managemen" +
                 "t System or External Interface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="overall_model_simulation_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OverallModelSimulationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="model_setup_and_sizing_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModelSetupAndSizingProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_air_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfAirConnections { get; set; } = null;
        

        [Description("Inlet air for primary air stream")]
        [JsonProperty(PropertyName="air_connection_1_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirConnection1InletNodeName { get; set; } = "";
        

        [Description("Outlet air for primary air stream")]
        [JsonProperty(PropertyName="air_connection_1_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirConnection1OutletNodeName { get; set; } = "";
        

        [Description("Inlet air for secondary air stream")]
        [JsonProperty(PropertyName="air_connection_2_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirConnection2InletNodeName { get; set; } = "";
        

        [Description("Outlet air for secondary air stream")]
        [JsonProperty(PropertyName="air_connection_2_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirConnection2OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_is_used", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_UserDefined_PlantConnectionIsUsed PlantConnectionIsUsed { get; set; } = (Coil_UserDefined_PlantConnectionIsUsed)Enum.Parse(typeof(Coil_UserDefined_PlantConnectionIsUsed), "No");
        

        [JsonProperty(PropertyName="plant_connection_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnectionInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="plant_connection_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantConnectionOutletNodeName { get; set; } = "";
        

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