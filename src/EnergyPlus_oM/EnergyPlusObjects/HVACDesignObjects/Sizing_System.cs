using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("Specifies the input needed to perform sizing calculations for a central forced ai" +
                 "r system. System design air flow, heating capacity, and cooling capacity will be" +
                 " calculated using this input data.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Sizing_System : BHoMObject
    {
        

        [JsonProperty(PropertyName="airloop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirloopName { get; set; } = "";
        

        [Description(@"Specifies the basis for sizing the system supply air flow rate Sensible and Total use the zone design air flow rates to size the system supply air flow rate The cooling coil will then be sized at either the peak Sensible or Total flow rate and conditions The heating coil is always sized at the peak sensible heating load. VentilationRequirement uses the system ventilation requirement")]
        [JsonProperty(PropertyName="type_of_load_to_size_on", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_TypeOfLoadToSizeOn TypeOfLoadToSizeOn { get; set; } = (Sizing_System_TypeOfLoadToSizeOn)Enum.Parse(typeof(Sizing_System_TypeOfLoadToSizeOn), "Sensible");
        

        [JsonProperty(PropertyName="design_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="central_heating_maximum_system_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CentralHeatingMaximumSystemAirFlowRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="preheat_design_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PreheatDesignTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="preheat_design_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PreheatDesignHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="precool_design_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PrecoolDesignTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="precool_design_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PrecoolDesignHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="central_cooling_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CentralCoolingDesignSupplyAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="central_heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CentralHeatingDesignSupplyAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="type_of_zone_sum_to_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_TypeOfZoneSumToUse TypeOfZoneSumToUse { get; set; } = (Sizing_System_TypeOfZoneSumToUse)Enum.Parse(typeof(Sizing_System_TypeOfZoneSumToUse), "NonCoincident");
        

        [JsonProperty(PropertyName="100_outdoor_air_in_cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes _100OutdoorAirInCooling { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="100_outdoor_air_in_heating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes _100OutdoorAirInHeating { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="central_cooling_design_supply_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CentralCoolingDesignSupplyAirHumidityRatio { get; set; } = Double.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="central_heating_design_supply_air_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CentralHeatingDesignSupplyAirHumidityRatio { get; set; } = Double.Parse("0.008", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (Sizing_System_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(Sizing_System_CoolingSupplyAirFlowRateMethod), "DesignDay");
        

        [Description("This input is used if Cooling Supply Air Flow Rate Method is Flow/System This val" +
                     "ue will *not* be multiplied by any sizing factor or by zone multipliers. If usin" +
                     "g zone multipliers, this value must be large enough to serve the multiplied zone" +
                     "s.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the cooling supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Cooling Supply Air Flow Rate Method is FlowPerFloorArea.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
                     "w rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedCoolingAirflow.")]
        [JsonProperty(PropertyName="cooling_fraction_of_autosized_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate per unit cooling capacity. Required field w" +
                     "hen Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate_per_unit_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="heating_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (Sizing_System_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(Sizing_System_HeatingSupplyAirFlowRateMethod), "DesignDay");
        

        [Description("Required field when Heating Supply Air Flow Rate Method is Flow/System This value" +
                     " will *not* be multiplied by any sizing factor or by zone multipliers. If using " +
                     "zone multipliers, this value must be large enough to serve the multiplied zones." +
                     "")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the heating supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Heating Supply Air Flow Rate Method is FlowPerFloorArea.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
                     "w rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedHeatingAirflow.")]
        [JsonProperty(PropertyName="heating_fraction_of_autosized_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
                     "w rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedCoolingAirflow.")]
        [JsonProperty(PropertyName="heating_fraction_of_autosized_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the heating supply air volume flow rate per unit heating capacity. Required" +
                     " field when Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate_per_unit_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="system_outdoor_air_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_SystemOutdoorAirMethod SystemOutdoorAirMethod { get; set; } = (Sizing_System_SystemOutdoorAirMethod)Enum.Parse(typeof(Sizing_System_SystemOutdoorAirMethod), "ZoneSum");
        

        [JsonProperty(PropertyName="zone_maximum_outdoor_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneMaximumOutdoorAirFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the method used to determine the system cooling design capacity for scalable sizing. None is used when a cooling coils is not included in an airloop or this field may be blank. If this input field is left blank, then the design cooling capacity is set to zero. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zones served by an airloop. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
        [JsonProperty(PropertyName="cooling_design_capacity_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (Sizing_System_CoolingDesignCapacityMethod)Enum.Parse(typeof(Sizing_System_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

        [Description("Enter the design cooling capacity.")]
        [JsonProperty(PropertyName="cooling_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingDesignCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
                     "an airloop. Required field when the cooling design capacity method field is Capa" +
                     "cityPerFloorArea.")]
        [JsonProperty(PropertyName="cooling_design_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty(PropertyName="fraction_of_autosized_cooling_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the heating design capacity for scalable sizing. None is used when a heating coil not included in an airloop or this field may be blank. If this input field is left blank, then the design heating capacity is set to zero. HeatingDesignCapacity => selected when the design heating capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design heating capacity is determined from user specified heating capacity per flow area and total floor area of heated zones served by an airloop. FractionOfAutosizedHeatingCapacity => is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity of the system.")]
        [JsonProperty(PropertyName="heating_design_capacity_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (Sizing_System_HeatingDesignCapacityMethod)Enum.Parse(typeof(Sizing_System_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

        [Description("Enter the design heating capacity.")]
        [JsonProperty(PropertyName="heating_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingDesignCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty(PropertyName="heating_design_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized heating design capacity. Required field when cap" +
                     "acity the heating design capacity method field is FractionOfAutosizedHeatingCapa" +
                     "city.")]
        [JsonProperty(PropertyName="fraction_of_autosized_heating_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfAutosizedHeatingDesignCapacity { get; set; } = null;
        

        [Description("Method used to control the coil\'s output")]
        [JsonProperty(PropertyName="central_cooling_capacity_control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_System_CentralCoolingCapacityControlMethod CentralCoolingCapacityControlMethod { get; set; } = (Sizing_System_CentralCoolingCapacityControlMethod)Enum.Parse(typeof(Sizing_System_CentralCoolingCapacityControlMethod), "OnOff");
    }
}