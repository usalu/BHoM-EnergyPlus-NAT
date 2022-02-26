using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("The pipe segment to be used in an underground piping system This object represent" +
                 "s a single pipe leg positioned axially in the local z-direction, at a given x, y" +
                 " location in the domain")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PipingSystem_Underground_PipeSegment : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This segment will be centered at this distance from the x=0 domain surface or the" +
                     " basement wall surface, based on whether a basement exists in this domain and th" +
                     "e selection of the shift input field found in the domain object.")]
        [JsonProperty(PropertyName="x_position", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> XPosition { get; set; } = null;
        

        [Description("This segment will be centered at this distance away from the ground surface; thus" +
                     " this value represents the burial depth of this pipe segment.")]
        [JsonProperty(PropertyName="y_position", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> YPosition { get; set; } = null;
        

        [Description("This segment will be simulated such that the flow is in the selected direction. T" +
                     "his can allow for detailed analysis of circuiting effects in a single domain.")]
        [JsonProperty(PropertyName="flow_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PipingSystem_Underground_PipeSegment_FlowDirection FlowDirection { get; set; } = (PipingSystem_Underground_PipeSegment_FlowDirection)Enum.Parse(typeof(PipingSystem_Underground_PipeSegment_FlowDirection), "DecreasingZ");
    }
}