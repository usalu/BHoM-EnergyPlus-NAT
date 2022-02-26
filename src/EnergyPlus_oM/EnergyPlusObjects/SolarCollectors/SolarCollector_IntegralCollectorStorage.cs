using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description(@"Glazed solar collector with integral storage unit. Thermal and optical properties are taken from the referenced SolarCollectorPerformance:IntegralCollectorStorage object. Collector tilt, azimuth, and gross area are taken from the referenced building surface or shading surface. The collector surface participates normally in all shading calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollector_IntegralCollectorStorage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="integralcollectorstorageparameters_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IntegralcollectorstorageparametersName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="bottom_surface_boundary_conditions_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType BottomSurfaceBoundaryConditionsType { get; set; } = (SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType)Enum.Parse(typeof(SolarCollector_IntegralCollectorStorage_BottomSurfaceBoundaryConditionsType), "AmbientAir");
        

        [Description("Enter the name of a SurfaceProperty:OtherSideConditionsModel object. Specified on" +
                     "ly if the boundary condition type is OtherSideConditionsModel, otherwise leave i" +
                     "t blank")]
        [JsonProperty(PropertyName="boundary_condition_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BoundaryConditionModelName { get; set; } = "";
        

        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFlowRate { get; set; } = null;
    }
}