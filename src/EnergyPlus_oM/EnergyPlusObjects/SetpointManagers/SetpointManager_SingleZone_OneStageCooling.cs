using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This object can be used with CoilSystem:Cooling:DX to model on/off cycling control of single stage air systems. Setpoints are modulated to run coil full on or full off depending on zone conditions. Intended for use with ZoneControl:Thermostat:StagedDualSetpoint")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_SingleZone_OneStageCooling : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This is the setpoint value applied when cooling device is to cycle ON")]
        [JsonProperty(PropertyName="cooling_stage_on_supply_air_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingStageOnSupplyAirSetpointTemperature { get; set; } = Double.Parse("-99", CultureInfo.InvariantCulture);
        

        [Description("This is the setpoint value applied when cooling device is to cycle OFF")]
        [JsonProperty(PropertyName="cooling_stage_off_supply_air_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingStageOffSupplyAirSetpointTemperature { get; set; } = Double.Parse("99", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlZoneName { get; set; } = "";
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}