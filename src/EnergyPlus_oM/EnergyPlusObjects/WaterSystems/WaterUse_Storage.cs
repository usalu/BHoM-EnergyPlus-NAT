using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description(@"A water storage tank. If the building model is to include any on-site water collection, wells, or storing and reuse of graywater, then a WaterUse:Storage object is needed. Each WaterUse:Storage can serve as a central node and make connections to numerous sources of supply or numerous components with demand. If a maximum capacity is not specified, the tank is assumed to have unlimited capacity.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Storage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_quality_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterQualitySubcategory { get; set; } = "";
        

        [Description("Defaults to unlimited capacity.")]
        [JsonProperty(PropertyName="maximum_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="initial_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialVolume { get; set; } = null;
        

        [Description("Defaults to unlimited flow.")]
        [JsonProperty(PropertyName="design_in_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignInFlowRate { get; set; } = null;
        

        [Description("Defaults to unlimited flow.")]
        [JsonProperty(PropertyName="design_out_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignOutFlowRate { get; set; } = null;
        

        [Description("If blank, overflow is discarded")]
        [JsonProperty(PropertyName="overflow_destination", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OverflowDestination { get; set; } = "";
        

        [JsonProperty(PropertyName="type_of_supply_controlled_by_float_valve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Storage_TypeOfSupplyControlledByFloatValve TypeOfSupplyControlledByFloatValve { get; set; } = (WaterUse_Storage_TypeOfSupplyControlledByFloatValve)Enum.Parse(typeof(WaterUse_Storage_TypeOfSupplyControlledByFloatValve), "GroundwaterWell");
        

        [Description("Lower range of target storage level e.g. float valve kicks on")]
        [JsonProperty(PropertyName="float_valve_on_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FloatValveOnCapacity { get; set; } = null;
        

        [Description("Upper range of target storage level e.g. float valve kicks off")]
        [JsonProperty(PropertyName="float_valve_off_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FloatValveOffCapacity { get; set; } = null;
        

        [Description("Lower range of secondary target storage level used to keep tanks at a minimum lev" +
                     "el using mains water if well can\'t keep up")]
        [JsonProperty(PropertyName="backup_mains_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BackupMainsCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="other_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OtherTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_thermal_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Storage_WaterThermalMode WaterThermalMode { get; set; } = (WaterUse_Storage_WaterThermalMode)Enum.Parse(typeof(WaterUse_Storage_WaterThermalMode), "ScheduledTemperature");
        

        [JsonProperty(PropertyName="water_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="ambient_temperature_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Storage_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (WaterUse_Storage_AmbientTemperatureIndicator)Enum.Parse(typeof(WaterUse_Storage_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty(PropertyName="ambient_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="tank_surface_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankSurfaceArea { get; set; } = null;
        

        [JsonProperty(PropertyName="tank_u_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankUValue { get; set; } = null;
        

        [JsonProperty(PropertyName="tank_outside_surface_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TankOutsideSurfaceMaterialName { get; set; } = "";
    }
}