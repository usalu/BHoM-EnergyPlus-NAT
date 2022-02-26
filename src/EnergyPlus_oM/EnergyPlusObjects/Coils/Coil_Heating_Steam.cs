using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("Steam heating coil. Condenses and sub-cools steam at loop pressure and discharges" +
                 " condensate through steam traps to low pressure condensate line.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Heating_Steam : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_steam_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSteamFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="degree_of_subcooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DegreeOfSubcooling { get; set; } = null;
        

        [JsonProperty(PropertyName="degree_of_loop_subcooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DegreeOfLoopSubcooling { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Use ZoneLoadControl if the coil is contained within another component such as an " +
                     "air terminal unit, zone HVAC equipment, or unitary system. Use TemperatureSetpoi" +
                     "ntControl if the coil is located directly in an air loop branch or outdoor air e" +
                     "quipment list.")]
        [JsonProperty(PropertyName="coil_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Heating_Steam_CoilControlType CoilControlType { get; set; } = (Coil_Heating_Steam_CoilControlType)Enum.Parse(typeof(Coil_Heating_Steam_CoilControlType), "TemperatureSetpointControl");
        

        [Description("Required if Coil Control Type is TemperatureSetpointControl")]
        [JsonProperty(PropertyName="temperature_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemperatureSetpointNodeName { get; set; } = "";
    }
}