using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used only with Generator:FuelCell and Generator:MicroCHP")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelSupply : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fuel_temperature_modeling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_FuelTemperatureModelingMode FuelTemperatureModelingMode { get; set; } = (Generator_FuelSupply_FuelTemperatureModelingMode)Enum.Parse(typeof(Generator_FuelSupply_FuelTemperatureModelingMode), "Scheduled");
        

        [JsonProperty(PropertyName="fuel_temperature_reference_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FuelTemperatureReferenceNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fuel_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FuelTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="compressor_power_multiplier_function_of_fuel_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompressorPowerMultiplierFunctionOfFuelRateCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="compressor_heat_loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorHeatLossFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_FuelType FuelType { get; set; } = (Generator_FuelSupply_FuelType)Enum.Parse(typeof(Generator_FuelSupply_FuelType), "GaseousConstituents");
        

        [JsonProperty(PropertyName="liquid_generic_fuel_lower_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidGenericFuelLowerHeatingValue { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_generic_fuel_higher_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidGenericFuelHigherHeatingValue { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_generic_fuel_molecular_weight", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidGenericFuelMolecularWeight { get; set; } = null;
        

        [JsonProperty(PropertyName="liquid_generic_fuel_co2_emission_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidGenericFuelCo2EmissionFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_constituents_in_gaseous_constituent_fuel_supply", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfConstituentsInGaseousConstituentFuelSupply { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent1Name Constituent1Name { get; set; } = (Generator_FuelSupply_Constituent1Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent1Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_1_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent1MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent2Name Constituent2Name { get; set; } = (Generator_FuelSupply_Constituent2Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent2Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_2_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent2MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent3Name Constituent3Name { get; set; } = (Generator_FuelSupply_Constituent3Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent3Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_3_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent3MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent4Name Constituent4Name { get; set; } = (Generator_FuelSupply_Constituent4Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent4Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_4_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent4MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent5Name Constituent5Name { get; set; } = (Generator_FuelSupply_Constituent5Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent5Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_5_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent5MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent6Name Constituent6Name { get; set; } = (Generator_FuelSupply_Constituent6Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent6Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_6_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent6MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent7Name Constituent7Name { get; set; } = (Generator_FuelSupply_Constituent7Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent7Name), "Butane");
        

        [JsonProperty(PropertyName="constituent_7_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent7MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent8Name Constituent8Name { get; set; } = (Generator_FuelSupply_Constituent8Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent8Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_8_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent8MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent9Name Constituent9Name { get; set; } = (Generator_FuelSupply_Constituent9Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent9Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_9_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent9MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent10Name Constituent10Name { get; set; } = (Generator_FuelSupply_Constituent10Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent10Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_10_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent10MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_11_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent11Name Constituent11Name { get; set; } = (Generator_FuelSupply_Constituent11Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent11Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_11_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent11MolarFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="constituent_12_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelSupply_Constituent12Name Constituent12Name { get; set; } = (Generator_FuelSupply_Constituent12Name)Enum.Parse(typeof(Generator_FuelSupply_Constituent12Name), "Argon");
        

        [JsonProperty(PropertyName="constituent_12_molar_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Constituent12MolarFraction { get; set; } = null;
    }
}