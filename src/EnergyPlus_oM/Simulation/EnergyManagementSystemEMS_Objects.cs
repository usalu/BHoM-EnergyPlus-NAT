using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Energy Management System (EMS)")]
    public class EnergyManagementSystemEMS_Objects : BHoMObject
    {
        
        public bool ShouldSerializeEnergyManagementSystem_Sensor_List()
        {
            return (EnergyManagementSystem_Sensor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:Sensor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Sensor> EnergyManagementSystem_Sensor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Sensor> ();
        
        public bool ShouldSerializeEnergyManagementSystem_Actuator_List()
        {
            return (EnergyManagementSystem_Actuator_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:Actuator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Actuator> EnergyManagementSystem_Actuator_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Actuator> ();
        
        public bool ShouldSerializeEnergyManagementSystem_ProgramCallingManager_List()
        {
            return (EnergyManagementSystem_ProgramCallingManager_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:ProgramCallingManager", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ProgramCallingManager> EnergyManagementSystem_ProgramCallingManager_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ProgramCallingManager> ();
        
        public bool ShouldSerializeEnergyManagementSystem_Program_List()
        {
            return (EnergyManagementSystem_Program_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:Program", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Program> EnergyManagementSystem_Program_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Program> ();
        
        public bool ShouldSerializeEnergyManagementSystem_Subroutine_List()
        {
            return (EnergyManagementSystem_Subroutine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:Subroutine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Subroutine> EnergyManagementSystem_Subroutine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_Subroutine> ();
        
        public bool ShouldSerializeEnergyManagementSystem_GlobalVariable_List()
        {
            return (EnergyManagementSystem_GlobalVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:GlobalVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_GlobalVariable> EnergyManagementSystem_GlobalVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_GlobalVariable> ();
        
        public bool ShouldSerializeEnergyManagementSystem_OutputVariable_List()
        {
            return (EnergyManagementSystem_OutputVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:OutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_OutputVariable> EnergyManagementSystem_OutputVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_OutputVariable> ();
        
        public bool ShouldSerializeEnergyManagementSystem_MeteredOutputVariable_List()
        {
            return (EnergyManagementSystem_MeteredOutputVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:MeteredOutputVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_MeteredOutputVariable> EnergyManagementSystem_MeteredOutputVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_MeteredOutputVariable> ();
        
        public bool ShouldSerializeEnergyManagementSystem_TrendVariable_List()
        {
            return (EnergyManagementSystem_TrendVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:TrendVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_TrendVariable> EnergyManagementSystem_TrendVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_TrendVariable> ();
        
        public bool ShouldSerializeEnergyManagementSystem_InternalVariable_List()
        {
            return (EnergyManagementSystem_InternalVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:InternalVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_InternalVariable> EnergyManagementSystem_InternalVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_InternalVariable> ();
        
        public bool ShouldSerializeEnergyManagementSystem_CurveOrTableIndexVariable_List()
        {
            return (EnergyManagementSystem_CurveOrTableIndexVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:CurveOrTableIndexVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_CurveOrTableIndexVariable> EnergyManagementSystem_CurveOrTableIndexVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_CurveOrTableIndexVariable> ();
        
        public bool ShouldSerializeEnergyManagementSystem_ConstructionIndexVariable_List()
        {
            return (EnergyManagementSystem_ConstructionIndexVariable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnergyManagementSystem:ConstructionIndexVariable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ConstructionIndexVariable> EnergyManagementSystem_ConstructionIndexVariable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS.EnergyManagementSystem_ConstructionIndexVariable> ();
    }
}