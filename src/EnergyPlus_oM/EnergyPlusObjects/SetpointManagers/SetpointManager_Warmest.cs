using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This SetpointManager resets the cooling supply air temperature of a central force" +
                 "d air HVAC system according to the cooling demand of the warmest zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_Warmest : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_Warmest_ControlVariable ControlVariable { get; set; } = (SetpointManager_Warmest_ControlVariable)Enum.Parse(typeof(SetpointManager_Warmest_ControlVariable), "Temperature");
        

        [Description("Enter the name of an AirLoopHVAC object")]
        [JsonProperty(PropertyName="hvac_air_loop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointTemperature { get; set; } = Double.Parse("12", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_Warmest_Strategy Strategy { get; set; } = (SetpointManager_Warmest_Strategy)Enum.Parse(typeof(SetpointManager_Warmest_Strategy), "MaximumTemperature");
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}