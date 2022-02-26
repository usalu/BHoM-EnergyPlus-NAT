using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Zone HVAC Radiative/Convective Units")]
    public class ZoneHVACRadiativeConvectiveUnits_Objects : BHoMObject
    {
        
        public bool ShouldSerializeZoneHVAC_Baseboard_RadiantConvective_Water_Design_List()
        {
            return (ZoneHVAC_Baseboard_RadiantConvective_Water_Design_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Water:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water_Design> ZoneHVAC_Baseboard_RadiantConvective_Water_Design_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water_Design> ();
        
        public bool ShouldSerializeZoneHVAC_Baseboard_RadiantConvective_Water_List()
        {
            return (ZoneHVAC_Baseboard_RadiantConvective_Water_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water> ZoneHVAC_Baseboard_RadiantConvective_Water_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Water> ();
        
        public bool ShouldSerializeZoneHVAC_Baseboard_RadiantConvective_Steam_Design_List()
        {
            return (ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Steam:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam_Design> ZoneHVAC_Baseboard_RadiantConvective_Steam_Design_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam_Design> ();
        
        public bool ShouldSerializeZoneHVAC_Baseboard_RadiantConvective_Steam_List()
        {
            return (ZoneHVAC_Baseboard_RadiantConvective_Steam_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam> ZoneHVAC_Baseboard_RadiantConvective_Steam_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Steam> ();
        
        public bool ShouldSerializeZoneHVAC_Baseboard_RadiantConvective_Electric_List()
        {
            return (ZoneHVAC_Baseboard_RadiantConvective_Electric_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:RadiantConvective:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Electric> ZoneHVAC_Baseboard_RadiantConvective_Electric_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_RadiantConvective_Electric> ();
        
        public bool ShouldSerializeZoneHVAC_CoolingPanel_RadiantConvective_Water_List()
        {
            return (ZoneHVAC_CoolingPanel_RadiantConvective_Water_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:CoolingPanel:RadiantConvective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_CoolingPanel_RadiantConvective_Water> ZoneHVAC_CoolingPanel_RadiantConvective_Water_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_CoolingPanel_RadiantConvective_Water> ();
        
        public bool ShouldSerializeZoneHVAC_Baseboard_Convective_Water_List()
        {
            return (ZoneHVAC_Baseboard_Convective_Water_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:Convective:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Water> ZoneHVAC_Baseboard_Convective_Water_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Water> ();
        
        public bool ShouldSerializeZoneHVAC_Baseboard_Convective_Electric_List()
        {
            return (ZoneHVAC_Baseboard_Convective_Electric_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:Baseboard:Convective:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Electric> ZoneHVAC_Baseboard_Convective_Electric_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_Baseboard_Convective_Electric> ();
        
        public bool ShouldSerializeZoneHVAC_LowTemperatureRadiant_VariableFlow_List()
        {
            return (ZoneHVAC_LowTemperatureRadiant_VariableFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:VariableFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow> ZoneHVAC_LowTemperatureRadiant_VariableFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow> ();
        
        public bool ShouldSerializeZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_List()
        {
            return (ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:VariableFlow:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design> ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_VariableFlow_Design> ();
        
        public bool ShouldSerializeZoneHVAC_LowTemperatureRadiant_ConstantFlow_List()
        {
            return (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:ConstantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow> ZoneHVAC_LowTemperatureRadiant_ConstantFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow> ();
        
        public bool ShouldSerializeZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_List()
        {
            return (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:ConstantFlow:Design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design> ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design> ();
        
        public bool ShouldSerializeZoneHVAC_LowTemperatureRadiant_Electric_List()
        {
            return (ZoneHVAC_LowTemperatureRadiant_Electric_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_Electric> ZoneHVAC_LowTemperatureRadiant_Electric_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_Electric> ();
        
        public bool ShouldSerializeZoneHVAC_LowTemperatureRadiant_SurfaceGroup_List()
        {
            return (ZoneHVAC_LowTemperatureRadiant_SurfaceGroup_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:LowTemperatureRadiant:SurfaceGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_SurfaceGroup> ZoneHVAC_LowTemperatureRadiant_SurfaceGroup_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_LowTemperatureRadiant_SurfaceGroup> ();
        
        public bool ShouldSerializeZoneHVAC_HighTemperatureRadiant_List()
        {
            return (ZoneHVAC_HighTemperatureRadiant_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:HighTemperatureRadiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_HighTemperatureRadiant> ZoneHVAC_HighTemperatureRadiant_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_HighTemperatureRadiant> ();
        
        public bool ShouldSerializeZoneHVAC_VentilatedSlab_List()
        {
            return (ZoneHVAC_VentilatedSlab_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:VentilatedSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab> ZoneHVAC_VentilatedSlab_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab> ();
        
        public bool ShouldSerializeZoneHVAC_VentilatedSlab_SlabGroup_List()
        {
            return (ZoneHVAC_VentilatedSlab_SlabGroup_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneHVAC:VentilatedSlab:SlabGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab_SlabGroup> ZoneHVAC_VentilatedSlab_SlabGroup_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_VentilatedSlab_SlabGroup> ();
    }
}