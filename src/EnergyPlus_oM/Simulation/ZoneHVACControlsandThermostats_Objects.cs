using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Zone HVAC Controls and Thermostats")]
    public class ZoneHVACControlsandThermostats_Objects : BHoMObject
    {
        
        public bool ShouldSerializeZoneControl_Humidistat_List()
        {
            return (ZoneControl_Humidistat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:Humidistat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Humidistat> ZoneControl_Humidistat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Humidistat> ();
        
        public bool ShouldSerializeZoneControl_Thermostat_List()
        {
            return (ZoneControl_Thermostat_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:Thermostat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat> ZoneControl_Thermostat_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat> ();
        
        public bool ShouldSerializeZoneControl_Thermostat_OperativeTemperature_List()
        {
            return (ZoneControl_Thermostat_OperativeTemperature_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:Thermostat:OperativeTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_OperativeTemperature> ZoneControl_Thermostat_OperativeTemperature_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_OperativeTemperature> ();
        
        public bool ShouldSerializeZoneControl_Thermostat_ThermalComfort_List()
        {
            return (ZoneControl_Thermostat_ThermalComfort_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:Thermostat:ThermalComfort", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_ThermalComfort> ZoneControl_Thermostat_ThermalComfort_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_ThermalComfort> ();
        
        public bool ShouldSerializeZoneControl_Thermostat_TemperatureAndHumidity_List()
        {
            return (ZoneControl_Thermostat_TemperatureAndHumidity_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:Thermostat:TemperatureAndHumidity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_TemperatureAndHumidity> ZoneControl_Thermostat_TemperatureAndHumidity_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_TemperatureAndHumidity> ();
        
        public bool ShouldSerializeThermostatSetpoint_SingleHeating_List()
        {
            return (ThermostatSetpoint_SingleHeating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:SingleHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeating> ThermostatSetpoint_SingleHeating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeating> ();
        
        public bool ShouldSerializeThermostatSetpoint_SingleCooling_List()
        {
            return (ThermostatSetpoint_SingleCooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:SingleCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleCooling> ThermostatSetpoint_SingleCooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleCooling> ();
        
        public bool ShouldSerializeThermostatSetpoint_SingleHeatingOrCooling_List()
        {
            return (ThermostatSetpoint_SingleHeatingOrCooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:SingleHeatingOrCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeatingOrCooling> ThermostatSetpoint_SingleHeatingOrCooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_SingleHeatingOrCooling> ();
        
        public bool ShouldSerializeThermostatSetpoint_DualSetpoint_List()
        {
            return (ThermostatSetpoint_DualSetpoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_DualSetpoint> ThermostatSetpoint_DualSetpoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_DualSetpoint> ();
        
        public bool ShouldSerializeThermostatSetpoint_ThermalComfort_Fanger_SingleHeating_List()
        {
            return (ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating> ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeating> ();
        
        public bool ShouldSerializeThermostatSetpoint_ThermalComfort_Fanger_SingleCooling_List()
        {
            return (ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:SingleCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling> ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleCooling> ();
        
        public bool ShouldSerializeThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling_List()
        {
            return (ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:SingleHeatingOrCooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling> ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_SingleHeatingOrCooling> ();
        
        public bool ShouldSerializeThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint_List()
        {
            return (ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermostatSetpoint:ThermalComfort:Fanger:DualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint> ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ThermostatSetpoint_ThermalComfort_Fanger_DualSetpoint> ();
        
        public bool ShouldSerializeZoneControl_Thermostat_StagedDualSetpoint_List()
        {
            return (ZoneControl_Thermostat_StagedDualSetpoint_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:Thermostat:StagedDualSetpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_StagedDualSetpoint> ZoneControl_Thermostat_StagedDualSetpoint_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_Thermostat_StagedDualSetpoint> ();
        
        public bool ShouldSerializeZoneControl_ContaminantController_List()
        {
            return (ZoneControl_ContaminantController_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneControl:ContaminantController", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_ContaminantController> ZoneControl_ContaminantController_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats.ZoneControl_ContaminantController> ();
    }
}