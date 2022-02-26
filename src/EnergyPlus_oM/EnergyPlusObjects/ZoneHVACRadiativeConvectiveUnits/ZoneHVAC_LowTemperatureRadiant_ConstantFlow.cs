using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("Low temperature hydronic radiant heating and/or cooling system embedded in a buil" +
                 "ding surface (wall, ceiling, or floor). Controlled by varying the hot or chilled" +
                 " water temperature circulating through the unit.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_LowTemperatureRadiant_ConstantFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_object", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignObject { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of zone system is serving")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Identifies surfaces that radiant system is embedded in. For a system with multipl" +
                     "e surfaces, enter the name of a ZoneHVAC:LowTemperatureRadiant:SurfaceGroup obje" +
                     "ct.")]
        [JsonProperty(PropertyName="surface_name_or_radiant_surface_group_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceNameOrRadiantSurfaceGroupName { get; set; } = "";
        

        [Description("(total length of pipe embedded in surface)")]
        [JsonProperty(PropertyName="hydronic_tubing_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HydronicTubingLength { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Modifies the Rated Flow Rate of the pump on a time basis the default is that the pump is ON and runs according to its other operational requirements specified above. The schedule is for special pump operations. Values here are between 0 and 1 and are multipliers on the previous field (Rated Flow Rate).")]
        [JsonProperty(PropertyName="pump_flow_rate_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PumpFlowRateScheduleName { get; set; } = "";
        

        [Description("default head is 60 feet")]
        [JsonProperty(PropertyName="rated_pump_head", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedPumpHead { get; set; } = Double.Parse("179352", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="rated_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedPowerConsumption { get; set; } = null;
        

        [JsonProperty(PropertyName="heating_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingWaterOutletNodeName { get; set; } = "";
        

        [Description(@"Water and control temperatures for heating work together to provide a linear function that determines the water temperature sent to the radiant system. The current control temperature (see Temperature Control Type above) is compared to the high and low control temperatures at the current time. If the control temperature is above the high temperature, then the inlet water temperature is set to the low water temperature. If the control temperature is below the low temperature, then the inlet water temperature is set to the high water temperature. If the control temperature is between the high and low value, then the inlet water temperature is linearly interpolated between the low and high water temperature values.")]
        [JsonProperty(PropertyName="heating_high_water_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingHighWaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_low_water_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingLowWaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_high_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingHighControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_low_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingLowControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingWaterOutletNodeName { get; set; } = "";
        

        [Description("See note for Heating High Water Temperature Schedule above for interpretation inf" +
                     "ormation (or see the Input/Output Reference).")]
        [JsonProperty(PropertyName="cooling_high_water_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingHighWaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_low_water_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingLowWaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_high_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingHighControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_low_control_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingLowControlTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_circuits", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits NumberOfCircuits { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_NumberOfCircuits), "OnePerSurface");
        

        [JsonProperty(PropertyName="circuit_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CircuitLength { get; set; } = Double.Parse("106.7", CultureInfo.InvariantCulture);
    }
}