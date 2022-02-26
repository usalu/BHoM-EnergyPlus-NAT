using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("This object is used to describe general scalable zone HVAC equipment sizing which" +
                 " are referenced by other objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DesignSpecification_ZoneHVAC_Sizing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the cooling supply air volume flow rate. None is used when a cooling coil is not included in the Zone HVAC Equip or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by the Zone HVAC unit and Flow Per Floor Area value specified. FractionOfAutosizedCoolingAirflow => is selected when the supply air volume is determined from a user specified fraction and the autosized cooling supply air flow rate value determined by the simulation. FlowPerCoolingCapacity => is selected when the supply air volume is determined from user specified flow per Cooling Capacity and Cooling Capacity determined by the simulation.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_CoolingSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

        [Description("Enter the magnitude of supply air volume flow rate during cooling operation. Requ" +
                     "ired field when Cooling Supply Air Flow Rate Method is SupplyAirFlowRate. This f" +
                     "ield may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the cooling supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Cooling Supply Air Flow Rate Method is FlowPerFloorArea. This" +
                     " field may be blank if a cooling coil is not included in the Zone HVAC equipment" +
                     ".")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description(@"Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAutosizedCoolingAirflow. This field may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
        [JsonProperty(PropertyName="cooling_fraction_of_autosized_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the cooling supply air volume flow rate unit cooling capacity. Required fie" +
                     "ld when Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity. This fiel" +
                     "d may be blank if a cooling coil is not included in the Zone HVAC equipment.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate_per_unit_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingSupplyAirFlowRatePerUnitCoolingCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the supply air volume flow rate When No Cooling or Heating is Required. None is used when a cooling or heating coil is not included in the Zone HVAC Equipment or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by the Zone HVAC unit and Flow Per Floor Area is specified. FractionOfAutosizedCoolingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized cooling supply air flow rate value determined by the simulation. FractionOfAutosizedHeatingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized heating supply air flow rate value determined by the simulation.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod NoLoadSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_NoLoadSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

        [Description("Enter the magnitude of the supply air volume flow rate during when no cooling or " +
                     "heating is required. Required field when No Load Supply Air Flow Rate Method is " +
                     "SupplyAirFlowRate.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the supply air volume flow rate per total floor area. Required field when N" +
                     "o Load Supply Air Flow Rate Method is FlowPerFloorArea.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
                     "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedCoolingAirflow.")]
        [JsonProperty(PropertyName="no_load_fraction_of_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NoLoadFractionOfCoolingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
                     "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
                     "osizedHeatingAirflow.")]
        [JsonProperty(PropertyName="no_load_fraction_of_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NoLoadFractionOfHeatingSupplyAirFlowRate { get; set; } = null;
        

        [Description(@"Enter the method used to determine the heating supply air volume flow rate. None is used when a heating coil is not included in the Zone HVAC Equipment or this field may be blank. SupplyAirFlowRate => selected when the magnitude of the heating supply air volume flow rate is specified. FlowPerFloorArea => selected when the supply air volume flow rate is determined from total floor area served by a Zone HVAC unit and user specified value of Flow Per Floor Area. FractionOfAutosizedHeatingAirflow => is selected when the supply air volume is determined from a user specified fraction and the Autosized heating supply air flow rate value determined by the simulation. FlowPerHeatingCapacity => is selected when the supply air volume is determined from user specified flow per Heating Capacity and Heating Capacity determined by the simulation.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_HeatingSupplyAirFlowRateMethod), "SupplyAirFlowRate");
        

        [Description("Enter the magnitude of the supply air volume flow rate during heating operation. " +
                     "Required field when Heating Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
                     "is field may be blank if a heating coil is not included in the Zone HVAC equipme" +
                     "nt.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the heating supply air volume flow rate per total conditioned floor area. R" +
                     "equired field when Heating Supply Air Flow Rate Method is FlowPerFloorArea. This" +
                     " field may be blank if a heating coil is not included in the Zone HVAC equipment" +
                     ".")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

        [Description(@"Enter the supply air volume flow rate as a fraction of the heating supply air flow rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAutosizedHeatingAirflow. This field may be blank if a heating coil is not included in the Zone HVAC equipment.")]
        [JsonProperty(PropertyName="heating_fraction_of_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingFractionOfHeatingSupplyAirFlowRate { get; set; } = null;
        

        [Description("Enter the supply air volume flow rate per unit heating capacity. Required field w" +
                     "hen Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity. This field ma" +
                     "y be blank if a heating coil is not included in the Zone HVAC equipment.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate_per_unit_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingSupplyAirFlowRatePerUnitHeatingCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. None is used when a cooling coils is not included in the Zone HVAC Equipment or this field may be blank. If this input field is left blank, then the design cooling capacity is set to zero. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determine from user specified cooling capacity per floor area and zone floor area. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity.")]
        [JsonProperty(PropertyName="cooling_design_capacity_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_CoolingDesignCapacityMethod), "None");
        

        [Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
                     "y method CoolingDesignCapacity.")]
        [JsonProperty(PropertyName="cooling_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingDesignCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the cooling design capacity per zone floor area. Required field when the co" +
                     "oling design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty(PropertyName="cooling_design_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty(PropertyName="fraction_of_autosized_cooling_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [Description(@"Enter the method used to determine the heating design capacity for scalable sizing. None is used when a heating coil is not included in the Zone HVAC Equipment or this field may be blank. If this input field is left blank, then the design heating capacity is set to zero. HeatingDesignCapacity => selected when the design heating capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determine from user specified heating capacity per flow area and zone floor area. FractionOfAutosizedHeatingCapacity => is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity")]
        [JsonProperty(PropertyName="heating_design_capacity_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod)Enum.Parse(typeof(DesignSpecification_ZoneHVAC_Sizing_HeatingDesignCapacityMethod), "None");
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
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
    }
}