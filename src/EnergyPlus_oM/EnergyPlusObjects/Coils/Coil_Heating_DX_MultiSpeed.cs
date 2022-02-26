using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) heating coil (air-to-air heat pump) and compressor unit (includes electric or engine-driven compressor and outdoor fan), multi-speed (or variable-speed), with defrost controls. Requires two to four sets of performance data and will interpolate between speeds.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Heating_DX_MultiSpeed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_outdoor_dry_bulb_temperature_for_compressor_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = Double.Parse("-8", CultureInfo.InvariantCulture);
        

        [Description(@"The outdoor temperature when the compressor is automatically turned back on following an automatic shut off because of low outdoor dry-bulb temperature. This field is only used for the calculation of HSPF. If this field is not provided, then outdoor bin temperature used in the HSPF calculation is always considered to be greater than this temperature and 'Minimum Outdoor Dry-Bulb Temperature for Compressor Operation' field described above. This assumption is based on AHRI standard 210/240 (2008) and can introduce significant error in the final value of HSPF.")]
        [JsonProperty(PropertyName="outdoor_dry_bulb_temperature_to_turn_on_compressor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorDryBulbTemperatureToTurnOnCompressor { get; set; } = null;
        

        [JsonProperty(PropertyName="crankcase_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrankcaseHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("biquadratic curve = a + b*wb + c*wb**2 + d*oat + e*oat**2 + f*wb*oat wb = wet-bul" +
                     "b temperature (C) of air entering the indoor coil oat = outdoor air dry-bulb tem" +
                     "perature (C) only required if ReverseCycle defrost strategy is specified")]
        [JsonProperty(PropertyName="defrost_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefrostEnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_defrost_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForDefrostOperation { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="defrost_strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_DX_MultiSpeed_DefrostStrategy DefrostStrategy { get; set; } = (Coil_Heating_DX_MultiSpeed_DefrostStrategy)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_DefrostStrategy), "ReverseCycle");
        

        [JsonProperty(PropertyName="defrost_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_DX_MultiSpeed_DefrostControl DefrostControl { get; set; } = (Coil_Heating_DX_MultiSpeed_DefrostControl)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_DefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if timed defrost control is spec" +
                     "ified")]
        [JsonProperty(PropertyName="defrost_time_period_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DefrostTimePeriodFraction { get; set; } = Double.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [Description("only applicable if resistive defrost strategy is specified")]
        [JsonProperty(PropertyName="resistive_defrost_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ResistiveDefrostHeaterCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="apply_part_load_fraction_to_speeds_greater_than_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ApplyPartLoadFractionToSpeedsGreaterThan1 { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_DX_MultiSpeed_FuelType FuelType { get; set; } = (Coil_Heating_DX_MultiSpeed_FuelType)Enum.Parse(typeof(Coil_Heating_DX_MultiSpeed_FuelType), "Diesel");
        

        [Description("Standard Region number for which HSPF and other standard ratings are calculated")]
        [JsonProperty(PropertyName="region_number_for_calculating_hspf", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RegionNumberForCalculatingHspf { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
        

        [Description("Enter the number of the following sets of data for coil capacity, COP, flow rate," +
                     " and associated curves.")]
        [JsonProperty(PropertyName="number_of_speeds", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfSpeeds { get; set; } = null;
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="speed_1_gross_rated_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed1GrossRatedHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty(PropertyName="speed_1_gross_rated_heating_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty(PropertyName="speed_1_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed1RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 1 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty(PropertyName="speed_1_rated_supply_air_fan_power_per_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = Double.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_1_heating_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_1_heating_capacity_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_1_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_1_energy_input_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty(PropertyName="speed_1_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty(PropertyName="speed_1_rated_waste_heat_fraction_of_power_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1RatedWasteHeatFractionOfPowerInput { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty(PropertyName="speed_1_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="speed_2_gross_rated_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed2GrossRatedHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty(PropertyName="speed_2_gross_rated_heating_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty(PropertyName="speed_2_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed2RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 2 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty(PropertyName="speed_2_rated_supply_air_fan_power_per_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = Double.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_2_heating_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_2_heating_capacity_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_2_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_2_energy_input_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty(PropertyName="speed_2_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty(PropertyName="speed_2_rated_waste_heat_fraction_of_power_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2RatedWasteHeatFractionOfPowerInput { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty(PropertyName="speed_2_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="speed_3_gross_rated_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed3GrossRatedHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty(PropertyName="speed_3_gross_rated_heating_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty(PropertyName="speed_3_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed3RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 3 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty(PropertyName="speed_3_rated_supply_air_fan_power_per_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = Double.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_3_heating_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_3_heating_capacity_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_3_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_3_energy_input_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty(PropertyName="speed_3_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty(PropertyName="speed_3_rated_waste_heat_fraction_of_power_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3RatedWasteHeatFractionOfPowerInput { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty(PropertyName="speed_3_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="speed_4_gross_rated_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed4GrossRatedHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated heating capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply air fan heat or supply air fan electrical energy")]
        [JsonProperty(PropertyName="speed_4_gross_rated_heating_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4GrossRatedHeatingCop { get; set; } = null;
        

        [Description("Flow rate corresponding to rated total capacity should be between 0.00004027 m3/s" +
                     " and .00006041 m3/s per watt of rated total heating capacity")]
        [JsonProperty(PropertyName="speed_4_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed4RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the supply air fan power per air volume flow rate at the rated speed 4 test conditions. The test conditions vary external static pressure based on heating capacity. This value is only used to calculate Heating Seasonal Performance Factor(HSPF). This value is not used for modeling the supply air fan during simulations.")]
        [JsonProperty(PropertyName="speed_4_rated_supply_air_fan_power_per_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4RatedSupplyAirFanPowerPerVolumeFlowRate { get; set; } = Double.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the heating capacity to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_4_heating_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4HeatingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_4_heating_capacity_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4HeatingCapacityFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*oat + c*oat**2 cubic curve = a + b*oat + c*oat**2 + d*oat**3 biquadratic curve = a + b*iat + c*iat**2 + d*oat + e*oat**2 + f*iat*oat oat = outdoor air dry-bulb temperature (C) iat = indoor air dry-bulb temperature (C) biquadratic curve is recommended if sufficient manufacturer data is available for the energy input ratio to be sensitive to both iat and oat.")]
        [JsonProperty(PropertyName="speed_4_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="speed_4_energy_input_ratio_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4EnergyInputRatioFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (sensible heating load/steady state heating capacity)")]
        [JsonProperty(PropertyName="speed_4_part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("recoverable waste heat at full load and rated conditions")]
        [JsonProperty(PropertyName="speed_4_rated_waste_heat_fraction_of_power_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4RatedWasteHeatFractionOfPowerInput { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*odb + c*odb**2 + d*db + e*db**2 + f*odb*db odb = Outdoor air dry-bu" +
                     "lb temperature (C) db = entering coil dry-bulb temperature (C)")]
        [JsonProperty(PropertyName="speed_4_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (evaporator) of a heat pump is to be placed. This is an optional input field specified only when user desires to extract heat from the zone. The heat extracted is modeled as internal heat gain of the zone. If the primary DX system is a heat pump, then the zone name should be the same as the zone name specified for placing the secondary cooling DX coil.")]
        [JsonProperty(PropertyName="zone_name_for_evaporator_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneNameForEvaporatorPlacement { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty(PropertyName="speed_1_secondary_coil_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed1SecondaryCoilAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty(PropertyName="speed_1_secondary_coil_fan_flow_scaling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1SecondaryCoilFanFlowScalingFactor { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty(PropertyName="speed_1_nominal_sensible_heat_ratio_of_secondary_coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty(PropertyName="speed_1_sensible_heat_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty(PropertyName="speed_1_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty(PropertyName="speed_2_secondary_coil_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed2SecondaryCoilAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty(PropertyName="speed_2_secondary_coil_fan_flow_scaling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2SecondaryCoilFanFlowScalingFactor { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty(PropertyName="speed_2_nominal_sensible_heat_ratio_of_secondary_coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty(PropertyName="speed_2_sensible_heat_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty(PropertyName="speed_2_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty(PropertyName="speed_3_secondary_coil_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed3SecondaryCoilAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty(PropertyName="speed_3_secondary_coil_fan_flow_scaling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3SecondaryCoilFanFlowScalingFactor { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty(PropertyName="speed_3_nominal_sensible_heat_ratio_of_secondary_coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty(PropertyName="speed_3_sensible_heat_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty(PropertyName="speed_3_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
        

        [Description("This input value is the secondary coil (evaporator) air flow rate when the heat p" +
                     "ump is working in heating mode or the secondary DX coil (condenser) air flow rat" +
                     "e when the heat pump is working in cooling mode.")]
        [JsonProperty(PropertyName="speed_4_secondary_coil_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Speed4SecondaryCoilAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This input field is scaling factor for autosizing the secondary DX coil fan flow rate. The secondary air flow rate is determined by multiplying the primary DX coil rated air flow rate by the fan flow scaling factor. Default value is 1.25. If the secondary coil fan flow rate is not autosized, then the secondary coil fan flow scaling factor is set to 1.0.")]
        [JsonProperty(PropertyName="speed_4_secondary_coil_fan_flow_scaling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4SecondaryCoilFanFlowScalingFactor { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description(@"This input value is the nominal sensible heat ratio used to split the heat extracted by a secondary DX coil (evaporator) of a heat pump into sensible and latent components. This is an optional input field. If this input field is left blank, then pure sensible internal heat gain is assumed, i.e., sensible heat ratio of 1.0.")]
        [JsonProperty(PropertyName="speed_4_nominal_sensible_heat_ratio_of_secondary_coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4NominalSensibleHeatRatioOfSecondaryCoil { get; set; } = null;
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the secondary DX coil (C) db = entering dry-bulb temperature seen by the primary DX coil (C) This input field is name of sensible heat ratio modifier biquadratic curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary zone air node wet-bulb temperature and the heating DX coil entering air dry-bulb temperature. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified in the field above will be used.")]
        [JsonProperty(PropertyName="speed_4_sensible_heat_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = secondary air flow fraction of the full load flow This input field is name of sensible heat ratio modifier curve. The value of this curve modifies the nominal sensible heat ratio for current time step depending on the secondary coil air flow fraction. This is an optional input field. If this input field is left blank, then the nominal sensible heat ratio specified will be used.")]
        [JsonProperty(PropertyName="speed_4_sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
}