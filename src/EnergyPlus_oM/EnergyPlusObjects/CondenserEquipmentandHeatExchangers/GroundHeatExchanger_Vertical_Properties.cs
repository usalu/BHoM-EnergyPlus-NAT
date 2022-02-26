using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("Properties for vertical ground heat exchanger systems")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Vertical_Properties : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="depth_of_top_of_borehole", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DepthOfTopOfBorehole { get; set; } = null;
        

        [JsonProperty(PropertyName="borehole_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BoreholeLength { get; set; } = null;
        

        [JsonProperty(PropertyName="borehole_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BoreholeDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="grout_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroutThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="grout_thermal_heat_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroutThermalHeatCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_thermal_heat_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThermalHeatCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_outer_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeOuterDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="pipe_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PipeThickness { get; set; } = null;
        

        [JsonProperty(PropertyName="u_tube_distance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UTubeDistance { get; set; } = null;
    }
}