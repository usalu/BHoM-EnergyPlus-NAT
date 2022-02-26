using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("The fluid cooler is modeled as a cross flow heat exchanger (both streams unmixed)" +
                 " with two-speed fans (induced draft configuration).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidCooler_TwoSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of fluid cooler water inlet node")]
        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of fluid cooler water outlet node")]
        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
                     "A and the Design Water Flow Rate, or by specifying the fluid cooler nominal capa" +
                     "city")]
        [JsonProperty(PropertyName="performance_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FluidCooler_TwoSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (FluidCooler_TwoSpeed_PerformanceInputMethod)Enum.Parse(typeof(FluidCooler_TwoSpeed_PerformanceInputMethod), "NominalCapacity");
        

        [Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
        [JsonProperty(PropertyName="high_fan_speed_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HighFanSpeedUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity Low" +
                     " speed fluid cooler UA must be less than high speed fluid cooler UA Low speed fl" +
                     "uid cooler UA must be greater than free convection fluid cooler UA")]
        [JsonProperty(PropertyName="low_fan_speed_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> LowFanSpeedUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is only used if the previous field is set to autocalculate and the Per" +
                     "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
        [JsonProperty(PropertyName="low_fan_speed_u_factor_times_area_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowFanSpeedUFactorTimesAreaSizingFactor { get; set; } = Double.Parse("0.6", CultureInfo.InvariantCulture);
        

        [Description("Nominal fluid cooler capacity at high fan speed")]
        [JsonProperty(PropertyName="high_speed_nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighSpeedNominalCapacity { get; set; } = null;
        

        [Description("Nominal fluid cooler capacity at low fan speed")]
        [JsonProperty(PropertyName="low_speed_nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> LowSpeedNominalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is only used if the previous field is set to autocalculate and the Per" +
                     "formance Input Method is NominalCapacity")]
        [JsonProperty(PropertyName="low_speed_nominal_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowSpeedNominalCapacitySizingFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("Design Entering Water Temperature must be specified for both the performance inpu" +
                     "t methods and its value must be greater than Design Entering Air Temperature.")]
        [JsonProperty(PropertyName="design_entering_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringWaterTemperature { get; set; } = null;
        

        [Description("Design Entering Air Temperature must be specified for both the performance input " +
                     "methods and its value must be greater than Design Entering Air Wet-bulb Temperat" +
                     "ure.")]
        [JsonProperty(PropertyName="design_entering_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringAirTemperature { get; set; } = null;
        

        [Description("Design Entering Air Wet-bulb Temperature must be specified for both the performan" +
                     "ce input methods and its value must be less than Design Entering Air Temperature" +
                     ".")]
        [JsonProperty(PropertyName="design_entering_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="design_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Air Flow Rate at High Fan Speed must be greater than Air Flow Rate at Low Fan Spe" +
                     "ed")]
        [JsonProperty(PropertyName="high_fan_speed_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HighFanSpeedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power at high speed")]
        [JsonProperty(PropertyName="high_fan_speed_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HighFanSpeedFanPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Air Flow Rate at Low Fan Speed must be less than Air Flow Rate at High Fan Speed")]
        [JsonProperty(PropertyName="low_fan_speed_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> LowFanSpeedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is only used if the previous field is set to autocalculate.")]
        [JsonProperty(PropertyName="low_fan_speed_air_flow_rate_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowFanSpeedAirFlowRateSizingFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power at low speed")]
        [JsonProperty(PropertyName="low_fan_speed_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> LowFanSpeedFanPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is only used if the previous field is set to autocalculate.")]
        [JsonProperty(PropertyName="low_fan_speed_fan_power_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowFanSpeedFanPowerSizingFactor { get; set; } = Double.Parse("0.16", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="outdoor_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirInletNodeName { get; set; } = "";
    }
}