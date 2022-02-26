using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("Chilled water storage with a well-mixed, single-node tank. The chilled water is \"" +
                 "used\" by drawing from the \"Use Side\" of the water tank. The tank is indirectly c" +
                 "harged by circulating cold water through the \"Source Side\" of the water tank.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermalStorage_ChilledWater_Mixed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="tank_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankVolume { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="deadband_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeadbandTemperatureDifference { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumTemperatureLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="ambient_temperature_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator AmbientTemperatureIndicator { get; set; } = (ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator)Enum.Parse(typeof(ThermalStorage_ChilledWater_Mixed_AmbientTemperatureIndicator), "Outdoors");
        

        [JsonProperty(PropertyName="ambient_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="ambient_temperature_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureZoneName { get; set; } = "";
        

        [Description("required when field Ambient Temperature Indicator=Outdoors")]
        [JsonProperty(PropertyName="ambient_temperature_outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AmbientTemperatureOutdoorAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_gain_coefficient_from_ambient_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatGainCoefficientFromAmbientTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="use_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="use_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="use_side_heat_transfer_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UseSideHeatTransferEffectiveness { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for use side. Schedule value > 0 means the system is a" +
                     "vailable. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="use_side_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UseSideAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="use_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> UseSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="source_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_heat_transfer_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideHeatTransferEffectiveness { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Availability schedule name for source side. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="source_side_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SourceSideDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Parameter for autosizing design flow rates for indirectly cooled water tanks time" +
                     " required to lower temperature of entire tank from 14.4C to 9.0C")]
        [JsonProperty(PropertyName="tank_recovery_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankRecoveryTime { get; set; } = Double.Parse("4", CultureInfo.InvariantCulture);
    }
}