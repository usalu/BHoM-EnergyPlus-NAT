using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
                 "roups to the end of the list")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_CoolingPanel_RadiantConvective_Water : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="rated_inlet_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedInletWaterTemperature { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_inlet_space_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedInletSpaceTemperature { get; set; } = Double.Parse("24", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_water_mass_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedWaterMassFlowRate { get; set; } = Double.Parse("0.063", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the method used to determine the cooling design capacity for scalable sizing. CoolingDesignCapacity => selected when the design cooling capacity value is specified or auto-sized. CapacityPerFloorArea => selected when the design cooling capacity is determined from user specified cooling capacity per floor area and total floor area of cooled zone served by the hydrolic unit. FractionOfAutosizedCoolingCapacity => is selected when the design cooling capacity is determined from a user specified fraction and the auto-sized design cooling capacity of the system.")]
        [JsonProperty(PropertyName="cooling_design_capacity_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod CoolingDesignCapacityMethod { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_CoolingDesignCapacityMethod), "CoolingDesignCapacity");
        

        [Description("Enter the design cooling capacity. Required field when the cooling design capacit" +
                     "y method CoolingDesignCapacity.")]
        [JsonProperty(PropertyName="cooling_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingDesignCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the cooling design capacity per total floor area of cooled zones served by " +
                     "the unit. Required field when the cooling design capacity method field is Capaci" +
                     "tyPerFloorArea.")]
        [JsonProperty(PropertyName="cooling_design_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of auto-sized cooling design capacity. Required field when the" +
                     " cooling design capacity method field is FractionOfAutosizedCoolingCapacity.")]
        [JsonProperty(PropertyName="fraction_of_autosized_cooling_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfAutosizedCoolingDesignCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_chilled_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumChilledWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Temperature on which unit is controlled")]
        [JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType ControlType { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_ControlType), "MeanAirTemperature");
        

        [JsonProperty(PropertyName="cooling_control_throttling_range", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingControlThrottlingRange { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="condensation_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_CoolingPanel_RadiantConvective_Water_CondensationControlType), "SimpleOff");
        

        [JsonProperty(PropertyName="condensation_control_dewpoint_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondensationControlDewpointOffset { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_radiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionRadiant { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_of_radiant_energy_incident_on_people", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_fractions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_CoolingPanel_RadiantConvective_Water_SurfaceFractions_Item> SurfaceFractions { get; set; } = null;
    }
}