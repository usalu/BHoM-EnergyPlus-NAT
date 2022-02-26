using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: AirflowNetwork")]
    public class AirflowNetwork_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="AirflowNetwork:SimulationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_SimulationControl AirflowNetwork_SimulationControl { get; set; } = null;
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Zone_List()
        {
            return (AirflowNetwork_MultiZone_Zone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Zone> AirflowNetwork_MultiZone_Zone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Zone> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Surface_List()
        {
            return (AirflowNetwork_MultiZone_Surface_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface> AirflowNetwork_MultiZone_Surface_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_ReferenceCrackConditions_List()
        {
            return (AirflowNetwork_MultiZone_ReferenceCrackConditions_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:ReferenceCrackConditions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ReferenceCrackConditions> AirflowNetwork_MultiZone_ReferenceCrackConditions_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ReferenceCrackConditions> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Surface_Crack_List()
        {
            return (AirflowNetwork_MultiZone_Surface_Crack_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Surface:Crack", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_Crack> AirflowNetwork_MultiZone_Surface_Crack_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_Crack> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Surface_EffectiveLeakageArea_List()
        {
            return (AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea> AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Surface_EffectiveLeakageArea> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Component_DetailedOpening_List()
        {
            return (AirflowNetwork_MultiZone_Component_DetailedOpening_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:DetailedOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_DetailedOpening> AirflowNetwork_MultiZone_Component_DetailedOpening_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_DetailedOpening> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Component_SimpleOpening_List()
        {
            return (AirflowNetwork_MultiZone_Component_SimpleOpening_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:SimpleOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_SimpleOpening> AirflowNetwork_MultiZone_Component_SimpleOpening_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_SimpleOpening> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Component_HorizontalOpening_List()
        {
            return (AirflowNetwork_MultiZone_Component_HorizontalOpening_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:HorizontalOpening", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_HorizontalOpening> AirflowNetwork_MultiZone_Component_HorizontalOpening_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_HorizontalOpening> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_Component_ZoneExhaustFan_List()
        {
            return (AirflowNetwork_MultiZone_Component_ZoneExhaustFan_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:Component:ZoneExhaustFan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_ZoneExhaustFan> AirflowNetwork_MultiZone_Component_ZoneExhaustFan_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_Component_ZoneExhaustFan> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_ExternalNode_List()
        {
            return (AirflowNetwork_MultiZone_ExternalNode_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:ExternalNode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ExternalNode> AirflowNetwork_MultiZone_ExternalNode_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_ExternalNode> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_WindPressureCoefficientArray_List()
        {
            return (AirflowNetwork_MultiZone_WindPressureCoefficientArray_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:WindPressureCoefficientArray", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientArray> AirflowNetwork_MultiZone_WindPressureCoefficientArray_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientArray> ();
        
        public bool ShouldSerializeAirflowNetwork_MultiZone_WindPressureCoefficientValues_List()
        {
            return (AirflowNetwork_MultiZone_WindPressureCoefficientValues_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:MultiZone:WindPressureCoefficientValues", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientValues> AirflowNetwork_MultiZone_WindPressureCoefficientValues_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_MultiZone_WindPressureCoefficientValues> ();
        

        [JsonProperty(PropertyName="AirflowNetwork:ZoneControl:PressureController", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_ZoneControl_PressureController AirflowNetwork_ZoneControl_PressureController { get; set; } = null;
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Node_List()
        {
            return (AirflowNetwork_Distribution_Node_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Node> AirflowNetwork_Distribution_Node_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Node> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_Leak_List()
        {
            return (AirflowNetwork_Distribution_Component_Leak_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Leak", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Leak> AirflowNetwork_Distribution_Component_Leak_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Leak> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_LeakageRatio_List()
        {
            return (AirflowNetwork_Distribution_Component_LeakageRatio_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:LeakageRatio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_LeakageRatio> AirflowNetwork_Distribution_Component_LeakageRatio_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_LeakageRatio> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_Duct_List()
        {
            return (AirflowNetwork_Distribution_Component_Duct_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Duct", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Duct> AirflowNetwork_Distribution_Component_Duct_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Duct> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_Fan_List()
        {
            return (AirflowNetwork_Distribution_Component_Fan_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Fan", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Fan> AirflowNetwork_Distribution_Component_Fan_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Fan> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_Coil_List()
        {
            return (AirflowNetwork_Distribution_Component_Coil_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:Coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Coil> AirflowNetwork_Distribution_Component_Coil_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_Coil> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_HeatExchanger_List()
        {
            return (AirflowNetwork_Distribution_Component_HeatExchanger_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:HeatExchanger", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_HeatExchanger> AirflowNetwork_Distribution_Component_HeatExchanger_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_HeatExchanger> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_TerminalUnit_List()
        {
            return (AirflowNetwork_Distribution_Component_TerminalUnit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:TerminalUnit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_TerminalUnit> AirflowNetwork_Distribution_Component_TerminalUnit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_TerminalUnit> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_ConstantPressureDrop_List()
        {
            return (AirflowNetwork_Distribution_Component_ConstantPressureDrop_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:ConstantPressureDrop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ConstantPressureDrop> AirflowNetwork_Distribution_Component_ConstantPressureDrop_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ConstantPressureDrop> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_OutdoorAirFlow_List()
        {
            return (AirflowNetwork_Distribution_Component_OutdoorAirFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:OutdoorAirFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_OutdoorAirFlow> AirflowNetwork_Distribution_Component_OutdoorAirFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_OutdoorAirFlow> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Component_ReliefAirFlow_List()
        {
            return (AirflowNetwork_Distribution_Component_ReliefAirFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Component:ReliefAirFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ReliefAirFlow> AirflowNetwork_Distribution_Component_ReliefAirFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Component_ReliefAirFlow> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_Linkage_List()
        {
            return (AirflowNetwork_Distribution_Linkage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:Linkage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Linkage> AirflowNetwork_Distribution_Linkage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_Linkage> ();
        
        public bool ShouldSerializeAirflowNetwork_Distribution_DuctViewFactors_List()
        {
            return (AirflowNetwork_Distribution_DuctViewFactors_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:Distribution:DuctViewFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_DuctViewFactors> AirflowNetwork_Distribution_DuctViewFactors_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_DuctViewFactors> ();
        
        public bool ShouldSerializeAirflowNetwork_OccupantVentilationControl_List()
        {
            return (AirflowNetwork_OccupantVentilationControl_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:OccupantVentilationControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_OccupantVentilationControl> AirflowNetwork_OccupantVentilationControl_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_OccupantVentilationControl> ();
        
        public bool ShouldSerializeAirflowNetwork_IntraZone_Node_List()
        {
            return (AirflowNetwork_IntraZone_Node_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:IntraZone:Node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Node> AirflowNetwork_IntraZone_Node_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Node> ();
        
        public bool ShouldSerializeAirflowNetwork_IntraZone_Linkage_List()
        {
            return (AirflowNetwork_IntraZone_Linkage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="AirflowNetwork:IntraZone:Linkage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Linkage> AirflowNetwork_IntraZone_Linkage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_IntraZone_Linkage> ();
    }
}