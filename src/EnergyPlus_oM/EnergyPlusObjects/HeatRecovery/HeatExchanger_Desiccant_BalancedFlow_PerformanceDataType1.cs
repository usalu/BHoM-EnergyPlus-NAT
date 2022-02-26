using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HeatRecovery
{
    [Description(@"RTO = B1 + B2*RWI + B3*RTI + B4*(RWI/RTI) + B5*PWI + B6*PTI + B7*(PWI/PTI) + B8*RFV RWO = C1 + C2*RWI + C3*RTI + C4*(RWI/RTI) + C5*PWI + C6*PTI + C7*(PWI/PTI) + C8*RFV where, RTO = Dry-bulb temperature of the regeneration outlet air (C) RWO = Humidity ratio of the regeneration outlet air (kgWater/kgDryAir) RWI = Humidity ratio of the regeneration inlet air (kgWater/kgDryAir) RTI = Dry-bulb temperature of the regeneration inlet air (C) PWI = Humidity ratio of the process inlet air (kgWater/kgDryAir) PTI = Dry-bulb temperature of the process inlet air (C) RFV = Regeneration Face Velocity (m/s)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatExchanger_Desiccant_BalancedFlow_PerformanceDataType1 : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Air flow rate at nominal conditions (assumed to be the same for both sides of the" +
                     " heat exchanger).")]
        [JsonProperty(PropertyName="nominal_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_air_face_velocity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalAirFaceVelocity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Parasitic electric power (e.g., desiccant wheel motor)")]
        [JsonProperty(PropertyName="nominal_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalElectricPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient1 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient2 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient3 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient4 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient5 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient6 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient7 { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_equation_coefficient_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureEquationCoefficient8 { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_inlet_air_humidity_ratio_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_inlet_air_humidity_ratio_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_inlet_air_temperature_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_inlet_air_temperature_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_process_inlet_air_humidity_ratio_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumProcessInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_process_inlet_air_humidity_ratio_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumProcessInletAirHumidityRatioForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_process_inlet_air_temperature_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumProcessInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_process_inlet_air_temperature_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumProcessInletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_air_velocity_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationAirVelocityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_air_velocity_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationAirVelocityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_outlet_air_temperature_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationOutletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_outlet_air_temperature_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationOutletAirTemperatureForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_inlet_air_relative_humidity_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_inlet_air_relative_humidity_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_process_inlet_air_relative_humidity_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumProcessInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_process_inlet_air_relative_humidity_for_temperature_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumProcessInletAirRelativeHumidityForTemperatureEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient1 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient2 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient3 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient4 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient5 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient6 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient7 { get; set; } = null;
        

        [JsonProperty(PropertyName="humidity_ratio_equation_coefficient_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityRatioEquationCoefficient8 { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_inlet_air_humidity_ratio_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_inlet_air_humidity_ratio_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_inlet_air_temperature_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_inlet_air_temperature_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_process_inlet_air_humidity_ratio_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumProcessInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_process_inlet_air_humidity_ratio_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumProcessInletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_process_inlet_air_temperature_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumProcessInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_process_inlet_air_temperature_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumProcessInletAirTemperatureForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_air_velocity_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationAirVelocityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_air_velocity_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationAirVelocityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_outlet_air_humidity_ratio_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationOutletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_outlet_air_humidity_ratio_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationOutletAirHumidityRatioForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_regeneration_inlet_air_relative_humidity_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRegenerationInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_regeneration_inlet_air_relative_humidity_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRegenerationInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_process_inlet_air_relative_humidity_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumProcessInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_process_inlet_air_relative_humidity_for_humidity_ratio_equation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumProcessInletAirRelativeHumidityForHumidityRatioEquation { get; set; } = null;
    }
}