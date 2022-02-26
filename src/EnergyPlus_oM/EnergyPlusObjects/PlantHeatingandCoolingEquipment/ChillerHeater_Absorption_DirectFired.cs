using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("Direct fired gas absorption chiller-heater using performance curves similar to DO" +
                 "E-2")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ChillerHeater_Absorption_DirectFired : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="nominal_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("A positive fraction that represents the ratio of the heating capacity divided by " +
                     "the cooling capacity at rated conditions.")]
        [JsonProperty(PropertyName="heating_to_cooling_capacity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingToCoolingCapacityRatio { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("The positive fraction that represents the ratio of the instantaneous fuel used di" +
                     "vided by the cooling capacity at rated conditions.")]
        [JsonProperty(PropertyName="fuel_input_to_cooling_output_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FuelInputToCoolingOutputRatio { get; set; } = Double.Parse("0.97", CultureInfo.InvariantCulture);
        

        [Description("The positive fraction that represents the ratio of the instantaneous fuel used di" +
                     "vided by the nominal heating capacity.")]
        [JsonProperty(PropertyName="fuel_input_to_heating_output_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FuelInputToHeatingOutputRatio { get; set; } = Double.Parse("1.25", CultureInfo.InvariantCulture);
        

        [Description("The positive fraction that represents the ratio of the instantaneous electricity " +
                     "used divided by the cooling capacity at rated conditions. If the chiller is both" +
                     " heating and cooling only the cooling electricity is used.")]
        [JsonProperty(PropertyName="electric_input_to_cooling_output_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ElectricInputToCoolingOutputRatio { get; set; } = Double.Parse("0.01", CultureInfo.InvariantCulture);
        

        [Description("The positive fraction that represents the ratio of the instantaneous electricity " +
                     "used divided by the nominal heating capacity. If the chiller is both heating and" +
                     " cooling only the cooling electricity is used.")]
        [JsonProperty(PropertyName="electric_input_to_heating_output_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ElectricInputToHeatingOutputRatio { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chilled_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="chilled_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserInletNodeName { get; set; } = "";
        

        [Description("Not required if air-cooled")]
        [JsonProperty(PropertyName="condenser_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="hot_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="hot_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotWaterOutletNodeName { get; set; } = "";
        

        [Description(@"The positive fraction that represents the minimum cooling output possible when operated continually at rated temperature conditions divided by the nominal cooling capacity at those same conditions. If the load on the chiller is below this fraction the chiller will cycle.")]
        [JsonProperty(PropertyName="minimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPartLoadRatio { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description(@"The positive fraction that represents the maximum cooling output possible at rated temperature conditions divided by the nominal cooling capacity at those same conditions. If greater than 1.0, the chiller is typically thought of as capable of being overloaded.")]
        [JsonProperty(PropertyName="maximum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The positive fraction that represents the optimal cooling output at rated tempera" +
                     "ture conditions divided by the nominal cooling capacity at those same conditions" +
                     ". It represents the most desirable operating point for the chiller.")]
        [JsonProperty(PropertyName="optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OptimumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The temperature of the water entering the condenser of the chiller when operating" +
                     " at design conditions. This is usually based on the temperature delivered by the" +
                     " cooling tower in a water cooled application.")]
        [JsonProperty(PropertyName="design_entering_condenser_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringCondenserWaterTemperature { get; set; } = Double.Parse("29", CultureInfo.InvariantCulture);
        

        [Description("The temperature of the water leaving the evaporator of the chiller when operating" +
                     " at design conditions also called the chilled water supply temperature or leavin" +
                     "g chilled water temperature.")]
        [JsonProperty(PropertyName="design_leaving_chilled_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignLeavingChilledWaterTemperature { get; set; } = Double.Parse("7", CultureInfo.InvariantCulture);
        

        [Description("For variable volume this is the max flow & for constant flow this is the flow.")]
        [JsonProperty(PropertyName="design_chilled_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignChilledWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("The water flow rate at design conditions through the condenser. This field is not" +
                     " used for Condenser Type = AirCooled")]
        [JsonProperty(PropertyName="design_condenser_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignCondenserWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("The water flow rate at design conditions through the heater side.")]
        [JsonProperty(PropertyName="design_hot_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignHotWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"The CoolCapFT curve represents the fraction of the cooling capacity of the chiller as it varies by temperature. The curve is normalized so that at design conditions the value of the curve should be 1.0. This is a biquadratic curve with the input variables being the leaving chilled water temperature and either the entering or leaving condenser water temperature.")]
        [JsonProperty(PropertyName="cooling_capacity_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCapacityFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"The curve represents the fraction of the fuel input to the chiller at full load as it varies by temperature. The curve is normalized so that at design conditions the value of the curve should be 1.0. This is a biquadratic curve with the input variables being the leaving chilled water temperature and either the entering or leaving condenser water temperature.")]
        [JsonProperty(PropertyName="fuel_input_to_cooling_output_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FuelInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"The curve represents the fraction of the fuel input to the chiller as the load on the chiller varies but the operating temperatures remain at the design values. The curve is normalized so that at full load the value of the curve should be 1.0. The curve is usually linear or quadratic.")]
        [JsonProperty(PropertyName="fuel_input_to_cooling_output_ratio_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FuelInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description(@"The curve represents the fraction of the electricity to the chiller at full load as it varies by temperature. The curve is normalized so that at design conditions the value of the curve should be 1.0. This is a biquadratic curve with the input variables being the leaving chilled water temperature and either the entering or leaving condenser water temperature.")]
        [JsonProperty(PropertyName="electric_input_to_cooling_output_ratio_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricInputToCoolingOutputRatioFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"The curve represents the fraction of the electricity to the chiller as the load on the chiller varies but the operating temperatures remain at the design values. The curve is normalized so that at full load the value of the curve should be 1.0. The curve is usually linear or quadratic.")]
        [JsonProperty(PropertyName="electric_input_to_cooling_output_ratio_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricInputToCoolingOutputRatioFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description(@"The curve represents how the heating capacity of the chiller varies with cooling capacity when the chiller is simultaneous heating and cooling. The curve is normalized so an input of 1.0 represents the nominal cooling capacity and an output of 1.0 represents the full heating capacity (see the Heating to cooling capacity ratio input) The curve is usually linear or quadratic.")]
        [JsonProperty(PropertyName="heating_capacity_function_of_cooling_capacity_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCapacityFunctionOfCoolingCapacityCurveName { get; set; } = "";
        

        [Description(@"When the chiller is operating as only a heater, this curve is used to represent the fraction of fuel used as the heating load varies. It is normalized so that a value of 1.0 is the full heating capacity. The curve is usually linear or quadratic and will probably be similar to a boiler curve for most chillers.")]
        [JsonProperty(PropertyName="fuel_input_to_heat_output_ratio_during_heating_only_operation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FuelInputToHeatOutputRatioDuringHeatingOnlyOperationCurveName { get; set; } = "";
        

        [Description(@"Sets the second independent variable in the three temperature dependent performance curves to either the leaving or entering condenser water temperature. Manufacturers express the performance of their chillers using either the leaving condenser water temperature (to the tower) or the entering condenser water temperature (from the tower).")]
        [JsonProperty(PropertyName="temperature_curve_input_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeater_Absorption_DirectFired_TemperatureCurveInputVariable TemperatureCurveInputVariable { get; set; } = (ChillerHeater_Absorption_DirectFired_TemperatureCurveInputVariable)Enum.Parse(typeof(ChillerHeater_Absorption_DirectFired_TemperatureCurveInputVariable), "EnteringCondenser");
        

        [Description("The condenser can either be air cooled or connected to a cooling tower.")]
        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeater_Absorption_DirectFired_CondenserType CondenserType { get; set; } = (ChillerHeater_Absorption_DirectFired_CondenserType)Enum.Parse(typeof(ChillerHeater_Absorption_DirectFired_CondenserType), "WaterCooled");
        

        [Description("The chilled water supply temperature below which the chiller will shut off.")]
        [JsonProperty(PropertyName="chilled_water_temperature_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChilledWaterTemperatureLowerLimit { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Not currently used.")]
        [JsonProperty(PropertyName="fuel_higher_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FuelHigherHeatingValue { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChillerHeater_Absorption_DirectFired_FuelType FuelType { get; set; } = (ChillerHeater_Absorption_DirectFired_FuelType)Enum.Parse(typeof(ChillerHeater_Absorption_DirectFired_FuelType), "NaturalGas");
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}