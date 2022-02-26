namespace BH.oM.Adapters.EnergyPlus.Refrigeration
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
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
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
    
    
    [Description(@"The Refrigeration Case object works in conjunction with a compressor rack, a refrigeration system, or a secondary loop to simulate the performance of a refrigerated case system. The object calculates the energy use for lights, fans and anti-sweat heaters and accounts for the sensible and latent heat exchange with the surrounding environment (termed ""case credits"") which impacts the temperature and humidity in the zone where the case is located.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Case : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
    "s available. If this field is blank, the system is always available.")]
[JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
    "ct.")]
[JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ZoneName { get; set; } = "";
        

[JsonProperty(PropertyName="rated_ambient_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> RatedAmbientTemperature { get; set; } = Double.Parse("23.9", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="rated_ambient_relative_humidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> RatedAmbientRelativeHumidity { get; set; } = Double.Parse("55", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="rated_total_cooling_capacity_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> RatedTotalCoolingCapacityPerUnitLength { get; set; } = Double.Parse("1900", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="rated_latent_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> RatedLatentHeatRatio { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="rated_runtime_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> RatedRuntimeFraction { get; set; } = Double.Parse("0.85", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="case_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CaseLength { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="case_operating_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CaseOperatingTemperature { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="latent_case_credit_curve_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Refrigeration_Case_LatentCaseCreditCurveType LatentCaseCreditCurveType { get; set; } = (Refrigeration_Case_LatentCaseCreditCurveType)Enum.Parse(typeof(Refrigeration_Case_LatentCaseCreditCurveType), "CaseTemperatureMethod");
        

[JsonProperty(PropertyName="latent_case_credit_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string LatentCaseCreditCurveName { get; set; } = "";
        

[JsonProperty(PropertyName="standard_case_fan_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> StandardCaseFanPowerPerUnitLength { get; set; } = Double.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="operating_case_fan_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> OperatingCaseFanPowerPerUnitLength { get; set; } = Double.Parse("75", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="standard_case_lighting_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> StandardCaseLightingPowerPerUnitLength { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

[Description("default set equal to Standard Case Lighting Power per Unit Length")]
[JsonProperty(PropertyName="installed_case_lighting_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> InstalledCaseLightingPowerPerUnitLength { get; set; } = null;
        

[JsonProperty(PropertyName="case_lighting_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CaseLightingScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="fraction_of_lighting_energy_to_case", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FractionOfLightingEnergyToCase { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="case_anti_sweat_heater_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CaseAntiSweatHeaterPowerPerUnitLength { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[Description("This field is only applicable to the Linear, Dewpoint Method, and Heat Balance Me" +
    "thod anti-sweat heater control types")]
[JsonProperty(PropertyName="minimum_anti_sweat_heater_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MinimumAntiSweatHeaterPowerPerUnitLength { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="anti_sweat_heater_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Refrigeration_Case_AntiSweatHeaterControlType AntiSweatHeaterControlType { get; set; } = (Refrigeration_Case_AntiSweatHeaterControlType)Enum.Parse(typeof(Refrigeration_Case_AntiSweatHeaterControlType), "None");
        

[Description("This field is only applicable to Linear AS heater control type Zone relative humi" +
    "dity (%) where anti-sweat heater energy is zero")]
[JsonProperty(PropertyName="humidity_at_zero_anti_sweat_heater_energy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HumidityAtZeroAntiSweatHeaterEnergy { get; set; } = Double.Parse("-10", CultureInfo.InvariantCulture);
        

[Description("This field only applicable to Heat Balance Method AS heater control type Height m" +
    "ust be greater than zero if Heat Balance Method AS heater control is selected")]
[JsonProperty(PropertyName="case_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CaseHeight { get; set; } = Double.Parse("1.5", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="fraction_of_anti_sweat_heater_energy_to_case", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FractionOfAntiSweatHeaterEnergyToCase { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Used to evaluate load on case as well as power or heat consumption")]
[JsonProperty(PropertyName="case_defrost_power_per_unit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CaseDefrostPowerPerUnitLength { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="case_defrost_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Refrigeration_Case_CaseDefrostType CaseDefrostType { get; set; } = (Refrigeration_Case_CaseDefrostType)Enum.Parse(typeof(Refrigeration_Case_CaseDefrostType), "OffCycle");
        

[Description("A case defrost schedule name is required unless case defrost type = None")]
[JsonProperty(PropertyName="case_defrost_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CaseDefrostScheduleName { get; set; } = "";
        

[Description(@"If left blank, the defrost schedule will be used The start time for each defrost period in this drip-down schedule should coincide with the start time for each defrost period in the case defrost schedule (previous input field). The length of each defrost drip-down period must be greater than or equal to the corresponding defrost period specified in the case defrost schedule. This extra time allows the melted frost to drip from the coil before refrigeration is restarted.")]
[JsonProperty(PropertyName="case_defrost_drip_down_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CaseDefrostDripDownScheduleName { get; set; } = "";
        

[Description("Case Temperature, Relative Humidity, and Dewpoint Method are applicable to case d" +
    "efrost types with temperature termination only.")]
[JsonProperty(PropertyName="defrost_energy_correction_curve_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public Refrigeration_Case_DefrostEnergyCorrectionCurveType DefrostEnergyCorrectionCurveType { get; set; } = (Refrigeration_Case_DefrostEnergyCorrectionCurveType)Enum.Parse(typeof(Refrigeration_Case_DefrostEnergyCorrectionCurveType), "None");
        

[Description("Defrost Energy Correction Curve Name is applicable to case defrost types with tem" +
    "perature termination only.")]
[JsonProperty(PropertyName="defrost_energy_correction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string DefrostEnergyCorrectionCurveName { get; set; } = "";
        

[JsonProperty(PropertyName="under_case_hvac_return_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> UnderCaseHvacReturnAirFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Schedule values should be in units of Watts per unit case length (W/m) Leave this" +
    " field blank if no restocking is to be modeled")]
[JsonProperty(PropertyName="refrigerated_case_restocking_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string RefrigeratedCaseRestockingScheduleName { get; set; } = "";
        

[Description("Schedule values should be from 0 to 1 Leave this field blank if no case credit fr" +
    "action is to be applied")]
[JsonProperty(PropertyName="case_credit_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CaseCreditFractionScheduleName { get; set; } = "";
        

[Description(@"Required for detailed refrigeration system, not for compressor rack For a DX system, enter the saturated temperature for refrigerant pressure leaving case For a brine-cooled cooled (secondary system) case, enter the brine inlet temperature Default is 5 C less than case operating temperature")]
[JsonProperty(PropertyName="design_evaporator_temperature_or_brine_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DesignEvaporatorTemperatureOrBrineInletTemperature { get; set; } = null;
        

[JsonProperty(PropertyName="average_refrigerant_charge_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> AverageRefrigerantChargeInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Name of the return air node for this case. If left blank, defaults to the first r" +
    "eturn air node for this zone.")]
[JsonProperty(PropertyName="under_case_hvac_return_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string UnderCaseHvacReturnAirNodeName { get; set; } = "";
    }
}
