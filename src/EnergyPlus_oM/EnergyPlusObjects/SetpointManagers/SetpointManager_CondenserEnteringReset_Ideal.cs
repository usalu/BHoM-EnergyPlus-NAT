using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager determine the ideal optimum condenser entering water temper" +
                 "ature setpoint for a given timestep.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_CondenserEnteringReset_Ideal : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_CondenserEnteringReset_Ideal_ControlVariable ControlVariable { get; set; } = (SetpointManager_CondenserEnteringReset_Ideal_ControlVariable)Enum.Parse(typeof(SetpointManager_CondenserEnteringReset_Ideal_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="minimum_lift", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumLift { get; set; } = Double.Parse("11.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_condenser_entering_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCondenserEnteringWaterTemperature { get; set; } = Double.Parse("32", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}