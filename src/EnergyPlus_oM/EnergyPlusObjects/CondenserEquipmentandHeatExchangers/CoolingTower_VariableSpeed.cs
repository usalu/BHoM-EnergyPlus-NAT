using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(@"This open wet tower model is based on purely empirical algorithms derived from manufacturer's performance data or field measurements. The user can select from two existing algorithms (CoolTools or YorkCalc), or they can enter their own correlation for approach temperature by using a variable speed tower model coefficient object. For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CoolingTower_VariableSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of tower water inlet node")]
        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("Name of tower water outlet node")]
        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [Description("Determines the coefficients and form of the equation for calculating approach tem" +
                     "perature")]
        [JsonProperty(PropertyName="model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoolingTower_VariableSpeed_ModelType ModelType { get; set; } = (CoolingTower_VariableSpeed_ModelType)Enum.Parse(typeof(CoolingTower_VariableSpeed_ModelType), "YorkCalc");
        

        [Description("Name of the tower model coefficient object. Used only when tower Model Type is ei" +
                     "ther CoolToolsUserDefined or YorkCalcUserDefined.")]
        [JsonProperty(PropertyName="model_coefficient_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ModelCoefficientName { get; set; } = "";
        

        [Description("Enter the tower\'s design inlet air wet-bulb temperature")]
        [JsonProperty(PropertyName="design_inlet_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignInletAirWetBulbTemperature { get; set; } = Double.Parse("25.6", CultureInfo.InvariantCulture);
        

        [Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
                     "perature and design range temperature. Design approach temp = outlet water tempe" +
                     "rature minus inlet air wet-bulb temperature at design conditions.")]
        [JsonProperty(PropertyName="design_approach_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignApproachTemperature { get; set; } = Double.Parse("3.9", CultureInfo.InvariantCulture);
        

        [Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
                     "ature and design approach temperature. Design range = inlet water temperature mi" +
                     "nus outlet water temperature at design conditions.")]
        [JsonProperty(PropertyName="design_range_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignRangeTemperature { get; set; } = Double.Parse("5.6", CultureInfo.InvariantCulture);
        

        [Description("Water flow rate through the tower at design conditions")]
        [JsonProperty(PropertyName="design_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Design (maximum) air flow rate through the tower")]
        [JsonProperty(PropertyName="design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the fan motor electric input power at design (max) air flow through the tow" +
                     "er Standard conversion for horsepower is 1 HP = 745.7 W")]
        [JsonProperty(PropertyName="design_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignFanPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("FPR = a + b*AFR + c*AFR**2 + d*AFR**3 FPR = fraction of the design fan power AFR " +
                     "= fraction of the design air flow rate If left blank, then fan power is assumed " +
                     "to be proportional to (air flow rate ratio)^3")]
        [JsonProperty(PropertyName="fan_power_ratio_function_of_air_flow_rate_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanPowerRatioFunctionOfAirFlowRateRatioCurveName { get; set; } = "";
        

        [Description("Enter the minimum air flow rate ratio. This is typically determined by the variab" +
                     "le speed drive that controls the fan motor speed. Valid entries are from 0.2 to " +
                     "0.5.")]
        [JsonProperty(PropertyName="minimum_air_flow_rate_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumAirFlowRateRatio { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the fraction of tower capacity in the free convection regime. This is the fraction of the tower capacity, at the current inlet air wet-bulb temperature, that is available when the tower fan is off. Manufacturers typically estimate the free convection capacity at approximately 10-15%. Values are entered as a fraction and can range from 0 to 0.2.")]
        [JsonProperty(PropertyName="fraction_of_tower_capacity_in_free_convection_regime", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfTowerCapacityInFreeConvectionRegime { get; set; } = Double.Parse("0.125", CultureInfo.InvariantCulture);
        

        [Description("This heater maintains the basin water temperature at the basin heater setpoint te" +
                     "mperature when the outdoor air temperature falls below the setpoint temperature." +
                     " The basin heater only operates when water is not flowing through the tower.")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor dry-bulb temperature when the basin heater turns on")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty(PropertyName="basin_heater_operating_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="evaporation_loss_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoolingTower_VariableSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (CoolingTower_VariableSpeed_EvaporationLossMode)Enum.Parse(typeof(CoolingTower_VariableSpeed_EvaporationLossMode), "LossFactor");
        

        [Description(@"Rate of water evaporated from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [percent/K].")]
        [JsonProperty(PropertyName="evaporation_loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporationLossFactor { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
                     "al values are between 0.002 and 0.2% The default value is 0.008%")]
        [JsonProperty(PropertyName="drift_loss_percent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DriftLossPercent { get; set; } = null;
        

        [JsonProperty(PropertyName="blowdown_calculation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoolingTower_VariableSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (CoolingTower_VariableSpeed_BlowdownCalculationMode)Enum.Parse(typeof(CoolingTower_VariableSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

        [Description(@"Characterizes the rate of blowdown in the cooling tower. Blowdown is water intentionally drained from the tower in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. Typical values for tower operation are 3 to 5. The default value is 3.")]
        [JsonProperty(PropertyName="blowdown_concentration_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlowdownConcentrationRatio { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"Makeup water usage due to blowdown results from occasionally draining a small amount of water in the tower basin to purge scale or other contaminants to reduce their concentration in order to maintain an acceptable level of water quality. Schedule values should reflect water usage in m3/s.")]
        [JsonProperty(PropertyName="blowdown_makeup_water_usage_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlowdownMakeupWaterUsageScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty(PropertyName="outdoor_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_cells", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCells { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cell_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CoolingTower_VariableSpeed_CellControl CellControl { get; set; } = (CoolingTower_VariableSpeed_CellControl)Enum.Parse(typeof(CoolingTower_VariableSpeed_CellControl), "MinimalCell");
        

        [Description("The allowable minimal fraction of the nominal flow rate per cell")]
        [JsonProperty(PropertyName="cell_minimum_water_flow_rate_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CellMinimumWaterFlowRateFraction { get; set; } = Double.Parse("0.33", CultureInfo.InvariantCulture);
        

        [Description("The allowable maximal fraction of the nominal flow rate per cell")]
        [JsonProperty(PropertyName="cell_maximum_water_flow_rate_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CellMaximumWaterFlowRateFraction { get; set; } = Double.Parse("2.5", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}