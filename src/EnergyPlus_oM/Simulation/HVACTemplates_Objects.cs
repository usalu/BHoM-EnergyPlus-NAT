using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: HVAC Templates")]
    public class HVACTemplates_Objects : BHoMObject
    {
        
        public bool ShouldSerializeHVACTemplate_Thermostat_List()
        {
            return (HVACTemplate_Thermostat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Thermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Thermostat> HVACTemplate_Thermostat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Thermostat> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_IdealLoadsAirSystem_List()
        {
            return (HVACTemplate_Zone_IdealLoadsAirSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:IdealLoadsAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_IdealLoadsAirSystem> HVACTemplate_Zone_IdealLoadsAirSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_IdealLoadsAirSystem> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_BaseboardHeat_List()
        {
            return (HVACTemplate_Zone_BaseboardHeat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:BaseboardHeat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_BaseboardHeat> HVACTemplate_Zone_BaseboardHeat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_BaseboardHeat> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_FanCoil_List()
        {
            return (HVACTemplate_Zone_FanCoil_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:FanCoil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_FanCoil> HVACTemplate_Zone_FanCoil_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_FanCoil> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_PTAC_List()
        {
            return (HVACTemplate_Zone_PTAC_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:PTAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTAC> HVACTemplate_Zone_PTAC_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTAC> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_PTHP_List()
        {
            return (HVACTemplate_Zone_PTHP_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:PTHP", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTHP> HVACTemplate_Zone_PTHP_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_PTHP> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_WaterToAirHeatPump_List()
        {
            return (HVACTemplate_Zone_WaterToAirHeatPump_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:WaterToAirHeatPump", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_WaterToAirHeatPump> HVACTemplate_Zone_WaterToAirHeatPump_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_WaterToAirHeatPump> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_VRF_List()
        {
            return (HVACTemplate_Zone_VRF_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:VRF", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VRF> HVACTemplate_Zone_VRF_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VRF> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_Unitary_List()
        {
            return (HVACTemplate_Zone_Unitary_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:Unitary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_Unitary> HVACTemplate_Zone_Unitary_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_Unitary> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_VAV_List()
        {
            return (HVACTemplate_Zone_VAV_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV> HVACTemplate_Zone_VAV_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_VAV_FanPowered_List()
        {
            return (HVACTemplate_Zone_VAV_FanPowered_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:VAV:FanPowered", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_FanPowered> HVACTemplate_Zone_VAV_FanPowered_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_FanPowered> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_VAV_HeatAndCool_List()
        {
            return (HVACTemplate_Zone_VAV_HeatAndCool_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:VAV:HeatAndCool", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_HeatAndCool> HVACTemplate_Zone_VAV_HeatAndCool_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_VAV_HeatAndCool> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_ConstantVolume_List()
        {
            return (HVACTemplate_Zone_ConstantVolume_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_ConstantVolume> HVACTemplate_Zone_ConstantVolume_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_ConstantVolume> ();
        
        public bool ShouldSerializeHVACTemplate_Zone_DualDuct_List()
        {
            return (HVACTemplate_Zone_DualDuct_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Zone:DualDuct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_DualDuct> HVACTemplate_Zone_DualDuct_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Zone_DualDuct> ();
        
        public bool ShouldSerializeHVACTemplate_System_VRF_List()
        {
            return (HVACTemplate_System_VRF_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:VRF", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VRF> HVACTemplate_System_VRF_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VRF> ();
        
        public bool ShouldSerializeHVACTemplate_System_Unitary_List()
        {
            return (HVACTemplate_System_Unitary_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:Unitary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_Unitary> HVACTemplate_System_Unitary_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_Unitary> ();
        
        public bool ShouldSerializeHVACTemplate_System_UnitaryHeatPump_AirToAir_List()
        {
            return (HVACTemplate_System_UnitaryHeatPump_AirToAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:UnitaryHeatPump:AirToAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitaryHeatPump_AirToAir> HVACTemplate_System_UnitaryHeatPump_AirToAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitaryHeatPump_AirToAir> ();
        
        public bool ShouldSerializeHVACTemplate_System_UnitarySystem_List()
        {
            return (HVACTemplate_System_UnitarySystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:UnitarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitarySystem> HVACTemplate_System_UnitarySystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_UnitarySystem> ();
        
        public bool ShouldSerializeHVACTemplate_System_VAV_List()
        {
            return (HVACTemplate_System_VAV_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:VAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VAV> HVACTemplate_System_VAV_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_VAV> ();
        
        public bool ShouldSerializeHVACTemplate_System_PackagedVAV_List()
        {
            return (HVACTemplate_System_PackagedVAV_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:PackagedVAV", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_PackagedVAV> HVACTemplate_System_PackagedVAV_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_PackagedVAV> ();
        
        public bool ShouldSerializeHVACTemplate_System_ConstantVolume_List()
        {
            return (HVACTemplate_System_ConstantVolume_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:ConstantVolume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_ConstantVolume> HVACTemplate_System_ConstantVolume_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_ConstantVolume> ();
        
        public bool ShouldSerializeHVACTemplate_System_DualDuct_List()
        {
            return (HVACTemplate_System_DualDuct_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:DualDuct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DualDuct> HVACTemplate_System_DualDuct_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DualDuct> ();
        
        public bool ShouldSerializeHVACTemplate_System_DedicatedOutdoorAir_List()
        {
            return (HVACTemplate_System_DedicatedOutdoorAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:System:DedicatedOutdoorAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DedicatedOutdoorAir> HVACTemplate_System_DedicatedOutdoorAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_System_DedicatedOutdoorAir> ();
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:ChilledWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_ChilledWaterLoop HVACTemplate_Plant_ChilledWaterLoop { get; set; } = null;
        
        public bool ShouldSerializeHVACTemplate_Plant_Chiller_List()
        {
            return (HVACTemplate_Plant_Chiller_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:Chiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller> HVACTemplate_Plant_Chiller_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller> ();
        
        public bool ShouldSerializeHVACTemplate_Plant_Chiller_ObjectReference_List()
        {
            return (HVACTemplate_Plant_Chiller_ObjectReference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:Chiller:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller_ObjectReference> HVACTemplate_Plant_Chiller_ObjectReference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Chiller_ObjectReference> ();
        
        public bool ShouldSerializeHVACTemplate_Plant_Tower_List()
        {
            return (HVACTemplate_Plant_Tower_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:Tower", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower> HVACTemplate_Plant_Tower_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower> ();
        
        public bool ShouldSerializeHVACTemplate_Plant_Tower_ObjectReference_List()
        {
            return (HVACTemplate_Plant_Tower_ObjectReference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:Tower:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower_ObjectReference> HVACTemplate_Plant_Tower_ObjectReference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Tower_ObjectReference> ();
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:HotWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_HotWaterLoop HVACTemplate_Plant_HotWaterLoop { get; set; } = null;
        
        public bool ShouldSerializeHVACTemplate_Plant_Boiler_List()
        {
            return (HVACTemplate_Plant_Boiler_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:Boiler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler> HVACTemplate_Plant_Boiler_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler> ();
        
        public bool ShouldSerializeHVACTemplate_Plant_Boiler_ObjectReference_List()
        {
            return (HVACTemplate_Plant_Boiler_ObjectReference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:Boiler:ObjectReference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler_ObjectReference> HVACTemplate_Plant_Boiler_ObjectReference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_Boiler_ObjectReference> ();
        

        [JsonProperty(PropertyName="HVACTemplate:Plant:MixedWaterLoop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.HVACTemplates.HVACTemplate_Plant_MixedWaterLoop HVACTemplate_Plant_MixedWaterLoop { get; set; } = null;
    }
}