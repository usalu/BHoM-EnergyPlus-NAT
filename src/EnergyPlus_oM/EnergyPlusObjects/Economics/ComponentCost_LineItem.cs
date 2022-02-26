using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Each instance of this object creates a cost line item and will contribute to the " +
                 "total for a cost estimate.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ComponentCost_LineItem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; } = "";
        

        [Description("extend choice-keys as Cases are added to code")]
        [JsonProperty(PropertyName="line_item_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ComponentCost_LineItem_LineItemType LineItemType { get; set; } = (ComponentCost_LineItem_LineItemType)Enum.Parse(typeof(ComponentCost_LineItem_LineItemType), "ChillerElectric");
        

        [Description("wildcard \"*\" is acceptable for some components")]
        [JsonProperty(PropertyName="item_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ItemName { get; set; } = "";
        

        [Description("not yet used")]
        [JsonProperty(PropertyName="object_end_use_key", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ObjectEndUseKey { get; set; } = "";
        

        [JsonProperty(PropertyName="cost_per_each", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerEach { get; set; } = null;
        

        [JsonProperty(PropertyName="cost_per_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerArea { get; set; } = null;
        

        [JsonProperty(PropertyName="cost_per_unit_of_output_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerUnitOfOutputCapacity { get; set; } = null;
        

        [Description("The value is per change in COP.")]
        [JsonProperty(PropertyName="cost_per_unit_of_output_capacity_per_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerUnitOfOutputCapacityPerCop { get; set; } = null;
        

        [JsonProperty(PropertyName="cost_per_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerVolume { get; set; } = null;
        

        [JsonProperty(PropertyName="cost_per_volume_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerVolumeRate { get; set; } = null;
        

        [Description("as in for use with UA sizing of Coils")]
        [JsonProperty(PropertyName="cost_per_energy_per_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CostPerEnergyPerTemperatureDifference { get; set; } = null;
        

        [Description("optional for use with Cost per Each and \"General\" object Type")]
        [JsonProperty(PropertyName="quantity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Quantity { get; set; } = null;
    }
}