using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("This object is used to define coefficients for the approach temperature correlati" +
                 "on for a variable speed cooling tower when tower Model Type is specified as York" +
                 "CalcUserDefined in the object CoolingTower:VariableSpeed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CoolingTowerPerformance_YorkCalc : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Minimum valid inlet air wet-bulb temperature for this approach temperature correl" +
                     "ation.")]
        [JsonProperty(PropertyName="minimum_inlet_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumInletAirWetBulbTemperature { get; set; } = null;
        

        [Description("Maximum valid inlet air wet-bulb temperature for this approach temperature correl" +
                     "ation.")]
        [JsonProperty(PropertyName="maximum_inlet_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumInletAirWetBulbTemperature { get; set; } = null;
        

        [Description("Minimum valid range temperature for this approach temperature correlation.")]
        [JsonProperty(PropertyName="minimum_range_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumRangeTemperature { get; set; } = null;
        

        [Description("Maximum valid range temperature for this approach temperature correlation.")]
        [JsonProperty(PropertyName="maximum_range_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRangeTemperature { get; set; } = null;
        

        [Description("Minimum valid approach temperature for this correlation.")]
        [JsonProperty(PropertyName="minimum_approach_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumApproachTemperature { get; set; } = null;
        

        [Description("Maximum valid approach temperature for this correlation.")]
        [JsonProperty(PropertyName="maximum_approach_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumApproachTemperature { get; set; } = null;
        

        [Description("Minimum valid water flow rate ratio for this approach temperature correlation.")]
        [JsonProperty(PropertyName="minimum_water_flow_rate_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumWaterFlowRateRatio { get; set; } = null;
        

        [Description("Maximum valid water flow rate ratio for this approach temperature correlation.")]
        [JsonProperty(PropertyName="maximum_water_flow_rate_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumWaterFlowRateRatio { get; set; } = null;
        

        [Description("Maximum liquid (water) to gas (air) ratio for this approach temperature correlati" +
                     "on.")]
        [JsonProperty(PropertyName="maximum_liquid_to_gas_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumLiquidToGasRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient4 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient5 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient6 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient7 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient8 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient9 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient10 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient11 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient12 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient13 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient14 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient15 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient16 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient17 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient18 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient19 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient20 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient21 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient22 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient23 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient24 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient25 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_26", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient26 { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_27", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient27 { get; set; } = null;
    }
}