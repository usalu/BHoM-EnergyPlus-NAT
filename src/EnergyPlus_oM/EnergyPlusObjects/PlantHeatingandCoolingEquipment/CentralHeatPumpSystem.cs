using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"This chiller bank can contain multiple chiller heaters and heat pump performance objects. Its function is to encapsulate the extra controls needed to turn individual modules on/off and whether they are to operate in cooling-only, heating-only or simultaneous cooling/heating mode and whether to connect the source water to the evaporator or condenser side.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class CentralHeatPumpSystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ControlMethod ControlMethod { get; set; } = (CentralHeatPumpSystem_ControlMethod)Enum.Parse(typeof(CentralHeatPumpSystem_ControlMethod), "SmartMixing");
        

        [JsonProperty(PropertyName="cooling_loop_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingLoopInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_loop_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingLoopOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_loop_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceLoopInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_loop_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceLoopOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_loop_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingLoopInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_loop_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingLoopOutletNodeName { get; set; } = "";
        

        [Description("Power as demanded from any auxiliary controls")]
        [JsonProperty(PropertyName="ancillary_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This value from this schedule is multiplied times the Ancillary Power")]
        [JsonProperty(PropertyName="ancillary_operation_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AncillaryOperationScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType1 ChillerHeaterModulesPerformanceComponentObjectType1 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType1)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType1), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName1 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName1 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules1 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType2 ChillerHeaterModulesPerformanceComponentObjectType2 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType2)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType2), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName2 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName2 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules2 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_performance_component_object_type_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterPerformanceComponentObjectType3 ChillerHeaterPerformanceComponentObjectType3 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterPerformanceComponentObjectType3)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterPerformanceComponentObjectType3), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_performance_component_name_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterPerformanceComponentName3 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName3 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules3 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType4 ChillerHeaterModulesPerformanceComponentObjectType4 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType4)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType4), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName4 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName4 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules4 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType5 ChillerHeaterModulesPerformanceComponentObjectType5 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType5)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType5), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_models_performance_component_name_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModelsPerformanceComponentName5 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName5 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules5 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType6 ChillerHeaterModulesPerformanceComponentObjectType6 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType6)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType6), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName6 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName6 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules6 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType7 ChillerHeaterModulesPerformanceComponentObjectType7 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType7)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType7), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName7 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName7 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules7 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType8 ChillerHeaterModulesPerformanceComponentObjectType8 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType8)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType8), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName8 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName8 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules8 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType9 ChillerHeaterModulesPerformanceComponentObjectType9 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType9)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType9), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName9 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName9 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules9 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType10 ChillerHeaterModulesPerformanceComponentObjectType10 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType10)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType10), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName10 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName10 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules10 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType11 ChillerHeaterModulesPerformanceComponentObjectType11 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType11)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType11), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName11 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_module_control_schedule_name_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModuleControlScheduleName11 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules11 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType12 ChillerHeaterModulesPerformanceComponentObjectType12 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType12)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType12), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName12 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName12 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules12 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType13 ChillerHeaterModulesPerformanceComponentObjectType13 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType13)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType13), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName13 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName13 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules13 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType14 ChillerHeaterModulesPerformanceComponentObjectType14 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType14)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType14), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName14 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName14 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules14 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType15 ChillerHeaterModulesPerformanceComponentObjectType15 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType15)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType15), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName15 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName15 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules15 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType16 ChillerHeaterModulesPerformanceComponentObjectType16 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType16)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType16), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName16 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName16 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules16 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType17 ChillerHeaterModulesPerformanceComponentObjectType17 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType17)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType17), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName17 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName17 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules17 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType18 ChillerHeaterModulesPerformanceComponentObjectType18 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType18)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType18), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName18 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_control_schedule_name_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlControlScheduleName18 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules18 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType19 ChillerHeaterModulesPerformanceComponentObjectType19 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType19)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType19), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName19 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName19 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules19 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_object_type_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType20 ChillerHeaterModulesPerformanceComponentObjectType20 { get; set; } = (CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType20)Enum.Parse(typeof(CentralHeatPumpSystem_ChillerHeaterModulesPerformanceComponentObjectType20), "ChillerHeaterPerformanceElectricEIR");
        

        [JsonProperty(PropertyName="chiller_heater_modules_performance_component_name_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesPerformanceComponentName20 { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_heater_modules_control_schedule_name_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChillerHeaterModulesControlScheduleName20 { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_chiller_heater_modules_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfChillerHeaterModules20 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}