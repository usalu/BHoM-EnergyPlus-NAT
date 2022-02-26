using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) HeatBalanceAlgorithm = CondFD(ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_PhaseChange : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The base temperature is 20C. This is the thermal conductivity change per degree e" +
                     "xcursion from 20C. This variable conductivity function is overridden by the Vari" +
                     "ableThermalConductivity object, if present.")]
        [JsonProperty(PropertyName="temperature_coefficient_for_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureCoefficientForThermalConductivity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature1 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 1")]
        [JsonProperty(PropertyName="enthalpy_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy1 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature2 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 2")]
        [JsonProperty(PropertyName="enthalpy_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy2 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature3 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 3")]
        [JsonProperty(PropertyName="enthalpy_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy3 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature4 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 4")]
        [JsonProperty(PropertyName="enthalpy_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy4 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature5 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 5")]
        [JsonProperty(PropertyName="enthalpy_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy5 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature6 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 6")]
        [JsonProperty(PropertyName="enthalpy_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy6 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature7 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 7")]
        [JsonProperty(PropertyName="enthalpy_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy7 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature8 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 8")]
        [JsonProperty(PropertyName="enthalpy_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy8 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature9 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 1")]
        [JsonProperty(PropertyName="enthalpy_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy9 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature10 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 2")]
        [JsonProperty(PropertyName="enthalpy_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy10 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature11 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 3")]
        [JsonProperty(PropertyName="enthalpy_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy11 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature12 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 14")]
        [JsonProperty(PropertyName="enthalpy_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy12 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature13 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 15")]
        [JsonProperty(PropertyName="enthalpy_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy13 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature14 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 16")]
        [JsonProperty(PropertyName="enthalpy_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy14 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature15 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 17")]
        [JsonProperty(PropertyName="enthalpy_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy15 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function")]
        [JsonProperty(PropertyName="temperature_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Temperature16 { get; set; } = null;
        

        [Description("for Temperature-enthalpy function corresponding to temperature 16")]
        [JsonProperty(PropertyName="enthalpy_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Enthalpy16 { get; set; } = null;
    }
}