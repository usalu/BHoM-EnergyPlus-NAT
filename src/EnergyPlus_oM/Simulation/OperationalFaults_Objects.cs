using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Operational Faults")]
    public class OperationalFaults_Objects : BHoMObject
    {
        
        public bool ShouldSerializeFaultModel_TemperatureSensorOffset_OutdoorAir_List()
        {
            return (FaultModel_TemperatureSensorOffset_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_OutdoorAir> FaultModel_TemperatureSensorOffset_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_OutdoorAir> ();
        
        public bool ShouldSerializeFaultModel_HumiditySensorOffset_OutdoorAir_List()
        {
            return (FaultModel_HumiditySensorOffset_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:HumiditySensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumiditySensorOffset_OutdoorAir> FaultModel_HumiditySensorOffset_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumiditySensorOffset_OutdoorAir> ();
        
        public bool ShouldSerializeFaultModel_EnthalpySensorOffset_OutdoorAir_List()
        {
            return (FaultModel_EnthalpySensorOffset_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:EnthalpySensorOffset:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_OutdoorAir> FaultModel_EnthalpySensorOffset_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_OutdoorAir> ();
        
        public bool ShouldSerializeFaultModel_TemperatureSensorOffset_ReturnAir_List()
        {
            return (FaultModel_TemperatureSensorOffset_ReturnAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:ReturnAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ReturnAir> FaultModel_TemperatureSensorOffset_ReturnAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ReturnAir> ();
        
        public bool ShouldSerializeFaultModel_EnthalpySensorOffset_ReturnAir_List()
        {
            return (FaultModel_EnthalpySensorOffset_ReturnAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:EnthalpySensorOffset:ReturnAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_ReturnAir> FaultModel_EnthalpySensorOffset_ReturnAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_EnthalpySensorOffset_ReturnAir> ();
        
        public bool ShouldSerializeFaultModel_TemperatureSensorOffset_ChillerSupplyWater_List()
        {
            return (FaultModel_TemperatureSensorOffset_ChillerSupplyWater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:ChillerSupplyWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ChillerSupplyWater> FaultModel_TemperatureSensorOffset_ChillerSupplyWater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_ChillerSupplyWater> ();
        
        public bool ShouldSerializeFaultModel_TemperatureSensorOffset_CoilSupplyAir_List()
        {
            return (FaultModel_TemperatureSensorOffset_CoilSupplyAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:CoilSupplyAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CoilSupplyAir> FaultModel_TemperatureSensorOffset_CoilSupplyAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CoilSupplyAir> ();
        
        public bool ShouldSerializeFaultModel_TemperatureSensorOffset_CondenserSupplyWater_List()
        {
            return (FaultModel_TemperatureSensorOffset_CondenserSupplyWater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:TemperatureSensorOffset:CondenserSupplyWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CondenserSupplyWater> FaultModel_TemperatureSensorOffset_CondenserSupplyWater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_TemperatureSensorOffset_CondenserSupplyWater> ();
        
        public bool ShouldSerializeFaultModel_ThermostatOffset_List()
        {
            return (FaultModel_ThermostatOffset_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:ThermostatOffset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_ThermostatOffset> FaultModel_ThermostatOffset_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_ThermostatOffset> ();
        
        public bool ShouldSerializeFaultModel_HumidistatOffset_List()
        {
            return (FaultModel_HumidistatOffset_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:HumidistatOffset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumidistatOffset> FaultModel_HumidistatOffset_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_HumidistatOffset> ();
        
        public bool ShouldSerializeFaultModel_Fouling_AirFilter_List()
        {
            return (FaultModel_Fouling_AirFilter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:Fouling:AirFilter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_AirFilter> FaultModel_Fouling_AirFilter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_AirFilter> ();
        
        public bool ShouldSerializeFaultModel_Fouling_Boiler_List()
        {
            return (FaultModel_Fouling_Boiler_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:Fouling:Boiler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Boiler> FaultModel_Fouling_Boiler_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Boiler> ();
        
        public bool ShouldSerializeFaultModel_Fouling_EvaporativeCooler_List()
        {
            return (FaultModel_Fouling_EvaporativeCooler_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:Fouling:EvaporativeCooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_EvaporativeCooler> FaultModel_Fouling_EvaporativeCooler_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_EvaporativeCooler> ();
        
        public bool ShouldSerializeFaultModel_Fouling_Chiller_List()
        {
            return (FaultModel_Fouling_Chiller_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:Fouling:Chiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Chiller> FaultModel_Fouling_Chiller_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Chiller> ();
        
        public bool ShouldSerializeFaultModel_Fouling_CoolingTower_List()
        {
            return (FaultModel_Fouling_CoolingTower_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:Fouling:CoolingTower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_CoolingTower> FaultModel_Fouling_CoolingTower_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_CoolingTower> ();
        
        public bool ShouldSerializeFaultModel_Fouling_Coil_List()
        {
            return (FaultModel_Fouling_Coil_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FaultModel:Fouling:Coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Coil> FaultModel_Fouling_Coil_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OperationalFaults.FaultModel_Fouling_Coil> ();
    }
}