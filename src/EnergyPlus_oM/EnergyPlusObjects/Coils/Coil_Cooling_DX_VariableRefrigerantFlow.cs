using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Variable refrigerant flow (VRF) direct expansion (DX) cooling coil. Used with Zon" +
                 "eHVAC:TerminalUnit:VariableRefrigerantFlow. Condensing unit is modeled separatel" +
                 "y, see AirConditioner:VariableRefrigerantFlow.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX_VariableRefrigerantFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Cooli" +
                     "ng capacity excluding supply air fan heat")]
        [JsonProperty(PropertyName="gross_rated_total_cooling_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossRatedTotalCoolingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Sensible heat ratio excluding supply air fan heat")]
        [JsonProperty(PropertyName="gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Volume flow rate corresponding to rated total cooling capacity should be between " +
                     "0.00004027 m3/s and .00006041 m3/s per watt of rated total cooling capacity")]
        [JsonProperty(PropertyName="rated_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_capacity_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCapacityRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = fraction of the full load flow")]
        [JsonProperty(PropertyName="cooling_capacity_modifier_curve_function_of_flow_fraction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCapacityModifierCurveFunctionOfFlowFractionName { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_air_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilAirInletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_air_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilAirOutletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="name_of_water_storage_tank_for_condensate_collection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NameOfWaterStorageTankForCondensateCollection { get; set; } = "";
    }
}