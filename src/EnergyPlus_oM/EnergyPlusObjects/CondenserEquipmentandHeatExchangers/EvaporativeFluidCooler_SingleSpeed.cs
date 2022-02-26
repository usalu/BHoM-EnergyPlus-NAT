using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This model is based on Merkel\'s theory, which is also the basis for the cooling t" +
                 "ower model in EnergyPlus. The Evaporative fluid cooler is modeled as a counter f" +
                 "low heat exchanger.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EvaporativeFluidCooler_SingleSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of Fluid Cooler water inlet node")]
        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of Fluid Cooler water outlet node")]
        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This is the fan motor electric input power")]
        [JsonProperty(PropertyName="design_air_flow_rate_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRateFanPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_spray_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignSprayWaterFlowRate { get; set; } = null;
        

        [Description("User can define fluid cooler thermal performance by specifying the fluid cooler U" +
                     "A and the Design Water Flow Rate, or by specifying the fluid cooler Standard Des" +
                     "ign Capacity or by specifying Design Capacity for Non standard conditions.")]
        [JsonProperty(PropertyName="performance_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_PerformanceInputMethod), "StandardDesignCapacity");
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty(PropertyName="outdoor_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_rejection_capacity_and_nominal_capacity_sizing_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"Standard design capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Standard design capacity times the Heat Rejection Capacity and Nominal Capacity Sizing Ratio (e.g. 1.25) gives the actual fluid cooler heat rejection at these operating conditions. Only used for Performance Input Method = StandardDesignCapacity; for other input methods, this field is ignored. The standard conditions mentioned above for Standard design capacity are already specified in the EnergyPlus. So the input fields such as design entering water temp., design entering air wet-bulb and dry-bulb temp. and design water flow rate, if provided in the input, will be ignored for the StandardDesignCapacity performance input method. Also, the standard conditions are for water as a fluid type so this performance input method can only be used with water as a fluid type (as specified in CondenserLoop object).")]
        [JsonProperty(PropertyName="standard_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StandardDesignCapacity { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UFactorTimesAreaAndDesignWaterFlowRate; " +
                     "for other Performance Input Methods, this field is ignored.")]
        [JsonProperty(PropertyName="design_air_flow_rate_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRateUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Input value is ignored if fluid cooler Performance Input Method= StandardDesignCa" +
                     "pacity.")]
        [JsonProperty(PropertyName="design_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored.")]
        [JsonProperty(PropertyName="user_specified_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UserSpecifiedDesignCapacity { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Water Temperatu" +
                     "re must be greater than Design Entering Air Temperature.")]
        [JsonProperty(PropertyName="design_entering_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringWaterTemperature { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Air Temperature" +
                     " must be greater than Design Entering Air Wet-bulb Temperature.")]
        [JsonProperty(PropertyName="design_entering_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringAirTemperature { get; set; } = null;
        

        [Description("Only used for Performance Input Method = UserSpecifiedDesignCapacity; for other P" +
                     "erformance Input Methods, this field is ignored. Design Entering Air Wet-bulb Te" +
                     "mperature must be less than Design Entering Air Temperature.")]
        [JsonProperty(PropertyName="design_entering_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringAirWetBulbTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="capacity_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_SingleSpeed_CapacityControl CapacityControl { get; set; } = (EvaporativeFluidCooler_SingleSpeed_CapacityControl)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_CapacityControl), "FanCycling");
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="evaporation_loss_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_EvaporationLossMode), "SaturatedExit");
        

        [Description("Rate of water evaporation from the Fluid Cooler and lost to the outdoor air [%/K]" +
                     " Empirical correlation is used to calculate default loss factor if it not explic" +
                     "itly provided.")]
        [JsonProperty(PropertyName="evaporation_loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporationLossFactor { get; set; } = null;
        

        [Description("Rate of drift loss as a percentage of circulating spray water flow rate Default v" +
                     "alue for this field is under investigation. For now Cooling tower\'s drift loss p" +
                     "ercent default value is taken here.")]
        [JsonProperty(PropertyName="drift_loss_percent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DriftLossPercent { get; set; } = Double.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blowdown_calculation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode)Enum.Parse(typeof(EvaporativeFluidCooler_SingleSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

        [Description(@"Characterizes the rate of blowdown in the Evaporative Fluid Cooler. Blowdown is water intentionally drained from the basin in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Default value for this field is under investigation. For now Cooling tower's Blowdown Concentration Ratio percent default value is taken here.")]
        [JsonProperty(PropertyName="blowdown_concentration_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlowdownConcentrationRatio { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"Makeup water usage due to blowdown results from occasionally draining a small amount of water in the Fluid Cooler basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
        [JsonProperty(PropertyName="blowdown_makeup_water_usage_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyWaterStorageTankName { get; set; } = "";
    }
}