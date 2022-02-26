using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Detailed Ground Heat Transfer")]
    public class DetailedGroundHeatTransfer_Objects : BHoMObject
    {
        
        public bool ShouldSerializeGroundHeatTransfer_Control_List()
        {
            return (GroundHeatTransfer_Control_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Control> GroundHeatTransfer_Control_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Control> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_Materials_List()
        {
            return (GroundHeatTransfer_Slab_Materials_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:Materials", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Materials> GroundHeatTransfer_Slab_Materials_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Materials> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_MatlProps_List()
        {
            return (GroundHeatTransfer_Slab_MatlProps_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:MatlProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_MatlProps> GroundHeatTransfer_Slab_MatlProps_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_MatlProps> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_BoundConds_List()
        {
            return (GroundHeatTransfer_Slab_BoundConds_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:BoundConds", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BoundConds> GroundHeatTransfer_Slab_BoundConds_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BoundConds> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_BldgProps_List()
        {
            return (GroundHeatTransfer_Slab_BldgProps_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:BldgProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BldgProps> GroundHeatTransfer_Slab_BldgProps_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_BldgProps> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_Insulation_List()
        {
            return (GroundHeatTransfer_Slab_Insulation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:Insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Insulation> GroundHeatTransfer_Slab_Insulation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_Insulation> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_EquivalentSlab_List()
        {
            return (GroundHeatTransfer_Slab_EquivalentSlab_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:EquivalentSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_EquivalentSlab> GroundHeatTransfer_Slab_EquivalentSlab_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_EquivalentSlab> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_AutoGrid_List()
        {
            return (GroundHeatTransfer_Slab_AutoGrid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:AutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_AutoGrid> GroundHeatTransfer_Slab_AutoGrid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_AutoGrid> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_ManualGrid_List()
        {
            return (GroundHeatTransfer_Slab_ManualGrid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:ManualGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ManualGrid> GroundHeatTransfer_Slab_ManualGrid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ManualGrid> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_XFACE_List()
        {
            return (GroundHeatTransfer_Slab_XFACE_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:XFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_XFACE> GroundHeatTransfer_Slab_XFACE_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_XFACE> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_YFACE_List()
        {
            return (GroundHeatTransfer_Slab_YFACE_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:YFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_YFACE> GroundHeatTransfer_Slab_YFACE_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_YFACE> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Slab_ZFACE_List()
        {
            return (GroundHeatTransfer_Slab_ZFACE_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Slab:ZFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ZFACE> GroundHeatTransfer_Slab_ZFACE_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Slab_ZFACE> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_SimParameters_List()
        {
            return (GroundHeatTransfer_Basement_SimParameters_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:SimParameters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SimParameters> GroundHeatTransfer_Basement_SimParameters_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SimParameters> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_MatlProps_List()
        {
            return (GroundHeatTransfer_Basement_MatlProps_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:MatlProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_MatlProps> GroundHeatTransfer_Basement_MatlProps_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_MatlProps> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_Insulation_List()
        {
            return (GroundHeatTransfer_Basement_Insulation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:Insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Insulation> GroundHeatTransfer_Basement_Insulation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Insulation> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_SurfaceProps_List()
        {
            return (GroundHeatTransfer_Basement_SurfaceProps_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:SurfaceProps", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SurfaceProps> GroundHeatTransfer_Basement_SurfaceProps_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_SurfaceProps> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_BldgData_List()
        {
            return (GroundHeatTransfer_Basement_BldgData_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:BldgData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_BldgData> GroundHeatTransfer_Basement_BldgData_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_BldgData> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_Interior_List()
        {
            return (GroundHeatTransfer_Basement_Interior_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:Interior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Interior> GroundHeatTransfer_Basement_Interior_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_Interior> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_ComBldg_List()
        {
            return (GroundHeatTransfer_Basement_ComBldg_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:ComBldg", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ComBldg> GroundHeatTransfer_Basement_ComBldg_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ComBldg> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_EquivSlab_List()
        {
            return (GroundHeatTransfer_Basement_EquivSlab_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:EquivSlab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivSlab> GroundHeatTransfer_Basement_EquivSlab_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivSlab> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_EquivAutoGrid_List()
        {
            return (GroundHeatTransfer_Basement_EquivAutoGrid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:EquivAutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivAutoGrid> GroundHeatTransfer_Basement_EquivAutoGrid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_EquivAutoGrid> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_AutoGrid_List()
        {
            return (GroundHeatTransfer_Basement_AutoGrid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:AutoGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_AutoGrid> GroundHeatTransfer_Basement_AutoGrid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_AutoGrid> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_ManualGrid_List()
        {
            return (GroundHeatTransfer_Basement_ManualGrid_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:ManualGrid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ManualGrid> GroundHeatTransfer_Basement_ManualGrid_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ManualGrid> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_XFACE_List()
        {
            return (GroundHeatTransfer_Basement_XFACE_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:XFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_XFACE> GroundHeatTransfer_Basement_XFACE_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_XFACE> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_YFACE_List()
        {
            return (GroundHeatTransfer_Basement_YFACE_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:YFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_YFACE> GroundHeatTransfer_Basement_YFACE_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_YFACE> ();
        
        public bool ShouldSerializeGroundHeatTransfer_Basement_ZFACE_List()
        {
            return (GroundHeatTransfer_Basement_ZFACE_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GroundHeatTransfer:Basement:ZFACE", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ZFACE> GroundHeatTransfer_Basement_ZFACE_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer.GroundHeatTransfer_Basement_ZFACE> ();
    }
}