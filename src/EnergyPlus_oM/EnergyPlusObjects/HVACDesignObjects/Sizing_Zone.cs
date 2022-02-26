using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description(@"Specifies the data needed to perform a zone design air flow calculation. The calculation is done for every sizing period included in the input. The maximum cooling and heating load and cooling, heating, and ventilation air flows are then saved for system level and zone component design calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Sizing_Zone : BHoMObject
    {
        

        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(Sizing_Zone_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirTemperature { get; set; } = null;
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(Sizing_Zone_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperature { get; set; } = null;
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_cooling_design_supply_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_heating_design_supply_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="design_specification_outdoor_air_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("if blank or zero, global heating sizing factor from Sizing:Parameters is used.")]
        [JsonProperty(PropertyName="zone_heating_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("if blank or zero, global cooling sizing factor from Sizing:Parameters is used.")]
        [JsonProperty(PropertyName="zone_cooling_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingSizingFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="cooling_design_air_flow_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Zone_CoolingDesignAirFlowMethod CoolingDesignAirFlowMethod { get; set; } = (Sizing_Zone_CoolingDesignAirFlowMethod)Enum.Parse(typeof(Sizing_Zone_CoolingDesignAirFlowMethod), "DesignDay");
        

        [Description("This input is used if Cooling Design Air Flow Method is Flow/Zone This value will" +
                     " be multiplied by the global or zone sizing factor and by zone multipliers.")]
        [JsonProperty(PropertyName="cooling_design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignAirFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("default is .15 cfm/ft2 This input is used if Cooling Design Air Flow Method is De" +
                     "signDayWithLimit")]
        [JsonProperty(PropertyName="cooling_minimum_air_flow_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingMinimumAirFlowPerZoneFloorArea { get; set; } = Double.Parse("0.000762", CultureInfo.InvariantCulture);
        

        [Description("This input is used if Cooling Design Air Flow Method is DesignDayWithLimit")]
        [JsonProperty(PropertyName="cooling_minimum_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingMinimumAirFlow { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("fraction of the Cooling design Air Flow Rate This input is currently used in sizi" +
                     "ng the VAV air terminal unit and fan minimum flow rate It does not currently aff" +
                     "ect other component autosizing.")]
        [JsonProperty(PropertyName="cooling_minimum_air_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingMinimumAirFlowFraction { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heating_design_air_flow_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Zone_HeatingDesignAirFlowMethod HeatingDesignAirFlowMethod { get; set; } = (Sizing_Zone_HeatingDesignAirFlowMethod)Enum.Parse(typeof(Sizing_Zone_HeatingDesignAirFlowMethod), "DesignDay");
        

        [Description("This input is used if Heating Design Air Flow Method is Flow/Zone. This value wil" +
                     "l be multiplied by the global or zone sizing factor and by zone multipliers.")]
        [JsonProperty(PropertyName="heating_design_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingDesignAirFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("default is .40 cfm/ft2 This field is used to size the heating design flow rate wh" +
                     "en Heating Design Air Flow Method = Flow/Zone. This input is used for autosizing" +
                     " components when Heating Design Air Flow Method = DesignDayWithLimit.")]
        [JsonProperty(PropertyName="heating_maximum_air_flow_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingMaximumAirFlowPerZoneFloorArea { get; set; } = Double.Parse("0.002032", CultureInfo.InvariantCulture);
        

        [Description("default is 300 cfm This input is used for autosizing components when Heating Desi" +
                     "gn Air Flow Method = DesignDayWithLimit.")]
        [JsonProperty(PropertyName="heating_maximum_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingMaximumAirFlow { get; set; } = Double.Parse("0.1415762", CultureInfo.InvariantCulture);
        

        [Description("fraction of the Heating Design Air Flow Rate This input is used for autosizing co" +
                     "mponents when Heating Design Air Flow Method = DesignDayWithLimit.")]
        [JsonProperty(PropertyName="heating_maximum_air_flow_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingMaximumAirFlowFraction { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_specification_zone_air_distribution_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [Description("account for effect of dedicated outdoor air system supplying air directly to the " +
                     "zone")]
        [JsonProperty(PropertyName="account_for_dedicated_outdoor_air_system", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes AccountForDedicatedOutdoorAirSystem { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("1)supply neutral ventilation air; 2)supply neutral dehumidified and reheated vent" +
                     "ilation air; 3)supply cold ventilation air")]
        [JsonProperty(PropertyName="dedicated_outdoor_air_system_control_strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy DedicatedOutdoorAirSystemControlStrategy { get; set; } = (Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy)Enum.Parse(typeof(Sizing_Zone_DedicatedOutdoorAirSystemControlStrategy), "NeutralSupplyAir");
        

        [JsonProperty(PropertyName="dedicated_outdoor_air_low_setpoint_temperature_for_design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DedicatedOutdoorAirLowSetpointTemperatureForDesign { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dedicated_outdoor_air_high_setpoint_temperature_for_design", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DedicatedOutdoorAirHighSetpointTemperatureForDesign { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}