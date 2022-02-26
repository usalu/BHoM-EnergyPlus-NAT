using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Zone terminal unit with variable refrigerant flow (VRF) DX cooling and heating co" +
                 "ils (air-to-air or water-to-air heat pump). The VRF terminal units are served by" +
                 " an HVACTemplate:System:VRF system.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Zone_VRF : BHoMObject
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Name of a HVACTemplate:System:VRF object serving this zone")]
        [JsonProperty(PropertyName="template_vrf_system_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateVrfSystemName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty(PropertyName="template_thermostat_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty(PropertyName="zone_heating_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty(PropertyName="zone_cooling_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingSizingFactor { get; set; } = null;
        

        [Description(@"If this terminal unit's heating coil is autosized, the heating capacity is sized to be equal to the cooling capacity multiplied by this sizing ratio. This input applies to the terminal unit heating coil and overrides the sizing ratio entered in the HVACTemplate:System:VRF object.")]
        [JsonProperty(PropertyName="rated_total_heating_capacity_sizing_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedTotalHeatingCapacitySizingRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This flow rate is used when the terminal is not cooling and the previous mode was" +
                     " cooling. This field may be set to \"autosize\". If a value is entered, it will be" +
                     " multiplied by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty(PropertyName="no_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoCoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field may be set to \"autosize\". If a value is entered, it will be multiplied" +
                     " by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This flow rate is used when the terminal is not heating and the previous mode was" +
                     " heating. This field may be set to \"autosize\". If a value is entered, it will be" +
                     " multiplied by the Supply Air Sizing Factor and by zone multipliers.")]
        [JsonProperty(PropertyName="no_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoHeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
                     " below, unless a dedicated outdoor air system is specified for this zone and the" +
                     "n it will be set to zero.")]
        [JsonProperty(PropertyName="cooling_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
                     " below, unless a dedicated outdoor air system is specified for this zone and the" +
                     "n it will be set to zero.")]
        [JsonProperty(PropertyName="heating_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If this field is set to autosize it will be sized based on the outdoor air inputs" +
                     " below, unless a dedicated outdoor air system is specified for this zone and the" +
                     "n it will be set to zero.")]
        [JsonProperty(PropertyName="no_load_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty(PropertyName="outdoor_air_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_VRF_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_OutdoorAirMethod), "Empty");
        

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
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty(PropertyName="design_specification_outdoor_air_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty(PropertyName="design_specification_zone_air_distribution_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty(PropertyName="supply_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Select fan placement as either blow through or draw through.")]
        [JsonProperty(PropertyName="supply_air_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_SupplyAirFanPlacement SupplyAirFanPlacement { get; set; } = (HVACTemplate_Zone_VRF_SupplyAirFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_VRF_SupplyAirFanPlacement), "BlowThrough");
        

        [JsonProperty(PropertyName="supply_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanDeltaPressure { get; set; } = Double.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_VRF_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_CoolingCoilType), "VariableRefrigerantFlowDX");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="cooling_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
                     "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
                     "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_HeatPumpHeatingCoilType), "VariableRefrigerantFlowDX");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Capacity excluding supply air fan heat Rating point outdoor dry-bulb temp 8.33 C," +
                     " outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21" +
                     ".11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_gross_rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_terminal_unit_on_parasitic_electric_energy_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneTerminalUnitOnParasiticElectricEnergyUse { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_terminal_unit_off_parasitic_electric_energy_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneTerminalUnitOffParasiticElectricEnergyUse { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty(PropertyName="dedicated_outdoor_air_system_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

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
        public HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_VRF_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperature { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="baseboard_heating_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_VRF_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_VRF_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_VRF_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="baseboard_heating_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="baseboard_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> BaseboardHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}