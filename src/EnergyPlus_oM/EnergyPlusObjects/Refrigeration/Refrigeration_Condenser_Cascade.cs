using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Cascade condenser for a refrigeration system (Refrigeration:System). The cascade condenser is unlike the other condenser options because it rejects heat to another, higher-temperature, refrigeration system. That is, the cascade condenser acts as a heat rejection object for one system, but acts as a refrigeration load for another system.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Condenser_Cascade : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This is the condensing temperature for the lower temperature secondary loop")]
        [JsonProperty(PropertyName="rated_condensing_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCondensingTemperature { get; set; } = null;
        

        [Description("This is the difference between the condensing and evaporating temperatures")]
        [JsonProperty(PropertyName="rated_approach_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedApproachTemperatureDifference { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("used for identification and rough system size error checking")]
        [JsonProperty(PropertyName="rated_effective_total_heat_rejection_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

        [Description("Fixed keeps condensing temperature constant Float sets the condensing temperature" +
                     " according to the other loads on the higher temperature system")]
        [JsonProperty(PropertyName="condensing_temperature_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Condenser_Cascade_CondensingTemperatureControlType CondensingTemperatureControlType { get; set; } = (Refrigeration_Condenser_Cascade_CondensingTemperatureControlType)Enum.Parse(typeof(Refrigeration_Condenser_Cascade_CondensingTemperatureControlType), "Fixed");
        

        [Description("optional input")]
        [JsonProperty(PropertyName="condenser_refrigerant_operating_charge_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondenserRefrigerantOperatingChargeInventory { get; set; } = null;
        

        [Description("optional input")]
        [JsonProperty(PropertyName="condensate_receiver_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondensateReceiverRefrigerantInventory { get; set; } = null;
        

        [Description("optional input")]
        [JsonProperty(PropertyName="condensate_piping_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondensatePipingRefrigerantInventory { get; set; } = null;
    }
}