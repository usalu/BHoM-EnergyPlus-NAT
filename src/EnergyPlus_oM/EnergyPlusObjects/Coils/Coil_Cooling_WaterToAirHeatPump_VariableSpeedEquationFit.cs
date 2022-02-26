using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), variable-speed, equation-fit model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Equation-fit model uses normalized curves to describe the heat pump performance. Requires two to ten sets of performance data and will interpolate between speeds. Modeled as a single coil with variable-speed compressor.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_to_refrigerant_hx_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterToRefrigerantHxWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_to_refrigerant_hx_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterToRefrigerantHxWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="indoor_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IndoorAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="indoor_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IndoorAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_speeds", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfSpeeds { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("must be lower than or equal to the highest speed number")]
        [JsonProperty(PropertyName="nominal_speed_level", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalSpeedLevel { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="gross_rated_total_cooling_capacity_at_selected_nominal_speed_level", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossRatedTotalCoolingCapacityAtSelectedNominalSpeedLevel { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_air_flow_rate_at_selected_nominal_speed_level", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedAirFlowRateAtSelectedNominalSpeedLevel { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_water_flow_rate_at_selected_nominal_speed_level", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedWaterFlowRateAtSelectedNominalSpeedLevel { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_time_for_condensate_to_begin_leaving_the_coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalTimeForCondensateToBeginLeavingTheCoil { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="initial_moisture_evaporation_rate_divided_by_steady_state_ac_latent_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialMoistureEvaporationRateDividedBySteadyStateAcLatentCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Flag for using hot gas reheat, 0 - not used, 1 - used")]
        [JsonProperty(PropertyName="flag_for_using_hot_gas_reheat_0_or_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlagForUsingHotGasReheat0Or1 { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="energy_part_load_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnergyPartLoadFractionCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_1_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_1_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_1_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_1_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_1_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
                     "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="speed_1_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_1_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_1_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
                     "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="speed_1_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_1_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_1_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_1_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed1ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
                     "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="speed_1_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed1WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_2_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_2_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_2_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_2_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_2_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
                     "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="speed_2_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_2_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_2_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*ewet + e*ewt**2 + f*wb*ewt wb = entering wet-bulb " +
                     "temperature (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="speed_2_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**2 + d*ffa" +
                     "**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_2_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**2 + d*ffw" +
                     "**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_2_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_2_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed2ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering wet-bulb t" +
                     "emperature (C) ewt = water entering temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="speed_2_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed2WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_3_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_3_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_3_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_3_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_3_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_3_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_3_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_3_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_3_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_3_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_3_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_3_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed3ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_3_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed3WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_4_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_4_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_4_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_4_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_4_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_4_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_4_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_4_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_4_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_4_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_4_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_4_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed4ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_4_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed4WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_5_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed5ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_5_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed5ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_5_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed5ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_5_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed5ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_5_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed5ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_5_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_5_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_5_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_5_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_5_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_5_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_5_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed5ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_5_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed5WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_6_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed6ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_6_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed6ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_6_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed6ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_6_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed6ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_6_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed6ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_6_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_6_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_6_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_6_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_6_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_6_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_6_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed6ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_6_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed6WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_7_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed7ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_7_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed7ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_7_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed7ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_7_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed7ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_7_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed7ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_7_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_7_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_7_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_7_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_7_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_7_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_7_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed7ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_7_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed7WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_8_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed8ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_8_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed8ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_8_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed8ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_8_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed8ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_8_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed8ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_8_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_8_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_8_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_8_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_8_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_8_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_8_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed8ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_8_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed8WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_9_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed9ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_9_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed9ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_9_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed9ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_9_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed9ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_9_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed9ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_9_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_9_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_9_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_9_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_9_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_9_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_9_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed9ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_9_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed9WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="speed_10_reference_unit_gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed10ReferenceUnitGrossRatedTotalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_10_reference_unit_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed10ReferenceUnitGrossRatedSensibleHeatRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_10_reference_unit_gross_rated_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed10ReferenceUnitGrossRatedCoolingCop { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_10_reference_unit_rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed10ReferenceUnitRatedAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="speed_10_reference_unit_rated_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed10ReferenceUnitRatedWaterFlowRate { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_10_total_cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10TotalCoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_10_total_cooling_capacity_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10TotalCoolingCapacityFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_10_total_cooling_capacity_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10TotalCoolingCapacityFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_10_energy_input_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10EnergyInputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffa + c*ffa**2 cubic curve = a + b*ffa + c*ffa**" +
                     "2 + d*ffa**3 ffa = Fraction of the full load Air Flow")]
        [JsonProperty(PropertyName="speed_10_energy_input_ratio_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10EnergyInputRatioFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("optional quadratic curve = a + b*ffw + c*ffw**2 cubic curve = a + b*ffw + c*ffw**" +
                     "2 + d*ffw**3 ffw = Fraction of the full load Water Flow")]
        [JsonProperty(PropertyName="speed_10_energy_input_ratio_function_of_water_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10EnergyInputRatioFunctionOfWaterFlowFractionCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="speed_10_reference_unit_waste_heat_fraction_of_input_power_at_rated_conditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Speed10ReferenceUnitWasteHeatFractionOfInputPowerAtRatedConditions { get; set; } = null;
        

        [Description("optional curve = a + b*wb + c*wb**2 + d*ewt + e*ewt**2 + f*wb*ewt wb = entering w" +
                     "et-bulb temperature (C) ewt = water entering temperature seen by the condenser (" +
                     "C)")]
        [JsonProperty(PropertyName="speed_10_waste_heat_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Speed10WasteHeatFunctionOfTemperatureCurveName { get; set; } = "";
    }
}