using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Setpoint Managers")]
    public class SetpointManagers_Objects : BHoMObject
    {
        
        public bool ShouldSerializeSetpointManager_Scheduled_List()
        {
            return (SetpointManager_Scheduled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:Scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled> SetpointManager_Scheduled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled> ();
        
        public bool ShouldSerializeSetpointManager_Scheduled_DualSetpoint_List()
        {
            return (SetpointManager_Scheduled_DualSetpoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:Scheduled:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled_DualSetpoint> SetpointManager_Scheduled_DualSetpoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Scheduled_DualSetpoint> ();
        
        public bool ShouldSerializeSetpointManager_OutdoorAirReset_List()
        {
            return (SetpointManager_OutdoorAirReset_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:OutdoorAirReset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirReset> SetpointManager_OutdoorAirReset_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirReset> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_Reheat_List()
        {
            return (SetpointManager_SingleZone_Reheat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:Reheat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Reheat> SetpointManager_SingleZone_Reheat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Reheat> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_Heating_List()
        {
            return (SetpointManager_SingleZone_Heating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:Heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Heating> SetpointManager_SingleZone_Heating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Heating> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_Cooling_List()
        {
            return (SetpointManager_SingleZone_Cooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Cooling> SetpointManager_SingleZone_Cooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Cooling> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_Humidity_Minimum_List()
        {
            return (SetpointManager_SingleZone_Humidity_Minimum_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:Humidity:Minimum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Minimum> SetpointManager_SingleZone_Humidity_Minimum_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Minimum> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_Humidity_Maximum_List()
        {
            return (SetpointManager_SingleZone_Humidity_Maximum_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:Humidity:Maximum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Maximum> SetpointManager_SingleZone_Humidity_Maximum_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_Humidity_Maximum> ();
        
        public bool ShouldSerializeSetpointManager_MixedAir_List()
        {
            return (SetpointManager_MixedAir_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MixedAir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MixedAir> SetpointManager_MixedAir_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MixedAir> ();
        
        public bool ShouldSerializeSetpointManager_OutdoorAirPretreat_List()
        {
            return (SetpointManager_OutdoorAirPretreat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:OutdoorAirPretreat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirPretreat> SetpointManager_OutdoorAirPretreat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_OutdoorAirPretreat> ();
        
        public bool ShouldSerializeSetpointManager_Warmest_List()
        {
            return (SetpointManager_Warmest_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:Warmest", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Warmest> SetpointManager_Warmest_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Warmest> ();
        
        public bool ShouldSerializeSetpointManager_Coldest_List()
        {
            return (SetpointManager_Coldest_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:Coldest", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Coldest> SetpointManager_Coldest_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_Coldest> ();
        
        public bool ShouldSerializeSetpointManager_ReturnAirBypassFlow_List()
        {
            return (SetpointManager_ReturnAirBypassFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:ReturnAirBypassFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnAirBypassFlow> SetpointManager_ReturnAirBypassFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnAirBypassFlow> ();
        
        public bool ShouldSerializeSetpointManager_WarmestTemperatureFlow_List()
        {
            return (SetpointManager_WarmestTemperatureFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:WarmestTemperatureFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_WarmestTemperatureFlow> SetpointManager_WarmestTemperatureFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_WarmestTemperatureFlow> ();
        
        public bool ShouldSerializeSetpointManager_MultiZone_Heating_Average_List()
        {
            return (SetpointManager_MultiZone_Heating_Average_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MultiZone:Heating:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Heating_Average> SetpointManager_MultiZone_Heating_Average_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Heating_Average> ();
        
        public bool ShouldSerializeSetpointManager_MultiZone_Cooling_Average_List()
        {
            return (SetpointManager_MultiZone_Cooling_Average_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MultiZone:Cooling:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Cooling_Average> SetpointManager_MultiZone_Cooling_Average_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Cooling_Average> ();
        
        public bool ShouldSerializeSetpointManager_MultiZone_MinimumHumidity_Average_List()
        {
            return (SetpointManager_MultiZone_MinimumHumidity_Average_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MultiZone:MinimumHumidity:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MinimumHumidity_Average> SetpointManager_MultiZone_MinimumHumidity_Average_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MinimumHumidity_Average> ();
        
        public bool ShouldSerializeSetpointManager_MultiZone_MaximumHumidity_Average_List()
        {
            return (SetpointManager_MultiZone_MaximumHumidity_Average_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MultiZone:MaximumHumidity:Average", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MaximumHumidity_Average> SetpointManager_MultiZone_MaximumHumidity_Average_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_MaximumHumidity_Average> ();
        
        public bool ShouldSerializeSetpointManager_MultiZone_Humidity_Minimum_List()
        {
            return (SetpointManager_MultiZone_Humidity_Minimum_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MultiZone:Humidity:Minimum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Minimum> SetpointManager_MultiZone_Humidity_Minimum_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Minimum> ();
        
        public bool ShouldSerializeSetpointManager_MultiZone_Humidity_Maximum_List()
        {
            return (SetpointManager_MultiZone_Humidity_Maximum_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:MultiZone:Humidity:Maximum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Maximum> SetpointManager_MultiZone_Humidity_Maximum_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_MultiZone_Humidity_Maximum> ();
        
        public bool ShouldSerializeSetpointManager_FollowOutdoorAirTemperature_List()
        {
            return (SetpointManager_FollowOutdoorAirTemperature_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:FollowOutdoorAirTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowOutdoorAirTemperature> SetpointManager_FollowOutdoorAirTemperature_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowOutdoorAirTemperature> ();
        
        public bool ShouldSerializeSetpointManager_FollowSystemNodeTemperature_List()
        {
            return (SetpointManager_FollowSystemNodeTemperature_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:FollowSystemNodeTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowSystemNodeTemperature> SetpointManager_FollowSystemNodeTemperature_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowSystemNodeTemperature> ();
        
        public bool ShouldSerializeSetpointManager_FollowGroundTemperature_List()
        {
            return (SetpointManager_FollowGroundTemperature_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:FollowGroundTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowGroundTemperature> SetpointManager_FollowGroundTemperature_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_FollowGroundTemperature> ();
        
        public bool ShouldSerializeSetpointManager_CondenserEnteringReset_List()
        {
            return (SetpointManager_CondenserEnteringReset_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:CondenserEnteringReset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset> SetpointManager_CondenserEnteringReset_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset> ();
        
        public bool ShouldSerializeSetpointManager_CondenserEnteringReset_Ideal_List()
        {
            return (SetpointManager_CondenserEnteringReset_Ideal_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:CondenserEnteringReset:Ideal", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset_Ideal> SetpointManager_CondenserEnteringReset_Ideal_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_CondenserEnteringReset_Ideal> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_OneStageCooling_List()
        {
            return (SetpointManager_SingleZone_OneStageCooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:OneStageCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageCooling> SetpointManager_SingleZone_OneStageCooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageCooling> ();
        
        public bool ShouldSerializeSetpointManager_SingleZone_OneStageHeating_List()
        {
            return (SetpointManager_SingleZone_OneStageHeating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:SingleZone:OneStageHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageHeating> SetpointManager_SingleZone_OneStageHeating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_SingleZone_OneStageHeating> ();
        
        public bool ShouldSerializeSetpointManager_ReturnTemperature_ChilledWater_List()
        {
            return (SetpointManager_ReturnTemperature_ChilledWater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:ReturnTemperature:ChilledWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_ChilledWater> SetpointManager_ReturnTemperature_ChilledWater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_ChilledWater> ();
        
        public bool ShouldSerializeSetpointManager_ReturnTemperature_HotWater_List()
        {
            return (SetpointManager_ReturnTemperature_HotWater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SetpointManager:ReturnTemperature:HotWater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_HotWater> SetpointManager_ReturnTemperature_HotWater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SetpointManagers.SetpointManager_ReturnTemperature_HotWater> ();
    }
}