using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Plant-Condenser Control")]
    public class PlantCondenserControl_Objects : BHoMObject
    {
        
        public bool ShouldSerializePlantEquipmentList_List()
        {
            return (PlantEquipmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentList> PlantEquipmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentList> ();
        
        public bool ShouldSerializeCondenserEquipmentList_List()
        {
            return (CondenserEquipmentList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CondenserEquipmentList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentList> CondenserEquipmentList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentList> ();
        
        public bool ShouldSerializePlantEquipmentOperation_Uncontrolled_List()
        {
            return (PlantEquipmentOperation_Uncontrolled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:Uncontrolled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_Uncontrolled> PlantEquipmentOperation_Uncontrolled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_Uncontrolled> ();
        
        public bool ShouldSerializePlantEquipmentOperation_CoolingLoad_List()
        {
            return (PlantEquipmentOperation_CoolingLoad_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:CoolingLoad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_CoolingLoad> PlantEquipmentOperation_CoolingLoad_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_CoolingLoad> ();
        
        public bool ShouldSerializePlantEquipmentOperation_HeatingLoad_List()
        {
            return (PlantEquipmentOperation_HeatingLoad_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:HeatingLoad", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_HeatingLoad> PlantEquipmentOperation_HeatingLoad_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_HeatingLoad> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorDryBulb_List()
        {
            return (PlantEquipmentOperation_OutdoorDryBulb_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDryBulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulb> PlantEquipmentOperation_OutdoorDryBulb_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulb> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorWetBulb_List()
        {
            return (PlantEquipmentOperation_OutdoorWetBulb_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorWetBulb", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulb> PlantEquipmentOperation_OutdoorWetBulb_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulb> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorRelativeHumidity_List()
        {
            return (PlantEquipmentOperation_OutdoorRelativeHumidity_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorRelativeHumidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorRelativeHumidity> PlantEquipmentOperation_OutdoorRelativeHumidity_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorRelativeHumidity> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorDewpoint_List()
        {
            return (PlantEquipmentOperation_OutdoorDewpoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDewpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpoint> PlantEquipmentOperation_OutdoorDewpoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpoint> ();
        
        public bool ShouldSerializePlantEquipmentOperation_ComponentSetpoint_List()
        {
            return (PlantEquipmentOperation_ComponentSetpoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:ComponentSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ComponentSetpoint> PlantEquipmentOperation_ComponentSetpoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ComponentSetpoint> ();
        
        public bool ShouldSerializePlantEquipmentOperation_ThermalEnergyStorage_List()
        {
            return (PlantEquipmentOperation_ThermalEnergyStorage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:ThermalEnergyStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ThermalEnergyStorage> PlantEquipmentOperation_ThermalEnergyStorage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_ThermalEnergyStorage> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorDryBulbDifference_List()
        {
            return (PlantEquipmentOperation_OutdoorDryBulbDifference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDryBulbDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulbDifference> PlantEquipmentOperation_OutdoorDryBulbDifference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDryBulbDifference> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorWetBulbDifference_List()
        {
            return (PlantEquipmentOperation_OutdoorWetBulbDifference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorWetBulbDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulbDifference> PlantEquipmentOperation_OutdoorWetBulbDifference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorWetBulbDifference> ();
        
        public bool ShouldSerializePlantEquipmentOperation_OutdoorDewpointDifference_List()
        {
            return (PlantEquipmentOperation_OutdoorDewpointDifference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperation:OutdoorDewpointDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpointDifference> PlantEquipmentOperation_OutdoorDewpointDifference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperation_OutdoorDewpointDifference> ();
        
        public bool ShouldSerializePlantEquipmentOperationSchemes_List()
        {
            return (PlantEquipmentOperationSchemes_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="PlantEquipmentOperationSchemes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperationSchemes> PlantEquipmentOperationSchemes_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.PlantEquipmentOperationSchemes> ();
        
        public bool ShouldSerializeCondenserEquipmentOperationSchemes_List()
        {
            return (CondenserEquipmentOperationSchemes_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CondenserEquipmentOperationSchemes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentOperationSchemes> CondenserEquipmentOperationSchemes_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.PlantCondenserControl.CondenserEquipmentOperationSchemes> ();
    }
}