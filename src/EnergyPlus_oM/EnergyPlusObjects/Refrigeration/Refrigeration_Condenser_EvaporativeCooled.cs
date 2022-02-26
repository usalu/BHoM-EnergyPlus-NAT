using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Evaporative-cooled condenser for a refrigeration system (Refrigeration:System).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Condenser_EvaporativeCooled : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Rating as per ARI 490 Be sure the rating corresponds to the correct refrigerant")]
        [JsonProperty(PropertyName="rated_effective_total_heat_rejection_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedEffectiveTotalHeatRejectionRate { get; set; } = null;
        

        [Description("must correspond to rating given for total heat rejection effect")]
        [JsonProperty(PropertyName="rated_subcooling_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedSubcoolingTemperatureDifference { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fan_speed_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType FanSpeedControlType { get; set; } = (Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType)Enum.Parse(typeof(Refrigeration_Condenser_EvaporativeCooled_FanSpeedControlType), "Fixed");
        

        [Description("Power for condenser fan(s) corresponding to rated total heat rejection effect.")]
        [JsonProperty(PropertyName="rated_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedFanPower { get; set; } = null;
        

        [Description("Minimum air flow fraction through condenser fan")]
        [JsonProperty(PropertyName="minimum_fan_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumFanAirFlowRatio { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("A1 in delta T = A1 + A2(hrcf) + A3/(hrcf) + A4(Twb)")]
        [JsonProperty(PropertyName="approach_temperature_constant_term", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ApproachTemperatureConstantTerm { get; set; } = Double.Parse("6.63", CultureInfo.InvariantCulture);
        

        [Description("A2 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
        [JsonProperty(PropertyName="approach_temperature_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ApproachTemperatureCoefficient2 { get; set; } = Double.Parse("0.468", CultureInfo.InvariantCulture);
        

        [Description("A3 in delta T = A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
        [JsonProperty(PropertyName="approach_temperature_coefficient_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ApproachTemperatureCoefficient3 { get; set; } = Double.Parse("17.93", CultureInfo.InvariantCulture);
        

        [Description("A4 in deltaT=A1 + A2(hrcf) +A3/(hrcf) +A4(Twb)")]
        [JsonProperty(PropertyName="approach_temperature_coefficient_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ApproachTemperatureCoefficient4 { get; set; } = Double.Parse("-0.322", CultureInfo.InvariantCulture);
        

        [Description("taken from manufacturer\'s Heat Rejection Capacity Factor Table")]
        [JsonProperty(PropertyName="minimum_capacity_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCapacityFactor { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("taken from manufacturer\'s Heat Rejection Capacity Factor Table")]
        [JsonProperty(PropertyName="maximum_capacity_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCapacityFactor { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("If field is left blank, then the model assumes that the inlet air conditions are " +
                     "the outdoor air conditions for the current timestep (e.g., no adjustment for hei" +
                     "ght above ground).")]
        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Used to calculate evaporative condenser water use and fan energy use.")]
        [JsonProperty(PropertyName="rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for periods when the evap condenser is available (field Evaporative Condenser Availability Schedule). For this situation, the heater heats the basin water when the outdoor air dry-bulb temperature falls below the set point temperature, but only when the condenser fans are off (i.e., no refrigerated case load).")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("200", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Design recirculating water pump power.")]
        [JsonProperty(PropertyName="rated_water_pump_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> RatedWaterPumpPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If blank, water supply is from Mains.")]
        [JsonProperty(PropertyName="evaporative_water_supply_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeWaterSupplyTankName { get; set; } = "";
        

        [Description(@"Schedule values greater than 0 indicate that evaporative cooling of the condenser is available. This schedule allows the user to define seasonal shutdown/draining of the water cooling system in cold climate applications. For periods with schedule values of 0, the condenser operates as Air Cooled.")]
        [JsonProperty(PropertyName="evaporative_condenser_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeCondenserAvailabilityScheduleName { get; set; } = "";
        

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