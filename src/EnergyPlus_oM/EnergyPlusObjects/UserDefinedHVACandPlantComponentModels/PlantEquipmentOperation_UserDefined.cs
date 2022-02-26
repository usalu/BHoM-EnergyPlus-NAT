using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels
{
    [Description("Defines a generic plant operation scheme for custom supervisory control using Ene" +
                 "rgy Management System or External Interface to dispatch loads")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_UserDefined : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="main_model_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainModelProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="initialization_program_calling_manager_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InitializationProgramCallingManagerName { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment1ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment2ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment3ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment4ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_5_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment5ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_6_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment6ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_7_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment7ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_8_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment8ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_9_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment9ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment9Name { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_10_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment10ObjectType { get; set; } = "";
        

        [JsonProperty(PropertyName="equipment_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Equipment10Name { get; set; } = "";
    }
}