using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager sets the average supply air temperature based on the coolin" +
                 "g load requirements of all controlled zones in an air loop served by a central a" +
                 "ir-conditioner.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_MultiZone_Cooling_Average : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of an AirLoopHVAC object")]
        [JsonProperty(PropertyName="hvac_air_loop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointTemperature { get; set; } = Double.Parse("12", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}