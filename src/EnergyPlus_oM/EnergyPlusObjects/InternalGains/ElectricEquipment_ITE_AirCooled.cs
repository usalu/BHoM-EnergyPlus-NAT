using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("This object describes air-cooled electric information technology equipment (ITE) " +
                 "which has variable power consumption as a function of loading and temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricEquipment_ITE_AirCooled : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description(@"The specified method is used to calculate the IT inlet temperature and zone return air temperature. If FlowFromSystem is chosen, the zone is assumed to be well-mixed. If FlowControlWithApproachTemperatures is chosen, Supply and Return approach temperature should be defined to indicate the temperature difference due to the air distribution. When FlowControlWithApproachTemperatures is chosen, the inputs of Air Inlet Connection Type, Design Recirculation Fraction and Recirculation Function of Loading and Supply Temperature Curve Name are ignored. For multiple ITE objects defined for one zone, the same calculation method should apply. The FlowControlWithApproachTemperatures only applies to ITE zones with single duct VAV terminal unit. Other return air heat gains from window or lights are not allowed when FlowControlWithApproachTemperatures is chosen.")]
        [JsonProperty(PropertyName="air_flow_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod AirFlowCalculationMethod { get; set; } = (ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_AirFlowCalculationMethod), "FlowFromSystem");
        

        [Description("The entered calculation method is used to specify the design power input Watts/Un" +
                     "it => Watts per Unit -- Design Power = Watts per Unit * Number of Units Watts/Ar" +
                     "ea => Watts per Zone Floor Area -- Design Power = Watts per Zone Floor Area * Fl" +
                     "oor Area")]
        [JsonProperty(PropertyName="design_power_input_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod DesignPowerInputCalculationMethod { get; set; } = (ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_DesignPowerInputCalculationMethod), "Empty");
        

        [JsonProperty(PropertyName="watts_per_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WattsPerUnit { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_units", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfUnits { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="watts_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WattsPerZoneFloorArea { get; set; } = null;
        

        [Description("Operating schedule for this equipment, fraction applied to the design power input" +
                     ", generally (0.0 - 1.0) If this field is blank, the schedule is assumed to alway" +
                     "s be 1.0.")]
        [JsonProperty(PropertyName="design_power_input_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignPowerInputScheduleName { get; set; } = "";
        

        [Description("CPU loading schedule for this equipment as a fraction from 0.0 (idle) to 1.0 (ful" +
                     "l load). If this field is blank, the schedule is assumed to always be 1.0.")]
        [JsonProperty(PropertyName="cpu_loading_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CpuLoadingScheduleName { get; set; } = "";
        

        [Description(@"The name of a two-variable curve or table lookup object which modifies the CPU power input as a function of CPU loading (x) and air inlet node temperature (y). This curve (table) should equal 1.0 at design conditions (CPU loading = 1.0 and Design Entering Air Temperature).")]
        [JsonProperty(PropertyName="cpu_power_input_function_of_loading_and_air_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CpuPowerInputFunctionOfLoadingAndAirTemperatureCurveName { get; set; } = "";
        

        [Description("The fraction of the total power input at design conditions which is for the cooli" +
                     "ng fan(s)")]
        [JsonProperty(PropertyName="design_fan_power_input_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFanPowerInputFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The cooling fan air flow rate per total electric power input at design conditions" +
                     "")]
        [JsonProperty(PropertyName="design_fan_air_flow_rate_per_power_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFanAirFlowRatePerPowerInput { get; set; } = null;
        

        [Description(@"The name of a two-variable curve or table lookup object which modifies the cooling air flow rate as a function of CPU loading (x) and air inlet node temperature (y). This curve (table) should equal 1.0 at design conditions (CPU loading = 1.0 and Design Entering Air Temperature).")]
        [JsonProperty(PropertyName="air_flow_function_of_loading_and_air_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirFlowFunctionOfLoadingAndAirTemperatureCurveName { get; set; } = "";
        

        [Description("The name of a single-variable curve or table lookup object which modifies the coo" +
                     "ling fan power as a function of flow fraction (x). This curve (table) should equ" +
                     "al 1.0 at a flow fraction of 1.0.")]
        [JsonProperty(PropertyName="fan_power_input_function_of_flow_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanPowerInputFunctionOfFlowCurveName { get; set; } = "";
        

        [Description("The entering air temperature at design conditions.")]
        [JsonProperty(PropertyName="design_entering_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignEnteringAirTemperature { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [Description("Specifies the allowable operating conditions for the air inlet conditions. Used f" +
                     "or reporting time outside allowable conditions.")]
        [JsonProperty(PropertyName="environmental_class", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricEquipment_ITE_AirCooled_EnvironmentalClass EnvironmentalClass { get; set; } = (ElectricEquipment_ITE_AirCooled_EnvironmentalClass)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_EnvironmentalClass), "None");
        

        [Description(@"Specifies the type of connection between the zone and the ITE air inlet node. AdjustedSupply = ITE inlet temperature will be the current Supply Air Node temperature adjusted by the current recirculation fraction. All heat output is added to the zone air heat balance as a convective gain. ZoneAirNode = ITE air inlet condition is  the average zone condition. All heat output is added to the zone air heat balance as a convective gain. RoomAirModel = ITE air inlet and outlet are connected to room air model nodes. This field is only used when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="air_inlet_connection_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricEquipment_ITE_AirCooled_AirInletConnectionType AirInletConnectionType { get; set; } = (ElectricEquipment_ITE_AirCooled_AirInletConnectionType)Enum.Parse(typeof(ElectricEquipment_ITE_AirCooled_AirInletConnectionType), "AdjustedSupply");
        

        [Description("Name of a RoomAir:Node object which is connected to the ITE air inlet.")]
        [JsonProperty(PropertyName="air_inlet_room_air_model_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletRoomAirModelNodeName { get; set; } = "";
        

        [Description("Name of a RoomAir:Node object which is connected to the ITE air outlet.")]
        [JsonProperty(PropertyName="air_outlet_room_air_model_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletRoomAirModelNodeName { get; set; } = "";
        

        [Description("Name of the supply air inlet node serving this ITE. Required if the Air Node Conn" +
                     "ection Type = AdjustedSupply. Also required if Calculation Method = FlowControlW" +
                     "ithApproachTemperatures. Also required if reporting of Supply Heat Index is desi" +
                     "red.")]
        [JsonProperty(PropertyName="supply_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirNodeName { get; set; } = "";
        

        [Description(@"The recirculation fraction for this equipment at design conditions. This field is used only if the Air Node Connection Type = AdjustedSupply. The default is 0.0 (no recirculation). This field is only used when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="design_recirculation_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignRecirculationFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"The name of a two-variable curve or table lookup object which modifies the recirculation fractionas a function of CPU loading (x) and supply air node temperature (y). This curve (table) should equal 1.0 at design conditions (CPU loading = 1.0 and Design Entering Air Temperature).This field is used only if the Air Node Connection Type = AdjustedSupply. If this curve is left blank, then the curve is assumed to always equal 1.0. This field is only used when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="recirculation_function_of_loading_and_supply_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecirculationFunctionOfLoadingAndSupplyTemperatureCurveName { get; set; } = "";
        

        [Description("The efficiency of the power supply system serving this ITE")]
        [JsonProperty(PropertyName="design_electric_power_supply_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignElectricPowerSupplyEfficiency { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"The name of a single-variable curve or table lookup object which modifies the electric power supply efficiency as a function of part-load ratio (x). This curve (table) should equal 1.0 at full load (PLR = 1.0). If this curve is left blank, then the curve is assumed to always equal 1.0.")]
        [JsonProperty(PropertyName="electric_power_supply_efficiency_function_of_part_load_ratio_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricPowerSupplyEfficiencyFunctionOfPartLoadRatioCurveName { get; set; } = "";
        

        [Description("Fraction of the electric power supply losses which are a heat gain to the zone If" +
                     " this field is <1.0, the remainder of the losses are assumed to be lost to the o" +
                     "utdoors.")]
        [JsonProperty(PropertyName="fraction_of_electric_power_supply_losses_to_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfElectricPowerSupplyLossesToZone { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="cpu_end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CpuEndUseSubcategory { get; set; } = "ITE-CPU";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="fan_end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanEndUseSubcategory { get; set; } = "ITE-Fans";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="electric_power_supply_end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricPowerSupplyEndUseSubcategory { get; set; } = "ITE-UPS";
        

        [Description(@"The difference of the IT inlet temperature from the AHU supply air temperature. Either Supply Temperature Difference or Supply Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="supply_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyTemperatureDifference { get; set; } = null;
        

        [Description(@"The difference schedule of the IT inlet temperature from the AHU supply air temperature. Either Supply Temperature Difference or Supply Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="supply_temperature_difference_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyTemperatureDifferenceSchedule { get; set; } = "";
        

        [Description(@"The difference of the the actual AHU return air temperature to the IT equipment outlet temperature. Either Return Temperature Difference or Return Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="return_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnTemperatureDifference { get; set; } = null;
        

        [Description(@"The difference schedule of the actual AHU return air temperature to the IT equipment outlet temperature. Either Return Temperature Difference or Return Temperature Difference Schedule is required if Air Flow Calculation Method is set to FlowControlWithApproachTemperatures. This field is ignored when Air Flow Calculation Method is FlowFromSystem.")]
        [JsonProperty(PropertyName="return_temperature_difference_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnTemperatureDifferenceSchedule { get; set; } = "";
    }
}