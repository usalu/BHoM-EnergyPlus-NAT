using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description(@"Plant equipment operation scheme for outdoor dewpoint temperature difference operation. Specifies one or more groups of equipment which are available to operate for successive ranges based the difference between a reference node temperature and the outdoor dewpoint temperature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_OutdoorDewpointDifference : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_temperature_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReferenceTemperatureNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_1_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange1LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_1_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange1UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_1_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_2_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange2LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_2_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange2UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_2_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_3_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange3LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_3_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange3UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_3_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_4_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange4LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_4_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange4UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_4_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_5_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange5LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_5_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange5UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_5_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_6_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange6LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_6_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange6UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_6_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_7_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange7LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_7_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange7UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_7_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_8_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange8LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_8_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange8UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_8_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_9_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange9LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_9_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange9UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_9_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_10_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange10LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_difference_range_10_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureDifferenceRange10UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_10_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range10EquipmentListName { get; set; } = "";
    }
}