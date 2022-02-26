using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, variable volume, parallel powered " +
                 "induction unit (PIU), with reheat coil (hot water, electric, gas, or steam).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_ParallelPIU_Reheat : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_primary_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumPrimaryAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_secondary_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSecondaryAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_primary_air_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumPrimaryAirFlowFraction { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("the fraction of the primary air flow at which fan turns on")]
        [JsonProperty(PropertyName="fan_on_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> FanOnFlowFraction { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="secondary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondaryAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [Description("mixer outlet node")]
        [JsonProperty(PropertyName="reheat_coil_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReheatCoilAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_mixer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneMixerName { get; set; } = "";
        

        [Description("Fan type must be Fan:SystemModel or Fan:ConstantVolume")]
        [JsonProperty(PropertyName="fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanName { get; set; } = "";
        

        [JsonProperty(PropertyName="reheat_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_ParallelPIU_Reheat_ReheatCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty(PropertyName="reheat_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReheatCoilName { get; set; } = "";
        

        [Description("Not used when reheat coil type is gas or electric")]
        [JsonProperty(PropertyName="maximum_hot_water_or_steam_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumHotWaterOrSteamFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Not used when reheat coil type is gas or electric")]
        [JsonProperty(PropertyName="minimum_hot_water_or_steam_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumHotWaterOrSteamFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="convergence_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConvergenceTolerance { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
    }
}