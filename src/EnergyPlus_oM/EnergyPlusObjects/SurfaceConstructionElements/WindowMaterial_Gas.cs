using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Gas material properties that are used in Windows or Glass Doors")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_Gas : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="gas_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowMaterial_Gas_GasType GasType { get; set; } = (WindowMaterial_Gas_GasType)Enum.Parse(typeof(WindowMaterial_Gas_GasType), "Air");
        

        [JsonProperty(PropertyName="thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Thickness { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="conductivity_coefficient_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConductivityCoefficientA { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="conductivity_coefficient_b", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConductivityCoefficientB { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="conductivity_coefficient_c", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConductivityCoefficientC { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="viscosity_coefficient_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ViscosityCoefficientA { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="viscosity_coefficient_b", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ViscosityCoefficientB { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="viscosity_coefficient_c", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ViscosityCoefficientC { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="specific_heat_coefficient_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatCoefficientA { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="specific_heat_coefficient_b", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatCoefficientB { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="specific_heat_coefficient_c", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatCoefficientC { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="molecular_weight", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MolecularWeight { get; set; } = null;
        

        [Description("Used only if Gas Type = Custom")]
        [JsonProperty(PropertyName="specific_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatRatio { get; set; } = null;
    }
}