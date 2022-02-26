using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EvaporativeCoolers
{
    [Description("Indirect evaporative cooler with wetted coil, recirculating water pump, and secon" +
                 "dary air fan. This model has no controls other than its availability schedule.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EvaporativeCooler_Indirect_WetCoil : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_maximum_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoilMaximumEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="coil_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoilFlowRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="recirculating_water_pump_power_consumption", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RecirculatingWaterPumpPowerConsumption { get; set; } = null;
        

        [JsonProperty(PropertyName="secondary_air_fan_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SecondaryAirFanFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="secondary_air_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SecondaryAirFanTotalEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="secondary_air_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SecondaryAirFanDeltaPressure { get; set; } = null;
        

        [JsonProperty(PropertyName="primary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrimaryAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="primary_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PrimaryAirOutletNodeName { get; set; } = "";
        

        [Description("This field is not currently used and can be left blank")]
        [JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControlType { get; set; } = "";
        

        [JsonProperty(PropertyName="water_supply_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterSupplyStorageTankName { get; set; } = "";
        

        [Description("Enter the name of an outdoor air node")]
        [JsonProperty(PropertyName="secondary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondaryAirInletNodeName { get; set; } = "";
    }
}