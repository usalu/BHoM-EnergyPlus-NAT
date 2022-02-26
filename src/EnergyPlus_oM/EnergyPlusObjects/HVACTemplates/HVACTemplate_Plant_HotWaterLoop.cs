using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Plant loop to serve all HVACTemplate hot water coils and boilers.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_HotWaterLoop : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If blank, always available")]
        [JsonProperty(PropertyName="pump_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PumpScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="pump_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_PumpControlType PumpControlType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_PumpControlType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_PumpControlType), "Intermittent");
        

        [Description("Default operation type makes all equipment available at all times operating in or" +
                     "der of Priority specified in HVACTemplate:Plant:Boiler objects.")]
        [JsonProperty(PropertyName="hot_water_plant_operation_scheme_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType HotWaterPlantOperationSchemeType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPlantOperationSchemeType), "Default");
        

        [Description("Name of a PlantEquipmentOperationSchemes object Ignored if Plant Operation Scheme" +
                     " Type = Default")]
        [JsonProperty(PropertyName="hot_water_plant_equipment_operation_schemes_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotWaterPlantEquipmentOperationSchemesName { get; set; } = "";
        

        [Description("Leave blank if constant setpoint")]
        [JsonProperty(PropertyName="hot_water_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotWaterSetpointScheduleName { get; set; } = "";
        

        [Description("Used for sizing and as constant setpoint if no Setpoint Schedule Name is specifie" +
                     "d.")]
        [JsonProperty(PropertyName="hot_water_design_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HotWaterDesignSetpoint { get; set; } = Double.Parse("82", CultureInfo.InvariantCulture);
        

        [Description("VariableFlow - variable flow to boilers and coils, excess bypassed ConstantFlow -" +
                     " constant flow to boilers and coils, excess bypassed")]
        [JsonProperty(PropertyName="hot_water_pump_configuration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration HotWaterPumpConfiguration { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPumpConfiguration), "ConstantFlow");
        

        [Description("Default head is 60 feet H2O")]
        [JsonProperty(PropertyName="hot_water_pump_rated_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HotWaterPumpRatedHead { get; set; } = Double.Parse("179352", CultureInfo.InvariantCulture);
        

        [Description("Overrides Hot Water Setpoint Schedule Name")]
        [JsonProperty(PropertyName="hot_water_setpoint_reset_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType HotWaterSetpointResetType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterSetpointResetType), "None");
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="hot_water_setpoint_at_outdoor_dry_bulb_low", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HotWaterSetpointAtOutdoorDryBulbLow { get; set; } = Double.Parse("82.2", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="hot_water_reset_outdoor_dry_bulb_low", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HotWaterResetOutdoorDryBulbLow { get; set; } = Double.Parse("-6.7", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="hot_water_setpoint_at_outdoor_dry_bulb_high", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HotWaterSetpointAtOutdoorDryBulbHigh { get; set; } = Double.Parse("65.6", CultureInfo.InvariantCulture);
        

        [Description("Applicable only for OutdoorAirTemperatureReset control.")]
        [JsonProperty(PropertyName="hot_water_reset_outdoor_dry_bulb_high", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HotWaterResetOutdoorDryBulbHigh { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Describes the type of pump configuration used for the hot water loop.")]
        [JsonProperty(PropertyName="hot_water_pump_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType HotWaterPumpType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_HotWaterPumpType), "SinglePump");
        

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
        public HVACTemplate_Plant_HotWaterLoop_FluidType FluidType { get; set; } = (HVACTemplate_Plant_HotWaterLoop_FluidType)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_FluidType), "Water");
        

        [Description("The temperature difference used in sizing the loop flow rate.")]
        [JsonProperty(PropertyName="loop_design_delta_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoopDesignDeltaTemperature { get; set; } = Double.Parse("11", CultureInfo.InvariantCulture);
        

        [Description("The maximum outdoor dry-bulb temperature that the hot water loops operate. Leave " +
                     "blank for no limit.")]
        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="load_distribution_scheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme LoadDistributionScheme { get; set; } = (HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme)Enum.Parse(typeof(HVACTemplate_Plant_HotWaterLoop_LoadDistributionScheme), "SequentialLoad");
    }
}