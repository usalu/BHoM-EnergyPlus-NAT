namespace BH.oM.Adapters.EnergyPlus.InternalGains
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
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
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
    
    
    [Description("Sets internal gains and contaminant rates for occupants in the zone. If you use a" +
        " ZoneList in the Zone or ZoneList name field then this definition applies to all" +
        " the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class People : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ZoneOrZonelistName { get; set; } = "";
        

[Description("units in schedule should be fraction applied to number of people (0.0 - 1.0)")]
[JsonProperty(PropertyName="number_of_people_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NumberOfPeopleScheduleName { get; set; } = "";
        

[Description(@"The entered calculation method is used to create the maximum number of people for this set of attributes (i.e. sensible fraction, schedule, etc) Choices: People -- simply enter number of occupants. People per Zone Floor Area -- enter the number to apply. Value * Floor Area = Number of people Zone Floor Area per Person -- enter the number to apply. Floor Area / Value = Number of people")]
[JsonProperty(PropertyName="number_of_people_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_NumberOfPeopleCalculationMethod NumberOfPeopleCalculationMethod { get; set; } = (People_NumberOfPeopleCalculationMethod)Enum.Parse(typeof(People_NumberOfPeopleCalculationMethod), "People");
        

[JsonProperty(PropertyName="number_of_people", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NumberOfPeople { get; set; } = null;
        

[JsonProperty(PropertyName="people_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> PeoplePerZoneFloorArea { get; set; } = null;
        

[JsonProperty(PropertyName="zone_floor_area_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> ZoneFloorAreaPerPerson { get; set; } = null;
        

[Description("This is radiant fraction of the sensible heat released by people in a zone. This " +
    "value will be multiplied by the total sensible heat released by people yields th" +
    "e amount of long wavelength radiation gain from people in a zone. Default value " +
    "is 0.30.")]
[JsonProperty(PropertyName="fraction_radiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FractionRadiant { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

[Description("if input, overrides program calculated sensible/latent split")]
[JsonProperty(PropertyName="sensible_heat_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
public System.Nullable<double> SensibleHeatFraction { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Note that W has to be converted to mets in TC routine units in schedule are W/per" +
    "son")]
[JsonProperty(PropertyName="activity_level_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ActivityLevelScheduleName { get; set; } = "";
        

[Description("CO2 generation rate per unit of activity level. The default value is obtained fro" +
    "m ASHRAE Std 62.1 at 0.0084 cfm/met/person over the general adult population.")]
[JsonProperty(PropertyName="carbon_dioxide_generation_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CarbonDioxideGenerationRate { get; set; } = Double.Parse("3.82E-08", CultureInfo.InvariantCulture);
        

[JsonProperty(PropertyName="enable_ashrae_55_comfort_warnings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes EnableAshrae55ComfortWarnings { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description("optional (only required for thermal comfort runs)")]
[JsonProperty(PropertyName="mean_radiant_temperature_calculation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_MeanRadiantTemperatureCalculationType MeanRadiantTemperatureCalculationType { get; set; } = (People_MeanRadiantTemperatureCalculationType)Enum.Parse(typeof(People_MeanRadiantTemperatureCalculationType), "ZoneAveraged");
        

[Description("optional (only required for runs of thermal comfort models: Fanger, Pierce, KSU, " +
    "CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty(PropertyName="surface_name_angle_factor_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SurfaceNameAngleFactorListName { get; set; } = "";
        

[Description("units in schedule are 0.0 to 1.0 optional (only required for runs of thermal comf" +
    "ort models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty(PropertyName="work_efficiency_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string WorkEfficiencyScheduleName { get; set; } = "";
        

[JsonProperty(PropertyName="clothing_insulation_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ClothingInsulationCalculationMethod ClothingInsulationCalculationMethod { get; set; } = (People_ClothingInsulationCalculationMethod)Enum.Parse(typeof(People_ClothingInsulationCalculationMethod), "ClothingInsulationSchedule");
        

[Description("a schedule value of 1 for the Scheduled method, and 2 for the DynamicClothingMode" +
    "lASHRAE55 method")]
[JsonProperty(PropertyName="clothing_insulation_calculation_method_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ClothingInsulationCalculationMethodScheduleName { get; set; } = "";
        

[Description("use \"Clo\" from ASHRAE or Thermal Comfort guides optional (only required for runs " +
    "of thermal comfort models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraf" +
    "tASH55)")]
[JsonProperty(PropertyName="clothing_insulation_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ClothingInsulationScheduleName { get; set; } = "";
        

[Description("units in the schedule are m/s optional (only required for runs of thermal comfort" +
    " models: Fanger, Pierce, KSU, CoolingEffectASH55 and AnkleDraftASH55)")]
[JsonProperty(PropertyName="air_velocity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirVelocityScheduleName { get; set; } = "";
        

[Description("optional (only needed for people thermal comfort results reporting)")]
[JsonProperty(PropertyName="thermal_comfort_model_1_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel1Type ThermalComfortModel1Type { get; set; } = (People_ThermalComfortModel1Type)Enum.Parse(typeof(People_ThermalComfortModel1Type), "AdaptiveASH55");
        

[Description("optional (second type of thermal comfort model and results reporting)")]
[JsonProperty(PropertyName="thermal_comfort_model_2_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel2Type ThermalComfortModel2Type { get; set; } = (People_ThermalComfortModel2Type)Enum.Parse(typeof(People_ThermalComfortModel2Type), "AdaptiveASH55");
        

[Description("optional (third thermal comfort model and report type)")]
[JsonProperty(PropertyName="thermal_comfort_model_3_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel3Type ThermalComfortModel3Type { get; set; } = (People_ThermalComfortModel3Type)Enum.Parse(typeof(People_ThermalComfortModel3Type), "AdaptiveASH55");
        

[Description("optional (fourth thermal comfort model and report type)")]
[JsonProperty(PropertyName="thermal_comfort_model_4_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel4Type ThermalComfortModel4Type { get; set; } = (People_ThermalComfortModel4Type)Enum.Parse(typeof(People_ThermalComfortModel4Type), "AdaptiveASH55");
        

[Description("optional (fifth thermal comfort model and report type)")]
[JsonProperty(PropertyName="thermal_comfort_model_5_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel5Type ThermalComfortModel5Type { get; set; } = (People_ThermalComfortModel5Type)Enum.Parse(typeof(People_ThermalComfortModel5Type), "AdaptiveASH55");
        

[Description("optional (sixth thermal comfort model and report type)")]
[JsonProperty(PropertyName="thermal_comfort_model_6_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel6Type ThermalComfortModel6Type { get; set; } = (People_ThermalComfortModel6Type)Enum.Parse(typeof(People_ThermalComfortModel6Type), "AdaptiveASH55");
        

[Description("optional (seventh thermal comfort model and report type)")]
[JsonProperty(PropertyName="thermal_comfort_model_7_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public People_ThermalComfortModel7Type ThermalComfortModel7Type { get; set; } = (People_ThermalComfortModel7Type)Enum.Parse(typeof(People_ThermalComfortModel7Type), "AdaptiveASH55");
        

[Description("units in the schedule are m/s this is the schedule of the air speed at the 0.1 m " +
    "above the floor optional (only required for runs of thermal comfort models Ankle" +
    "DraftASH55)")]
[JsonProperty(PropertyName="ankle_level_air_velocity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AnkleLevelAirVelocityScheduleName { get; set; } = "";
    }
}
