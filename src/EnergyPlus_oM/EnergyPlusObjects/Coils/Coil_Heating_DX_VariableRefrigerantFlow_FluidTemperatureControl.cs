using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"This is a key object in the new physics based VRF model applicable for Fluid Temperature Control. It describes the the indoor unit coil of the system at heating mode. Used with ZoneHVAC:TerminalUnit:VariableRefrigerantFlow. Outdoor unit is modeled separately, see AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl or AirConditioner:VariableRefrigerantFlow:FluidTemperatureControl:HR")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a schedule that defines the availability of the coil Schedule v" +
                     "alues of 0 denote the unit is off. All other values denote the unit is available" +
                     " If this field is left blank, the unit is available the entire simulation")]
        [JsonProperty(PropertyName="availability_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilitySchedule { get; set; } = "";
        

        [Description("the inlet node to the coil")]
        [JsonProperty(PropertyName="coil_air_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilAirInletNode { get; set; } = "";
        

        [Description("the outlet node to the coil")]
        [JsonProperty(PropertyName="coil_air_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilAirOutletNode { get; set; } = "";
        

        [Description("Supply air fan heat is not included")]
        [JsonProperty(PropertyName="rated_total_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedTotalHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="indoor_unit_reference_subcooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorUnitReferenceSubcooling { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="indoor_unit_condensing_temperature_function_of_subcooling_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IndoorUnitCondensingTemperatureFunctionOfSubcoolingCurveName { get; set; } = "";
    }
}