using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"A cooltower (sometimes referred to as a wind tower or a shower cooling tower) models passive downdraught evaporative cooling (PDEC) that is designed to capture the wind at the top of a tower and cool the outdoor air using water evaporation before delivering it to a space.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneCoolTower_Shower : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("In case of stand alone tank or underground water, leave this input blank")]
        [JsonProperty(PropertyName="water_supply_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterSupplyStorageTankName { get; set; } = "";
        

        [Description("Water flow schedule should be selected when the water flow rate is known. Wind-dr" +
                     "iven flow should be selected when the water flow rate is unknown.")]
        [JsonProperty(PropertyName="flow_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneCoolTower_Shower_FlowControlType FlowControlType { get; set; } = (ZoneCoolTower_Shower_FlowControlType)Enum.Parse(typeof(ZoneCoolTower_Shower_FlowControlType), "WindDrivenFlow");
        

        [JsonProperty(PropertyName="pump_flow_rate_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PumpFlowRateScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumWaterFlowRate { get; set; } = null;
        

        [Description("This field is from either the spray or the wet pad to the top of the outlet.")]
        [JsonProperty(PropertyName="effective_tower_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EffectiveTowerHeight { get; set; } = null;
        

        [Description("User have to specify effective area when outlet area is relatively bigger than th" +
                     "e cross sectional area of cooltower. If the number of outlet is more than one, a" +
                     "ssume the air passes through only one.")]
        [JsonProperty(PropertyName="airflow_outlet_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirflowOutletArea { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumAirFlowRate { get; set; } = null;
        

        [Description("This field is to specify the indoor temperature below which cooltower is shutoff." +
                     "")]
        [JsonProperty(PropertyName="minimum_indoor_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumIndoorTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_of_water_loss", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfWaterLoss { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_of_flow_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfFlowSchedule { get; set; } = null;
        

        [JsonProperty(PropertyName="rated_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedPowerConsumption { get; set; } = null;
    }
}