using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterSystems
{
    [Description(@"Simulates on-site water supply from a well. Well water is pumped out of the ground into a WaterUse:Storage. The operation of the ground water well is controlled by the associated WaterUse:Storage which is assumed to be operated as a vented cistern with no pressure tank.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterUse_Well : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="pump_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PumpDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="pump_rated_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PumpRatedFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="pump_rated_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PumpRatedHead { get; set; } = null;
        

        [JsonProperty(PropertyName="pump_rated_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PumpRatedPowerConsumption { get; set; } = null;
        

        [JsonProperty(PropertyName="pump_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PumpEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="well_recovery_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WellRecoveryRate { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_well_storage_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalWellStorageVolume { get; set; } = null;
        

        [JsonProperty(PropertyName="water_table_depth_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterUse_Well_WaterTableDepthMode WaterTableDepthMode { get; set; } = (WaterUse_Well_WaterTableDepthMode)Enum.Parse(typeof(WaterUse_Well_WaterTableDepthMode), "Constant");
        

        [JsonProperty(PropertyName="water_table_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterTableDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="water_table_depth_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterTableDepthScheduleName { get; set; } = "";
    }
}