using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Pipe model with transport delay and heat transfer to the environment.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Outdoor : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty(PropertyName="ambient_temperature_outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="pipe_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeInsideDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeLength { get; set; } = null;
    }
}