using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with refrigerated cases and walkins to simulate the performance of a secondary loop supermarket refrigeration system. Heat from the refrigeration loads served by the secondary loop is absorbed by a primary refrigeration system (Refrigeration:System). The SecondarySystem object simulates a heat exchanger that is an evaporator, or refrigeration load, on the primary refrigeration system.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_SecondarySystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there i" +
                     "s more than one refrigerated case or walk-in served by this secondary system, en" +
                     "ter the name of a Refrigeration:CaseAndWalkInList object.")]
        [JsonProperty(PropertyName="refrigerated_case_or_walkin_or_caseandwalkinlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [Description(@"If ""FluidAlwaysLiquid"" is selected, the fluid properties must be input using the objects: FluidProperties:Name, FluidProperties:GlycolConcentration, and, if user defined fluid type, FluidProperties:Temperatures and FluidProperties:Concentration. Many sets of fluid properties can be found in GlycolPropertiesRefData.idf. If ""FluidPhaseChange"" is selected, the refrigerant properties must be input using the objects: (if user defined fluid type): FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated, and FluidProperties:Superheated. Many sets of refrigerant data can be found in FluidPropertiesRefData.idf.")]
        [JsonProperty(PropertyName="circulating_fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_SecondarySystem_CirculatingFluidType CirculatingFluidType { get; set; } = (Refrigeration_SecondarySystem_CirculatingFluidType)Enum.Parse(typeof(Refrigeration_SecondarySystem_CirculatingFluidType), "FluidAlwaysLiquid");
        

        [Description("This must correspond to a name in the FluidProperties:Name object.")]
        [JsonProperty(PropertyName="circulating_fluid_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CirculatingFluidName { get; set; } = "";
        

        [Description(@"For ""FluidAlwaysLiquid"", at least one of the two, Evaporator Capacity OR Evaporator Flow Rate for Secondary Fluid, is required. For ""FluidPhaseChange"", the default capacity is the sum of the rated capacities of the Cases and Walk-ins served by the secondary loop.")]
        [JsonProperty(PropertyName="evaporator_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorCapacity { get; set; } = null;
        

        [Description("For \"FluidAlwaysLiquid\", at least one of the two, Evaporator Capacity OR Evaporat" +
                     "or Flow Rate for Secondary Fluid, is required. For \"FluidPhaseChange\" loops, thi" +
                     "s input is not used. (see PhaseChange Circulating Rate)")]
        [JsonProperty(PropertyName="evaporator_flow_rate_for_secondary_fluid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorFlowRateForSecondaryFluid { get; set; } = null;
        

        [Description("This is the evaporating temperature in the heat exchanger used to chill or conden" +
                     "se the secondary loop circulating fluid. It is NOT the temperature in any cases " +
                     "or walk-ins served by the secondary loop.")]
        [JsonProperty(PropertyName="evaporator_evaporating_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorEvaporatingTemperature { get; set; } = null;
        

        [Description(@"For ""FluidAlwaysLiquid"", this is the rated difference between the temperature of the circulating fluid leaving the heat exchanger and the heat exchanger's rated evaporating temperature. For ""FluidPhaseChange"", this is the difference between the temperature of the evaporating and condensing temperatures in the heat exchanger.")]
        [JsonProperty(PropertyName="evaporator_approach_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorApproachTemperatureDifference { get; set; } = null;
        

        [Description(@"For ""FluidAlwaysLiquid"", this is the rated difference between the temperature of the circulating fluid entering the heat exchanger and the temperature of the circulating fluid leaving the heat exchanger, and is Required. For ""FluidPhaseChange"", this input is not used.")]
        [JsonProperty(PropertyName="evaporator_range_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorRangeTemperatureDifference { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_pumps_in_loop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfPumpsInLoop { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("For \"FluidAlwaysLiquid\",if not input, Evaporator Flow Rate for Secondary Fluid wi" +
                     "ll be used. For \"FluidPhaseChange\", if not input, this will be calculated using " +
                     "the PhaseChange Circulating Rate.")]
        [JsonProperty(PropertyName="total_pump_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalPumpFlowRate { get; set; } = null;
        

        [Description("Either the Total Pump Power or the Total Pump Head is required.")]
        [JsonProperty(PropertyName="total_pump_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalPumpPower { get; set; } = null;
        

        [Description("Either the Total Pump Power or the Total Pump Head is required.")]
        [JsonProperty(PropertyName="total_pump_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalPumpHead { get; set; } = null;
        

        [Description("This is the total mass flow at the pump divided by the gaseous mass flow leaving " +
                     "the refrigeration load.")]
        [JsonProperty(PropertyName="phasechange_circulating_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PhasechangeCirculatingRate { get; set; } = Double.Parse("2.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pump_drive_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_SecondarySystem_PumpDriveType PumpDriveType { get; set; } = (Refrigeration_SecondarySystem_PumpDriveType)Enum.Parse(typeof(Refrigeration_SecondarySystem_PumpDriveType), "Constant");
        

        [Description("Variable Speed Pump Curve Name is applicable to variable speed pumps only.")]
        [JsonProperty(PropertyName="variable_speed_pump_cubic_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VariableSpeedPumpCubicCurveName { get; set; } = "";
        

        [Description("This is the portion of the pump motor heat added to secondary circulating fluid a" +
                     "nd is equal to the motor efficiency for non-hermetic motor. Enter 1.0 for a semi" +
                     "-hermetic motor.")]
        [JsonProperty(PropertyName="pump_motor_heat_to_fluid", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PumpMotorHeatToFluid { get; set; } = Double.Parse("0.85", CultureInfo.InvariantCulture);
        

        [Description("Use only if you want to include distribution piping heat gain in refrigeration lo" +
                     "ad.")]
        [JsonProperty(PropertyName="sum_ua_distribution_piping", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SumUaDistributionPiping { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain. The pipe heat gains are also counted as cooling credit for the zone. Requi" +
                     "red only if Sum UA Distribution Piping >0.0")]
        [JsonProperty(PropertyName="distribution_piping_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DistributionPipingZoneName { get; set; } = "";
        

        [Description("Use only if you want to include Receiver/Separator Shell heat gain in refrigerati" +
                     "on load.")]
        [JsonProperty(PropertyName="sum_ua_receiver_separator_shell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SumUaReceiverSeparatorShell { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for Receiver/Separator Shell " +
                     "heat gain. The shell heat gains are also counted as cooling credit for the zone." +
                     " Required only if Sum UA Receiver/Separator Shell >0.0")]
        [JsonProperty(PropertyName="receiver_separator_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReceiverSeparatorZoneName { get; set; } = "";
        

        [Description("This value refers to the refrigerant circulating within the primary system provid" +
                     "ing cooling to the chiller for the secondary loop, not to the fluid circulating " +
                     "within the secondary loop itself.")]
        [JsonProperty(PropertyName="evaporator_refrigerant_inventory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorRefrigerantInventory { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}