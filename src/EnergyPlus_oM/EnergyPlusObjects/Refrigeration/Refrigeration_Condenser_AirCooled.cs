using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Air cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Condenser_AirCooled : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Rating as per ARI 460 Be sure the rating corresponds to the correct refrigerant H" +
                     "eatRejection(W)=C1 +C2(Condensing Temp - Entering Air Temp, deg C) Will be adjus" +
                     "ted for elevation automatically")]
        [JsonProperty(PropertyName="rated_effective_total_heat_rejection_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatedEffectiveTotalHeatRejectionRateCurveName { get; set; } = "";
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty(PropertyName="rated_subcooling_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedSubcoolingTemperatureDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condenser_fan_speed_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType CondenserFanSpeedControlType { get; set; } = (Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType)Enum.Parse(typeof(Refrigeration_Condenser_AirCooled_CondenserFanSpeedControlType), "Fixed");
        

        [Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
        [JsonProperty(PropertyName="rated_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedFanPower { get; set; } = Double.Parse("250", CultureInfo.InvariantCulture);
        

        [Description("Minimum air flow fraction through condenser fan")]
        [JsonProperty(PropertyName="minimum_fan_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumFanAirFlowRatio { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description(@"If field is left blank, then the model assumes that the inlet air conditions are the outdoor air conditions for the current timestep (e.g., no adjustment for height above ground). If the condenser rejects heat to a conditioned zone, enter the zone name here.")]
        [JsonProperty(PropertyName="air_inlet_node_name_or_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeNameOrZoneName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [Description("optional input")]
        [JsonProperty(PropertyName="condenser_refrigerant_operating_charge_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondenserRefrigerantOperatingChargeInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty(PropertyName="condensate_receiver_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondensateReceiverRefrigerantInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty(PropertyName="condensate_piping_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondensatePipingRefrigerantInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}