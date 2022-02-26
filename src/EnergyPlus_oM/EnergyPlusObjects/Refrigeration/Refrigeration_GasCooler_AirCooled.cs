using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("The transcritical refrigeration system requires a single gas cooler to reject the" +
                 " system heat.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_GasCooler_AirCooled : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Be sure the rating corresponds to the correct refrigerant (R744) HeatRejection(W)" +
                     "=C1 +C2(Gas Cooler Outlet Temp - Entering Air Temp, deg C) Will be adjusted for " +
                     "elevation automatically")]
        [JsonProperty(PropertyName="rated_total_heat_rejection_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RatedTotalHeatRejectionRateCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="gas_cooler_fan_speed_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType GasCoolerFanSpeedControlType { get; set; } = (Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType)Enum.Parse(typeof(Refrigeration_GasCooler_AirCooled_GasCoolerFanSpeedControlType), "Fixed");
        

        [Description("Power for gas cooler fan(s) corresponding to rated total heat rejection effect.")]
        [JsonProperty(PropertyName="rated_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedFanPower { get; set; } = Double.Parse("5000", CultureInfo.InvariantCulture);
        

        [Description("Minimum air flow fraction through gas cooler fan")]
        [JsonProperty(PropertyName="minimum_fan_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumFanAirFlowRatio { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Temperature at which system transitions between subcritical and transcritical ope" +
                     "ration.")]
        [JsonProperty(PropertyName="transition_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TransitionTemperature { get; set; } = Double.Parse("27", CultureInfo.InvariantCulture);
        

        [Description("Temperature difference between the CO2 exiting the gas cooler and the air enterin" +
                     "g the gas cooler during transcritical operation.")]
        [JsonProperty(PropertyName="transcritical_approach_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TranscriticalApproachTemperature { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Temperature difference between the saturated condensing temperature and the air t" +
                     "emperature during subcritical operation.")]
        [JsonProperty(PropertyName="subcritical_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SubcriticalTemperatureDifference { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Minimum saturated condensing temperature during subcritical operation.")]
        [JsonProperty(PropertyName="minimum_condensing_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCondensingTemperature { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("If field is left blank, then the model assumes that the inlet air conditions are " +
                     "the outdoor air conditions for the current timestep (e.g., no adjustment for hei" +
                     "ght above ground).")]
        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [Description("optional input")]
        [JsonProperty(PropertyName="gas_cooler_refrigerant_operating_charge_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasCoolerRefrigerantOperatingChargeInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty(PropertyName="gas_cooler_receiver_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasCoolerReceiverRefrigerantInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("optional input")]
        [JsonProperty(PropertyName="gas_cooler_outlet_piping_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GasCoolerOutletPipingRefrigerantInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}