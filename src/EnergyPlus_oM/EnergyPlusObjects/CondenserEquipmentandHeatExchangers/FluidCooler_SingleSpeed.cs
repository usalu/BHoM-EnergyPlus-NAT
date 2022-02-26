using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("The fluid cooler is modeled as a cross flow heat exchanger (both streams unmixed)" +
                 " with single-speed fans (induced draft configuration).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidCooler_SingleSpeed : BHoMObject, IEnergyPlusNode
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
        public FluidCooler_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (FluidCooler_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(FluidCooler_SingleSpeed_PerformanceInputMethod), "NominalCapacity");
        

        [Description("Leave field blank if fluid cooler Performance Input Method is NominalCapacity")]
        [JsonProperty(PropertyName="design_air_flow_rate_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRateUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Nominal fluid cooler capacity")]
        [JsonProperty(PropertyName="nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCapacity { get; set; } = null;
        

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
        [JsonProperty(PropertyName="design_entering_air_wetbulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringAirWetbulbTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="design_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power")]
        [JsonProperty(PropertyName="design_air_flow_rate_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRateFanPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty(PropertyName="outdoor_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirInletNodeName { get; set; } = "";
    }
}