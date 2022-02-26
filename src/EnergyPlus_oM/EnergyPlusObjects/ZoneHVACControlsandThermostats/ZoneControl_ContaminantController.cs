using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used to control a zone to a specified indoor level of CO2 or generic contaminants" +
                 ", or to specify minimum CO2 concentration schedule name for a zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_ContaminantController : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Availability schedule name for CO2 controller. Schedule value > 0 means the CO2 c" +
                     "ontroller is enabled. If this field is blank, then CO2 controller is always enab" +
                     "led.")]
        [JsonProperty(PropertyName="carbon_dioxide_control_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CarbonDioxideControlAvailabilityScheduleName { get; set; } = "";
        

        [Description("Schedule values should be carbon dioxide concentration in parts per million (ppm)" +
                     "")]
        [JsonProperty(PropertyName="carbon_dioxide_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CarbonDioxideSetpointScheduleName { get; set; } = "";
        

        [Description(@"Schedule values should be carbon dioxide concentration in parts per million (ppm) This field is used when the field System Outdoor Air Method = ProportionalControlBasedOnOccupancySchedule or ProportionalControlBasedOnDesignOccupancy, or ProportionalControlBasedOnDesignOARate in Controller:MechanicalVentilation")]
        [JsonProperty(PropertyName="minimum_carbon_dioxide_concentration_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumCarbonDioxideConcentrationScheduleName { get; set; } = "";
        

        [Description(@"Schedule values should be carbon dioxide concentration in parts per million (ppm) This field is used when the field System Outdoor Air Method = ProportionalControlBasedOnOccupancySchedule or ProportionalControlBasedOnDesignOccupancy or ProportionalControlBasedOnDesignOARate.")]
        [JsonProperty(PropertyName="maximum_carbon_dioxide_concentration_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumCarbonDioxideConcentrationScheduleName { get; set; } = "";
        

        [Description("Availability schedule name for generic contaminant controller. Schedule value > 0" +
                     " means the generic contaminant controller is enabled. If this field is blank, th" +
                     "en generic contaminant controller is always enabled.")]
        [JsonProperty(PropertyName="generic_contaminant_control_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GenericContaminantControlAvailabilityScheduleName { get; set; } = "";
        

        [Description("Schedule values should be generic contaminant concentration in parts per million " +
                     "(ppm) This field is used when the field System Outdoor Air Method = IndoorAirQua" +
                     "lityProcedureGenericContaminant in Controller:MechanicalVentilation")]
        [JsonProperty(PropertyName="generic_contaminant_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GenericContaminantSetpointScheduleName { get; set; } = "";
    }
}