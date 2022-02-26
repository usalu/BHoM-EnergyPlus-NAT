using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("Models a fan that exhausts air from a zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_ZoneExhaust : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanTotalEfficiency { get; set; } = Double.Parse("0.6", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pressure_rise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PressureRise { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [Description("If field is used, then when fan runs the exhausted air flow rate is controlled to" +
                     " be the scheduled fraction times the Maximum Flow Rate")]
        [JsonProperty(PropertyName="flow_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FlowFractionScheduleName { get; set; } = "";
        

        [Description("Control if fan is to be interlocked with HVAC system Availability Managers or not" +
                     ".")]
        [JsonProperty(PropertyName="system_availability_manager_coupling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode SystemAvailabilityManagerCouplingMode { get; set; } = (Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode)Enum.Parse(typeof(Fan_ZoneExhaust_SystemAvailabilityManagerCouplingMode), "Coupled");
        

        [Description("If field is used, the exhaust fan will not run if the zone temperature is lower t" +
                     "han this limit")]
        [JsonProperty(PropertyName="minimum_zone_temperature_limit_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumZoneTemperatureLimitScheduleName { get; set; } = "";
        

        [Description("Used to control fan\'s impact on flow at the return air node. Enter the portion of" +
                     " the exhaust that is balanced by simple airflows.")]
        [JsonProperty(PropertyName="balanced_exhaust_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BalancedExhaustFractionScheduleName { get; set; } = "";
    }
}