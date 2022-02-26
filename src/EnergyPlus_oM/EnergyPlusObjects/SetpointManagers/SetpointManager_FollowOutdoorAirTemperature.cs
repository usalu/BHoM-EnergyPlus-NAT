using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager is used to place a temperature setpoint on a system node th" +
                 "at is derived from the current outdoor air environmental conditions. The outdoor" +
                 " air conditions are obtained from the weather information during the simulation." +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_FollowOutdoorAirTemperature : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_FollowOutdoorAirTemperature_ControlVariable ControlVariable { get; set; } = (SetpointManager_FollowOutdoorAirTemperature_ControlVariable)Enum.Parse(typeof(SetpointManager_FollowOutdoorAirTemperature_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="reference_temperature_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType ReferenceTemperatureType { get; set; } = (SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType)Enum.Parse(typeof(SetpointManager_FollowOutdoorAirTemperature_ReferenceTemperatureType), "OutdoorAirWetBulb");
        

        [JsonProperty(PropertyName="offset_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffsetTemperatureDifference { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointTemperature { get; set; } = null;
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}