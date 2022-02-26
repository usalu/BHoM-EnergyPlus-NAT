using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("The Mixed Air Setpoint Manager is meant to be used in conjunction with a Controll" +
                 "er:OutdoorAir object. This setpoint manager is used to establish a temperature s" +
                 "etpoint at the mixed air node.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_MixedAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_MixedAir_ControlVariable ControlVariable { get; set; } = (SetpointManager_MixedAir_ControlVariable)Enum.Parse(typeof(SetpointManager_MixedAir_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="reference_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReferenceSetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanOutletNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
                     "ng coil.")]
        [JsonProperty(PropertyName="cooling_coil_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilInletNodeName { get; set; } = "";
        

        [Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
                     "ng coil.")]
        [JsonProperty(PropertyName="cooling_coil_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilOutletNodeName { get; set; } = "";
        

        [Description("Optional field used to limit economizer operation to prevent freezing of DX cooli" +
                     "ng coil.")]
        [JsonProperty(PropertyName="minimum_temperature_at_cooling_coil_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumTemperatureAtCoolingCoilOutletNode { get; set; } = Double.Parse("7.2", CultureInfo.InvariantCulture);
    }
}