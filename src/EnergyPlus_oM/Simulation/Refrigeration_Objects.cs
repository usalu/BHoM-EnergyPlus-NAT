using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Refrigeration")]
    public class Refrigeration_Objects : BHoMObject
    {
        
        public bool ShouldSerializeRefrigeration_Case_List()
        {
            return (Refrigeration_Case_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Case", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Case> Refrigeration_Case_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Case> ();
        
        public bool ShouldSerializeRefrigeration_CompressorRack_List()
        {
            return (Refrigeration_CompressorRack_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:CompressorRack", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorRack> Refrigeration_CompressorRack_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorRack> ();
        
        public bool ShouldSerializeRefrigeration_CaseAndWalkInList_List()
        {
            return (Refrigeration_CaseAndWalkInList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:CaseAndWalkInList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CaseAndWalkInList> Refrigeration_CaseAndWalkInList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CaseAndWalkInList> ();
        
        public bool ShouldSerializeRefrigeration_Condenser_AirCooled_List()
        {
            return (Refrigeration_Condenser_AirCooled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Condenser:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_AirCooled> Refrigeration_Condenser_AirCooled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_AirCooled> ();
        
        public bool ShouldSerializeRefrigeration_Condenser_EvaporativeCooled_List()
        {
            return (Refrigeration_Condenser_EvaporativeCooled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Condenser:EvaporativeCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_EvaporativeCooled> Refrigeration_Condenser_EvaporativeCooled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_EvaporativeCooled> ();
        
        public bool ShouldSerializeRefrigeration_Condenser_WaterCooled_List()
        {
            return (Refrigeration_Condenser_WaterCooled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Condenser:WaterCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_WaterCooled> Refrigeration_Condenser_WaterCooled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_WaterCooled> ();
        
        public bool ShouldSerializeRefrigeration_Condenser_Cascade_List()
        {
            return (Refrigeration_Condenser_Cascade_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Condenser:Cascade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_Cascade> Refrigeration_Condenser_Cascade_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Condenser_Cascade> ();
        
        public bool ShouldSerializeRefrigeration_GasCooler_AirCooled_List()
        {
            return (Refrigeration_GasCooler_AirCooled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:GasCooler:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_GasCooler_AirCooled> Refrigeration_GasCooler_AirCooled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_GasCooler_AirCooled> ();
        
        public bool ShouldSerializeRefrigeration_TransferLoadList_List()
        {
            return (Refrigeration_TransferLoadList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:TransferLoadList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TransferLoadList> Refrigeration_TransferLoadList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TransferLoadList> ();
        
        public bool ShouldSerializeRefrigeration_Subcooler_List()
        {
            return (Refrigeration_Subcooler_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Subcooler", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Subcooler> Refrigeration_Subcooler_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Subcooler> ();
        
        public bool ShouldSerializeRefrigeration_Compressor_List()
        {
            return (Refrigeration_Compressor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:Compressor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Compressor> Refrigeration_Compressor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_Compressor> ();
        
        public bool ShouldSerializeRefrigeration_CompressorList_List()
        {
            return (Refrigeration_CompressorList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:CompressorList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorList> Refrigeration_CompressorList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_CompressorList> ();
        
        public bool ShouldSerializeRefrigeration_System_List()
        {
            return (Refrigeration_System_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:System", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_System> Refrigeration_System_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_System> ();
        
        public bool ShouldSerializeRefrigeration_TranscriticalSystem_List()
        {
            return (Refrigeration_TranscriticalSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:TranscriticalSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TranscriticalSystem> Refrigeration_TranscriticalSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_TranscriticalSystem> ();
        
        public bool ShouldSerializeRefrigeration_SecondarySystem_List()
        {
            return (Refrigeration_SecondarySystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:SecondarySystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_SecondarySystem> Refrigeration_SecondarySystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_SecondarySystem> ();
        
        public bool ShouldSerializeRefrigeration_WalkIn_List()
        {
            return (Refrigeration_WalkIn_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:WalkIn", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_WalkIn> Refrigeration_WalkIn_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_WalkIn> ();
        
        public bool ShouldSerializeRefrigeration_AirChiller_List()
        {
            return (Refrigeration_AirChiller_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Refrigeration:AirChiller", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_AirChiller> Refrigeration_AirChiller_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_AirChiller> ();
        
        public bool ShouldSerializeZoneHVAC_RefrigerationChillerSet_List()
        {
            return (ZoneHVAC_RefrigerationChillerSet_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:RefrigerationChillerSet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.ZoneHVAC_RefrigerationChillerSet> ZoneHVAC_RefrigerationChillerSet_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.ZoneHVAC_RefrigerationChillerSet> ();
    }
}