using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("Models vertical ground heat exchangers systems using the response factor approach" +
                 " developed by Eskilson. Response factors are calculated using a finite line sour" +
                 "ce model assuming uniform heat flux at the borehole wall.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_System : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType UndisturbedGroundTemperatureModelType { get; set; } = (GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType)Enum.Parse(typeof(GroundHeatExchanger_System_UndisturbedGroundTemperatureModelType), "SiteGroundTemperatureUndisturbedFiniteDifference");
        

        [JsonProperty(PropertyName="undisturbed_ground_temperature_model_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UndisturbedGroundTemperatureModelName { get; set; } = "";
        

        [JsonProperty(PropertyName="ground_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="ground_thermal_heat_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundThermalHeatCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="ghe_vertical_responsefactors_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GheVerticalResponsefactorsObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="ghe_vertical_array_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GheVerticalArrayObjectName { get; set; } = "";
        

        [Description("This list is the GroundHeatExchangerVerticalSingleNames object-list")]
        [JsonProperty(PropertyName="vertical_well_locations", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> VerticalWellLocations { get; set; } = null;
    }
}