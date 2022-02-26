using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers
{
    [Description("Overrides fan/pump schedules depending on temperature difference between two node" +
                 "s.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AvailabilityManager_DifferentialThermostat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="hot_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cold_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColdNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="temperature_difference_on_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureDifferenceOnLimit { get; set; } = null;
        

        [Description("Defaults to Temperature Difference On Limit.")]
        [JsonProperty(PropertyName="temperature_difference_off_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureDifferenceOffLimit { get; set; } = null;
    }
}