using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("Buried Pipe model: For pipes buried at a depth less than one meter, this is an al" +
                 "ternative object to: HeatExchanger:Surface")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pipe_Underground : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty(PropertyName="sun_exposure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pipe_Underground_SunExposure SunExposure { get; set; } = (Pipe_Underground_SunExposure)Enum.Parse(typeof(Pipe_Underground_SunExposure), "NoSun");
        

        [Description("pipe thickness is defined in the Construction object")]
        [JsonProperty(PropertyName="pipe_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeInsideDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeLength { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SoilMaterialName { get; set; } = "";
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pipe_Underground_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (Pipe_Underground_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(Pipe_Underground_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
    }
}