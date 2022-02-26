using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.NodeBranchManagement
{
    [Description("only two connectors allowed per loop if two entered, one must be Connector:Splitt" +
                 "er and one must be Connector:Mixer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ConnectorList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="connector_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConnectorList_Connector1ObjectType Connector1ObjectType { get; set; } = (ConnectorList_Connector1ObjectType)Enum.Parse(typeof(ConnectorList_Connector1ObjectType), "ConnectorMixer");
        

        [JsonProperty(PropertyName="connector_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Connector1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="connector_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConnectorList_Connector2ObjectType Connector2ObjectType { get; set; } = (ConnectorList_Connector2ObjectType)Enum.Parse(typeof(ConnectorList_Connector2ObjectType), "ConnectorMixer");
        

        [JsonProperty(PropertyName="connector_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Connector2Name { get; set; } = "";
    }
}