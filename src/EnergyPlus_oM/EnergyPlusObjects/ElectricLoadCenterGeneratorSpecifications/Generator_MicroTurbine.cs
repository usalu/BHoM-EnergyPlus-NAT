using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("MicroTurbine generators are small combustion turbines (e.g., 25kW to 500kW). The " +
                 "model calculates electrical power output, fuel use, standby and ancillary power." +
                 " Energy recovery from exhaust air can be used to heat water.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_MicroTurbine : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_electrical_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceElectricalPowerOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_full_load_electrical_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumFullLoadElectricalPowerOutput { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If left blank, Maximum Full Load Electrical Power Output will be set equal to the" +
                     " Reference Electrical Power Output.")]
        [JsonProperty(PropertyName="maximum_full_load_electrical_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFullLoadElectricalPowerOutput { get; set; } = null;
        

        [Description("Electric power output divided by fuel energy input (LHV basis) at reference condi" +
                     "tions.")]
        [JsonProperty(PropertyName="reference_electrical_efficiency_using_lower_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceElectricalEfficiencyUsingLowerHeatingValue { get; set; } = null;
        

        [JsonProperty(PropertyName="reference_combustion_air_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCombustionAirInletTemperature { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_combustion_air_inlet_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceCombustionAirInletHumidityRatio { get; set; } = Double.Parse("0.00638", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_elevation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceElevation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev T = combustion air inlet" +
                     " temperature (C) Elev = elevation (m)")]
        [JsonProperty(PropertyName="electrical_power_function_of_temperature_and_elevation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricalPowerFunctionOfTemperatureAndElevationCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*T + c*T**2 Cubic curve = a + b*T + c*T**2 + d*T**3 T = co" +
                     "mbustion air inlet temperature (C)")]
        [JsonProperty(PropertyName="electrical_efficiency_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricalEfficiencyFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = ratio of Generator Load to steady state Electrical Power Output at cur" +
                     "rent operating conditions")]
        [JsonProperty(PropertyName="electrical_efficiency_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricalEfficiencyFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_MicroTurbine_FuelType FuelType { get; set; } = (Generator_MicroTurbine_FuelType)Enum.Parse(typeof(Generator_MicroTurbine_FuelType), "NaturalGas");
        

        [JsonProperty(PropertyName="fuel_higher_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FuelHigherHeatingValue { get; set; } = Double.Parse("50000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fuel_lower_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FuelLowerHeatingValue { get; set; } = Double.Parse("45450", CultureInfo.InvariantCulture);
        

        [Description("Electric power consumed when the generator is available but not being called by t" +
                     "he Electric Load Center.")]
        [JsonProperty(PropertyName="standby_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StandbyPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Electric power consumed by ancillary equipment (e.g., external fuel pressurization pump). Set to zero if Reference Electrical Power Output is the 'net' value (ancillary power already deducted). Input value is positive, but indicates negative electric generation.")]
        [JsonProperty(PropertyName="ancillary_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Quadratic curve = a + b*mdot + c*mdot**2 mdot = fuel mass flow rate (kg/s) If lef" +
                     "t blank, model assumes ancillary power defined in previous field is constant whe" +
                     "never the generator is operating.")]
        [JsonProperty(PropertyName="ancillary_power_function_of_fuel_input_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AncillaryPowerFunctionOfFuelInputCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

        [Description("Reference thermal efficiency (heat recovery to water) based on the Lower Heating " +
                     "Value (LHV) of the fuel.")]
        [JsonProperty(PropertyName="reference_thermal_efficiency_using_lower_heat_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceThermalEfficiencyUsingLowerHeatValue { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_inlet_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceInletWaterTemperature { get; set; } = null;
        

        [Description(@"PlantControl means the heat recovery water flow rate is determined by the plant, but the user needs to supply a heat recovery water flow rate. InternalControl means the heat recovery water flow rate is controlled by this generator. If 'InternalControl' is selected, then the user needs to supply a reference heat recovery water flow rate and optionally the name of a heat recovery flow rate modifier curve.")]
        [JsonProperty(PropertyName="heat_recovery_water_flow_operating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode HeatRecoveryWaterFlowOperatingMode { get; set; } = (Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode)Enum.Parse(typeof(Generator_MicroTurbine_HeatRecoveryWaterFlowOperatingMode), "PlantControl");
        

        [JsonProperty(PropertyName="reference_heat_recovery_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHeatRecoveryWaterFlowRate { get; set; } = null;
        

        [Description(@"curve = a + b*T + c*T**2 + d*Pnet + e*Pnet + f*T*Pnet T = heat recovery inlet water temperature Pnet = net power output = electric power output - ancillary power If left blank, model assumes the heat recovery water flow rate is constant whenever the generator is operating, at the Reference HR Water Flow Rate defined in the previous field.")]
        [JsonProperty(PropertyName="heat_recovery_water_flow_rate_function_of_temperature_and_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryWaterFlowRateFunctionOfTemperatureAndPowerCurveName { get; set; } = "";
        

        [Description(@"Bicubic curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev + g*T**3 + h*Elev**3 + i*T**2*Elev + j*T*Elev**2 Biquadratic curve = a + b*T + c*T**2 + d*Elev + e*Elev**2 + f*T*Elev T = combustion air inlet temperature (C) Elev = elevation (m) If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="thermal_efficiency_function_of_temperature_and_elevation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalEfficiencyFunctionOfTemperatureAndElevationCurveName { get; set; } = "";
        

        [Description(@"Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = ratio of Generator Load to steady state Electrical Power Output at current operating conditions If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="heat_recovery_rate_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryRateFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*T + c*T**2 T = inlet water temperature (C) If field is le" +
                     "ft blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="heat_recovery_rate_function_of_inlet_water_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryRateFunctionOfInletWaterTemperatureCurveName { get; set; } = "";
        

        [Description("Quadratic curve = a + b*Flow + c*Flow**2 Flow = flow rate of water through the he" +
                     "at exchanger (m3/s) If field is left blank, model assumes this modifier equals 1" +
                     " for entire simulation.")]
        [JsonProperty(PropertyName="heat_recovery_rate_function_of_water_flow_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryRateFunctionOfWaterFlowRateCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_heat_recovery_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumHeatRecoveryWaterFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_heat_recovery_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumHeatRecoveryWaterFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_heat_recovery_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumHeatRecoveryWaterTemperature { get; set; } = null;
        

        [Description("Must be an outdoor air node.")]
        [JsonProperty(PropertyName="combustion_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CombustionAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="combustion_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CombustionAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_exhaust_air_mass_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceExhaustAirMassFlowRate { get; set; } = null;
        

        [Description("Quadratic curve = a + b*T + c*T**2 Cubic curve = a + b*T + c*T**2 + d*T**3 T = co" +
                     "mbustion air inlet temperature (C) If field is left blank, model assumes this mo" +
                     "difier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="exhaust_air_flow_rate_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirFlowRateFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = ratio of Generator Load to steady state Electrical Power Output at current operating conditions. If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="exhaust_air_flow_rate_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirFlowRateFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Exhaust air outlet temperature at reference conditions.")]
        [JsonProperty(PropertyName="nominal_exhaust_air_outlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalExhaustAirOutletTemperature { get; set; } = null;
        

        [Description("Quadratic curve = a + b*T + c*T**2 Cubic curve = a + b*T + c*T**2 + d*T**3 T = co" +
                     "mbustion air inlet temperature (C) If field is left blank, model assumes this mo" +
                     "difier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="exhaust_air_temperature_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirTemperatureFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"Quadratic curve = a + b*PLR + c*PLR**2 Cubic curve = a + b*PLR + c*PLR**2 + d*PLR**3 PLR = ratio of Generator Load to steady state Electrical Power Output at current operating conditions. If field is left blank, model assumes this modifier equals 1 for entire simulation.")]
        [JsonProperty(PropertyName="exhaust_air_temperature_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirTemperatureFunctionOfPartLoadRatioCurveName { get; set; } = "";
    }
}