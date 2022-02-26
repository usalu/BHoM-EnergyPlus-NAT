using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("DX cooling coil performance specification referencing one or more operating modes" +
                 ". Mode 1 is always the base design operating mode. Additional modes are optional" +
                 " states such as subcool reheat for humidity control.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX_CurveFit_Performance : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="crankcase_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrankcaseHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_outdoor_dry_bulb_temperature_for_compressor_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = Double.Parse("-25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description(@"Enter pressure drop for the unit containing the coil. This value is only used to calculate Energy Efficiency Ratio (EER), Integrated Energy Efficiency Ratio (IEER), and the Standard Rating (Net) Cooling Capacity. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty(PropertyName="unit_internal_static_air_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UnitInternalStaticAirPressure { get; set; } = null;
        

        [JsonProperty(PropertyName="capacity_control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod CapacityControlMethod { get; set; } = (Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_Performance_CapacityControlMethod), "Discrete");
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
        [JsonProperty(PropertyName="evaporative_condenser_basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserBasinHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty(PropertyName="evaporative_condenser_basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserBasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty(PropertyName="evaporative_condenser_basin_heater_operating_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeCondenserBasinHeaterOperatingScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="compressor_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType CompressorFuelType { get; set; } = (Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType)Enum.Parse(typeof(Coil_Cooling_DX_CurveFit_Performance_CompressorFuelType), "Electricity");
        

        [Description("Operating Mode 1 is always used as the base design operating mode.")]
        [JsonProperty(PropertyName="base_operating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseOperatingMode { get; set; } = "";
        

        [Description(@"The alternative operating mode is used for enhanced dehumidification. If this is blank, the coil will always operate in the base operating mode. If an alternate mode is defined here, the coil will use the enhanced mode if activated by the parent system controls.")]
        [JsonProperty(PropertyName="alternative_operating_mode_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AlternativeOperatingMode1 { get; set; } = "";
        

        [Description(@"The alternative operating mode is used for enhanced dehumidification. If this is blank, the coil will always operate in the base operating mode or Alternative Mode 1. If both Alternative Operating Mode 1 and Mode 2 are defined here, the coil will perform both Subcool and Reheat modes for enhanced dehumidification. Alternative Operating Mode 1 is used as Subcool mode, and Alternative Operating Mode 2 is used as Reheat mode.")]
        [JsonProperty(PropertyName="alternative_operating_mode_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AlternativeOperatingMode2 { get; set; } = "";
    }
}