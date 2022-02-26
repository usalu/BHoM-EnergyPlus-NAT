using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Define the Thermostat settings for a zone or list of zones. If you use a ZoneList" +
                 " in the Zone or ZoneList name field then this definition applies to all the zone" +
                 "s in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description(@"This schedule contains appropriate control types for thermostat. Control types are integers: 0 - Uncontrolled (floating, no thermostat), 1 = ThermostatSetpoint:SingleHeating, 2 = ThermostatSetpoint:SingleCooling, 3 = ThermostatSetpoint:SingleHeatingOrCooling, 4 = ThermostatSetpoint:DualSetpoint")]
        [JsonProperty(PropertyName="control_type_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlTypeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_Control1ObjectType Control1ObjectType { get; set; } = (ZoneControl_Thermostat_Control1ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control1ObjectType), "ThermostatSetpointDualSetpoint");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty(PropertyName="control_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Control1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="control_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_Control2ObjectType Control2ObjectType { get; set; } = (ZoneControl_Thermostat_Control2ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control2ObjectType), "ThermostatSetpointDualSetpoint");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty(PropertyName="control_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Control2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="control_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_Control3ObjectType Control3ObjectType { get; set; } = (ZoneControl_Thermostat_Control3ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control3ObjectType), "ThermostatSetpointDualSetpoint");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty(PropertyName="control_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Control3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="control_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneControl_Thermostat_Control4ObjectType Control4ObjectType { get; set; } = (ZoneControl_Thermostat_Control4ObjectType)Enum.Parse(typeof(ZoneControl_Thermostat_Control4ObjectType), "ThermostatSetpointDualSetpoint");
        

        [Description("Control names are names of individual control objects (e.g. ThermostatSetpoint:Si" +
                     "ngleHeating) Schedule values in these objects list actual setpoint temperatures " +
                     "for the control types")]
        [JsonProperty(PropertyName="control_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Control4Name { get; set; } = "";
        

        [Description("This optional choice field provides a temperature difference between cut-out temp" +
                     "erature and setpoint. The difference is used to adjust to heating or cooling set" +
                     "point based on control types.")]
        [JsonProperty(PropertyName="temperature_difference_between_cutout_and_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureDifferenceBetweenCutoutAndSetpoint { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}