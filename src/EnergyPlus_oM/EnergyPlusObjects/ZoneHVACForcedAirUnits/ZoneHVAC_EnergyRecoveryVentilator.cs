using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description(@"This compound component models a stand-alone energy recovery ventilator (ERV) that conditions outdoor ventilation air and supplies that air directly to a zone. The ERV unit is modeled as a collection of components: air-to-air heat exchanger, supply air fan, exhaust air fan and an optional controller to avoid overheating of the supply air (economizer or free cooling operation).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_EnergyRecoveryVentilator : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Heat exchanger type must be HeatExchanger:AirToAir:SensibleAndLatent")]
        [JsonProperty(PropertyName="heat_exchanger_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatExchangerName { get; set; } = "";
        

        [Description("This flow rate must match the supply fan\'s air flow rate.")]
        [JsonProperty(PropertyName="supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This flow rate must match the supply fan air flow rate.")]
        [JsonProperty(PropertyName="exhaust_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> ExhaustAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Fan type must be Fan:OnOff or Fan:SystemModel")]
        [JsonProperty(PropertyName="supply_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanName { get; set; } = "";
        

        [Description("Fan type must be Fan:OnOff or Fan:SystemModel")]
        [JsonProperty(PropertyName="exhaust_air_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirFanName { get; set; } = "";
        

        [Description("Enter the name of a ZoneHVAC:EnergyRecoveryVentilator:Controller object.")]
        [JsonProperty(PropertyName="controller_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControllerName { get; set; } = "";
        

        [Description("0.000508 m3/s-m2 corresponds to 0.1 ft3/min-ft2 Used only when supply and exhaust" +
                     " air flow rates are autosized.")]
        [JsonProperty(PropertyName="ventilation_rate_per_unit_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VentilationRatePerUnitFloorArea { get; set; } = null;
        

        [Description("0.00236 m3/s-person corresponds to 5 ft3/min-person Used only when supply and exh" +
                     "aust air flow rates are autosized.")]
        [JsonProperty(PropertyName="ventilation_rate_per_occupant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VentilationRatePerOccupant { get; set; } = null;
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
    }
}