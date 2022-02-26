using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Plant Heating and Cooling Equipment")]
    public class PlantHeatingandCoolingEquipment_Objects : BHoMObject
    {
        
        public bool ShouldSerializeBoiler_HotWater_List()
        {
            return (Boiler_HotWater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Boiler:HotWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_HotWater> Boiler_HotWater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_HotWater> ();
        
        public bool ShouldSerializeBoiler_Steam_List()
        {
            return (Boiler_Steam_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Boiler:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_Steam> Boiler_Steam_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Boiler_Steam> ();
        
        public bool ShouldSerializeChiller_Electric_EIR_List()
        {
            return (Chiller_Electric_EIR_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:Electric:EIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_EIR> Chiller_Electric_EIR_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_EIR> ();
        
        public bool ShouldSerializeChiller_Electric_ReformulatedEIR_List()
        {
            return (Chiller_Electric_ReformulatedEIR_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:Electric:ReformulatedEIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_ReformulatedEIR> Chiller_Electric_ReformulatedEIR_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric_ReformulatedEIR> ();
        
        public bool ShouldSerializeChiller_Electric_List()
        {
            return (Chiller_Electric_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric> Chiller_Electric_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Electric> ();
        
        public bool ShouldSerializeChiller_Absorption_Indirect_List()
        {
            return (Chiller_Absorption_Indirect_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:Absorption:Indirect", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption_Indirect> Chiller_Absorption_Indirect_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption_Indirect> ();
        
        public bool ShouldSerializeChiller_Absorption_List()
        {
            return (Chiller_Absorption_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:Absorption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption> Chiller_Absorption_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_Absorption> ();
        
        public bool ShouldSerializeChiller_ConstantCOP_List()
        {
            return (Chiller_ConstantCOP_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:ConstantCOP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_ConstantCOP> Chiller_ConstantCOP_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_ConstantCOP> ();
        
        public bool ShouldSerializeChiller_EngineDriven_List()
        {
            return (Chiller_EngineDriven_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:EngineDriven", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_EngineDriven> Chiller_EngineDriven_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_EngineDriven> ();
        
        public bool ShouldSerializeChiller_CombustionTurbine_List()
        {
            return (Chiller_CombustionTurbine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Chiller:CombustionTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_CombustionTurbine> Chiller_CombustionTurbine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.Chiller_CombustionTurbine> ();
        
        public bool ShouldSerializeChillerHeater_Absorption_DirectFired_List()
        {
            return (ChillerHeater_Absorption_DirectFired_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ChillerHeater:Absorption:DirectFired", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DirectFired> ChillerHeater_Absorption_DirectFired_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DirectFired> ();
        
        public bool ShouldSerializeChillerHeater_Absorption_DoubleEffect_List()
        {
            return (ChillerHeater_Absorption_DoubleEffect_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ChillerHeater:Absorption:DoubleEffect", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DoubleEffect> ChillerHeater_Absorption_DoubleEffect_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeater_Absorption_DoubleEffect> ();
        
        public bool ShouldSerializeHeatPump_PlantLoop_EIR_Cooling_List()
        {
            return (HeatPump_PlantLoop_EIR_Cooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatPump:PlantLoop:EIR:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Cooling> HeatPump_PlantLoop_EIR_Cooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Cooling> ();
        
        public bool ShouldSerializeHeatPump_PlantLoop_EIR_Heating_List()
        {
            return (HeatPump_PlantLoop_EIR_Heating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatPump:PlantLoop:EIR:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Heating> HeatPump_PlantLoop_EIR_Heating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_PlantLoop_EIR_Heating> ();
        
        public bool ShouldSerializeHeatPump_WaterToWater_EquationFit_Heating_List()
        {
            return (HeatPump_WaterToWater_EquationFit_Heating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatPump:WaterToWater:EquationFit:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Heating> HeatPump_WaterToWater_EquationFit_Heating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Heating> ();
        
        public bool ShouldSerializeHeatPump_WaterToWater_EquationFit_Cooling_List()
        {
            return (HeatPump_WaterToWater_EquationFit_Cooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatPump:WaterToWater:EquationFit:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Cooling> HeatPump_WaterToWater_EquationFit_Cooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_EquationFit_Cooling> ();
        
        public bool ShouldSerializeHeatPump_WaterToWater_ParameterEstimation_Cooling_List()
        {
            return (HeatPump_WaterToWater_ParameterEstimation_Cooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatPump:WaterToWater:ParameterEstimation:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Cooling> HeatPump_WaterToWater_ParameterEstimation_Cooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Cooling> ();
        
        public bool ShouldSerializeHeatPump_WaterToWater_ParameterEstimation_Heating_List()
        {
            return (HeatPump_WaterToWater_ParameterEstimation_Heating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatPump:WaterToWater:ParameterEstimation:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Heating> HeatPump_WaterToWater_ParameterEstimation_Heating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.HeatPump_WaterToWater_ParameterEstimation_Heating> ();
        
        public bool ShouldSerializeDistrictCooling_List()
        {
            return (DistrictCooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DistrictCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictCooling> DistrictCooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictCooling> ();
        
        public bool ShouldSerializeDistrictHeating_List()
        {
            return (DistrictHeating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DistrictHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictHeating> DistrictHeating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.DistrictHeating> ();
        
        public bool ShouldSerializePlantComponent_TemperatureSource_List()
        {
            return (PlantComponent_TemperatureSource_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantComponent:TemperatureSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.PlantComponent_TemperatureSource> PlantComponent_TemperatureSource_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.PlantComponent_TemperatureSource> ();
        
        public bool ShouldSerializeCentralHeatPumpSystem_List()
        {
            return (CentralHeatPumpSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CentralHeatPumpSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.CentralHeatPumpSystem> CentralHeatPumpSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.CentralHeatPumpSystem> ();
        
        public bool ShouldSerializeChillerHeaterPerformance_Electric_EIR_List()
        {
            return (ChillerHeaterPerformance_Electric_EIR_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ChillerHeaterPerformance:Electric:EIR", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeaterPerformance_Electric_EIR> ChillerHeaterPerformance_Electric_EIR_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment.ChillerHeaterPerformance_Electric_EIR> ();
    }
}