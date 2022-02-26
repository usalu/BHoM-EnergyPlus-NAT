using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("This object is used for air-source integrated heat pump, a collection of its work" +
                 "ing modes.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CoilSystem_IntegratedHeatPump_AirSource : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_hot_water_flow_sensor_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyHotWaterFlowSensorNodeName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty(PropertyName="space_cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpaceCoolingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty(PropertyName="space_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpaceHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty(PropertyName="dedicated_water_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DedicatedWaterHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty(PropertyName="scwh_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScwhCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Cooling:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty(PropertyName="scdwh_cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScdwhCoolingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty(PropertyName="scdwh_water_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScdwhWaterHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:Heating:DX:VariableSpeed objec" +
                     "t.")]
        [JsonProperty(PropertyName="shdwh_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShdwhHeatingCoilName { get; set; } = "";
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:VariableSpeed object.")]
        [JsonProperty(PropertyName="shdwh_water_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShdwhWaterHeatingCoilName { get; set; } = "";
        

        [Description("Indoor Temperature above which Indoor Overcooling is Allowed during Cooling Opera" +
                     "tion")]
        [JsonProperty(PropertyName="indoor_temperature_limit_for_scwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorTemperatureLimitForScwhMode { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Ambient Temperature above which Indoor Overcooling is Allowed during Cooling Oper" +
                     "ation")]
        [JsonProperty(PropertyName="ambient_temperature_limit_for_scwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AmbientTemperatureLimitForScwhMode { get; set; } = Double.Parse("27", CultureInfo.InvariantCulture);
        

        [Description("Indoor Temperature above which Water Heating has the higher priority and Space He" +
                     "ating Call Can be ignored.")]
        [JsonProperty(PropertyName="indoor_temperature_above_which_wh_has_higher_priority", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorTemperatureAboveWhichWhHasHigherPriority { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Ambient Temperature above which Water Heating has the higher priority and Space H" +
                     "eating Call Can be ignored.")]
        [JsonProperty(PropertyName="ambient_temperature_above_which_wh_has_higher_priority", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AmbientTemperatureAboveWhichWhHasHigherPriority { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("0: match space cooling load in SCWH mode, 1: match water heating load in SCWH mod" +
                     "e")]
        [JsonProperty(PropertyName="flag_to_indicate_load_control_in_scwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FlagToIndicateLoadControlInScwhMode { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_speed_level_for_scwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSpeedLevelForScwhMode { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_water_flow_volume_before_switching_from_scdwh_to_scwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumWaterFlowVolumeBeforeSwitchingFromScdwhToScwhMode { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_speed_level_for_scdwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSpeedLevelForScdwhMode { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_running_time_before_allowing_electric_resistance_heat_use_during_shdwh_mo" +
                                   "de", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumRunningTimeBeforeAllowingElectricResistanceHeatUseDuringShdwhMode { get; set; } = Double.Parse("360", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_speed_level_for_shdwh_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSpeedLevelForShdwhMode { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}