using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Pumps
{
    [Description("This pump model is described in the ASHRAE secondary HVAC toolkit. Variable Speed" +
                 " Condensate pump for Steam Systems")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Pump_VariableSpeed_Condensate : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [Description("this is the volume of steam before condensation, the volume of condensate is much" +
                     " lower and calculated from steam density")]
        [JsonProperty(PropertyName="design_steam_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignSteamVolumeFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("default head is 60 feet")]
        [JsonProperty(PropertyName="design_pump_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignPumpHead { get; set; } = Double.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("When autosized the type of scaling factor is chosen in the input field Design Pow" +
                     "er Sizing Method")]
        [JsonProperty(PropertyName="design_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignPowerConsumption { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This is the motor efficiency only. When the Design Power Consumption is autosized" +
                     " using PowerPerFlowPerPressure, the Design Shaft Power per Unit Flow Rate per Un" +
                     "it Head is used in addition to the motor efficiency.")]
        [JsonProperty(PropertyName="motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_of_motor_inefficiencies_to_fluid_stream", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfMotorInefficienciesToFluidStream { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coefficient_1_of_the_part_load_performance_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfThePartLoadPerformanceCurve { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coefficient_2_of_the_part_load_performance_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfThePartLoadPerformanceCurve { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coefficient_3_of_the_part_load_performance_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfThePartLoadPerformanceCurve { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coefficient_4_of_the_part_load_performance_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient4OfThePartLoadPerformanceCurve { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Modifies the rated flow rate of the pump on a time basis. Default is that the pum" +
                     "p is on and runs according to its other operational requirements specified above" +
                     ". The schedule is for special pump operations.")]
        [JsonProperty(PropertyName="pump_flow_rate_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PumpFlowRateScheduleName { get; set; } = "";
        

        [Description("optional, if used pump losses transfered to zone as internal gains")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("optional. If zone identified in previous field then this determines the split bet" +
                     "ween convection and radiation for the skin losses")]
        [JsonProperty(PropertyName="skin_loss_radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossRadiativeFraction { get; set; } = null;
        

        [Description(@"Used to indicate which sizing factor is used to calculate Design Power Consumption. PowerPerFlow indicates that Design Electric Power per Unit Flow Rate is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * scaling factor PowerPerFlowPerPressure indicates that Design Shaft Power per Unit Flow Rate per Unit Head is used as scaling factor. Design Power Consumption = Design Maximum Flow Rate * Design Pump Head * scaling factor / Motor Efficiency")]
        [JsonProperty(PropertyName="design_power_sizing_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Pump_VariableSpeed_Condensate_DesignPowerSizingMethod DesignPowerSizingMethod { get; set; } = (Pump_VariableSpeed_Condensate_DesignPowerSizingMethod)Enum.Parse(typeof(Pump_VariableSpeed_Condensate_DesignPowerSizingMethod), "PowerPerFlowPerPressure");
        

        [Description("Used to size Design Power Consumption from design flow rate")]
        [JsonProperty(PropertyName="design_electric_power_per_unit_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignElectricPowerPerUnitFlowRate { get; set; } = Double.Parse("348701.1", CultureInfo.InvariantCulture);
        

        [Description("Used to size Design Power Consumption from design flow rate for head and motor ef" +
                     "ficiency")]
        [JsonProperty(PropertyName="design_shaft_power_per_unit_flow_rate_per_unit_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignShaftPowerPerUnitFlowRatePerUnitHead { get; set; } = Double.Parse("1.282051282", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}