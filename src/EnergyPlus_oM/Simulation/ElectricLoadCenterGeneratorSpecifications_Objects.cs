using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Electric Load Center-Generator Specif" +
                 "ications")]
    public class ElectricLoadCenterGeneratorSpecifications_Objects : BHoMObject
    {
        
        public bool ShouldSerializeGenerator_InternalCombustionEngine_List()
        {
            return (Generator_InternalCombustionEngine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:InternalCombustionEngine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_InternalCombustionEngine> Generator_InternalCombustionEngine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_InternalCombustionEngine> ();
        
        public bool ShouldSerializeGenerator_CombustionTurbine_List()
        {
            return (Generator_CombustionTurbine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:CombustionTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_CombustionTurbine> Generator_CombustionTurbine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_CombustionTurbine> ();
        
        public bool ShouldSerializeGenerator_MicroTurbine_List()
        {
            return (Generator_MicroTurbine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:MicroTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroTurbine> Generator_MicroTurbine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroTurbine> ();
        
        public bool ShouldSerializeGenerator_Photovoltaic_List()
        {
            return (Generator_Photovoltaic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:Photovoltaic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_Photovoltaic> Generator_Photovoltaic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_Photovoltaic> ();
        
        public bool ShouldSerializePhotovoltaicPerformance_Simple_List()
        {
            return (PhotovoltaicPerformance_Simple_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PhotovoltaicPerformance:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Simple> PhotovoltaicPerformance_Simple_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Simple> ();
        
        public bool ShouldSerializePhotovoltaicPerformance_EquivalentOneDiode_List()
        {
            return (PhotovoltaicPerformance_EquivalentOneDiode_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PhotovoltaicPerformance:EquivalentOne-Diode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_EquivalentOneDiode> PhotovoltaicPerformance_EquivalentOneDiode_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_EquivalentOneDiode> ();
        
        public bool ShouldSerializePhotovoltaicPerformance_Sandia_List()
        {
            return (PhotovoltaicPerformance_Sandia_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PhotovoltaicPerformance:Sandia", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Sandia> PhotovoltaicPerformance_Sandia_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.PhotovoltaicPerformance_Sandia> ();
        
        public bool ShouldSerializeGenerator_PVWatts_List()
        {
            return (Generator_PVWatts_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:PVWatts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_PVWatts> Generator_PVWatts_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_PVWatts> ();
        
        public bool ShouldSerializeElectricLoadCenter_Inverter_PVWatts_List()
        {
            return (ElectricLoadCenter_Inverter_PVWatts_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Inverter:PVWatts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_PVWatts> ElectricLoadCenter_Inverter_PVWatts_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_PVWatts> ();
        
        public bool ShouldSerializeGenerator_FuelCell_List()
        {
            return (Generator_FuelCell_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell> Generator_FuelCell_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell> ();
        
        public bool ShouldSerializeGenerator_FuelCell_PowerModule_List()
        {
            return (Generator_FuelCell_PowerModule_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:PowerModule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_PowerModule> Generator_FuelCell_PowerModule_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_PowerModule> ();
        
        public bool ShouldSerializeGenerator_FuelCell_AirSupply_List()
        {
            return (Generator_FuelCell_AirSupply_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:AirSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AirSupply> Generator_FuelCell_AirSupply_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AirSupply> ();
        
        public bool ShouldSerializeGenerator_FuelCell_WaterSupply_List()
        {
            return (Generator_FuelCell_WaterSupply_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:WaterSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_WaterSupply> Generator_FuelCell_WaterSupply_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_WaterSupply> ();
        
        public bool ShouldSerializeGenerator_FuelCell_AuxiliaryHeater_List()
        {
            return (Generator_FuelCell_AuxiliaryHeater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:AuxiliaryHeater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AuxiliaryHeater> Generator_FuelCell_AuxiliaryHeater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AuxiliaryHeater> ();
        
        public bool ShouldSerializeGenerator_FuelCell_ExhaustGasToWaterHeatExchanger_List()
        {
            return (Generator_FuelCell_ExhaustGasToWaterHeatExchanger_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:ExhaustGasToWaterHeatExchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ExhaustGasToWaterHeatExchanger> Generator_FuelCell_ExhaustGasToWaterHeatExchanger_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ExhaustGasToWaterHeatExchanger> ();
        
        public bool ShouldSerializeGenerator_FuelCell_ElectricalStorage_List()
        {
            return (Generator_FuelCell_ElectricalStorage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:ElectricalStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ElectricalStorage> Generator_FuelCell_ElectricalStorage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_ElectricalStorage> ();
        
        public bool ShouldSerializeGenerator_FuelCell_Inverter_List()
        {
            return (Generator_FuelCell_Inverter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:Inverter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_Inverter> Generator_FuelCell_Inverter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_Inverter> ();
        
        public bool ShouldSerializeGenerator_FuelCell_StackCooler_List()
        {
            return (Generator_FuelCell_StackCooler_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelCell:StackCooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_StackCooler> Generator_FuelCell_StackCooler_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_StackCooler> ();
        
        public bool ShouldSerializeGenerator_MicroCHP_List()
        {
            return (Generator_MicroCHP_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:MicroCHP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP> Generator_MicroCHP_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP> ();
        
        public bool ShouldSerializeGenerator_MicroCHP_NonNormalizedParameters_List()
        {
            return (Generator_MicroCHP_NonNormalizedParameters_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:MicroCHP:NonNormalizedParameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP_NonNormalizedParameters> Generator_MicroCHP_NonNormalizedParameters_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_MicroCHP_NonNormalizedParameters> ();
        
        public bool ShouldSerializeGenerator_FuelSupply_List()
        {
            return (Generator_FuelSupply_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:FuelSupply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelSupply> Generator_FuelSupply_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelSupply> ();
        
        public bool ShouldSerializeGenerator_WindTurbine_List()
        {
            return (Generator_WindTurbine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Generator:WindTurbine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_WindTurbine> Generator_WindTurbine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_WindTurbine> ();
        
        public bool ShouldSerializeElectricLoadCenter_Generators_List()
        {
            return (ElectricLoadCenter_Generators_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Generators", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Generators> ElectricLoadCenter_Generators_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Generators> ();
        
        public bool ShouldSerializeElectricLoadCenter_Inverter_Simple_List()
        {
            return (ElectricLoadCenter_Inverter_Simple_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Inverter:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_Simple> ElectricLoadCenter_Inverter_Simple_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_Simple> ();
        
        public bool ShouldSerializeElectricLoadCenter_Inverter_FunctionOfPower_List()
        {
            return (ElectricLoadCenter_Inverter_FunctionOfPower_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Inverter:FunctionOfPower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_FunctionOfPower> ElectricLoadCenter_Inverter_FunctionOfPower_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_FunctionOfPower> ();
        
        public bool ShouldSerializeElectricLoadCenter_Inverter_LookUpTable_List()
        {
            return (ElectricLoadCenter_Inverter_LookUpTable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Inverter:LookUpTable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_LookUpTable> ElectricLoadCenter_Inverter_LookUpTable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Inverter_LookUpTable> ();
        
        public bool ShouldSerializeElectricLoadCenter_Storage_Simple_List()
        {
            return (ElectricLoadCenter_Storage_Simple_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Storage:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Simple> ElectricLoadCenter_Storage_Simple_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Simple> ();
        
        public bool ShouldSerializeElectricLoadCenter_Storage_Battery_List()
        {
            return (ElectricLoadCenter_Storage_Battery_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Storage:Battery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Battery> ElectricLoadCenter_Storage_Battery_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Battery> ();
        
        public bool ShouldSerializeElectricLoadCenter_Storage_LiIonNMCBattery_List()
        {
            return (ElectricLoadCenter_Storage_LiIonNMCBattery_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Storage:LiIonNMCBattery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_LiIonNMCBattery> ElectricLoadCenter_Storage_LiIonNMCBattery_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_LiIonNMCBattery> ();
        
        public bool ShouldSerializeElectricLoadCenter_Transformer_List()
        {
            return (ElectricLoadCenter_Transformer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Transformer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Transformer> ElectricLoadCenter_Transformer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Transformer> ();
        
        public bool ShouldSerializeElectricLoadCenter_Distribution_List()
        {
            return (ElectricLoadCenter_Distribution_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Distribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Distribution> ElectricLoadCenter_Distribution_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Distribution> ();
        
        public bool ShouldSerializeElectricLoadCenter_Storage_Converter_List()
        {
            return (ElectricLoadCenter_Storage_Converter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricLoadCenter:Storage:Converter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Converter> ElectricLoadCenter_Storage_Converter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.ElectricLoadCenter_Storage_Converter> ();
    }
}