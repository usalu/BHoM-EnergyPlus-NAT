using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Direct expansion (DX) cooling coil and condensing unit (includes electric compres" +
                 "sor and condenser fan), single-speed with packaged integrated thermal storage fo" +
                 "r cooling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX_SingleSpeed_ThermalStorage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="operating_mode_control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod OperatingModeControlMethod { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_OperatingModeControlMethod), "EMSControlled");
        

        [Description("This field is used if the control method is set to ScheduledModes Schedule values" +
                     " control operating mode: 0=off, 1=cooling only, 2= cooling and charge, 3= coolin" +
                     "g and discharge, 4= charge only, and 5= discharge only")]
        [JsonProperty(PropertyName="operation_mode_control_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OperationModeControlScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType StorageType { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_StorageType), "Ice");
        

        [Description("This field is required when Storage Type is UserDefinedFluidType")]
        [JsonProperty(PropertyName="user_defined_fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserDefinedFluidType { get; set; } = "";
        

        [Description("required field if Storage Type is Water or UserDefinedFluidType")]
        [JsonProperty(PropertyName="fluid_storage_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> FluidStorageVolume { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("required field if Storage Type is Ice")]
        [JsonProperty(PropertyName="ice_storage_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> IceStorageCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If one of the previous two fields is set to autocalculate, this determines the st" +
                     "orage capacity as a function of Cooling Only Mode Rated Total Evaporator Cooling" +
                     " Capacity")]
        [JsonProperty(PropertyName="storage_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageCapacitySizingFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="storage_tank_ambient_temperature_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageTankAmbientTemperatureNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_tank_to_ambient_u_value_times_area_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageTankToAmbientUValueTimesAreaHeatTransferCoefficient { get; set; } = null;
        

        [Description("required field if Storage Type is Water or UserDefinedFluidType")]
        [JsonProperty(PropertyName="fluid_storage_tank_rating_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FluidStorageTankRatingTemperature { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total cooling capacity, Rated SHR and Rated COP")]
        [JsonProperty(PropertyName="rated_evaporator_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedEvaporatorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="evaporator_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporatorAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="evaporator_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporatorAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_only_mode_available", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable CoolingOnlyModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingOnlyModeAvailable), "No");
        

        [Description(@"required field if Cooling Only Mode is available or if autocalculating sizes gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty(PropertyName="cooling_only_mode_rated_total_evaporator_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingOnlyModeRatedTotalEvaporatorCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("required field if Cooling Only Mode is available Rated sensible heat ratio (gross" +
                     " sensible capacity/gross total capacity) sensible and total capacities do not in" +
                     "clude supply fan heat")]
        [JsonProperty(PropertyName="cooling_only_mode_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingOnlyModeRatedSensibleHeatRatio { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input required " +
                     "field if Cooling Only Mode is available")]
        [JsonProperty(PropertyName="cooling_only_mode_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingOnlyModeRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used biquadratic curve = a + b*ewb + c*ewb**2 + d*db + e*db**2 + f*ewb*db x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="cooling_only_mode_total_evaporator_cooling_capacity_function_of_temperature_curve" +
                                   "_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
                     "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
                     "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
                     "low rate")]
        [JsonProperty(PropertyName="cooling_only_mode_total_evaporator_cooling_capacity_function_of_flow_fraction_cur" +
                                   "ve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*db + e*db**2 + f*ewb*db x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="cooling_only_mode_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
                     "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
                     "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
                     "low")]
        [JsonProperty(PropertyName="cooling_only_mode_energy_input_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_only_mode_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModePartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = evaporator entering wet-bulb temperature seen by the cooling coil (C) y = edb = evaporator entering dry-bulb temperature seen by the cooling coil (C)")]
        [JsonProperty(PropertyName="cooling_only_mode_sensible_heat_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling Only Mode is available Any curve or table with one inde" +
                     "pendent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve = " +
                     "a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air f" +
                     "low")]
        [JsonProperty(PropertyName="cooling_only_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_and_charge_mode_available", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable CoolingAndChargeModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndChargeModeAvailable), "No");
        

        [Description(@"required field if Cooling And Charge Mode is available gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_rated_total_evaporator_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoolingAndChargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the evaporator capacity as a " +
                     "multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndChargeModeCapacitySizingFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling And Charge Mode is available net capacity including any internal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_rated_storage_charging_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoolingAndChargeModeRatedStorageChargingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the storage cooling capacity " +
                     "as a multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity" +
                     "")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_storage_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndChargeModeStorageCapacitySizingFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("required field if Cooling And Charge Mode is available Rated sensible heat ratio " +
                     "(gross sensible evaporator capacity/gross total evaporator capacity) sensible an" +
                     "d total capacities do not include supply fan heat")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndChargeModeRatedSensibleHeatRatio { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Gross evaporator cooling capacity divided by power input to the compressor (for c" +
                     "ooling) and outdoor fan, does not include supply fan heat or supply fan electric" +
                     "al energy input required field if Cooling And Charge Mode is available")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_cooling_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndChargeModeCoolingRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("net cooling capacity divided by power input to the compressor (for charging) and " +
                     "outdoor fan, includes any internal devices required field if Cooling And Charge " +
                     "Mode is available")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_charging_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndChargeModeChargingRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_total_evaporator_cooling_capacity_function_of_temperature" +
                                   "_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_total_evaporator_cooling_capacity_function_of_flow_fracti" +
                                   "on_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_evaporator_energy_input_ratio_function_of_temperature_cur" +
                                   "ve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_evaporator_energy_input_ratio_function_of_flow_fraction_c" +
                                   "urve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_evaporator_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_storage_charge_capacity_function_of_temperature_curve_nam" +
                                   "e", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_storage_charge_capacity_function_of_total_evaporator_plr_" +
                                   "curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeStorageChargeCapacityFunctionOfTotalEvaporatorPlrCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_storage_energy_input_ratio_function_of_temperature_curve_" +
                                   "name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_storage_energy_input_ratio_function_of_flow_fraction_curv" +
                                   "e_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_storage_energy_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Charge Mode is available Curves or tables with either two or three independent variables can be used. Curve:Biquadratic, Table:Lookup, Curve:Bicubic and Curve:QuadraticLinear allowed curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) Also allows Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_sensible_heat_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Charge Mode is available Any curve or table with on" +
                     "e independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic cu" +
                     "rve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator" +
                     " air flow")]
        [JsonProperty(PropertyName="cooling_and_charge_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndChargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_and_discharge_mode_available", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable CoolingAndDischargeModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CoolingAndDischargeModeAvailable), "No");
        

        [Description(@"required field if Cooling And Discharge Mode is available gross capacity excluding supply air fan heat rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at Fluid Storage Tank Rating Temperature (water or fluid) or storage faction of 0.5 (ice)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_rated_total_evaporator_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoolingAndDischargeModeRatedTotalEvaporatorCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
                     "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_evaporator_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndDischargeModeEvaporatorCapacitySizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling And Discharge Mode is available net capacity including any internal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb thermal storage tank at 26.7 C (water) or storage faction of 0.5 (ice)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_rated_storage_discharging_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoolingAndDischargeModeRatedStorageDischargingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
                     "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_discharge_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndDischargeModeStorageDischargeCapacitySizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("required field if Cooling And Discharge Mode is available Rated sensible heat rat" +
                     "io (gross sensible evaporator capacity/gross total evaporator capacity) sensible" +
                     " and total capacities do not include supply fan heat")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndDischargeModeRatedSensibleHeatRatio { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Gross evaporator cooling capacity divided by power input to the compressor (for c" +
                     "ooling) and outdoor fan, does not include supply fan heat or supply fan electric" +
                     "al energy input required field if Cooling And Discharge Mode is available")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_cooling_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndDischargeModeCoolingRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("gross cooling capacity divided by power input to the compressor (for discharging)" +
                     ", includes any internal devices for discharging storage but not supply fan requi" +
                     "red field if Cooling And Discharge Mode is available")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_discharging_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingAndDischargeModeDischargingRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Cooling Only Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_total_evaporator_cooling_capacity_function_of_temperat" +
                                   "ure_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
                     "tor air flow")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_total_evaporator_cooling_capacity_function_of_flow_fra" +
                                   "ction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeTotalEvaporatorCoolingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_evaporator_energy_input_ratio_function_of_temperature_" +
                                   "curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator " +
                     "air flow")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_evaporator_energy_input_ratio_function_of_flow_fractio" +
                                   "n_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeEvaporatorEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_evaporator_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeEvaporatorPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_discharge_capacity_function_of_temperature_cur" +
                                   "ve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator " +
                     "air flow")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_discharge_capacity_function_of_flow_fraction_c" +
                                   "urve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x =PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_discharge_capacity_function_of_total_evaporato" +
                                   "r_plr_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeStorageDischargeCapacityFunctionOfTotalEvaporatorPlrCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Allowed curve or table objects are Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = db, z = stes) x = ewb = evaporator entering wet-bulb temperature (C) y = db = dry-bulb temperature seen by the condenser (C) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_energy_input_ratio_function_of_temperature_cur" +
                                   "ve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
                     "tor air flow")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_energy_input_ratio_function_of_flow_fraction_c" +
                                   "urve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeStorageEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Any curve or table with one independent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 x = PLR = part load ratio (evaporator cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_storage_energy_part_load_fraction_correlation_curve_na" +
                                   "me", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeStorageEnergyPartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Cooling And Discharge Mode is available Curves or tables with either two or three independent variables can be used. curve = a + b*ewb + c*ewb**2 + d*edb + e*edb**2 + f*ewb*edb x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) Also allows Curve:Triquadratic and Table:Lookup curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_sensible_heat_ratio_function_of_temperature_curve_name" +
                                   "", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Cooling And Discharge Mode is available Any curve or table with" +
                     " one independent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic" +
                     " curve = a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evapora" +
                     "tor air flow")]
        [JsonProperty(PropertyName="cooling_and_discharge_mode_sensible_heat_ratio_function_of_flow_fraction_curve_na" +
                                   "me", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingAndDischargeModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="charge_only_mode_available", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable ChargeOnlyModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_ChargeOnlyModeAvailable), "No");
        

        [Description("required field if Charge Only  Mode is available net capacity including any inter" +
                     "nal devices air entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-" +
                     "bulb thermal storage tank at 26.7 C (water) or storage faction of 0.5 (ice)")]
        [JsonProperty(PropertyName="charge_only_mode_rated_storage_charging_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> ChargeOnlyModeRatedStorageChargingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the charging capacity as a mu" +
                     "ltiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty(PropertyName="charge_only_mode_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChargeOnlyModeCapacitySizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("net cooling capacity divided by power input to the compressor (for charging) and " +
                     "outdoor fan, includes any internal devices required field if Charge Only Mode is" +
                     " available")]
        [JsonProperty(PropertyName="charge_only_mode_charging_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChargeOnlyModeChargingRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Charge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*db + c*db**2 + d*stes + e*stes**2 + f*db*stes x = db = dry-bulb temperature seen by the condenser (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="charge_only_mode_storage_charge_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChargeOnlyModeStorageChargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"required field if Charge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*db + c*db**2 + d*stes + e*stes**2 + f*db*stes x = db = dry-bulb temperature seen by the condenser (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="charge_only_mode_storage_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChargeOnlyModeStorageEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="discharge_only_mode_available", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable DischargeOnlyModeAvailable { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_DischargeOnlyModeAvailable), "No");
        

        [Description("required field if Discharge Only Mode is available net capacity including any int" +
                     "ernal devices rating point: air entering the cooling coil at 26.7 C dry-bulb/19." +
                     "4 C wet-bulb, and thermal storage tank at 26.7 C (water) or storage faction of 0" +
                     ".5 (ice)")]
        [JsonProperty(PropertyName="discharge_only_mode_rated_storage_discharging_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DischargeOnlyModeRatedStorageDischargingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the discharging capacity as a" +
                     " multiplier on the Cooling Only Mode Rated Total Evaporator Cooling Capacity")]
        [JsonProperty(PropertyName="discharge_only_mode_capacity_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeOnlyModeCapacitySizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("required field if Discharge Only Mode is available Rated sensible heat ratio (gro" +
                     "ss sensible evaporator capacity/gross total evaporator capacity) sensible and to" +
                     "tal capacities do not include supply fan heat")]
        [JsonProperty(PropertyName="discharge_only_mode_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeOnlyModeRatedSensibleHeatRatio { get; set; } = null;
        

        [Description("required field if Discharge Only Mode is available gross cooling capacity divided" +
                     " by power input to the compressor (for discharging), includes any internal devic" +
                     "es for discharging storage but not supply fan")]
        [JsonProperty(PropertyName="discharge_only_mode_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeOnlyModeRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description(@"required field if Discharge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*stes + e*stes**2 + f*ewb*stes x = ewb = evaporator entering wet-bulb temperature (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="discharge_only_mode_storage_discharge_capacity_function_of_temperature_curve_name" +
                                   "", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModeStorageDischargeCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
                     "= a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air" +
                     " flow")]
        [JsonProperty(PropertyName="discharge_only_mode_storage_discharge_capacity_function_of_flow_fraction_curve_na" +
                                   "me", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModeStorageDischargeCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"required field if Discharge Only Mode is available Any curve or table with two independent variables can be used curve = a + b*ewb + c*ewb**2 + d*stes + e*stes**2 + f*ewb*stes x = ewb = evaporator entering wet-bulb temperature (C) y = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="discharge_only_mode_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModeEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
                     "= a + b*ff + c*ff**2 + d*ff**3 x = ff = Fraction of the full load evaporator air" +
                     " flow")]
        [JsonProperty(PropertyName="discharge_only_mode_energy_input_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModeEnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*PLR + c*PLR**2 cubic curv" +
                     "e = a + b*PLR + c*PLR**2 + d*PLR**3")]
        [JsonProperty(PropertyName="discharge_only_mode_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModePartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description(@"required field if Discharge Only Mode is available Curves or tables with either two or three independent variables can be used. For two independent variables: x = ewb = entering wet-bulb temperature seen by the cooling coil (C) y = edb = entering dry-bulb temperature seen by the cooling coil (C) For three independent variables: curve or table = func(x = ewb, y = edb, z = stes) z = stes = state of thermal energy storage (C or fraction)")]
        [JsonProperty(PropertyName="discharge_only_mode_sensible_heat_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModeSensibleHeatRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("required field if Discharge Only Mode is available Any curve or table with one in" +
                     "dependent variable can be used quadratic curve = a + b*ff + c*ff**2 cubic curve " +
                     "= a + b*ff + c*ff**2 + d*ff**3 ff = Fraction of the full load evaporator air flo" +
                     "w")]
        [JsonProperty(PropertyName="discharge_only_mode_sensible_heat_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargeOnlyModeSensibleHeatRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("controls and miscellaneous standby ancillary electric power draw, when available")]
        [JsonProperty(PropertyName="ancillary_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryElectricPower { get; set; } = null;
        

        [JsonProperty(PropertyName="cold_weather_operation_minimum_outdoor_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColdWeatherOperationMinimumOutdoorAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="cold_weather_operation_ancillary_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ColdWeatherOperationAncillaryPower { get; set; } = null;
        

        [Description("Enter the name of an outdoor air node. This node name is also specified in an Out" +
                     "doorAir:Node or OutdoorAir:NodeList object.")]
        [JsonProperty(PropertyName="condenser_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserAirOutletNodeName { get; set; } = "";
        

        [Description("Used to calculate condenser leaving conditions and water use if evaporatively coo" +
                     "led.")]
        [JsonProperty(PropertyName="condenser_design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CondenserDesignAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If previous field is autocalculate, this determines the condenser air flow size a" +
                     "s a multiplier on the Rated Evaporator Air Flow Rate.")]
        [JsonProperty(PropertyName="condenser_air_flow_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondenserAirFlowSizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType CondenserType { get; set; } = (Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType)Enum.Parse(typeof(Coil_Cooling_DX_SingleSpeed_ThermalStorage_CondenserType), "AirCooled");
        

        [Description("required field if condenser type is evaporatively cooled")]
        [JsonProperty(PropertyName="evaporative_condenser_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserEffectiveness { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("Rated power consumed by the evaporative condenser\'s water pump")]
        [JsonProperty(PropertyName="evaporative_condenser_pump_rated_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> EvaporativeCondenserPumpRatedPowerConsumption { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off. If this field is blank, the basin heater is always available.")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty(PropertyName="basin_heater_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinHeaterAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="condensate_collection_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_tank_plant_connection_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageTankPlantConnectionInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_tank_plant_connection_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageTankPlantConnectionOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_tank_plant_connection_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageTankPlantConnectionDesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="storage_tank_plant_connection_heat_transfer_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageTankPlantConnectionHeatTransferEffectiveness { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [Description("For fluid storage tanks only, minimum limit for storage tank If omitted,then the " +
                     "minimum temperature limit is that used for fluid property data.")]
        [JsonProperty(PropertyName="storage_tank_minimum_operating_limit_fluid_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageTankMinimumOperatingLimitFluidTemperature { get; set; } = null;
        

        [Description("For fluid storage tanks only, maximum limit for storage tank If omitted,then the " +
                     "maximum temperature limit is that used for fluid property data.")]
        [JsonProperty(PropertyName="storage_tank_maximum_operating_limit_fluid_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageTankMaximumOperatingLimitFluidTemperature { get; set; } = null;
    }
}