using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Air Distribution")]
    public class AirDistribution_Objects : BHoMObject
    {
        
        public bool ShouldSerializeAirLoopHVAC_List()
        {
            return (AirLoopHVAC_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC> AirLoopHVAC_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC> ();
        
        public bool ShouldSerializeAirLoopHVAC_OutdoorAirSystem_EquipmentList_List()
        {
            return (AirLoopHVAC_OutdoorAirSystem_EquipmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:OutdoorAirSystem:EquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem_EquipmentList> AirLoopHVAC_OutdoorAirSystem_EquipmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem_EquipmentList> ();
        
        public bool ShouldSerializeAirLoopHVAC_OutdoorAirSystem_List()
        {
            return (AirLoopHVAC_OutdoorAirSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:OutdoorAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem> AirLoopHVAC_OutdoorAirSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_OutdoorAirSystem> ();
        
        public bool ShouldSerializeOutdoorAir_Mixer_List()
        {
            return (OutdoorAir_Mixer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="OutdoorAir:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.OutdoorAir_Mixer> OutdoorAir_Mixer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.OutdoorAir_Mixer> ();
        
        public bool ShouldSerializeAirLoopHVAC_ZoneSplitter_List()
        {
            return (AirLoopHVAC_ZoneSplitter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:ZoneSplitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneSplitter> AirLoopHVAC_ZoneSplitter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneSplitter> ();
        
        public bool ShouldSerializeAirLoopHVAC_SupplyPlenum_List()
        {
            return (AirLoopHVAC_SupplyPlenum_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:SupplyPlenum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPlenum> AirLoopHVAC_SupplyPlenum_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPlenum> ();
        
        public bool ShouldSerializeAirLoopHVAC_SupplyPath_List()
        {
            return (AirLoopHVAC_SupplyPath_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:SupplyPath", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPath> AirLoopHVAC_SupplyPath_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_SupplyPath> ();
        
        public bool ShouldSerializeAirLoopHVAC_ZoneMixer_List()
        {
            return (AirLoopHVAC_ZoneMixer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:ZoneMixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneMixer> AirLoopHVAC_ZoneMixer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ZoneMixer> ();
        
        public bool ShouldSerializeAirLoopHVAC_ReturnPlenum_List()
        {
            return (AirLoopHVAC_ReturnPlenum_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:ReturnPlenum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPlenum> AirLoopHVAC_ReturnPlenum_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPlenum> ();
        
        public bool ShouldSerializeAirLoopHVAC_ReturnPath_List()
        {
            return (AirLoopHVAC_ReturnPath_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:ReturnPath", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPath> AirLoopHVAC_ReturnPath_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_ReturnPath> ();
        
        public bool ShouldSerializeAirLoopHVAC_DedicatedOutdoorAirSystem_List()
        {
            return (AirLoopHVAC_DedicatedOutdoorAirSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:DedicatedOutdoorAirSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_DedicatedOutdoorAirSystem> AirLoopHVAC_DedicatedOutdoorAirSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_DedicatedOutdoorAirSystem> ();
        
        public bool ShouldSerializeAirLoopHVAC_Mixer_List()
        {
            return (AirLoopHVAC_Mixer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:Mixer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Mixer> AirLoopHVAC_Mixer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Mixer> ();
        
        public bool ShouldSerializeAirLoopHVAC_Splitter_List()
        {
            return (AirLoopHVAC_Splitter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirLoopHVAC:Splitter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Splitter> AirLoopHVAC_Splitter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirDistribution.AirLoopHVAC_Splitter> ();
    }
}