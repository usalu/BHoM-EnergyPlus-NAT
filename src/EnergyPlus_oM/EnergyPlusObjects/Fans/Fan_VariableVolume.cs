using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("Variable air volume fan where the electric power input varies according to a perf" +
                 "ormance curve as a function of flow fraction.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_VariableVolume : BHoMObject, IEnergyPlusNode
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
        public System.Nullable<double> FanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pressure_rise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PressureRise { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fan_power_minimum_flow_rate_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod FanPowerMinimumFlowRateInputMethod { get; set; } = (Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod)Enum.Parse(typeof(Fan_VariableVolume_FanPowerMinimumFlowRateInputMethod), "Fraction");
        

        [JsonProperty(PropertyName="fan_power_minimum_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerMinimumFlowFraction { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fan_power_minimum_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerMinimumAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("0.0 means fan motor outside of air stream, 1.0 means motor inside of air stream")]
        [JsonProperty(PropertyName="motor_in_airstream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorInAirstreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("all Fan Power Coefficients should not be 0.0 or no fan power will be consumed. Fa" +
                     "n Power Coefficents are specified as function of full flow rate/power Equation:")]
        [JsonProperty(PropertyName="fan_power_coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerCoefficient1 { get; set; } = null;
        

        [JsonProperty(PropertyName="fan_power_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerCoefficient2 { get; set; } = null;
        

        [JsonProperty(PropertyName="fan_power_coefficient_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerCoefficient3 { get; set; } = null;
        

        [JsonProperty(PropertyName="fan_power_coefficient_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerCoefficient4 { get; set; } = null;
        

        [JsonProperty(PropertyName="fan_power_coefficient_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanPowerCoefficient5 { get; set; } = null;
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}