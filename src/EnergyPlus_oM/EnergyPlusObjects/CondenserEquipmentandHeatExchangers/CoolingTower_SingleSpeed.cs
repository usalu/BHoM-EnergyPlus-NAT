namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UnitaryEquipment;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description(@"This tower model is based on Merkel's theory, which is also the basis for the tower model in ASHRAE's HVAC1 Toolkit. The open wet cooling tower is modeled as a counter flow heat exchanger with a single-speed fan drawing air through the tower (induced-draft configuration). Added fluid bypass as an additional capacity control. 8/2008. For a multi-cell tower, the capacity and air/water flow rate inputs are for the entire tower.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CoolingTower_SingleSpeed : BHoMObject, IEnergyPlusNode
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
        

[Description("Leave field blank if tower performance input method is NominalCapacity")]
[JsonProperty(PropertyName="design_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("This is the fan motor electric input power")]
[JsonProperty(PropertyName="design_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignFanPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Leave field blank if tower performance input method is NominalCapacity")]
[JsonProperty(PropertyName="design_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="free_convection_regime_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
public System.Nullable<double> FreeConvectionRegimeAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("This field is only used if the previous field is set to autocalculate.")]
[JsonProperty(PropertyName="free_convection_regime_air_flow_rate_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FreeConvectionRegimeAirFlowRateSizingFactor { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="free_convection_regime_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
public System.Nullable<double> FreeConvectionRegimeUFactorTimesAreaValue { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("This field is only used if the previous field is set to autocalculate and the Per" +
    "formance Input Method is UFactorTimesAreaAndDesignWaterFlowRate")]
[JsonProperty(PropertyName="free_convection_u_factor_times_area_value_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FreeConvectionUFactorTimesAreaValueSizingFactor { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("User can define tower thermal performance by specifying the tower UA, the Design " +
    "Air Flow Rate and the Design Water Flow Rate, or by specifying the tower nominal" +
    " capacity")]
[JsonProperty(PropertyName="performance_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CoolingTower_SingleSpeed_PerformanceInputMethod PerformanceInputMethod { get; set; } = (CoolingTower_SingleSpeed_PerformanceInputMethod)Enum.Parse(typeof(CoolingTower_SingleSpeed_PerformanceInputMethod), "UFactorTimesAreaAndDesignWaterFlowRate");
        

[JsonProperty(PropertyName="heat_rejection_capacity_and_nominal_capacity_sizing_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HeatRejectionCapacityAndNominalCapacitySizingRatio { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

[Description(@"Nominal tower capacity with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt (3 gpm/ton). Nominal tower capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty(PropertyName="nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NominalCapacity { get; set; } = null;
        

[Description(@"Tower capacity in free convection regime with entering water at 35C (95F), leaving water at 29.44C (85F), entering air at 25.56C (78F) wet-bulb temperature and 35C (95F) dry-bulb temperature. Design water flow rate assumed to be 5.382E-8 m3/s per watt of nominal tower capacity (3 gpm/ton). Tower free convection capacity times (1.25) gives the actual tower heat rejection at these operating conditions.")]
[JsonProperty(PropertyName="free_convection_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
public System.Nullable<double> FreeConvectionCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("This field is only used if the previous field is set to autocalculate")]
[JsonProperty(PropertyName="free_convection_nominal_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FreeConvectionNominalCapacitySizingFactor { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air dry-bulb temperature")]
[JsonProperty(PropertyName="design_inlet_air_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DesignInletAirDryBulbTemperature { get; set; } = Double.Parse("35", CultureInfo.InvariantCulture);
        

[Description("Enter the tower\'s design inlet air wet-bulb temperature")]
[JsonProperty(PropertyName="design_inlet_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DesignInletAirWetBulbTemperature { get; set; } = Double.Parse("25.6", CultureInfo.InvariantCulture);
        

[Description("Enter the approach temperature corresponding to the design inlet air wet-bulb tem" +
    "perature and design range temperature. Design approach temp = outlet water tempe" +
    "rature minus inlet air wet-bulb temperature at design conditions. Autosized to 3" +
    ".9 deltaC.")]
[JsonProperty(PropertyName="design_approach_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignApproachTemperature { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Enter the range temperature corresponding to the design inlet air wet-bulb temper" +
    "ature and design approach temperature. Design range = inlet water temperature mi" +
    "nus outlet water temperature at design conditions. Autosized to 5.5 deltaC.")]
[JsonProperty(PropertyName="design_range_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> DesignRangeTemperature { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

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
public CoolingTower_SingleSpeed_EvaporationLossMode EvaporationLossMode { get; set; } = (CoolingTower_SingleSpeed_EvaporationLossMode)Enum.Parse(typeof(CoolingTower_SingleSpeed_EvaporationLossMode), "LossFactor");
        

[Description(@"Rate of water evaporation from the cooling tower and lost to the outdoor air [%/K] Evaporation loss is calculated as percentage of the circulating condenser water rate Value entered here is percent-per-degree K of temperature drop in the condenser water Typical values are from 0.15 to 0.27 [%/K].")]
[JsonProperty(PropertyName="evaporation_loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> EvaporationLossFactor { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

[Description("Rate of drift loss as a percentage of circulating condenser water flow rate Typic" +
    "al values are between 0.002 and 0.2% The default value is 0.008%")]
[JsonProperty(PropertyName="drift_loss_percent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DriftLossPercent { get; set; } = Double.Parse("0.008", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="blowdown_calculation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CoolingTower_SingleSpeed_BlowdownCalculationMode BlowdownCalculationMode { get; set; } = (CoolingTower_SingleSpeed_BlowdownCalculationMode)Enum.Parse(typeof(CoolingTower_SingleSpeed_BlowdownCalculationMode), "ConcentrationRatio");
        

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
        

[JsonProperty(PropertyName="capacity_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CoolingTower_SingleSpeed_CapacityControl CapacityControl { get; set; } = (CoolingTower_SingleSpeed_CapacityControl)Enum.Parse(typeof(CoolingTower_SingleSpeed_CapacityControl), "FanCycling");
        

[JsonProperty(PropertyName="number_of_cells", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfCells { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="cell_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public CoolingTower_SingleSpeed_CellControl CellControl { get; set; } = (CoolingTower_SingleSpeed_CellControl)Enum.Parse(typeof(CoolingTower_SingleSpeed_CellControl), "MinimalCell");
        

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
