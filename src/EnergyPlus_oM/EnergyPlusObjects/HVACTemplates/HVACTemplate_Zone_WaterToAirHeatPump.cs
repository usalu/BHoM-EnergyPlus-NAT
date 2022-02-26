using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Water to Air Heat Pump to be used with HVACTemplate:Plant:MixedWaterLoop")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Zone_WaterToAirHeatPump : BHoMObject
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty(PropertyName="template_thermostat_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("Supply air flow rate during cooling operation This field may be set to \"autosize\"" +
                     ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
                     "nd by zone multipliers.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Supply air flow rate during heating operation This field may be set to \"autosize\"" +
                     ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
                     "nd by zone multipliers.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty(PropertyName="zone_heating_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty(PropertyName="zone_cooling_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingSizingFactor { get; set; } = null;
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty(PropertyName="outdoor_air_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_OutdoorAirMethod), "Empty");
        

        [Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
                     "Method is Flow/Person, Sum, or Maximum")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorAirFlowRatePerPerson { get; set; } = Double.Parse("0.00944", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_per_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorAirFlowRatePerZone { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty(PropertyName="supply_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty(PropertyName="supply_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanDeltaPressure { get; set; } = Double.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_CoolingCoilType), "Empty");
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electric power input")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilGrossRatedCop { get; set; } = Double.Parse("3.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpHeatingCoilType), "Empty");
        

        [Description("Capacity excluding supply air fan heat")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_gross_rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Heat Pump Heating Coil Rated Capacity divided by power input to the compressor an" +
                     "d outdoor fan, does not include supply air fan heat or supply air fan electric p" +
                     "ower input")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpHeatingCoilGrossRatedCop { get; set; } = Double.Parse("4.2", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="supplemental_heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supplemental_heating_coil_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplementalHeatingCoilCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("The maximum on-off cycling rate for the compressor Suggested value is 2.5 for a t" +
                     "ypical heat pump")]
        [JsonProperty(PropertyName="maximum_cycling_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCyclingRate { get; set; } = Double.Parse("2.5", CultureInfo.InvariantCulture);
        

        [Description("Time constant for the cooling coil\'s capacity to reach steady state after startup" +
                     " Suggested value is 60 for a typical heat pump")]
        [JsonProperty(PropertyName="heat_pump_time_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpTimeConstant { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

        [Description("The fraction of on-cycle power use to adjust the part load fraction based on the " +
                     "off-cycle power consumption due to crankcase heaters, controls, fans, and etc. S" +
                     "uggested value is 0.01 for a typical heat pump")]
        [JsonProperty(PropertyName="fraction_of_on_cycle_power_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfOnCyclePowerUse { get; set; } = Double.Parse("0.01", CultureInfo.InvariantCulture);
        

        [Description("Programmed time delay for heat pump fan to shut off after compressor cycle off. O" +
                     "nly required when fan operating mode is cycling Enter 0 when fan operating mode " +
                     "is continuous")]
        [JsonProperty(PropertyName="heat_pump_fan_delay_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpFanDelayTime { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty(PropertyName="dedicated_outdoor_air_system_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [JsonProperty(PropertyName="supplemental_heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_SupplementalHeatingCoilType), "Electric");
        

        [Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirTemperature { get; set; } = Double.Parse("14", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = Double.Parse("11.11", CultureInfo.InvariantCulture);
        

        [Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperature { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description(@"used only when the heat pump coils are of the type WaterToAirHeatPump:EquationFit Constant results in 100% water flow regardless of compressor PLR Cycling results in water flow that matches compressor PLR ConstantOnDemand results in 100% water flow whenever the coil is on, but is 0% whenever the coil has no load")]
        [JsonProperty(PropertyName="heat_pump_coil_water_flow_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode HeatPumpCoilWaterFlowMode { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_HeatPumpCoilWaterFlowMode), "Cycling");
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty(PropertyName="design_specification_outdoor_air_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty(PropertyName="design_specification_zone_air_distribution_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="baseboard_heating_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_WaterToAirHeatPump_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="baseboard_heating_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="baseboard_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> BaseboardHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}