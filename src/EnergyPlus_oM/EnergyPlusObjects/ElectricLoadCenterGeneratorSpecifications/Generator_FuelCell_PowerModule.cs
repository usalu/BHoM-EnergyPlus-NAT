using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Describe the core power module subsystem of a fuel cell power generator. This includes the fuel cell stack, fuel reformer, and whatever ancillary devices are included inside. If the model has multiple FC generators that are of the exact same type, then only one of these objects is needed and all the Generator:FuelCell objects can reference it.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_PowerModule : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="efficiency_curve_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_PowerModule_EfficiencyCurveMode EfficiencyCurveMode { get; set; } = (Generator_FuelCell_PowerModule_EfficiencyCurveMode)Enum.Parse(typeof(Generator_FuelCell_PowerModule_EfficiencyCurveMode), "Annex42");
        

        [JsonProperty(PropertyName="efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EfficiencyCurveName { get; set; } = "";
        

        [Description("This field is not used.")]
        [JsonProperty(PropertyName="nominal_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalEfficiency { get; set; } = null;
        

        [Description("This field is not used")]
        [JsonProperty(PropertyName="nominal_electrical_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalElectricalPower { get; set; } = null;
        

        [Description("this is Nstops in SOFC model specification")]
        [JsonProperty(PropertyName="number_of_stops_at_start_of_simulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfStopsAtStartOfSimulation { get; set; } = null;
        

        [Description("this is D in SOFC model specification")]
        [JsonProperty(PropertyName="cycling_performance_degradation_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CyclingPerformanceDegradationCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_run_hours_at_beginning_of_simulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfRunHoursAtBeginningOfSimulation { get; set; } = null;
        

        [Description("this is L in SOFC model specification")]
        [JsonProperty(PropertyName="accumulated_run_time_degradation_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AccumulatedRunTimeDegradationCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="run_time_degradation_initiation_time_threshold", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RunTimeDegradationInitiationTimeThreshold { get; set; } = null;
        

        [Description("Maximum rate of change in electrical output [power increasing]")]
        [JsonProperty(PropertyName="power_up_transient_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerUpTransientLimit { get; set; } = null;
        

        [Description("Maximum rate of change in electrical output [power decreasing] Enter positive val" +
                     "ue for rate of change")]
        [JsonProperty(PropertyName="power_down_transient_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerDownTransientLimit { get; set; } = null;
        

        [Description("Time from start up to normal operation")]
        [JsonProperty(PropertyName="start_up_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartUpTime { get; set; } = null;
        

        [JsonProperty(PropertyName="start_up_fuel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartUpFuel { get; set; } = null;
        

        [JsonProperty(PropertyName="start_up_electricity_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartUpElectricityConsumption { get; set; } = null;
        

        [JsonProperty(PropertyName="start_up_electricity_produced", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StartUpElectricityProduced { get; set; } = null;
        

        [JsonProperty(PropertyName="shut_down_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShutDownTime { get; set; } = null;
        

        [JsonProperty(PropertyName="shut_down_fuel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShutDownFuel { get; set; } = null;
        

        [JsonProperty(PropertyName="shut_down_electricity_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShutDownElectricityConsumption { get; set; } = null;
        

        [JsonProperty(PropertyName="ancillary_electricity_constant_term", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryElectricityConstantTerm { get; set; } = null;
        

        [JsonProperty(PropertyName="ancillary_electricity_linear_term", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryElectricityLinearTerm { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_calculation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_PowerModule_SkinLossCalculationMode SkinLossCalculationMode { get; set; } = (Generator_FuelCell_PowerModule_SkinLossCalculationMode)Enum.Parse(typeof(Generator_FuelCell_PowerModule_SkinLossCalculationMode), "ConstantRate");
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="skin_loss_radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossRadiativeFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constant_skin_loss_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantSkinLossRate { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_u_factor_times_area_term", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossUFactorTimesAreaTerm { get; set; } = null;
        

        [Description("curve is function of fuel use rate")]
        [JsonProperty(PropertyName="skin_loss_quadratic_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SkinLossQuadraticCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="dilution_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DilutionAirFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="stack_heat_loss_to_dilution_air", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StackHeatLossToDilutionAir { get; set; } = null;
        

        [JsonProperty(PropertyName="dilution_inlet_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DilutionInletAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="dilution_outlet_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DilutionOutletAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_operating_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOperatingPoint { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_operating_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOperatingPoint { get; set; } = null;
    }
}