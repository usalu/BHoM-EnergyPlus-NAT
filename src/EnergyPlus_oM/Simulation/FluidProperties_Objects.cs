using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Fluid Properties")]
    public class FluidProperties_Objects : BHoMObject
    {
        
        public bool ShouldSerializeFluidProperties_Name_List()
        {
            return (FluidProperties_Name_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidProperties:Name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Name> FluidProperties_Name_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Name> ();
        
        public bool ShouldSerializeFluidProperties_GlycolConcentration_List()
        {
            return (FluidProperties_GlycolConcentration_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidProperties:GlycolConcentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_GlycolConcentration> FluidProperties_GlycolConcentration_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_GlycolConcentration> ();
        
        public bool ShouldSerializeFluidProperties_Temperatures_List()
        {
            return (FluidProperties_Temperatures_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidProperties:Temperatures", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Temperatures> FluidProperties_Temperatures_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Temperatures> ();
        
        public bool ShouldSerializeFluidProperties_Saturated_List()
        {
            return (FluidProperties_Saturated_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidProperties:Saturated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Saturated> FluidProperties_Saturated_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Saturated> ();
        
        public bool ShouldSerializeFluidProperties_Superheated_List()
        {
            return (FluidProperties_Superheated_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidProperties:Superheated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Superheated> FluidProperties_Superheated_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Superheated> ();
        
        public bool ShouldSerializeFluidProperties_Concentration_List()
        {
            return (FluidProperties_Concentration_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FluidProperties:Concentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Concentration> FluidProperties_Concentration_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.FluidProperties.FluidProperties_Concentration> ();
    }
}