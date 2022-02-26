using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Daylighting")]
    public class Daylighting_Objects : BHoMObject
    {
        
        public bool ShouldSerializeDaylighting_Controls_List()
        {
            return (Daylighting_Controls_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Daylighting:Controls", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_Controls> Daylighting_Controls_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_Controls> ();
        
        public bool ShouldSerializeDaylighting_ReferencePoint_List()
        {
            return (Daylighting_ReferencePoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Daylighting:ReferencePoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_ReferencePoint> Daylighting_ReferencePoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_ReferencePoint> ();
        
        public bool ShouldSerializeDaylighting_DELight_ComplexFenestration_List()
        {
            return (Daylighting_DELight_ComplexFenestration_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Daylighting:DELight:ComplexFenestration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_DELight_ComplexFenestration> Daylighting_DELight_ComplexFenestration_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Daylighting_DELight_ComplexFenestration> ();
        
        public bool ShouldSerializeDaylightingDevice_Tubular_List()
        {
            return (DaylightingDevice_Tubular_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DaylightingDevice:Tubular", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Tubular> DaylightingDevice_Tubular_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Tubular> ();
        
        public bool ShouldSerializeDaylightingDevice_Shelf_List()
        {
            return (DaylightingDevice_Shelf_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DaylightingDevice:Shelf", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Shelf> DaylightingDevice_Shelf_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_Shelf> ();
        
        public bool ShouldSerializeDaylightingDevice_LightWell_List()
        {
            return (DaylightingDevice_LightWell_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="DaylightingDevice:LightWell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_LightWell> DaylightingDevice_LightWell_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.DaylightingDevice_LightWell> ();
        
        public bool ShouldSerializeOutput_DaylightFactors_List()
        {
            return (Output_DaylightFactors_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:DaylightFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Output_DaylightFactors> Output_DaylightFactors_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Output_DaylightFactors> ();
        
        public bool ShouldSerializeOutput_IlluminanceMap_List()
        {
            return (Output_IlluminanceMap_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:IlluminanceMap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Output_IlluminanceMap> Output_IlluminanceMap_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Daylighting.Output_IlluminanceMap> ();
        

        [JsonProperty(PropertyName="OutputControl:IlluminanceMap:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.Daylighting.OutputControl_IlluminanceMap_Style OutputControl_IlluminanceMap_Style { get; set; } = null;
    }
}