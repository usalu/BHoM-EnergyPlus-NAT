using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the connection between two nodes and a component.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Linkage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of zone or AirflowNetwork Node.")]
        [JsonProperty(PropertyName="node_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Node1Name { get; set; } = "";
        

        [Description("Enter the name of zone or AirflowNetwork Node.")]
        [JsonProperty(PropertyName="node_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Node2Name { get; set; } = "";
        

        [Description("Enter the name of an AirflowNetwork component. A component is one of the followin" +
                     "g AirflowNetwork:Distribution:Component objects: Leak, LeakageRatio, Duct, Const" +
                     "antVolumeFan, Coil, TerminalUnit, ConstantPressureDrop, or HeatExchanger.")]
        [JsonProperty(PropertyName="component_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentName { get; set; } = "";
        

        [Description("Only used if component = AirflowNetwork:Distribution:Component:Duct The zone name" +
                     " is where AirflowNetwork:Distribution:Component:Duct is exposed. Leave this fiel" +
                     "d blank if the duct conduction loss is ignored.")]
        [JsonProperty(PropertyName="thermal_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalZoneName { get; set; } = "";
    }
}