using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas mixtures that are used in Windows or Glass Doors")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_GasMixture : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_gases_in_mixture", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfGasesInMixture { get; set; } = null;
        

        [JsonProperty(PropertyName="gas_1_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas1Type Gas1Type { get; set; } = (WindowMaterial_GasMixture_Gas1Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas1Type), "Air");
        

        [JsonProperty(PropertyName="gas_1_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Gas1Fraction { get; set; } = null;
        

        [JsonProperty(PropertyName="gas_2_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas2Type Gas2Type { get; set; } = (WindowMaterial_GasMixture_Gas2Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas2Type), "Air");
        

        [JsonProperty(PropertyName="gas_2_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Gas2Fraction { get; set; } = null;
        

        [JsonProperty(PropertyName="gas_3_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas3Type Gas3Type { get; set; } = (WindowMaterial_GasMixture_Gas3Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas3Type), "Air");
        

        [JsonProperty(PropertyName="gas_3_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Gas3Fraction { get; set; } = null;
        

        [JsonProperty(PropertyName="gas_4_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_GasMixture_Gas4Type Gas4Type { get; set; } = (WindowMaterial_GasMixture_Gas4Type)Enum.Parse(typeof(WindowMaterial_GasMixture_Gas4Type), "Air");
        

        [JsonProperty(PropertyName="gas_4_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Gas4Fraction { get; set; } = null;
    }
}