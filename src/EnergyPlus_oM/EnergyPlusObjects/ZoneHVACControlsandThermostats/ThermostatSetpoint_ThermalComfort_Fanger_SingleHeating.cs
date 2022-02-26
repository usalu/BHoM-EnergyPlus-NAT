using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for heating only thermal comfort control. The PMV setpoint can be scheduled " +
                 "and varied throughout the simulation but only heating is allowed with this contr" +
                 "ol type.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty(PropertyName="fanger_thermal_comfort_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FangerThermalComfortScheduleName { get; set; } = "";
    }
}