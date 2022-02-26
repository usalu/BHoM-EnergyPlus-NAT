using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This SetpointManager is used in dual duct systems to reset the setpoint temperatu" +
                 "re of the air in the heating supply duct. Usually it is used in conjunction with" +
                 " a SetpointManager:Warmest resetting the temperature of the air in the cooling s" +
                 "upply duct.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_Coldest : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_Coldest_ControlVariable ControlVariable { get; set; } = (SetpointManager_Coldest_ControlVariable)Enum.Parse(typeof(SetpointManager_Coldest_ControlVariable), "Temperature");
        

        [Description("Enter the name of an AirLoopHVAC object.")]
        [JsonProperty(PropertyName="hvac_air_loop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointTemperature { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointTemperature { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_Coldest_Strategy Strategy { get; set; } = (SetpointManager_Coldest_Strategy)Enum.Parse(typeof(SetpointManager_Coldest_Strategy), "MinimumTemperature");
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}