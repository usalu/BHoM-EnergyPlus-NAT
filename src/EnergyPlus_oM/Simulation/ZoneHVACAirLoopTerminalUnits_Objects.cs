using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Zone HVAC Air Loop Terminal Units")]
    public class ZoneHVACAirLoopTerminalUnits_Objects : BHoMObject
    {
        
        public bool ShouldSerializeAirTerminal_SingleDuct_ConstantVolume_Reheat_List()
        {
            return (AirTerminal_SingleDuct_ConstantVolume_Reheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_Reheat> AirTerminal_SingleDuct_ConstantVolume_Reheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_Reheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_ConstantVolume_NoReheat_List()
        {
            return (AirTerminal_SingleDuct_ConstantVolume_NoReheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_NoReheat> AirTerminal_SingleDuct_ConstantVolume_NoReheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_NoReheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_VAV_NoReheat_List()
        {
            return (AirTerminal_SingleDuct_VAV_NoReheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_NoReheat> AirTerminal_SingleDuct_VAV_NoReheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_NoReheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_VAV_Reheat_List()
        {
            return (AirTerminal_SingleDuct_VAV_Reheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat> AirTerminal_SingleDuct_VAV_Reheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_List()
        {
            return (AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:Reheat:VariableSpeedFan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan> AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_Reheat_VariableSpeedFan> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat_List()
        {
            return (AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:HeatAndCool:NoReheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat> AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_NoReheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_List()
        {
            return (AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:VAV:HeatAndCool:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat> AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_VAV_HeatAndCool_Reheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_SeriesPIU_Reheat_List()
        {
            return (AirTerminal_SingleDuct_SeriesPIU_Reheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:SeriesPIU:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_SeriesPIU_Reheat> AirTerminal_SingleDuct_SeriesPIU_Reheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_SeriesPIU_Reheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_ParallelPIU_Reheat_List()
        {
            return (AirTerminal_SingleDuct_ParallelPIU_Reheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:ParallelPIU:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ParallelPIU_Reheat> AirTerminal_SingleDuct_ParallelPIU_Reheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ParallelPIU_Reheat> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_List()
        {
            return (AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:FourPipeInduction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction> AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeInduction> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_ConstantVolume_FourPipeBeam_List()
        {
            return (AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:FourPipeBeam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam> AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_FourPipeBeam> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_ConstantVolume_CooledBeam_List()
        {
            return (AirTerminal_SingleDuct_ConstantVolume_CooledBeam_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:ConstantVolume:CooledBeam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_CooledBeam> AirTerminal_SingleDuct_ConstantVolume_CooledBeam_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_ConstantVolume_CooledBeam> ();
        
        public bool ShouldSerializeAirTerminal_SingleDuct_Mixer_List()
        {
            return (AirTerminal_SingleDuct_Mixer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:SingleDuct:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_Mixer> AirTerminal_SingleDuct_Mixer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_SingleDuct_Mixer> ();
        
        public bool ShouldSerializeAirTerminal_DualDuct_ConstantVolume_List()
        {
            return (AirTerminal_DualDuct_ConstantVolume_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:DualDuct:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_ConstantVolume> AirTerminal_DualDuct_ConstantVolume_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_ConstantVolume> ();
        
        public bool ShouldSerializeAirTerminal_DualDuct_VAV_List()
        {
            return (AirTerminal_DualDuct_VAV_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:DualDuct:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV> AirTerminal_DualDuct_VAV_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV> ();
        
        public bool ShouldSerializeAirTerminal_DualDuct_VAV_OutdoorAir_List()
        {
            return (AirTerminal_DualDuct_VAV_OutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirTerminal:DualDuct:VAV:OutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV_OutdoorAir> AirTerminal_DualDuct_VAV_OutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.AirTerminal_DualDuct_VAV_OutdoorAir> ();
        
        public bool ShouldSerializeZoneHVAC_AirDistributionUnit_List()
        {
            return (ZoneHVAC_AirDistributionUnit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:AirDistributionUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.ZoneHVAC_AirDistributionUnit> ZoneHVAC_AirDistributionUnit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits.ZoneHVAC_AirDistributionUnit> ();
    }
}