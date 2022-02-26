using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: External Interface")]
    public class ExternalInterface_Objects : BHoMObject
    {
        
        public bool ShouldSerializeExternalInterface_List()
        {
            return (ExternalInterface_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface> ExternalInterface_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface> ();
        
        public bool ShouldSerializeExternalInterface_Schedule_List()
        {
            return (ExternalInterface_Schedule_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Schedule> ExternalInterface_Schedule_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Schedule> ();
        
        public bool ShouldSerializeExternalInterface_Variable_List()
        {
            return (ExternalInterface_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Variable> ExternalInterface_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Variable> ();
        
        public bool ShouldSerializeExternalInterface_Actuator_List()
        {
            return (ExternalInterface_Actuator_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Actuator> ExternalInterface_Actuator_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_Actuator> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitImport_List()
        {
            return (ExternalInterface_FunctionalMockupUnitImport_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport> ExternalInterface_FunctionalMockupUnitImport_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitImport_From_Variable_List()
        {
            return (ExternalInterface_FunctionalMockupUnitImport_From_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:From:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_From_Variable> ExternalInterface_FunctionalMockupUnitImport_From_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_From_Variable> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitImport_To_Schedule_List()
        {
            return (ExternalInterface_FunctionalMockupUnitImport_To_Schedule_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:To:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Schedule> ExternalInterface_FunctionalMockupUnitImport_To_Schedule_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Schedule> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitImport_To_Actuator_List()
        {
            return (ExternalInterface_FunctionalMockupUnitImport_To_Actuator_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:To:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Actuator> ExternalInterface_FunctionalMockupUnitImport_To_Actuator_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Actuator> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitImport_To_Variable_List()
        {
            return (ExternalInterface_FunctionalMockupUnitImport_To_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitImport:To:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Variable> ExternalInterface_FunctionalMockupUnitImport_To_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitImport_To_Variable> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitExport_From_Variable_List()
        {
            return (ExternalInterface_FunctionalMockupUnitExport_From_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:From:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_From_Variable> ExternalInterface_FunctionalMockupUnitExport_From_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_From_Variable> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitExport_To_Schedule_List()
        {
            return (ExternalInterface_FunctionalMockupUnitExport_To_Schedule_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:To:Schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Schedule> ExternalInterface_FunctionalMockupUnitExport_To_Schedule_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Schedule> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitExport_To_Actuator_List()
        {
            return (ExternalInterface_FunctionalMockupUnitExport_To_Actuator_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:To:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Actuator> ExternalInterface_FunctionalMockupUnitExport_To_Actuator_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Actuator> ();
        
        public bool ShouldSerializeExternalInterface_FunctionalMockupUnitExport_To_Variable_List()
        {
            return (ExternalInterface_FunctionalMockupUnitExport_To_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ExternalInterface:FunctionalMockupUnitExport:To:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Variable> ExternalInterface_FunctionalMockupUnitExport_To_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ExternalInterface.ExternalInterface_FunctionalMockupUnitExport_To_Variable> ();
    }
}