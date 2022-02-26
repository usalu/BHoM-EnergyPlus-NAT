using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Window air conditioner. Forced-convection cooling-only unit with supply fan, dire" +
                 "ct expansion (DX) cooling coil, and fixed-position outdoor air mixer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_WindowAirConditioner : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("currently only one OutdoorAir:Mixer object type is available.")]
        [JsonProperty(PropertyName="outdoor_air_mixer_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (ZoneHVAC_WindowAirConditioner_OutdoorAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [JsonProperty(PropertyName="outdoor_air_mixer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description(@"Fan:ConstantVolume only works when continuous fan operation is used the entire simulation (all supply air fan operating mode schedule values are greater than 0). If any fan operating mode schedule values are 0 a Fan:SystemModel or Fan:OnOff object must be used.")]
        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_WindowAirConditioner_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Fan type Fan:ConstantVolume is used with continuous fan and fan type Fan:OnOff is" +
                     " used with cycling Fan.")]
        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_WindowAirConditioner_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty(PropertyName="dx_cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DxCoolingCoilName { get; set; } = "";
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule Name values of 0 denote cycling fan operation (fan cycles with cooling coil). Schedule values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation). The fan operating mode defaults to cycling fan operation if this field is left blank.")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_WindowAirConditioner_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_WindowAirConditioner_FanPlacement)Enum.Parse(typeof(ZoneHVAC_WindowAirConditioner_FanPlacement), "BlowThrough");
        

        [JsonProperty(PropertyName="cooling_convergence_tolerance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingConvergenceTolerance { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
    }
}