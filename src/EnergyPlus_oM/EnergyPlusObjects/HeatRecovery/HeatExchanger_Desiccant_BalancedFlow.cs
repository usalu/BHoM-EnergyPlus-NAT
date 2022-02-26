using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    [Description(@"This object models a balanced desiccant heat exchanger. The heat exchanger transfers both sensible and latent energy between the process and regeneration air streams. The air flow rate and face velocity are assumed to be the same on both the process and regeneration sides of the heat exchanger.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatExchanger_Desiccant_BalancedFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="regeneration_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegenerationAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="regeneration_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegenerationAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="process_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProcessAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="process_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProcessAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_exchanger_performance_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType HeatExchangerPerformanceObjectType { get; set; } = (HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType)Enum.Parse(typeof(HeatExchanger_Desiccant_BalancedFlow_HeatExchangerPerformanceObjectType), "Empty");
        

        [JsonProperty(PropertyName="heat_exchanger_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatExchangerPerformanceName { get; set; } = "";
        

        [Description("Yes means that the heat exchanger will be locked out (off) when the economizer is" +
                     " operating or high humidity control is active")]
        [JsonProperty(PropertyName="economizer_lockout", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes EconomizerLockout { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
    }
}