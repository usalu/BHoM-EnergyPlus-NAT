using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("The pipe circuit object in an underground piping system. This object is simulated" +
                 " within an underground piping domain object and connected on a branch on a plant" +
                 " loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_PipeCircuit : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="pipe_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeDensity { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeSpecificHeat { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_inner_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeInnerDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_outer_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeOuterDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="circuit_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CircuitInletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="circuit_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CircuitOutletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="convergence_criterion_for_the_inner_radial_iteration_loop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConvergenceCriterionForTheInnerRadialIterationLoop { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_iterations_in_the_inner_radial_iteration_loop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumIterationsInTheInnerRadialIterationLoop { get; set; } = Double.Parse("500", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="number_of_soil_nodes_in_the_inner_radial_near_pipe_mesh_region", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfSoilNodesInTheInnerRadialNearPipeMeshRegion { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Required because it must be selected by user instead of being inferred from circu" +
                     "it/domain object inputs.")]
        [JsonProperty(PropertyName="radial_thickness_of_inner_radial_near_pipe_mesh_region", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RadialThicknessOfInnerRadialNearPipeMeshRegion { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_pipe_segments_entered_for_this_pipe_circuit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfPipeSegmentsEnteredForThisPipeCircuit { get; set; } = null;
        

        [Description("This list is the PipingSystemUndergroundSegmentNames object-list")]
        [JsonProperty(PropertyName="pipe_segments", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> PipeSegments { get; set; } = null;
    }
}