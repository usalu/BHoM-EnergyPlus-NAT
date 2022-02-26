using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This indirect absorption chiller model is an enhanced model from the Building Loads and System Thermodynamics (BLAST) program. Chiller performance curves are generated by fitting catalog data to third order polynomial equations. The chiller capacity is a function of condenser, chilled water, and generator temperatures. The heat input is a function of part-load ratio, condenser temperature, and chilled water temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Chiller_Absorption_Indirect : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_pumping_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalPumpingPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chilled_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="chilled_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OptimumPartLoadRatio { get; set; } = null;
        

        [Description("Used only when condenser flow rate is autosized.")]
        [JsonProperty(PropertyName="design_condenser_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignCondenserInletTemperature { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("Provides warnings when entering condenser temperature is below minimum. Capacity " +
                     "is not adjusted when entering condenser temperature is below minimum.")]
        [JsonProperty(PropertyName="condenser_inlet_temperature_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondenserInletTemperatureLowerLimit { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("Capacity is adjusted when leaving chilled water temperature is below minimum.")]
        [JsonProperty(PropertyName="chilled_water_outlet_temperature_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChilledWaterOutletTemperatureLowerLimit { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("For variable flow this is the max flow & for constant flow this is the flow.")]
        [JsonProperty(PropertyName="design_chilled_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignChilledWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_condenser_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignCondenserWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Select operating mode for fluid flow through the chiller. ""NotModulated"" is for either variable or constant pumping with flow controlled by the external plant system. ""ConstantFlow"" is for constant pumping with flow controlled by chiller to operate at full design flow rate. ""LeavingSetpointModulated"" is for variable pumping with flow controlled by chiller to vary flow to target a leaving temperature setpoint.")]
        [JsonProperty(PropertyName="chiller_flow_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_Absorption_Indirect_ChillerFlowMode ChillerFlowMode { get; set; } = (Chiller_Absorption_Indirect_ChillerFlowMode)Enum.Parse(typeof(Chiller_Absorption_Indirect_ChillerFlowMode), "NotModulated");
        

        [JsonProperty(PropertyName="generator_heat_input_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorHeatInputFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="pump_electric_input_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PumpElectricInputFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Enter the generator inlet node name which connects this chiller to a steam or hot" +
                     " water plant, otherwise leave this field blank. Generator nodes are used to mode" +
                     "l heat input to the chiller.")]
        [JsonProperty(PropertyName="generator_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorInletNodeName { get; set; } = "";
        

        [Description("Enter the generator outlet node name which connects this chiller to a steam or ho" +
                     "t water plant, otherwise leave this field blank. Generator nodes are used to mod" +
                     "el heat input to the chiller.")]
        [JsonProperty(PropertyName="generator_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorOutletNodeName { get; set; } = "";
        

        [Description("Curve which shows the change in normalized capacity to changes in condenser tempe" +
                     "rature.")]
        [JsonProperty(PropertyName="capacity_correction_function_of_condenser_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CapacityCorrectionFunctionOfCondenserTemperatureCurveName { get; set; } = "";
        

        [Description("Curve which shows the change in normalized capacity to changes in leaving chilled" +
                     " water temperature.")]
        [JsonProperty(PropertyName="capacity_correction_function_of_chilled_water_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CapacityCorrectionFunctionOfChilledWaterTemperatureCurveName { get; set; } = "";
        

        [Description("Used when generator fluid type is hot water Curve which shows the change in norma" +
                     "lized capacity to changes in generator temperature.")]
        [JsonProperty(PropertyName="capacity_correction_function_of_generator_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CapacityCorrectionFunctionOfGeneratorTemperatureCurveName { get; set; } = "";
        

        [Description("Curve which shows the change in normalized heat input to changes in condenser tem" +
                     "perature.")]
        [JsonProperty(PropertyName="generator_heat_input_correction_function_of_condenser_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorHeatInputCorrectionFunctionOfCondenserTemperatureCurveName { get; set; } = "";
        

        [Description("Curve which shows the change in normalized heat input to changes in leaving chill" +
                     "ed water temperature.")]
        [JsonProperty(PropertyName="generator_heat_input_correction_function_of_chilled_water_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorHeatInputCorrectionFunctionOfChilledWaterTemperatureCurveName { get; set; } = "";
        

        [Description(@"The Generator side of the chiller can be connected to a hot water or steam plant where the generator inlet and outlet nodes are connected to a plant loop. If the generator is not connected to a plant loop, and the generator inlet/outlet nodes are not used, this field should be specified as steam or left blank. When a plant is not used, the model assumes steam as the heat source.")]
        [JsonProperty(PropertyName="generator_heat_source_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_Absorption_Indirect_GeneratorHeatSourceType GeneratorHeatSourceType { get; set; } = (Chiller_Absorption_Indirect_GeneratorHeatSourceType)Enum.Parse(typeof(Chiller_Absorption_Indirect_GeneratorHeatSourceType), "Steam");
        

        [Description("For variable flow this is the max flow and for constant flow this is the flow.")]
        [JsonProperty(PropertyName="design_generator_fluid_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignGeneratorFluidFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Provides warnings when entering generator temperature is below minimum. Capacity " +
                     "is not adjusted when entering generator temperature is below minimum.")]
        [JsonProperty(PropertyName="temperature_lower_limit_generator_inlet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureLowerLimitGeneratorInlet { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is not used when the generator inlet/outlet nodes are not specified or" +
                     " the generator is connected to a hot water loop.")]
        [JsonProperty(PropertyName="degree_of_subcooling_in_steam_generator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DegreeOfSubcoolingInSteamGenerator { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This field is not used when the generator inlet/outlet nodes are not specified or" +
                     " the generator is connected to a hot water loop.")]
        [JsonProperty(PropertyName="degree_of_subcooling_in_steam_condensate_loop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DegreeOfSubcoolingInSteamCondensateLoop { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}