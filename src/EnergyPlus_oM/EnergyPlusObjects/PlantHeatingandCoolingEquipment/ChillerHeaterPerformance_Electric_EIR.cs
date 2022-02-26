using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This chiller model is a generic chiller-heater where the cooling mode performance is a function of condenser entering or leaving fluid temperature and the heating mode performance is typically a function of condenser leaving fluid temperature. Performance at off-reference conditions is modeled using three polynomial equations per mode. Six curve objects are required.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ChillerHeaterPerformance_Electric_EIR : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_cooling_mode_evaporator_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ReferenceCoolingModeEvaporatorCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Efficiency of the chiller compressor (cooling output/compressor energy input).")]
        [JsonProperty(PropertyName="reference_cooling_mode_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCoolingModeCop { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_cooling_mode_leaving_chilled_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCoolingModeLeavingChilledWaterTemperature { get; set; } = Double.Parse("6.67", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_cooling_mode_entering_condenser_fluid_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCoolingModeEnteringCondenserFluidTemperature { get; set; } = Double.Parse("29.44", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_cooling_mode_leaving_condenser_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCoolingModeLeavingCondenserWaterTemperature { get; set; } = Double.Parse("35", CultureInfo.InvariantCulture);
        

        [Description("During simultaneous cooling-heating mode, this ratio is relative to the Reference" +
                     " Cooling Mode Cooling Capacity (Evaporator capacity at simul clg-htg mode ref co" +
                     "ndition)/ (Evaporator capacity at cooling mode ref condition)")]
        [JsonProperty(PropertyName="reference_heating_mode_cooling_capacity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHeatingModeCoolingCapacityRatio { get; set; } = Double.Parse("0.75", CultureInfo.InvariantCulture);
        

        [Description("During simultaneous cooling-heating mode, this ratio is relative to the Reference" +
                     " Cooling Mode COP (Power at simultaneous clg-htg mode reference condition)/ (Pow" +
                     "er at cooling mode reference condition)")]
        [JsonProperty(PropertyName="reference_heating_mode_cooling_power_input_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHeatingModeCoolingPowerInputRatio { get; set; } = Double.Parse("1.38", CultureInfo.InvariantCulture);
        

        [Description("During simultaneous cooling-heating mode")]
        [JsonProperty(PropertyName="reference_heating_mode_leaving_chilled_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHeatingModeLeavingChilledWaterTemperature { get; set; } = Double.Parse("6.67", CultureInfo.InvariantCulture);
        

        [Description("During simultaneous cooling-heating mode")]
        [JsonProperty(PropertyName="reference_heating_mode_leaving_condenser_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHeatingModeLeavingCondenserWaterTemperature { get; set; } = Double.Parse("49", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_heating_mode_entering_condenser_fluid_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHeatingModeEnteringCondenserFluidTemperature { get; set; } = Double.Parse("29.44", CultureInfo.InvariantCulture);
        

        [Description("During simultaneous cooling-heating mode")]
        [JsonProperty(PropertyName="heating_mode_entering_chilled_water_temperature_low_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingModeEnteringChilledWaterTemperatureLowLimit { get; set; } = Double.Parse("12.22", CultureInfo.InvariantCulture);
        

        [Description("Sets chilled water flow rate to either constant or variable.")]
        [JsonProperty(PropertyName="chilled_water_flow_mode_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeaterPerformance_Electric_EIR_ChilledWaterFlowModeType ChilledWaterFlowModeType { get; set; } = (ChillerHeaterPerformance_Electric_EIR_ChilledWaterFlowModeType)Enum.Parse(typeof(ChillerHeaterPerformance_Electric_EIR_ChilledWaterFlowModeType), "ConstantFlow");
        

        [JsonProperty(PropertyName="design_chilled_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignChilledWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_condenser_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignCondenserWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_hot_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignHotWaterFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Fraction of compressor electrical energy that must be rejected by the condenser. " +
                     "Enter 1.0 or leave this field blank for a hermetic compressor.")]
        [JsonProperty(PropertyName="compressor_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorMotorEfficiency { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeaterPerformance_Electric_EIR_CondenserType CondenserType { get; set; } = (ChillerHeaterPerformance_Electric_EIR_CondenserType)Enum.Parse(typeof(ChillerHeaterPerformance_Electric_EIR_CondenserType), "WaterCooled");
        

        [Description(@"Sets the second independent variable in the three temperature dependent performance curves to either the leaving or entering condenser water temperature. Manufacturers express the performance of their chillers using either the leaving condenser water temperature (to the tower) or the entering condenser water temperature (from the tower). Cooling mode is generally a stronger function of Entering Condenser Fluid Temperature")]
        [JsonProperty(PropertyName="cooling_mode_temperature_curve_condenser_water_independent_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeaterPerformance_Electric_EIR_CoolingModeTemperatureCurveCondenserWaterIndependentVariable CoolingModeTemperatureCurveCondenserWaterIndependentVariable { get; set; } = (ChillerHeaterPerformance_Electric_EIR_CoolingModeTemperatureCurveCondenserWaterIndependentVariable)Enum.Parse(typeof(ChillerHeaterPerformance_Electric_EIR_CoolingModeTemperatureCurveCondenserWaterIndependentVariable), "EnteringCondenser");
        

        [Description(@"Cooling capacity as a function of leaving chilled water temperature and either entering or leaving condenser fluid temperature curve = a + b*CWS + c*CWS**2 + d*TCond + e*TCond**2 + f*CWS*TCond If ClgModeCondWaterCurveInputVariable = EnteringCondenser, TCond = ECT If ClgModeCondWaterCurveInputVariable = LeavingCondenser, TCond = LCT CWS = supply (leaving) chilled water temperature(C) LCT = leaving condenser fluid temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="cooling_mode_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingModeCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Electric Input Ratio (EIR) as a function of supply (leaving) chilled water temperature and leaving condenser fluid temperature. EIR = 1/COP. curve = a + b*CWS + c*CWS**2 + d*TCond + e*TCond**2 + f*CWS*TCond If ClgModeCondWaterCurveInputVariable = EnteringCondenser, TCond = ECT If ClgModeCondWaterCurveInputVariable = LeavingCondenser, TCond = LCT CWS = supply (leaving) chilled water temperature(C) LCT = leaving condenser fluid temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="cooling_mode_electric_input_to_cooling_output_ratio_function_of_temperature_curve" +
                                   "_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingModeElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR) EIR = 1/COP Bicubic = a + b*TCond + c*TCond**2 + d*PLR + e*PLR**2 + f*TCond*PLR +g*0 + h*PLR**3+i*0+j*0 If ClgModeCondWaterCurveInputVariable = EnteringCondenser, TCond = ECT If ClgModeCondWaterCurveInputVariable = LeavingCondenser, TCond = LCT Normally, a bicubic curve here should be in terms of LCT rather than ECT Also, a bicubic curve is more applicable for variable-speed compressor motor drives or Quadratic = a + b*PLR + c*PLR**2 PLR = part load ratio (cooling load/steady-state capacity) LCT = leaving condenser fluid temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="cooling_mode_electric_input_to_cooling_output_ratio_function_of_part_load_ratio_c" +
                                   "urve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingModeElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Optimum part load ratio where the chiller is most efficient. Must be greater than" +
                     " or equal to the Minimum Part Load Ratio and less than or equal to the Maximum P" +
                     "art Load Ratio. The Min/Max PLR are taken from their associated EIR-FPLR curve r" +
                     "eferences.")]
        [JsonProperty(PropertyName="cooling_mode_cooling_capacity_optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingModeCoolingCapacityOptimumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"Sets the second independent variable in the three temperature dependent performance curves to either the leaving or entering condenser water temperature. Manufacturers express the performance of their chillers using either the leaving condenser water temperature (to the tower) or the entering condenser water temperature (from the tower). Heating mode (or Simul Clg/Htg Load) should be a function of Leaving Condenser Fluid Temperature Only use EnteringCondenser as a last resort in case no performance data exists for LeavingCondenser")]
        [JsonProperty(PropertyName="heating_mode_temperature_curve_condenser_water_independent_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeaterPerformance_Electric_EIR_HeatingModeTemperatureCurveCondenserWaterIndependentVariable HeatingModeTemperatureCurveCondenserWaterIndependentVariable { get; set; } = (ChillerHeaterPerformance_Electric_EIR_HeatingModeTemperatureCurveCondenserWaterIndependentVariable)Enum.Parse(typeof(ChillerHeaterPerformance_Electric_EIR_HeatingModeTemperatureCurveCondenserWaterIndependentVariable), "LeavingCondenser");
        

        [Description(@"Evaporator (cooling) capacity as a function of leaving chilled water temperature and leaving condenser fluid temperature when in heating or simultaneous cool/heat mode curve = a + b*CWS + c*CWS**2 + d*TCond + e*TCond**2 + f*CWS*TCond If independent variable = EnteringCondenser, TCond = ECT If independent variable = LeavingCondenser, TCond = LCT CWS = supply (leaving) chilled water temperature(C) LCT = leaving condenser fluid temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="heating_mode_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingModeCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Electric Input Ratio (EIR) as a function of leaving chilled water temperature when in heating or simultaneous cool/heat mode and leaving condenser fluid temperature. EIR = 1/COP. curve = a + b*CWS + c*CWS**2 + d*TCond + e*TCond**2 + f*CWS*TCond If independent variable = EnteringCondenser, TCond = ECT If independent variable = LeavingCondenser, TCond = LCT CWS = leaving chilled water temperature(C) LCT = leaving condenser fluid temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="heating_mode_electric_input_to_cooling_output_ratio_function_of_temperature_curve" +
                                   "_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingModeElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Electric Input Ratio (EIR) as a function of Part Load Ratio (PLR) when in heating or simultaneous cool/heat mode EIR = 1/COP Bicubic = a + b*LCT + c*LCT**2 + d*PLR + e*PLR**2 + f*LCT*PLR + g*0 + h*PLR**3 + i*0 + j*0 Normally, a bicubic curve here should be in terms of LCT rather than ECT Also, a bicubic curve is more applicable for variable-speed compressor motor drives or Quadratic = a + b*PLR + c*PLR**2 PLR = part load ratio (cooling load/steady-state capacity) LCT = leaving condenser fluid temperature(C) ECT = entering condenser fluid temperature(C)")]
        [JsonProperty(PropertyName="heating_mode_electric_input_to_cooling_output_ratio_function_of_part_load_ratio_c" +
                                   "urve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingModeElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description(@"Optimum part load ratio where the chiller is most efficient when in heating or simultaneous cool/heat mode. Must be greater than or equal to the Minimum Part Load Ratio and less than or equal to the Maximum Part Load Ratio. The Min/Max PLR are taken from their associated EIR-FPLR curve references.")]
        [JsonProperty(PropertyName="heating_mode_cooling_capacity_optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingModeCoolingCapacityOptimumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}