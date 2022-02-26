using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Used for heating and cooling thermal comfort control with dual setpoints. The PMV" +
                 " setpoints can be scheduled and varied throughout the simulation for both heatin" +
                 "g and cooling.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty(PropertyName="fanger_thermal_comfort_heating_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FangerThermalComfortHeatingScheduleName { get; set; } = "";
        

        [Description("Schedule values should be Predicted Mean Vote (PMV)")]
        [JsonProperty(PropertyName="fanger_thermal_comfort_cooling_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FangerThermalComfortCoolingScheduleName { get; set; } = "";
    }
}