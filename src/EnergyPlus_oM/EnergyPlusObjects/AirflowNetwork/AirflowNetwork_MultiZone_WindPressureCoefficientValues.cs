using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description(@"Used only if Wind Pressure Coefficient (WPC) Type = INPUT in the AirflowNetwork:SimulationControl object. The number of WPC numeric inputs must correspond to the number of wind direction inputs in the AirflowNetwork:Multizone:WindPressureCoefficientArray object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_WindPressureCoefficientValues : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of the AirflowNetwork:Multizone:WindPressureCoefficientArray objec" +
                     "t.")]
        [JsonProperty(PropertyName="airflownetwork_multizone_windpressurecoefficientarray_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirflownetworkMultizoneWindpressurecoefficientarrayName { get; set; } = "";
        

        [Description("Enter the WPC Value corresponding to the 1st wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue1 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 2nd wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue2 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 3rd wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue3 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 4th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue4 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 5th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue5 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 6th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue6 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 7th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue7 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 8th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue8 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 9th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue9 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 10th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue10 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 11th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue11 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 12th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue12 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 13th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue13 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 14th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue14 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 15th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue15 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 16th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue16 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 17th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue17 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 18th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue18 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 19th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue19 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 20th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue20 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 21st wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue21 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 22nd wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue22 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 23rd wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue23 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 24th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue24 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 25th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue25 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 26th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_26", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue26 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 27th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_27", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue27 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 28th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_28", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue28 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 29th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_29", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue29 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 30th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_30", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue30 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 31st wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_31", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue31 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 32nd wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_32", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue32 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 33rd wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_33", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue33 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 34th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_34", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue34 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 35th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_35", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue35 { get; set; } = null;
        

        [Description("Enter the WPC Value corresponding to the 36th wind direction.")]
        [JsonProperty(PropertyName="wind_pressure_coefficient_value_36", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindPressureCoefficientValue36 { get; set; } = null;
    }
}