using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description(@"Used only if Wind Pressure Coefficient (WPC) Type = Input in the AirflowNetwork:SimulationControl object. Number of WPC Values in the corresponding AirflowNetwork:MultiZone:WindPressureCoefficientValues object must be the same as the number of wind directions specified for this AirflowNetwork:MultiZone:WindPressureCoefficientArray object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_WindPressureCoefficientArray : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the wind direction corresponding to the 1st WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection1 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 2nd WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection2 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 3rd WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection3 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 4th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection4 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 5th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection5 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 6th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection6 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 7th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection7 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 8th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection8 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 9th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection9 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 10th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection10 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 11th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection11 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 12th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection12 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 13th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection13 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 14th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection14 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 15th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection15 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 16th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection16 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 17th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection17 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 18th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection18 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 19th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection19 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 20th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection20 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 21st WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection21 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 22nd WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection22 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 23rd WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection23 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 24th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection24 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 25th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection25 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 26th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_26", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection26 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 27th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_27", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection27 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 28th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_28", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection28 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 29th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_29", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection29 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 30th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_30", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection30 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 31st WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_31", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection31 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 32nd WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_32", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection32 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 33rd WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_33", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection33 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 34th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_34", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection34 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 35th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_35", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection35 { get; set; } = null;
        

        [Description("Enter the wind direction corresponding to the 36th WPC Array value.")]
        [JsonProperty(PropertyName="wind_direction_36", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindDirection36 { get; set; } = null;
    }
}