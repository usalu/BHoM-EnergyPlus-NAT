using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil for water-to-air heat pump (includes electric compressor), single-speed, parameter estimation model. Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Parameter estimation model is a deterministic model that requires a consistent set of parameters to describe the operating conditions of the heat pump components.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_WaterToAirHeatPump_ParameterEstimation : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Parameters 1-5 are as named below. Parameters 6-10 depend on the type of compress" +
                     "or and fluid. Refer to the InputOutputReference on the parameters required")]
        [JsonProperty(PropertyName="compressor_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType CompressorType { get; set; } = (Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType)Enum.Parse(typeof(Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_CompressorType), "Reciprocating");
        

        [JsonProperty(PropertyName="refrigerant_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerantType { get; set; } = "R22";
        

        [JsonProperty(PropertyName="design_source_side_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignSourceSideFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_cooling_coil_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCoolingCoilCapacity { get; set; } = null;
        

        [Description(@"The nominal time for condensate to begin leaving the coil's condensate drain line at the coil's rated air flow rate and temperature conditions. Nominal time is equal to the ratio of the energy of the coil's maximum condensate holding capacity (J) to the coil's steady state latent capacity (W). Suggested value is 1000; zero value means latent degradation model is disabled.")]
        [JsonProperty(PropertyName="nominal_time_for_condensate_removal_to_begin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalTimeForCondensateRemovalToBegin { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Ratio of the initial moisture evaporation rate from the cooling coil (when the compressor first turns off) and the coil's steady state latent capacity at rated air flow rate and temperature conditions. Suggested value is 1.5; zero value means latent degradation model is disabled.")]
        [JsonProperty(PropertyName="ratio_of_initial_moisture_evaporation_rate_and_steady_state_latent_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatioOfInitialMoistureEvaporationRateAndSteadyStateLatentCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="high_pressure_cutoff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighPressureCutoff { get; set; } = null;
        

        [JsonProperty(PropertyName="low_pressure_cutoff", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowPressureCutoff { get; set; } = null;
        

        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Previously called Parameter 1")]
        [JsonProperty(PropertyName="load_side_total_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoadSideTotalHeatTransferCoefficient { get; set; } = null;
        

        [Description("Previously called Parameter 2")]
        [JsonProperty(PropertyName="load_side_outside_surface_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoadSideOutsideSurfaceHeatTransferCoefficient { get; set; } = null;
        

        [Description("Previously called Parameter 3")]
        [JsonProperty(PropertyName="superheat_temperature_at_the_evaporator_outlet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SuperheatTemperatureAtTheEvaporatorOutlet { get; set; } = null;
        

        [Description("Accounts for the loss of work due to mechanical and electrical losses in the comp" +
                     "ressor. Previously called Parameter 4")]
        [JsonProperty(PropertyName="compressor_power_losses", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorPowerLosses { get; set; } = null;
        

        [Description("Previously called Parameter 5")]
        [JsonProperty(PropertyName="compressor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorEfficiency { get; set; } = null;
        

        [Description("Use when Compressor Type is Reciprocating or Rotary Leave this field blank for Co" +
                     "mpressor Type is Scroll. Previously part of Parameter 6")]
        [JsonProperty(PropertyName="compressor_piston_displacement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorPistonDisplacement { get; set; } = null;
        

        [Description("Used when Compressor Type is Rotary or Reciprocating Leave this field blank for C" +
                     "ompressor Type is Scroll. Previously part of Parameter 7")]
        [JsonProperty(PropertyName="compressor_suction_discharge_pressure_drop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorSuctionDischargePressureDrop { get; set; } = null;
        

        [Description("Used when Compressor Type is Reciprocating. Leave this field blank for Compressor" +
                     " Type is Rotary or Scroll. Previously part of Parameter 8")]
        [JsonProperty(PropertyName="compressor_clearance_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorClearanceFactor { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll Leave this field blank for Compressor Type is " +
                     "Rotary or Reciprocating. Previously part of Parameter 6")]
        [JsonProperty(PropertyName="refrigerant_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RefrigerantVolumeFlowRate { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
                     " Rotary or Reciprocating. Previously part of Parameter 7")]
        [JsonProperty(PropertyName="volume_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VolumeRatio { get; set; } = null;
        

        [Description("Use when Compressor Type is Scroll. Leave this field blank for Compressor Type is" +
                     " Rotary or Reciprocating. Previously part of Parameter 8")]
        [JsonProperty(PropertyName="leak_rate_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeakRateCoefficient { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is Water Leave this field blank when Source Side " +
                     "Fluid Name is an antifreeze Previously part of Parameter 9")]
        [JsonProperty(PropertyName="source_side_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideHeatTransferCoefficient { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
                     "e Side Fluid is Water Previously part of Parameter 9")]
        [JsonProperty(PropertyName="source_side_heat_transfer_resistance1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideHeatTransferResistance1 { get; set; } = null;
        

        [Description("Use when Source Side Fluid Name is an antifreeze Leave this field blank for Sourc" +
                     "e Side Fluid is Water Previously part of Parameter 10")]
        [JsonProperty(PropertyName="source_side_heat_transfer_resistance2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideHeatTransferResistance2 { get; set; } = null;
    }
}