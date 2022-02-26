using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Start with outside layer and work your way to the inside Layer Up to 11 layers to" +
                 "tal. Up to six solid layers and up to five gaps. Enter the material name for eac" +
                 "h layer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_WindowEquivalentLayer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outside_layer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideLayer { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer2 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer3 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer4 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer5 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer6 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer7 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer8 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer9 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer10 { get; set; } = "";
        

        [JsonProperty(PropertyName="layer_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer11 { get; set; } = "";
    }
}