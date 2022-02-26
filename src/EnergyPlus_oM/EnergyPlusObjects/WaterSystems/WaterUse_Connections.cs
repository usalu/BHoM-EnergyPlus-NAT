using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description(@"A subsystem that groups together multiple WaterUse:Equipment components. As its name suggests, the object provides connections that are shared by these components, including: 1. Inlet node and outlet node connections to a plant loop 2. Connections to WaterUse:Storage objects to store and draw reclaimed water 3. Internal connections to simulate drainwater heat recovery.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Connections : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [Description("If blank, or tank is empty, defaults to fresh water from the mains")]
        [JsonProperty(PropertyName="supply_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="reclamation_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReclamationWaterStorageTankName { get; set; } = "";
        

        [Description("Defaults to cold water supply temperature")]
        [JsonProperty(PropertyName="hot_water_supply_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HotWaterSupplyTemperatureScheduleName { get; set; } = "";
        

        [Description("Defaults to water temperatures calculated by Site:WaterMainsTemperature object")]
        [JsonProperty(PropertyName="cold_water_supply_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ColdWaterSupplyTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="drain_water_heat_exchanger_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Connections_DrainWaterHeatExchangerType DrainWaterHeatExchangerType { get; set; } = (WaterUse_Connections_DrainWaterHeatExchangerType)Enum.Parse(typeof(WaterUse_Connections_DrainWaterHeatExchangerType), "None");
        

        [JsonProperty(PropertyName="drain_water_heat_exchanger_destination", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Connections_DrainWaterHeatExchangerDestination DrainWaterHeatExchangerDestination { get; set; } = (WaterUse_Connections_DrainWaterHeatExchangerDestination)Enum.Parse(typeof(WaterUse_Connections_DrainWaterHeatExchangerDestination), "Plant");
        

        [JsonProperty(PropertyName="drain_water_heat_exchanger_u_factor_times_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DrainWaterHeatExchangerUFactorTimesArea { get; set; } = null;
        

        [Description("This list is the WaterUseEquipmentNames object-list")]
        [JsonProperty(PropertyName="connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Connections { get; set; } = null;
    }
}