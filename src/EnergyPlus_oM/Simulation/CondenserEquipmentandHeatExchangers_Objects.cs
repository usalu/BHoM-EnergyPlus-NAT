using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Condenser Equipment and Heat Exchange" +
                 "rs")]
    public class CondenserEquipmentandHeatExchangers_Objects : BHoMObject
    {
        
        public bool ShouldSerializeCoolingTower_SingleSpeed_List()
        {
            return (CoolingTower_SingleSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoolingTower:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_SingleSpeed> CoolingTower_SingleSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_SingleSpeed> ();
        
        public bool ShouldSerializeCoolingTower_TwoSpeed_List()
        {
            return (CoolingTower_TwoSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoolingTower:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_TwoSpeed> CoolingTower_TwoSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_TwoSpeed> ();
        
        public bool ShouldSerializeCoolingTower_VariableSpeed_Merkel_List()
        {
            return (CoolingTower_VariableSpeed_Merkel_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoolingTower:VariableSpeed:Merkel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed_Merkel> CoolingTower_VariableSpeed_Merkel_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed_Merkel> ();
        
        public bool ShouldSerializeCoolingTower_VariableSpeed_List()
        {
            return (CoolingTower_VariableSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoolingTower:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed> CoolingTower_VariableSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTower_VariableSpeed> ();
        
        public bool ShouldSerializeCoolingTowerPerformance_CoolTools_List()
        {
            return (CoolingTowerPerformance_CoolTools_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoolingTowerPerformance:CoolTools", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_CoolTools> CoolingTowerPerformance_CoolTools_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_CoolTools> ();
        
        public bool ShouldSerializeCoolingTowerPerformance_YorkCalc_List()
        {
            return (CoolingTowerPerformance_YorkCalc_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoolingTowerPerformance:YorkCalc", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_YorkCalc> CoolingTowerPerformance_YorkCalc_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.CoolingTowerPerformance_YorkCalc> ();
        
        public bool ShouldSerializeEvaporativeFluidCooler_SingleSpeed_List()
        {
            return (EvaporativeFluidCooler_SingleSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeFluidCooler:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_SingleSpeed> EvaporativeFluidCooler_SingleSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_SingleSpeed> ();
        
        public bool ShouldSerializeEvaporativeFluidCooler_TwoSpeed_List()
        {
            return (EvaporativeFluidCooler_TwoSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EvaporativeFluidCooler:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_TwoSpeed> EvaporativeFluidCooler_TwoSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.EvaporativeFluidCooler_TwoSpeed> ();
        
        public bool ShouldSerializeFluidCooler_SingleSpeed_List()
        {
            return (FluidCooler_SingleSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidCooler:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_SingleSpeed> FluidCooler_SingleSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_SingleSpeed> ();
        
        public bool ShouldSerializeFluidCooler_TwoSpeed_List()
        {
            return (FluidCooler_TwoSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidCooler:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_TwoSpeed> FluidCooler_TwoSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.FluidCooler_TwoSpeed> ();
        
        public bool ShouldSerializeGroundHeatExchanger_System_List()
        {
            return (GroundHeatExchanger_System_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_System> GroundHeatExchanger_System_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_System> ();
        
        public bool ShouldSerializeGroundHeatExchanger_Vertical_Properties_List()
        {
            return (GroundHeatExchanger_Vertical_Properties_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:Vertical:Properties", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Properties> GroundHeatExchanger_Vertical_Properties_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Properties> ();
        
        public bool ShouldSerializeGroundHeatExchanger_Vertical_Array_List()
        {
            return (GroundHeatExchanger_Vertical_Array_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:Vertical:Array", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Array> GroundHeatExchanger_Vertical_Array_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Array> ();
        
        public bool ShouldSerializeGroundHeatExchanger_Vertical_Single_List()
        {
            return (GroundHeatExchanger_Vertical_Single_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:Vertical:Single", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Single> GroundHeatExchanger_Vertical_Single_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Vertical_Single> ();
        
        public bool ShouldSerializeGroundHeatExchanger_ResponseFactors_List()
        {
            return (GroundHeatExchanger_ResponseFactors_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:ResponseFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_ResponseFactors> GroundHeatExchanger_ResponseFactors_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_ResponseFactors> ();
        
        public bool ShouldSerializeGroundHeatExchanger_Pond_List()
        {
            return (GroundHeatExchanger_Pond_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:Pond", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Pond> GroundHeatExchanger_Pond_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Pond> ();
        
        public bool ShouldSerializeGroundHeatExchanger_Surface_List()
        {
            return (GroundHeatExchanger_Surface_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:Surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Surface> GroundHeatExchanger_Surface_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Surface> ();
        
        public bool ShouldSerializeGroundHeatExchanger_HorizontalTrench_List()
        {
            return (GroundHeatExchanger_HorizontalTrench_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:HorizontalTrench", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_HorizontalTrench> GroundHeatExchanger_HorizontalTrench_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_HorizontalTrench> ();
        
        public bool ShouldSerializeGroundHeatExchanger_Slinky_List()
        {
            return (GroundHeatExchanger_Slinky_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatExchanger:Slinky", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Slinky> GroundHeatExchanger_Slinky_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_Slinky> ();
        
        public bool ShouldSerializeHeatExchanger_FluidToFluid_List()
        {
            return (HeatExchanger_FluidToFluid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HeatExchanger:FluidToFluid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.HeatExchanger_FluidToFluid> HeatExchanger_FluidToFluid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.HeatExchanger_FluidToFluid> ();
    }
}