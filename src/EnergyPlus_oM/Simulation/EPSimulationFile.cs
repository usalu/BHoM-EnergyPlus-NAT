namespace BH.oM.Adapters.EnergyPlus
{
    using System.ComponentModel;
    using System;
    using System.Globalization;
    using BH.oM.Base;
    using AdvancedConstructionSurfaceZoneConcepts;
    using AirDistribution;
    using AirflowNetwork;
    using Coils;
    using ComplianceObjects;
    using CondenserEquipmentandHeatExchangers;
    using Controllers;
    using Daylighting;
    using DemandLimitingControls;
    using DetailedGroundHeatTransfer;
    using Economics;
    using ElectricLoadCenterGeneratorSpecifications;
    using EnergyManagementSystemEMS;
    using EvaporativeCoolers;
    using ExteriorEquipment;
    using ExternalInterface;
    using Fans;
    using FluidProperties;
    using GeneralDataEntry;
    using HeatRecovery;
    using HumidifiersandDehumidifiers;
    using HVACDesignObjects;
    using HVACTemplates;
    using HybridModel;
    using InternalGains;
    using LocationandClimate;
    using NodeBranchManagement;
    using NonZoneEquipment;
    using OperationalFaults;
    using OutputReporting;
    using Parametrics;
    using PerformanceCurves;
    using PerformanceTables;
    using PlantHeatingandCoolingEquipment;
    using PlantCondenserControl;
    using PlantCondenserFlowControl;
    using PlantCondenserLoops;
    using Pumps;
    using PythonPluginSystem;
    using Refrigeration;
    using RoomAirModels;
    using Schedules;
    using SetpointManagers;
    using SimulationParameters;
    using SolarCollectors;
    using SurfaceConstructionElements;
    using SystemAvailabilityManagers;
    using ThermalZonesandSurfaces;
    using UnitaryEquipment;
    using UserDefinedHVACandPlantComponentModels;
    using VariableRefrigerantFlowEquipment;
    using WaterHeatersandThermalStorage;
    using WaterSystems;
    using ZoneAirflow;
    using ZoneHVACAirLoopTerminalUnits;
    using ZoneHVACControlsandThermostats;
    using ZoneHVACEquipmentConnections;
    using ZoneHVACForcedAirUnits;
    using ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description("Ultimate class that can be automatically (de)serialized and simulated.")]
    [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPJsonJsonConverter))]
    public class EPSimulationFile : BHoMObject
    {
        

[Description("This a wrapper for all object in the group: Advanced Construction, Surface, Zone " +
    "Concepts")]
public AdvancedConstructionSurfaceZoneConcepts_Objects AdvancedConstructionSurfaceZoneConcepts_Objects { get; set; } = new AdvancedConstructionSurfaceZoneConcepts_Objects();
        

[Description("This a wrapper for all object in the group: Air Distribution")]
public AirDistribution_Objects AirDistribution_Objects { get; set; } = new AirDistribution_Objects();
        

[Description("This a wrapper for all object in the group: AirflowNetwork")]
public AirflowNetwork_Objects AirflowNetwork_Objects { get; set; } = new AirflowNetwork_Objects();
        

[Description("This a wrapper for all object in the group: Coils")]
public Coils_Objects Coils_Objects { get; set; } = new Coils_Objects();
        

[Description("This a wrapper for all object in the group: Compliance Objects")]
public ComplianceObjects_Objects ComplianceObjects_Objects { get; set; } = new ComplianceObjects_Objects();
        

[Description("This a wrapper for all object in the group: Condenser Equipment and Heat Exchange" +
    "rs")]
public CondenserEquipmentandHeatExchangers_Objects CondenserEquipmentandHeatExchangers_Objects { get; set; } = new CondenserEquipmentandHeatExchangers_Objects();
        

[Description("This a wrapper for all object in the group: Controllers")]
public Controllers_Objects Controllers_Objects { get; set; } = new Controllers_Objects();
        

[Description("This a wrapper for all object in the group: Daylighting")]
public Daylighting_Objects Daylighting_Objects { get; set; } = new Daylighting_Objects();
        

[Description("This a wrapper for all object in the group: Demand Limiting Controls")]
public DemandLimitingControls_Objects DemandLimitingControls_Objects { get; set; } = new DemandLimitingControls_Objects();
        

[Description("This a wrapper for all object in the group: Detailed Ground Heat Transfer")]
public DetailedGroundHeatTransfer_Objects DetailedGroundHeatTransfer_Objects { get; set; } = new DetailedGroundHeatTransfer_Objects();
        

[Description("This a wrapper for all object in the group: Economics")]
public Economics_Objects Economics_Objects { get; set; } = new Economics_Objects();
        

[Description("This a wrapper for all object in the group: Electric Load Center-Generator Specif" +
    "ications")]
public ElectricLoadCenterGeneratorSpecifications_Objects ElectricLoadCenterGeneratorSpecifications_Objects { get; set; } = new ElectricLoadCenterGeneratorSpecifications_Objects();
        

[Description("This a wrapper for all object in the group: Energy Management System (EMS)")]
public EnergyManagementSystemEMS_Objects EnergyManagementSystemEMS_Objects { get; set; } = new EnergyManagementSystemEMS_Objects();
        

[Description("This a wrapper for all object in the group: Evaporative Coolers")]
public EvaporativeCoolers_Objects EvaporativeCoolers_Objects { get; set; } = new EvaporativeCoolers_Objects();
        

[Description("This a wrapper for all object in the group: Exterior Equipment")]
public ExteriorEquipment_Objects ExteriorEquipment_Objects { get; set; } = new ExteriorEquipment_Objects();
        

[Description("This a wrapper for all object in the group: External Interface")]
public ExternalInterface_Objects ExternalInterface_Objects { get; set; } = new ExternalInterface_Objects();
        

[Description("This a wrapper for all object in the group: Fans")]
public Fans_Objects Fans_Objects { get; set; } = new Fans_Objects();
        

[Description("This a wrapper for all object in the group: Fluid Properties")]
public FluidProperties_Objects FluidProperties_Objects { get; set; } = new FluidProperties_Objects();
        

[Description("This a wrapper for all object in the group: General Data Entry")]
public GeneralDataEntry_Objects GeneralDataEntry_Objects { get; set; } = new GeneralDataEntry_Objects();
        

[Description("This a wrapper for all object in the group: Heat Recovery")]
public HeatRecovery_Objects HeatRecovery_Objects { get; set; } = new HeatRecovery_Objects();
        

[Description("This a wrapper for all object in the group: Humidifiers and Dehumidifiers")]
public HumidifiersandDehumidifiers_Objects HumidifiersandDehumidifiers_Objects { get; set; } = new HumidifiersandDehumidifiers_Objects();
        

[Description("This a wrapper for all object in the group: HVAC Design Objects")]
public HVACDesignObjects_Objects HVACDesignObjects_Objects { get; set; } = new HVACDesignObjects_Objects();
        

[Description("This a wrapper for all object in the group: HVAC Templates")]
public HVACTemplates_Objects HVACTemplates_Objects { get; set; } = new HVACTemplates_Objects();
        

[Description("This a wrapper for all object in the group: Hybrid Model")]
public HybridModel_Objects HybridModel_Objects { get; set; } = new HybridModel_Objects();
        

[Description("This a wrapper for all object in the group: Internal Gains")]
public InternalGains_Objects InternalGains_Objects { get; set; } = new InternalGains_Objects();
        

[Description("This a wrapper for all object in the group: Location and Climate")]
public LocationandClimate_Objects LocationandClimate_Objects { get; set; } = new LocationandClimate_Objects();
        

[Description("This a wrapper for all object in the group: Node-Branch Management")]
public NodeBranchManagement_Objects NodeBranchManagement_Objects { get; set; } = new NodeBranchManagement_Objects();
        

[Description("This a wrapper for all object in the group: Non-Zone Equipment")]
public NonZoneEquipment_Objects NonZoneEquipment_Objects { get; set; } = new NonZoneEquipment_Objects();
        

[Description("This a wrapper for all object in the group: Operational Faults")]
public OperationalFaults_Objects OperationalFaults_Objects { get; set; } = new OperationalFaults_Objects();
        

[Description("This a wrapper for all object in the group: Output Reporting")]
public OutputReporting_Objects OutputReporting_Objects { get; set; } = new OutputReporting_Objects();
        

[Description("This a wrapper for all object in the group: Parametrics")]
public Parametrics_Objects Parametrics_Objects { get; set; } = new Parametrics_Objects();
        

[Description("This a wrapper for all object in the group: Performance Curves")]
public PerformanceCurves_Objects PerformanceCurves_Objects { get; set; } = new PerformanceCurves_Objects();
        

[Description("This a wrapper for all object in the group: Performance Tables")]
public PerformanceTables_Objects PerformanceTables_Objects { get; set; } = new PerformanceTables_Objects();
        

[Description("This a wrapper for all object in the group: Plant Heating and Cooling Equipment")]
public PlantHeatingandCoolingEquipment_Objects PlantHeatingandCoolingEquipment_Objects { get; set; } = new PlantHeatingandCoolingEquipment_Objects();
        

[Description("This a wrapper for all object in the group: Plant-Condenser Control")]
public PlantCondenserControl_Objects PlantCondenserControl_Objects { get; set; } = new PlantCondenserControl_Objects();
        

[Description("This a wrapper for all object in the group: Plant-Condenser Flow Control")]
public PlantCondenserFlowControl_Objects PlantCondenserFlowControl_Objects { get; set; } = new PlantCondenserFlowControl_Objects();
        

[Description("This a wrapper for all object in the group: Plant-Condenser Loops")]
public PlantCondenserLoops_Objects PlantCondenserLoops_Objects { get; set; } = new PlantCondenserLoops_Objects();
        

[Description("This a wrapper for all object in the group: Pumps")]
public Pumps_Objects Pumps_Objects { get; set; } = new Pumps_Objects();
        

[Description("This a wrapper for all object in the group: Python Plugin System")]
public PythonPluginSystem_Objects PythonPluginSystem_Objects { get; set; } = new PythonPluginSystem_Objects();
        

[Description("This a wrapper for all object in the group: Refrigeration")]
public Refrigeration_Objects Refrigeration_Objects { get; set; } = new Refrigeration_Objects();
        

[Description("This a wrapper for all object in the group: Room Air Models")]
public RoomAirModels_Objects RoomAirModels_Objects { get; set; } = new RoomAirModels_Objects();
        

[Description("This a wrapper for all object in the group: Schedules")]
public Schedules_Objects Schedules_Objects { get; set; } = new Schedules_Objects();
        

[Description("This a wrapper for all object in the group: Setpoint Managers")]
public SetpointManagers_Objects SetpointManagers_Objects { get; set; } = new SetpointManagers_Objects();
        

[Description("This a wrapper for all object in the group: Simulation Parameters")]
public SimulationParameters_Objects SimulationParameters_Objects { get; set; } = new SimulationParameters_Objects();
        

[Description("This a wrapper for all object in the group: Solar Collectors")]
public SolarCollectors_Objects SolarCollectors_Objects { get; set; } = new SolarCollectors_Objects();
        

[Description("This a wrapper for all object in the group: Surface Construction Elements")]
public SurfaceConstructionElements_Objects SurfaceConstructionElements_Objects { get; set; } = new SurfaceConstructionElements_Objects();
        

[Description("This a wrapper for all object in the group: System Availability Managers")]
public SystemAvailabilityManagers_Objects SystemAvailabilityManagers_Objects { get; set; } = new SystemAvailabilityManagers_Objects();
        

[Description("This a wrapper for all object in the group: Thermal Zones and Surfaces")]
public ThermalZonesandSurfaces_Objects ThermalZonesandSurfaces_Objects { get; set; } = new ThermalZonesandSurfaces_Objects();
        

[Description("This a wrapper for all object in the group: Unitary Equipment")]
public UnitaryEquipment_Objects UnitaryEquipment_Objects { get; set; } = new UnitaryEquipment_Objects();
        

[Description("This a wrapper for all object in the group: User Defined HVAC and Plant Component" +
    " Models")]
public UserDefinedHVACandPlantComponentModels_Objects UserDefinedHVACandPlantComponentModels_Objects { get; set; } = new UserDefinedHVACandPlantComponentModels_Objects();
        

[Description("This a wrapper for all object in the group: Variable Refrigerant Flow Equipment")]
public VariableRefrigerantFlowEquipment_Objects VariableRefrigerantFlowEquipment_Objects { get; set; } = new VariableRefrigerantFlowEquipment_Objects();
        

[Description("This a wrapper for all object in the group: Water Heaters and Thermal Storage")]
public WaterHeatersandThermalStorage_Objects WaterHeatersandThermalStorage_Objects { get; set; } = new WaterHeatersandThermalStorage_Objects();
        

[Description("This a wrapper for all object in the group: Water Systems")]
public WaterSystems_Objects WaterSystems_Objects { get; set; } = new WaterSystems_Objects();
        

[Description("This a wrapper for all object in the group: Zone Airflow")]
public ZoneAirflow_Objects ZoneAirflow_Objects { get; set; } = new ZoneAirflow_Objects();
        

[Description("This a wrapper for all object in the group: Zone HVAC Air Loop Terminal Units")]
public ZoneHVACAirLoopTerminalUnits_Objects ZoneHVACAirLoopTerminalUnits_Objects { get; set; } = new ZoneHVACAirLoopTerminalUnits_Objects();
        

[Description("This a wrapper for all object in the group: Zone HVAC Controls and Thermostats")]
public ZoneHVACControlsandThermostats_Objects ZoneHVACControlsandThermostats_Objects { get; set; } = new ZoneHVACControlsandThermostats_Objects();
        

[Description("This a wrapper for all object in the group: Zone HVAC Equipment Connections")]
public ZoneHVACEquipmentConnections_Objects ZoneHVACEquipmentConnections_Objects { get; set; } = new ZoneHVACEquipmentConnections_Objects();
        

[Description("This a wrapper for all object in the group: Zone HVAC Forced Air Units")]
public ZoneHVACForcedAirUnits_Objects ZoneHVACForcedAirUnits_Objects { get; set; } = new ZoneHVACForcedAirUnits_Objects();
        

[Description("This a wrapper for all object in the group: Zone HVAC Radiative/Convective Units")]
public ZoneHVACRadiativeConvectiveUnits_Objects ZoneHVACRadiativeConvectiveUnits_Objects { get; set; } = new ZoneHVACRadiativeConvectiveUnits_Objects();
    }
}
