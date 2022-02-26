using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for component setpoint operation. Specifies one " +
                 "or pieces of equipment which are controlled to meet the temperature setpoint at " +
                 "the component outlet node.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_ComponentSetpoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment1ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_1_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation1NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_1_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint1NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_1_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component1FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_1_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation1Type Operation1Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation1Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation1Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment2ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_2_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation2NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_2_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint2NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_2_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component2FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_2_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation2Type Operation2Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation2Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation2Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment3ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_3_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation3NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_3_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint3NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_3_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component3FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_3_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation3Type Operation3Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation3Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation3Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment4ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_4_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation4NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_4_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint4NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_4_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component4FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_4_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation4Type Operation4Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation4Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation4Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_5_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment5ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_5_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation5NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_5_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint5NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_5_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component5FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_5_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation5Type Operation5Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation5Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation5Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_6_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment6ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_6_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation6NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_6_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint6NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_6_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component6FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_6_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation6Type Operation6Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation6Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation6Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_7_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment7ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_7_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation7NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_7_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint7NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_7_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component7FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_7_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation7Type Operation7Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation7Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation7Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_8_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment8ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_8_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation8NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_8_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint8NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_8_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component8FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_8_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation8Type Operation8Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation8Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation8Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_9_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment9ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment9Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_9_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation9NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_9_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint9NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_9_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component9FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_9_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation9Type Operation9Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation9Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation9Type), "Cooling");
        

        [JsonProperty(PropertyName="equipment_10_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment10ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment10Name { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_calculation_10_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DemandCalculation10NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="setpoint_10_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Setpoint10NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_10_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component10FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="operation_10_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ComponentSetpoint_Operation10Type Operation10Type { get; set; } = (PlantEquipmentOperation_ComponentSetpoint_Operation10Type)Enum.Parse(typeof(PlantEquipmentOperation_ComponentSetpoint_Operation10Type), "Cooling");
    }
}