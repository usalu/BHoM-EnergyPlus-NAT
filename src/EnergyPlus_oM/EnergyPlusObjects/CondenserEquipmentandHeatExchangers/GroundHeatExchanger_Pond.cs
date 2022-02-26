using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("A model of a shallow pond with immersed pipe loops. Typically used in hybrid geot" +
                 "hermal systems and included in the condenser loop. This component may also be us" +
                 "ed as a simple solar collector.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Pond : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fluid_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FluidInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fluid_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FluidOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="pond_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PondDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="pond_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PondArea { get; set; } = null;
        

        [JsonProperty(PropertyName="hydronic_tubing_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingInsideDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="hydronic_tubing_outside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingOutsideDiameter { get; set; } = null;
        

        [JsonProperty(PropertyName="hydronic_tubing_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="ground_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_tubing_circuits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfTubingCircuits { get; set; } = null;
        

        [JsonProperty(PropertyName="length_of_each_tubing_circuit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LengthOfEachTubingCircuit { get; set; } = null;
    }
}