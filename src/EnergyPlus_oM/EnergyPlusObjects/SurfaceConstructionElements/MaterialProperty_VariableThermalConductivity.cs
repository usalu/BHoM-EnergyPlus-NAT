using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Additional properties for temperature dependent thermal conductivity using piecewise linear temperature-conductivity function. HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_VariableThermalConductivity : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature1 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 1")]
        [JsonProperty(PropertyName="thermal_conductivity_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity1 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature2 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 2")]
        [JsonProperty(PropertyName="thermal_conductivity_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity2 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature3 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 3")]
        [JsonProperty(PropertyName="thermal_conductivity_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity3 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature4 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 4")]
        [JsonProperty(PropertyName="thermal_conductivity_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity4 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature5 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 5")]
        [JsonProperty(PropertyName="thermal_conductivity_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity5 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature6 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 6")]
        [JsonProperty(PropertyName="thermal_conductivity_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity6 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature7 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 7")]
        [JsonProperty(PropertyName="thermal_conductivity_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity7 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature8 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 8")]
        [JsonProperty(PropertyName="thermal_conductivity_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity8 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature9 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 9")]
        [JsonProperty(PropertyName="thermal_conductivity_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity9 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function")]
        [JsonProperty(PropertyName="temperature_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature10 { get; set; } = null;
        

        [Description("for Temperature-Thermal Conductivity function corresponding to temperature 10")]
        [JsonProperty(PropertyName="thermal_conductivity_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity10 { get; set; } = null;
    }
}