using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description("Packaged terminal air conditioner (PTAC). Forced-convection heating-cooling unit " +
                 "with supply fan, direct expansion (DX) cooling coil, heating coil (gas, electric" +
                 ", hot water, or steam) and fixed-position outdoor air mixer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_PackagedTerminalAirConditioner : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available. Schedule va" +
                     "lues of 0 denote the unit is off.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Air inlet node for the PTAC must be a zone air exhaust Node.")]
        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Air outlet node for the PTAC must be a zone air inlet node.")]
        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Currently only one OutdoorAir:Mixer object type is available. This field should b" +
                     "e left blank if the PTAC is connected to central dedicated outdoor air through a" +
                     "n AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty(PropertyName="outdoor_air_mixer_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_PackagedTerminalAirConditioner_OutdoorAirMixerObjectType OutdoorAirMixerObjectType { get; set; } = (ZoneHVAC_PackagedTerminalAirConditioner_OutdoorAirMixerObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalAirConditioner_OutdoorAirMixerObjectType), "OutdoorAirMixer");
        

        [Description(@"If this field is blank, the OutdoorAir:Mixer is not used. This optional field specifies the name of the OutdoorAir:Mixer object. When used, this name needs to match name of the OutdoorAir:Mixer object. This field should be left blank if the PTAC is connected to central dedicated outdoor air through an AirTerminal:SingleDuct:Mixer object.")]
        [JsonProperty(PropertyName="outdoor_air_mixer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirMixerName { get; set; } = "";
        

        [Description("Must be less than or equal to fan size.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Must be less than or equal to fan size.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Must be less than or equal to fan size. Only used when supply air fan operating mode schedule values specify continuous fan (schedule values greater than 0 specify continuous fan operation). This air flow rate is used when no heating or cooling is required and the cooling or heating coil is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Must be less than or equal to supply air flow rate during cooling operation. This" +
                     " field is set to zero flow when the PTAC is connected to central dedicated outdo" +
                     "or air through air terminal single duct mixer object.")]
        [JsonProperty(PropertyName="cooling_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Must be less than or equal to supply air flow rate during heating operation. This" +
                     " field is set to zero flow when the PTAC is connected to central dedicated outdo" +
                     "or air through air terminal single duct mixer object.")]
        [JsonProperty(PropertyName="heating_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Only used when supply air fan operating mode schedule values specify continuous fan (schedule values greater than 0 specify continuous fan operation). This air flow rate is used when no heating or cooling is required and the cooling or heating coil is off. If this field is left blank or zero, the outdoor air flow rate from the previous on cycle (either cooling or heating) is used. This field is set to zero flow when the PTAC is connected to central dedicated outdoor air through air terminal single duct mixer object.")]
        [JsonProperty(PropertyName="no_load_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Fan:ConstantVolume only works when continuous fan operation is used the entire simulation (all supply air fan operating mode schedule values are greater than 0). If any fan operating mode schedule values are 0 a Fan:SystemModel or Fan:OnOff object must be used.")]
        [JsonProperty(PropertyName="supply_air_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_PackagedTerminalAirConditioner_SupplyAirFanObjectType SupplyAirFanObjectType { get; set; } = (ZoneHVAC_PackagedTerminalAirConditioner_SupplyAirFanObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalAirConditioner_SupplyAirFanObjectType), "FanConstantVolume");
        

        [Description("Needs to match in the fan object.")]
        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description("Select the type of heating coil.")]
        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_PackagedTerminalAirConditioner_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (ZoneHVAC_PackagedTerminalAirConditioner_HeatingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalAirConditioner_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [Description("Needs to match in the heating coil object.")]
        [JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Select the type of Cooling Coil. Only works with Coil:Cooling:DX:SingleSpeed or C" +
                     "oilSystem:Cooling:DX:HeatExchangerAssisted or Coil:Cooling:DX:VariableSpeed.")]
        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_PackagedTerminalAirConditioner_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (ZoneHVAC_PackagedTerminalAirConditioner_CoolingCoilObjectType)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalAirConditioner_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [Description("Needs to match a DX cooling coil object.")]
        [JsonProperty(PropertyName="cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilName { get; set; } = "";
        

        [Description("Select fan placement as either blow through or draw through.")]
        [JsonProperty(PropertyName="fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_PackagedTerminalAirConditioner_FanPlacement FanPlacement { get; set; } = (ZoneHVAC_PackagedTerminalAirConditioner_FanPlacement)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalAirConditioner_FanPlacement), "DrawThrough");
        

        [Description(@"Enter the name of a schedule that controls fan operation. Schedule Name values of 0 denote cycling fan operation (fan cycles with cooling or heating coil). Schedule Name values greater than 0 denote constant fan operation (fan runs continually regardless of coil operation).")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Enter the name of a DesignSpecificationZoneHVACSizing object.")]
        [JsonProperty(PropertyName="design_specification_zonehvac_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZonehvacSizingObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="capacity_control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_PackagedTerminalAirConditioner_CapacityControlMethod CapacityControlMethod { get; set; } = (ZoneHVAC_PackagedTerminalAirConditioner_CapacityControlMethod)Enum.Parse(typeof(ZoneHVAC_PackagedTerminalAirConditioner_CapacityControlMethod), "None");
        

        [Description("For Capacity Control Method = SingleZoneVAV, enter the minimum air temperature li" +
                     "mit for reduced fan speed.")]
        [JsonProperty(PropertyName="minimum_supply_air_temperature_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumSupplyAirTemperatureInCoolingMode { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("For Capacity Control Method = SingleZoneVAV, enter the maximum air temperature li" +
                     "mit for reduced fan speed.")]
        [JsonProperty(PropertyName="maximum_supply_air_temperature_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSupplyAirTemperatureInHeatingMode { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
    }
}