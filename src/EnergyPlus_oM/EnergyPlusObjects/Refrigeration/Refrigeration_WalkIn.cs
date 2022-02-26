using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with a compressor rack, a refrigeration system, or a refrigeration secondary system to simulate the performance of a walk-in cooler. The walk-in cooler model uses information at rated conditions along with input descriptions for heat transfer surfaces facing multiple zones to determine performance.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_WalkIn : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="rated_coil_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCoilCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="operating_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OperatingTemperature { get; set; } = null;
        

        [Description("If DXEvaporator, use evaporating temperature (saturated suction temperature) If B" +
                     "rineCoil, use Brine entering temperature used to set minimum suction pressure fo" +
                     "r DX systems and minimum brine temp for secondary systems")]
        [JsonProperty(PropertyName="rated_cooling_source_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCoolingSourceTemperature { get; set; } = null;
        

        [Description("Include total for all anti-sweat, door, drip-pan, and floor heater power Do not i" +
                     "nclude defrost heater power")]
        [JsonProperty(PropertyName="rated_total_heating_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedTotalHeatingPower { get; set; } = null;
        

        [Description("Values will be used to multiply the total heating power Values in the schedule sh" +
                     "ould be between 0.0 and 1.0 For example, this could be used if display door anti" +
                     "sweat heaters are turned off at night Defaults to always on if schedule name lef" +
                     "t blank.")]
        [JsonProperty(PropertyName="heating_power_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingPowerScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="rated_cooling_coil_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCoolingCoilFanPower { get; set; } = Double.Parse("375", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_circulation_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCirculationFanPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the total (display + task) installed lighting power.")]
        [JsonProperty(PropertyName="rated_total_lighting_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedTotalLightingPower { get; set; } = null;
        

        [Description("The schedule should contain values between 0 and 1 Defaults to always on if sched" +
                     "ule name left blank.")]
        [JsonProperty(PropertyName="lighting_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LightingScheduleName { get; set; } = "";
        

        [Description("HotFluid includes either hot gas defrost for a DX system or Hot Brine defrost if " +
                     "this walk in is cooled by brine from a secondary chiller")]
        [JsonProperty(PropertyName="defrost_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_WalkIn_DefrostType DefrostType { get; set; } = (Refrigeration_WalkIn_DefrostType)Enum.Parse(typeof(Refrigeration_WalkIn_DefrostType), "Electric");
        

        [JsonProperty(PropertyName="defrost_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_WalkIn_DefrostControlType DefrostControlType { get; set; } = (Refrigeration_WalkIn_DefrostControlType)Enum.Parse(typeof(Refrigeration_WalkIn_DefrostControlType), "TimeSchedule");
        

        [Description("The schedule values should be 0 (off) or 1 (on)")]
        [JsonProperty(PropertyName="defrost_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefrostScheduleName { get; set; } = "";
        

        [Description(@"The schedule values should be 0 (off) or 1 (on) The start time for each defrost period in this drip-down schedule should coincide with the start time for each defrost period in the defrost schedule (previous input field). The length of each defrost drip-down period must be greater than or equal to the corresponding defrost period specified in the defrost schedule. This extra time allows the melted frost to drip from the coil before refrigeration is restarted.")]
        [JsonProperty(PropertyName="defrost_drip_down_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefrostDripDownScheduleName { get; set; } = "";
        

        [Description("needed for all defrost types except none and offcycle")]
        [JsonProperty(PropertyName="defrost_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DefrostPower { get; set; } = null;
        

        [Description("This is the portion of the defrost energy that is available to melt frost Needed " +
                     "only for defrost control type TemperatureTermination defaults to 0.7 for electri" +
                     "c defrost and to 0.3 for hot fluid defrost")]
        [JsonProperty(PropertyName="temperature_termination_defrost_fraction_to_ice", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureTerminationDefrostFractionToIce { get; set; } = null;
        

        [Description("Schedule values should be in units of Watts Leave this field blank if no restocki" +
                     "ng is to be modeled")]
        [JsonProperty(PropertyName="restocking_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RestockingScheduleName { get; set; } = "";
        

        [Description("This value is only used if the Cooling Source Type is DXEvaporator")]
        [JsonProperty(PropertyName="average_refrigerant_charge_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageRefrigerantChargeInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("floor area of walk-in cooler")]
        [JsonProperty(PropertyName="insulated_floor_surface_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsulatedFloorSurfaceArea { get; set; } = null;
        

        [Description("The default value corresponds to R18 [ft2-F-hr/Btu] To convert other IP R-values " +
                     "to U, divide 5.678 by the R-value Some examples: R15 is U 0.3785 W/m2-K R5 is U " +
                     "1.136 W/m2-K")]
        [JsonProperty(PropertyName="insulated_floor_u_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsulatedFloorUValue { get; set; } = Double.Parse("0.3154", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_data", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Refrigeration.Refrigeration_WalkIn_ZoneData_Item> ZoneData { get; set; } = null;
    }
}