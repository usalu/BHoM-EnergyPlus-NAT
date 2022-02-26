using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description("Used for harvesting rainwater falling on building surfaces. The rainwater is sent" +
                 " to a WaterUse:Storage object. In order to use this object it is necessary to al" +
                 "so include a Site:Precipitation object to describe the rates of rainfall.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_RainCollector : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="loss_factor_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_RainCollector_LossFactorMode LossFactorMode { get; set; } = (WaterUse_RainCollector_LossFactorMode)Enum.Parse(typeof(WaterUse_RainCollector_LossFactorMode), "Constant");
        

        [Description("this is the portion of rain that is lost in the process of collecting it the rain" +
                     " collected is one minus this factor")]
        [JsonProperty(PropertyName="collection_loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CollectionLossFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="collection_loss_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CollectionLossFactorScheduleName { get; set; } = "";
        

        [Description("Defaults to unlimited flow.")]
        [JsonProperty(PropertyName="maximum_collection_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCollectionRate { get; set; } = null;
        

        [Description("This list is the AllShadingAndHTSurfNames object-list")]
        [JsonProperty(PropertyName="surfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Surfaces { get; set; } = null;
    }
}