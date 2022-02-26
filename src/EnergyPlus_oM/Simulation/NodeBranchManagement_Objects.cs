using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Node-Branch Management")]
    public class NodeBranchManagement_Objects : BHoMObject
    {
        
        public bool ShouldSerializeBranch_List()
        {
            return (Branch_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Branch", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Branch> Branch_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Branch> ();
        
        public bool ShouldSerializeBranchList_List()
        {
            return (BranchList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="BranchList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.BranchList> BranchList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.BranchList> ();
        
        public bool ShouldSerializeConnector_Splitter_List()
        {
            return (Connector_Splitter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Connector:Splitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Splitter> Connector_Splitter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Splitter> ();
        
        public bool ShouldSerializeConnector_Mixer_List()
        {
            return (Connector_Mixer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Connector:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Mixer> Connector_Mixer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Connector_Mixer> ();
        
        public bool ShouldSerializeConnectorList_List()
        {
            return (ConnectorList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ConnectorList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.ConnectorList> ConnectorList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.ConnectorList> ();
        
        public bool ShouldSerializeNodeList_List()
        {
            return (NodeList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="NodeList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.NodeList> NodeList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.NodeList> ();
        
        public bool ShouldSerializeOutdoorAir_Node_List()
        {
            return (OutdoorAir_Node_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="OutdoorAir:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_Node> OutdoorAir_Node_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_Node> ();
        
        public bool ShouldSerializeOutdoorAir_NodeList_List()
        {
            return (OutdoorAir_NodeList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="OutdoorAir:NodeList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_NodeList> OutdoorAir_NodeList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.OutdoorAir_NodeList> ();
        
        public bool ShouldSerializePipe_Adiabatic_List()
        {
            return (Pipe_Adiabatic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pipe:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic> Pipe_Adiabatic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic> ();
        
        public bool ShouldSerializePipe_Adiabatic_Steam_List()
        {
            return (Pipe_Adiabatic_Steam_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pipe:Adiabatic:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic_Steam> Pipe_Adiabatic_Steam_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Adiabatic_Steam> ();
        
        public bool ShouldSerializePipe_Indoor_List()
        {
            return (Pipe_Indoor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pipe:Indoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Indoor> Pipe_Indoor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Indoor> ();
        
        public bool ShouldSerializePipe_Outdoor_List()
        {
            return (Pipe_Outdoor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pipe:Outdoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Outdoor> Pipe_Outdoor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Outdoor> ();
        
        public bool ShouldSerializePipe_Underground_List()
        {
            return (Pipe_Underground_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Pipe:Underground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Underground> Pipe_Underground_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Pipe_Underground> ();
        
        public bool ShouldSerializePipingSystem_Underground_Domain_List()
        {
            return (PipingSystem_Underground_Domain_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PipingSystem:Underground:Domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_Domain> PipingSystem_Underground_Domain_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_Domain> ();
        
        public bool ShouldSerializePipingSystem_Underground_PipeCircuit_List()
        {
            return (PipingSystem_Underground_PipeCircuit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PipingSystem:Underground:PipeCircuit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeCircuit> PipingSystem_Underground_PipeCircuit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeCircuit> ();
        
        public bool ShouldSerializePipingSystem_Underground_PipeSegment_List()
        {
            return (PipingSystem_Underground_PipeSegment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PipingSystem:Underground:PipeSegment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeSegment> PipingSystem_Underground_PipeSegment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.PipingSystem_Underground_PipeSegment> ();
        
        public bool ShouldSerializeDuct_List()
        {
            return (Duct_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Duct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Duct> Duct_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NodeBranchManagement.Duct> ();
    }
}