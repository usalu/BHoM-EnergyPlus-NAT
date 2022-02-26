using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Variable refrigerant flow (VRF) direct expansion (DX) heating coil (air-to-air he" +
                 "at pump). Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Condensing un" +
                 "it is modeled separately, see AirConditioner:VariableRefrigerantFlow.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Heating_DX_VariableRefrigerantFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilitySchedule { get; set; } = "";
        

        [Description(@"Heating capacity not accounting for the effect of supply air fan heat capacity excluding supply air fan heat rating point outside dry-bulb temp 8.33 C, outside wet-bulb temp 6.11 C rating point heating coil entering air dry-bulb 21.11 C, coil entering wetbulb 15.55 C")]
        [JsonProperty(PropertyName="gross_rated_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossRatedHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("volume flow rate corresponding to rated total capacity should be between 0.000040" +
                     "27 m3/s and .00006041 m3/s per watt of rated heating capacity")]
        [JsonProperty(PropertyName="rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coil_air_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilAirInletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_air_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilAirOutletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_capacity_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="heating_capacity_modifier_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCapacityModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
}