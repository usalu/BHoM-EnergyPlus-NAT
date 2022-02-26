using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(@"A hydronic surface/panel consisting of a multi-layer construction with embedded rows of tubes. Typically used in hybrid geothermal systems and included in the condenser loop. This component may also be used as a simple solar collector. The bottom surface may be defined as ground-coupled or exposed to wind (eg. bridge deck).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Surface : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [JsonProperty(PropertyName="fluid_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fluid_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="hydronic_tubing_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingInsideDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_tubing_circuits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfTubingCircuits { get; set; } = null;
        

        [JsonProperty(PropertyName="hydronic_tube_spacing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubeSpacing { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SurfaceLength { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SurfaceWidth { get; set; } = null;
        

        [JsonProperty(PropertyName="lower_surface_environment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_Surface_LowerSurfaceEnvironment LowerSurfaceEnvironment { get; set; } = (GroundHeatExchanger_Surface_LowerSurfaceEnvironment)Enum.Parse(typeof(GroundHeatExchanger_Surface_LowerSurfaceEnvironment), "Ground");
    }
}