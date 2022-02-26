using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of the supply Air Fan used in an Air loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Fan : BHoMObject
    {
        

        [Description("Enter the name of the fan in the primary air loop.")]
        [JsonProperty(PropertyName="fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_Fan_SupplyFanObjectType), "Empty");
    }
}