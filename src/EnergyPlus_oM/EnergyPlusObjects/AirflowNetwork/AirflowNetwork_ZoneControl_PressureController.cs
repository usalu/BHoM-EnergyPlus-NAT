using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to control a zone to a specified indoor pressure using the Ai" +
                 "rflowNetwork model. The specified pressure setpoint is used to control the zone " +
                 "exhaust fan flow rate in a controlled zone or the relief air flow rate in an air" +
                 " loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_ZoneControl_PressureController : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneName { get; set; } = "";
        

        [Description("The current selection is AirflowNetwork:MultiZone:Component:ZoneExhaustFan or Air" +
                     "flowNetwork:Distribution:Component:ReliefAirFlow.")]
        [JsonProperty(PropertyName="control_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_ZoneControl_PressureController_ControlObjectType ControlObjectType { get; set; } = (AirflowNetwork_ZoneControl_PressureController_ControlObjectType)Enum.Parse(typeof(AirflowNetwork_ZoneControl_PressureController_ControlObjectType), "AirflowNetworkDistributionComponentReliefAirFlow");
        

        [Description("Control names are names of individual control objects")]
        [JsonProperty(PropertyName="control_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlObjectName { get; set; } = "";
        

        [Description("Availability schedule name for pressure controller. Schedule value > 0 means the " +
                     "pressure controller is enabled. If this field is blank, then pressure controller" +
                     " is always enabled.")]
        [JsonProperty(PropertyName="pressure_control_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PressureControlAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="pressure_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PressureSetpointScheduleName { get; set; } = "";
    }
}