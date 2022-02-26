using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Water cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Condenser_WaterCooled : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Rating as per ARI 450 Be sure the rating corresponds to the correct refrigerant n" +
                     "ot used in calculations, only for identification and output")]
        [JsonProperty(PropertyName="rated_effective_total_heat_rejection_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty(PropertyName="rated_condensing_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCondensingTemperature { get; set; } = null;
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty(PropertyName="rated_subcooling_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedSubcoolingTemperatureDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty(PropertyName="rated_water_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedWaterInletTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_cooled_loop_flow_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType WaterCooledLoopFlowType { get; set; } = (Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType)Enum.Parse(typeof(Refrigeration_Condenser_WaterCooled_WaterCooledLoopFlowType), "VariableFlow");
        

        [Description("Applicable only when loop flow type is Variable Flow.")]
        [JsonProperty(PropertyName="water_outlet_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletTemperatureScheduleName { get; set; } = "";
        

        [Description("note required units must be converted from L/s as specified in ARI 450-2007 Appli" +
                     "cable only when loop flow type is Constant Flow.")]
        [JsonProperty(PropertyName="water_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterDesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="water_maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterMaximumFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="water_maximum_water_outlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterMaximumWaterOutletTemperature { get; set; } = Double.Parse("55", CultureInfo.InvariantCulture);
        

        [Description("related to the minimum allowed refrigeration system condensing temperature")]
        [JsonProperty(PropertyName="water_minimum_water_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterMinimumWaterInletTemperature { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

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