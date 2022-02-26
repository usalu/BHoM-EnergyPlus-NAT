using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determines the required conditions at the outdoor air strea" +
                 "m node which will produce the reference setpoint condition at the mixed air node" +
                 " when mixed with the return air stream")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_OutdoorAirPretreat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_OutdoorAirPretreat_ControlVariable ControlVariable { get; set; } = (SetpointManager_OutdoorAirPretreat_ControlVariable)Enum.Parse(typeof(SetpointManager_OutdoorAirPretreat_ControlVariable), "HumidityRatio");
        

        [Description("Applicable only if Control variable is Temperature")]
        [JsonProperty(PropertyName="minimum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointTemperature { get; set; } = Double.Parse("-99", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is Temperature")]
        [JsonProperty(PropertyName="maximum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointTemperature { get; set; } = Double.Parse("99", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is MaximumHumidityRatio, MinimumHumidityRatio" +
                     ", or HumidityRatio - then minimum is 0.00001")]
        [JsonProperty(PropertyName="minimum_setpoint_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointHumidityRatio { get; set; } = Double.Parse("1E-05", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Control variable is MaximumHumidityRatio, MinimumHumidityRatio" +
                     ", or HumidityRatio - then minimum is 0.00001")]
        [JsonProperty(PropertyName="maximum_setpoint_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointHumidityRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The current setpoint at this node is the desired condition for the Mixed Air Node" +
                     " This node must have a valid setpoint which has been set by another setpoint man" +
                     "ager")]
        [JsonProperty(PropertyName="reference_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReferenceSetpointNodeName { get; set; } = "";
        

        [Description("Name of Mixed Air Node")]
        [JsonProperty(PropertyName="mixed_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Outdoor Air Stream Node")]
        [JsonProperty(PropertyName="outdoor_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Return Air Stream Node")]
        [JsonProperty(PropertyName="return_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnAirStreamNodeName { get; set; } = "";
        

        [Description("Node(s) at which the temperature or humidity ratio will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}