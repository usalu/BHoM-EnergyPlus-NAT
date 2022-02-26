using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.RoomAirModels
{
    [Description("Define an air node for some types of nodal room air models")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoomAir_Node : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="node_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoomAir_Node_NodeType NodeType { get; set; } = (RoomAir_Node_NodeType)Enum.Parse(typeof(RoomAir_Node_NodeType), "Ceiling");
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="height_of_nodal_control_volume_center", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightOfNodalControlVolumeCenter { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface9Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface10Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_11_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface11Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_12_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface12Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_13_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface13Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_14_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface14Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_15_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface15Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_16_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface16Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_17_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface17Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_18_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface18Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_19_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface19Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_20_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface20Name { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_21_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Surface21Name { get; set; } = "";
    }
}