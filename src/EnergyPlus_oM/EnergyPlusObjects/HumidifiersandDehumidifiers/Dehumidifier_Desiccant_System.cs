using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    [Description(@"This compound object models a desiccant heat exchanger, an optional heater, and associated fans. The process air stream is the air which is dehumidified. The regeneration air stream is the air which is heated to regenerate the desiccant. The desiccant heat exchanger transfers both sensible and latent energy between the process and regeneration air streams. The desiccant dehumidifier is typically used in an AirLoopHVAC:OutdoorAirSystem, but can also be specified in any AirLoopHVAC.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Dehumidifier_Desiccant_System : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="desiccant_heat_exchanger_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType DesiccantHeatExchangerObjectType { get; set; } = (Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_DesiccantHeatExchangerObjectType), "HeatExchangerDesiccantBalancedFlow");
        

        [JsonProperty(PropertyName="desiccant_heat_exchanger_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesiccantHeatExchangerName { get; set; } = "";
        

        [JsonProperty(PropertyName="sensor_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SensorNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="regeneration_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_RegenerationAirFanObjectType RegenerationAirFanObjectType { get; set; } = (Dehumidifier_Desiccant_System_RegenerationAirFanObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_RegenerationAirFanObjectType), "FanConstantVolume");
        

        [JsonProperty(PropertyName="regeneration_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegenerationAirFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="regeneration_air_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_RegenerationAirFanPlacement RegenerationAirFanPlacement { get; set; } = (Dehumidifier_Desiccant_System_RegenerationAirFanPlacement)Enum.Parse(typeof(Dehumidifier_Desiccant_System_RegenerationAirFanPlacement), "DrawThrough");
        

        [Description(@"works with gas, electric, hot water and steam heating coils. For autosizing the regeneration air heating coil the Design Coil Inlet Air Condition used is the outdoor air condition if the desiccant system is on the primary air loop, or else if the desiccant system is on outdoor air system then it is the return air condition. The Design Coil Outlet Air Temperature is the Regeneration Inlet Air Setpoint Temperature specified in the input field below.")]
        [JsonProperty(PropertyName="regeneration_air_heater_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_RegenerationAirHeaterObjectType RegenerationAirHeaterObjectType { get; set; } = (Dehumidifier_Desiccant_System_RegenerationAirHeaterObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_RegenerationAirHeaterObjectType), "CoilHeatingElectric");
        

        [JsonProperty(PropertyName="regeneration_air_heater_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegenerationAirHeaterName { get; set; } = "";
        

        [Description("This value is also used as regeneration air heater design coil air outlet tempera" +
                     "ture for autosizing calculation of the heater.")]
        [JsonProperty(PropertyName="regeneration_inlet_air_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RegenerationInletAirSetpointTemperature { get; set; } = Double.Parse("46", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="companion_cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Dehumidifier_Desiccant_System_CompanionCoolingCoilObjectType CompanionCoolingCoilObjectType { get; set; } = (Dehumidifier_Desiccant_System_CompanionCoolingCoilObjectType)Enum.Parse(typeof(Dehumidifier_Desiccant_System_CompanionCoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty(PropertyName="companion_cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanionCoolingCoilName { get; set; } = "";
        

        [Description("Select Yes if the companion cooling coil is located directly upstream of the desi" +
                     "ccant heat exchanger\'s process air inlet node.")]
        [JsonProperty(PropertyName="companion_cooling_coil_upstream_of_dehumidifier_process_inlet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CompanionCoolingCoilUpstreamOfDehumidifierProcessInlet { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="companion_coil_regeneration_air_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CompanionCoilRegenerationAirHeating { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="exhaust_fan_maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExhaustFanMaximumFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="exhaust_fan_maximum_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExhaustFanMaximumPower { get; set; } = null;
        

        [Description("Curve object type must be Curve:Quadratic or Curve:Cubic")]
        [JsonProperty(PropertyName="exhaust_fan_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustFanPowerCurveName { get; set; } = "";
    }
}