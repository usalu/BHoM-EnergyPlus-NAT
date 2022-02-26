using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Economics")]
    public class Economics_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="CurrencyType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Economics.CurrencyType CurrencyType { get; set; } = null;
        
        public bool ShouldSerializeComponentCost_Adjustments_List()
        {
            return (ComponentCost_Adjustments_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ComponentCost:Adjustments", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Adjustments> ComponentCost_Adjustments_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Adjustments> ();
        
        public bool ShouldSerializeComponentCost_Reference_List()
        {
            return (ComponentCost_Reference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ComponentCost:Reference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Reference> ComponentCost_Reference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_Reference> ();
        
        public bool ShouldSerializeComponentCost_LineItem_List()
        {
            return (ComponentCost_LineItem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ComponentCost:LineItem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_LineItem> ComponentCost_LineItem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.ComponentCost_LineItem> ();
        
        public bool ShouldSerializeUtilityCost_Tariff_List()
        {
            return (UtilityCost_Tariff_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Tariff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Tariff> UtilityCost_Tariff_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Tariff> ();
        
        public bool ShouldSerializeUtilityCost_Qualify_List()
        {
            return (UtilityCost_Qualify_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Qualify", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Qualify> UtilityCost_Qualify_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Qualify> ();
        
        public bool ShouldSerializeUtilityCost_Charge_Simple_List()
        {
            return (UtilityCost_Charge_Simple_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Charge:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Simple> UtilityCost_Charge_Simple_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Simple> ();
        
        public bool ShouldSerializeUtilityCost_Charge_Block_List()
        {
            return (UtilityCost_Charge_Block_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Charge:Block", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Block> UtilityCost_Charge_Block_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Charge_Block> ();
        
        public bool ShouldSerializeUtilityCost_Ratchet_List()
        {
            return (UtilityCost_Ratchet_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Ratchet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Ratchet> UtilityCost_Ratchet_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Ratchet> ();
        
        public bool ShouldSerializeUtilityCost_Variable_List()
        {
            return (UtilityCost_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Variable> UtilityCost_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Variable> ();
        
        public bool ShouldSerializeUtilityCost_Computation_List()
        {
            return (UtilityCost_Computation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="UtilityCost:Computation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Computation> UtilityCost_Computation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.UtilityCost_Computation> ();
        

        [JsonProperty(PropertyName="LifeCycleCost:Parameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_Parameters LifeCycleCost_Parameters { get; set; } = null;
        
        public bool ShouldSerializeLifeCycleCost_RecurringCosts_List()
        {
            return (LifeCycleCost_RecurringCosts_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="LifeCycleCost:RecurringCosts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_RecurringCosts> LifeCycleCost_RecurringCosts_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_RecurringCosts> ();
        
        public bool ShouldSerializeLifeCycleCost_NonrecurringCost_List()
        {
            return (LifeCycleCost_NonrecurringCost_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="LifeCycleCost:NonrecurringCost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_NonrecurringCost> LifeCycleCost_NonrecurringCost_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_NonrecurringCost> ();
        
        public bool ShouldSerializeLifeCycleCost_UsePriceEscalation_List()
        {
            return (LifeCycleCost_UsePriceEscalation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="LifeCycleCost:UsePriceEscalation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UsePriceEscalation> LifeCycleCost_UsePriceEscalation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UsePriceEscalation> ();
        
        public bool ShouldSerializeLifeCycleCost_UseAdjustment_List()
        {
            return (LifeCycleCost_UseAdjustment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="LifeCycleCost:UseAdjustment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UseAdjustment> LifeCycleCost_UseAdjustment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Economics.LifeCycleCost_UseAdjustment> ();
    }
}