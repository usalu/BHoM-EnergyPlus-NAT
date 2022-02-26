using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Works in conjunction with the refrigeration case and walk-in objects to simulate the performance of a refrigerated case system. This object models the electric consumption of the rack compressors and the condenser fans. Heat can be rejected either outdoors or to a zone. Compressor rack waste heat can also be reclaimed for use by an optional air- or water-heating coil (Coil:Heating:Desuperheater and Coil:WaterHeating:Desuperheater).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_CompressorRack : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_rejection_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_CompressorRack_HeatRejectionLocation HeatRejectionLocation { get; set; } = (Refrigeration_CompressorRack_HeatRejectionLocation)Enum.Parse(typeof(Refrigeration_CompressorRack_HeatRejectionLocation), "Outdoors");
        

        [Description("It is important that this COP correspond to the lowest saturated suction temperat" +
                     "ure needed to serve all refrigeration loads")]
        [JsonProperty(PropertyName="design_compressor_rack_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignCompressorRackCop { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("It is important that this COP curve correspond to the lowest saturated suction te" +
                     "mperature needed to serve all refrigeration loads")]
        [JsonProperty(PropertyName="compressor_rack_cop_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompressorRackCopFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Design power for condenser fan(s).")]
        [JsonProperty(PropertyName="design_condenser_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignCondenserFanPower { get; set; } = Double.Parse("250", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condenser_fan_power_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserFanPowerFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("Applicable only when Heat Rejection Location is Outdoors.")]
        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_CompressorRack_CondenserType CondenserType { get; set; } = (Refrigeration_CompressorRack_CondenserType)Enum.Parse(typeof(Refrigeration_CompressorRack_CondenserType), "AirCooled");
        

        [JsonProperty(PropertyName="water_cooled_condenser_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterCooledCondenserInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_cooled_condenser_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterCooledCondenserOutletNodeName { get; set; } = "";
        

        [Description("Applicable only when Condenser Type is WaterCooled.")]
        [JsonProperty(PropertyName="water_cooled_loop_flow_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_CompressorRack_WaterCooledLoopFlowType WaterCooledLoopFlowType { get; set; } = (Refrigeration_CompressorRack_WaterCooledLoopFlowType)Enum.Parse(typeof(Refrigeration_CompressorRack_WaterCooledLoopFlowType), "VariableFlow");
        

        [Description("Applicable only when loop Flow type is VariableFlow.")]
        [JsonProperty(PropertyName="water_cooled_condenser_outlet_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterCooledCondenserOutletTemperatureScheduleName { get; set; } = "";
        

        [Description("Applicable only when loop flow type is ConstantFlow.")]
        [JsonProperty(PropertyName="water_cooled_condenser_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterCooledCondenserDesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="water_cooled_condenser_maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterCooledCondenserMaximumFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="water_cooled_condenser_maximum_water_outlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterCooledCondenserMaximumWaterOutletTemperature { get; set; } = Double.Parse("55", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="water_cooled_condenser_minimum_water_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterCooledCondenserMinimumWaterInletTemperature { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 indicate that evaporative cooling of the condenser is available. This schedule allows the user to define seasonal shutdown/draining of the water cooling system in cold climate applications. For periods with schedule values of 0, the condenser operates as AirCooled.")]
        [JsonProperty(PropertyName="evaporative_condenser_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeCondenserAvailabilityScheduleName { get; set; } = "";
        

        [Description("Applicable only for Condenser Type = EvaporativlyCooled.")]
        [JsonProperty(PropertyName="evaporative_condenser_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserEffectiveness { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for Condenser Type = EvaporativelyCooled. Used to calculate evapo" +
                     "rative condenser water use.")]
        [JsonProperty(PropertyName="evaporative_condenser_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> EvaporativeCondenserAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the evaporatively cooled condenser is available (field Evaporative Condenser Availability Schedule Name). For this situation, the heater heats the basin water when the outdoor air dry-bulb temperature falls below the setpoint temperature, but only when the condenser fans are off (i.e., no refrigerated case load).")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("200", CultureInfo.InvariantCulture);
        

        [Description("Enter the outdoor dry-bulb temperature at which the basin heater turns on.")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Design recirc water pump power for Condenser Type = EvaporativelyCooled. Applicab" +
                     "le only for Condenser Type = EvaporativelyCooled.")]
        [JsonProperty(PropertyName="design_evaporative_condenser_water_pump_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> DesignEvaporativeCondenserWaterPumpPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If blank, water supply is from Mains. Applicable only for Condenser Type = Evapor" +
                     "ativelyCooled.")]
        [JsonProperty(PropertyName="evaporative_water_supply_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeWaterSupplyTankName { get; set; } = "";
        

        [Description(@"Applicable only when Heat Rejection Location is Outdoors and Condenser Type is not WaterCooled; otherwise, leave field blank. If field is left blank with Heat Rejection Location = Outdoors, then the model assumes that the Inlet Air conditions are the outdoor air conditions for the current timestep (e.g., no adjustment for height above ground).")]
        [JsonProperty(PropertyName="condenser_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserAirInletNodeName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [Description("Enter the name of a Refrigeration:Case or Refrigeration:Walkin or Refrigeration:C" +
                     "aseAndWalkinList object.")]
        [JsonProperty(PropertyName="refrigeration_case_name_or_walkin_name_or_caseandwalkinlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationCaseNameOrWalkinNameOrCaseandwalkinlistName { get; set; } = "";
        

        [Description("This must be a controlled zone and appear in a ZoneHVAC:EquipmentConnections obje" +
                     "ct. Required only if walk-in[s] are connected to this rack AND the heat rejectio" +
                     "n location is \"Zone\"")]
        [JsonProperty(PropertyName="heat_rejection_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRejectionZoneName { get; set; } = "";
    }
}