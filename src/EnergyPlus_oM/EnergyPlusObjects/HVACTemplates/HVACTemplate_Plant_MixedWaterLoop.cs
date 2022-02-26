using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Central plant loop portion of a water source heat pump system.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_MixedWaterLoop : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always available Applies to both chilled water and condenser loop pumps" +
                     "")]
        [JsonProperty(PropertyName="pump_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PumpScheduleName { get; set; } = "";
        

        [Description("Applies to both chilled water and condenser loop pumps")]
        [JsonProperty(PropertyName="pump_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_PumpControlType), "Intermittent");
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Boiler and HVACTemplate:Plant:To" +
                     "wer objects.")]
        [JsonProperty(PropertyName="operation_scheme_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType OperationSchemeType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_OperationSchemeType), "Default");
        

        [Description("Name of a PlantEquipmentOperationSchemes object Ignored if Plant Operation Scheme" +
                     " Type = Default")]
        [JsonProperty(PropertyName="equipment_operation_schemes_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EquipmentOperationSchemesName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty(PropertyName="high_temperature_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HighTemperatureSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specifie" +
                     "d.")]
        [JsonProperty(PropertyName="high_temperature_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighTemperatureDesignSetpoint { get; set; } = Double.Parse("33", CultureInfo.InvariantCulture);
        

        [Description("Leave blank if constant setpoint May be left blank if not serving any water coole" +
                     "d chillers")]
        [JsonProperty(PropertyName="low_temperature_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LowTemperatureSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Condenser Water Setpoint Schedule " +
                     "Name is specified. May be left blank if not serving any water cooled chillers")]
        [JsonProperty(PropertyName="low_temperature_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowTemperatureDesignSetpoint { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("VariableFlow - variable flow to boilers and coils, excess bypassed ConstantFlow -" +
                     " constant flow to boilers and coils, excess bypassed")]
        [JsonProperty(PropertyName="water_pump_configuration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration WaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_WaterPumpConfiguration), "ConstantFlow");
        

        [Description("May be left blank if not serving any water cooled chillers default head is 60 fee" +
                     "t H2O")]
        [JsonProperty(PropertyName="water_pump_rated_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterPumpRatedHead { get; set; } = Double.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Describes the type of pump configuration used for the mixed water loop.")]
        [JsonProperty(PropertyName="water_pump_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_WaterPumpType WaterPumpType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_WaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_WaterPumpType), "SinglePump");
        

        [Description("Determines if a supply side bypass pipe is present in the hot water loop.")]
        [JsonProperty(PropertyName="supply_side_bypass_pipe", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SupplySideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Determines if a demand side bypass pipe is present in the hot water loop.")]
        [JsonProperty(PropertyName="demand_side_bypass_pipe", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DemandSideBypassPipe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty(PropertyName="fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_FluidType), "Water");
        

        [Description("The temperature difference used in sizing the loop flow rate.")]
        [JsonProperty(PropertyName="loop_design_delta_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoopDesignDeltaTemperature { get; set; } = Double.Parse("5.6", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="load_distribution_scheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_MixedWaterLoop_LoadDistributionScheme), "SequentialLoad");
    }
}