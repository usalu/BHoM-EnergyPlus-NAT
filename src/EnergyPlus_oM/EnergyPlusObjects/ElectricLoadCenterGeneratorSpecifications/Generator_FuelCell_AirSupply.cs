using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to define details of the air supply subsystem for a fuel cell power generato" +
                 "r.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_AirSupply : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="blower_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlowerPowerCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="blower_heat_loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlowerHeatLossFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="air_supply_rate_calculation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AirSupply_AirSupplyRateCalculationMode AirSupplyRateCalculationMode { get; set; } = (Generator_FuelCell_AirSupply_AirSupplyRateCalculationMode)Enum.Parse(typeof(Generator_FuelCell_AirSupply_AirSupplyRateCalculationMode), "AirRatiobyStoics");
        

        [Description("This is the excess air \"stoics\" the value entered is incremented by 1 in the mode" +
                     "l.")]
        [JsonProperty(PropertyName="stoichiometric_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StoichiometricRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="air_rate_function_of_electric_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirRateFunctionOfElectricPowerCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_rate_air_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirRateAirTemperatureCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="air_rate_function_of_fuel_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirRateFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_intake_heat_recovery_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AirSupply_AirIntakeHeatRecoveryMode AirIntakeHeatRecoveryMode { get; set; } = (Generator_FuelCell_AirSupply_AirIntakeHeatRecoveryMode)Enum.Parse(typeof(Generator_FuelCell_AirSupply_AirIntakeHeatRecoveryMode), "NoRecovery");
        

        [JsonProperty(PropertyName="air_supply_constituent_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AirSupply_AirSupplyConstituentMode AirSupplyConstituentMode { get; set; } = (Generator_FuelCell_AirSupply_AirSupplyConstituentMode)Enum.Parse(typeof(Generator_FuelCell_AirSupply_AirSupplyConstituentMode), "AmbientAir");
        

        [JsonProperty(PropertyName="number_of_userdefined_constituents", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfUserdefinedConstituents { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_fractions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications.Generator_FuelCell_AirSupply_ConstituentFractions_Item> ConstituentFractions { get; set; } = null;
    }
}