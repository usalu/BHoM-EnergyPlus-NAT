using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Simulation Parameters")]
    public class SimulationParameters_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="Version", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.Version Version { get; set; } = null;
        

        [JsonProperty(PropertyName="SimulationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.SimulationControl SimulationControl { get; set; } = null;
        

        [JsonProperty(PropertyName="PerformancePrecisionTradeoffs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.PerformancePrecisionTradeoffs PerformancePrecisionTradeoffs { get; set; } = null;
        

        [JsonProperty(PropertyName="Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.Building Building { get; set; } = null;
        

        [JsonProperty(PropertyName="ShadowCalculation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.ShadowCalculation ShadowCalculation { get; set; } = null;
        

        [JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Inside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.SurfaceConvectionAlgorithm_Inside SurfaceConvectionAlgorithm_Inside { get; set; } = null;
        

        [JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Outside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.SurfaceConvectionAlgorithm_Outside SurfaceConvectionAlgorithm_Outside { get; set; } = null;
        

        [JsonProperty(PropertyName="HeatBalanceAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.HeatBalanceAlgorithm HeatBalanceAlgorithm { get; set; } = null;
        

        [JsonProperty(PropertyName="HeatBalanceSettings:ConductionFiniteDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.HeatBalanceSettings_ConductionFiniteDifference HeatBalanceSettings_ConductionFiniteDifference { get; set; } = null;
        

        [JsonProperty(PropertyName="ZoneAirHeatBalanceAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirHeatBalanceAlgorithm ZoneAirHeatBalanceAlgorithm { get; set; } = null;
        

        [JsonProperty(PropertyName="ZoneAirContaminantBalance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirContaminantBalance ZoneAirContaminantBalance { get; set; } = null;
        

        [JsonProperty(PropertyName="ZoneAirMassFlowConservation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneAirMassFlowConservation ZoneAirMassFlowConservation { get; set; } = null;
        
        public bool ShouldSerializeZoneCapacitanceMultiplier_ResearchSpecial_List()
        {
            return (ZoneCapacitanceMultiplier_ResearchSpecial_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneCapacitanceMultiplier:ResearchSpecial", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneCapacitanceMultiplier_ResearchSpecial> ZoneCapacitanceMultiplier_ResearchSpecial_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SimulationParameters.ZoneCapacitanceMultiplier_ResearchSpecial> ();
        

        [JsonProperty(PropertyName="Timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.Timestep Timestep { get; set; } = null;
        

        [JsonProperty(PropertyName="ConvergenceLimits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.ConvergenceLimits ConvergenceLimits { get; set; } = null;
        

        [JsonProperty(PropertyName="HVACSystemRootFindingAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.SimulationParameters.HVACSystemRootFindingAlgorithm HVACSystemRootFindingAlgorithm { get; set; } = null;
    }
}