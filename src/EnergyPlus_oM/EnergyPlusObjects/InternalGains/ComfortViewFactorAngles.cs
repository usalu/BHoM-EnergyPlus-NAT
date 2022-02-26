using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Used to specify radiant view factors for thermal comfort calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ComfortViewFactorAngles : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor1 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor2 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor3 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor4 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor5 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor6 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor7 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor8 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface9Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor9 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface10Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor10 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_11_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface11Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor11 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_12_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface12Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor12 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_13_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface13Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor13 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_14_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface14Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor14 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_15_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface15Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor15 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_16_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface16Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor16 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_17_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface17Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor17 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_18_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface18Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor18 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_19_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface19Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor19 { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_20_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface20Name { get; set; } = "";
        

        [JsonProperty(PropertyName="angle_factor_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AngleFactor20 { get; set; } = null;
    }
}