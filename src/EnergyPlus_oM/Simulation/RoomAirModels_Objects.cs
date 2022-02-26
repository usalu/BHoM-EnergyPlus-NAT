using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Room Air Models")]
    public class RoomAirModels_Objects : BHoMObject
    {
        
        public bool ShouldSerializeRoomAirModelType_List()
        {
            return (RoomAirModelType_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirModelType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirModelType> RoomAirModelType_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirModelType> ();
        
        public bool ShouldSerializeRoomAir_TemperaturePattern_UserDefined_List()
        {
            return (RoomAir_TemperaturePattern_UserDefined_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:TemperaturePattern:UserDefined", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_UserDefined> RoomAir_TemperaturePattern_UserDefined_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_UserDefined> ();
        
        public bool ShouldSerializeRoomAir_TemperaturePattern_ConstantGradient_List()
        {
            return (RoomAir_TemperaturePattern_ConstantGradient_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:TemperaturePattern:ConstantGradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_ConstantGradient> RoomAir_TemperaturePattern_ConstantGradient_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_ConstantGradient> ();
        
        public bool ShouldSerializeRoomAir_TemperaturePattern_TwoGradient_List()
        {
            return (RoomAir_TemperaturePattern_TwoGradient_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:TemperaturePattern:TwoGradient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_TwoGradient> RoomAir_TemperaturePattern_TwoGradient_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_TwoGradient> ();
        
        public bool ShouldSerializeRoomAir_TemperaturePattern_NondimensionalHeight_List()
        {
            return (RoomAir_TemperaturePattern_NondimensionalHeight_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:TemperaturePattern:NondimensionalHeight", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_NondimensionalHeight> RoomAir_TemperaturePattern_NondimensionalHeight_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_NondimensionalHeight> ();
        
        public bool ShouldSerializeRoomAir_TemperaturePattern_SurfaceMapping_List()
        {
            return (RoomAir_TemperaturePattern_SurfaceMapping_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:TemperaturePattern:SurfaceMapping", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_SurfaceMapping> RoomAir_TemperaturePattern_SurfaceMapping_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_TemperaturePattern_SurfaceMapping> ();
        
        public bool ShouldSerializeRoomAir_Node_List()
        {
            return (RoomAir_Node_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node> RoomAir_Node_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node> ();
        
        public bool ShouldSerializeRoomAirSettings_OneNodeDisplacementVentilation_List()
        {
            return (RoomAirSettings_OneNodeDisplacementVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirSettings:OneNodeDisplacementVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_OneNodeDisplacementVentilation> RoomAirSettings_OneNodeDisplacementVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_OneNodeDisplacementVentilation> ();
        
        public bool ShouldSerializeRoomAirSettings_ThreeNodeDisplacementVentilation_List()
        {
            return (RoomAirSettings_ThreeNodeDisplacementVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirSettings:ThreeNodeDisplacementVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_ThreeNodeDisplacementVentilation> RoomAirSettings_ThreeNodeDisplacementVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_ThreeNodeDisplacementVentilation> ();
        
        public bool ShouldSerializeRoomAirSettings_CrossVentilation_List()
        {
            return (RoomAirSettings_CrossVentilation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirSettings:CrossVentilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_CrossVentilation> RoomAirSettings_CrossVentilation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_CrossVentilation> ();
        
        public bool ShouldSerializeRoomAirSettings_UnderFloorAirDistributionInterior_List()
        {
            return (RoomAirSettings_UnderFloorAirDistributionInterior_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirSettings:UnderFloorAirDistributionInterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionInterior> RoomAirSettings_UnderFloorAirDistributionInterior_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionInterior> ();
        
        public bool ShouldSerializeRoomAirSettings_UnderFloorAirDistributionExterior_List()
        {
            return (RoomAirSettings_UnderFloorAirDistributionExterior_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirSettings:UnderFloorAirDistributionExterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionExterior> RoomAirSettings_UnderFloorAirDistributionExterior_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_UnderFloorAirDistributionExterior> ();
        
        public bool ShouldSerializeRoomAir_Node_AirflowNetwork_List()
        {
            return (RoomAir_Node_AirflowNetwork_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork> RoomAir_Node_AirflowNetwork_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork> ();
        
        public bool ShouldSerializeRoomAir_Node_AirflowNetwork_AdjacentSurfaceList_List()
        {
            return (RoomAir_Node_AirflowNetwork_AdjacentSurfaceList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork:AdjacentSurfaceList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_AdjacentSurfaceList> RoomAir_Node_AirflowNetwork_AdjacentSurfaceList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_AdjacentSurfaceList> ();
        
        public bool ShouldSerializeRoomAir_Node_AirflowNetwork_InternalGains_List()
        {
            return (RoomAir_Node_AirflowNetwork_InternalGains_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork:InternalGains", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_InternalGains> RoomAir_Node_AirflowNetwork_InternalGains_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_InternalGains> ();
        
        public bool ShouldSerializeRoomAir_Node_AirflowNetwork_HVACEquipment_List()
        {
            return (RoomAir_Node_AirflowNetwork_HVACEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAir:Node:AirflowNetwork:HVACEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_HVACEquipment> RoomAir_Node_AirflowNetwork_HVACEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAir_Node_AirflowNetwork_HVACEquipment> ();
        
        public bool ShouldSerializeRoomAirSettings_AirflowNetwork_List()
        {
            return (RoomAirSettings_AirflowNetwork_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoomAirSettings:AirflowNetwork", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_AirflowNetwork> RoomAirSettings_AirflowNetwork_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.RoomAirModels.RoomAirSettings_AirflowNetwork> ();
    }
}