using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Used to define the gap between two layers in a complex fenestration system, where the Construction:ComplexFenestrationState object is used. It is referenced as a layer in the Construction:ComplexFenestrationState object. It cannot be referenced as a layer from the Construction object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gap : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = null;
        

        [Description("This field should reference only WindowMaterial:Gas or WindowMaterial:GasMixture " +
                     "objects")]
        [JsonProperty(PropertyName="gas_or_gas_mixture_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GasOrGasMixture { get; set; } = "";
        

        [JsonProperty(PropertyName="pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Pressure { get; set; } = Double.Parse("101325", CultureInfo.InvariantCulture);
        

        [Description("If left blank, it will be considered that gap is not deflected")]
        [JsonProperty(PropertyName="deflection_state", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeflectionState { get; set; } = "";
        

        [Description("If left blank, it will be considered that gap does not have support pillars")]
        [JsonProperty(PropertyName="support_pillar", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupportPillar { get; set; } = "";
    }
}