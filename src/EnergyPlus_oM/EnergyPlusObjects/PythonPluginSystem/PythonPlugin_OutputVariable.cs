using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PythonPluginSystem
{
    [Description("This object sets up an EnergyPlus output variable from a Python Plugin variable")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PythonPlugin_OutputVariable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Must be listed in the PythonPlugin:Variables object")]
        [JsonProperty(PropertyName="python_plugin_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PythonPluginVariableName { get; set; } = "";
        

        [Description("If Metered is selected, the variable is automatically set to a \"Summed\" type, and" +
                     " the Resource Type, Group Type, and End-Use Subcategory fields on this object ar" +
                     "e required")]
        [JsonProperty(PropertyName="type_of_data_in_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PythonPlugin_OutputVariable_TypeOfDataInVariable TypeOfDataInVariable { get; set; } = (PythonPlugin_OutputVariable_TypeOfDataInVariable)Enum.Parse(typeof(PythonPlugin_OutputVariable_TypeOfDataInVariable), "Averaged");
        

        [JsonProperty(PropertyName="update_frequency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PythonPlugin_OutputVariable_UpdateFrequency UpdateFrequency { get; set; } = (PythonPlugin_OutputVariable_UpdateFrequency)Enum.Parse(typeof(PythonPlugin_OutputVariable_UpdateFrequency), "SystemTimestep");
        

        [Description("optional but will result in dimensionless units for blank EnergyPlus units are st" +
                     "andard SI units")]
        [JsonProperty(PropertyName="units", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Units { get; set; } = "";
        

        [Description(@"This field is optional for regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed. For Metered variables, this field is required. Choose the type of fuel, water, electricity, pollution or heat rate that should be metered.")]
        [JsonProperty(PropertyName="resource_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PythonPlugin_OutputVariable_ResourceType ResourceType { get; set; } = (PythonPlugin_OutputVariable_ResourceType)Enum.Parse(typeof(PythonPlugin_OutputVariable_ResourceType), "Coal");
        

        [Description(@"This field is optional for regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed. For Metered variables, this field is required. Choose a general classification, building (internal services), HVAC (air systems), or plant (hydronic systems), or system")]
        [JsonProperty(PropertyName="group_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PythonPlugin_OutputVariable_GroupType GroupType { get; set; } = (PythonPlugin_OutputVariable_GroupType)Enum.Parse(typeof(PythonPlugin_OutputVariable_GroupType), "Building");
        

        [Description("This field is optional for regular output variables with \"Type of Data in Variabl" +
                     "e\" set to either Averaged or Summed. For Metered variables, this field is requir" +
                     "ed. Choose how the metered output should be classified for end-use category")]
        [JsonProperty(PropertyName="end_use_category", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PythonPlugin_OutputVariable_EndUseCategory EndUseCategory { get; set; } = (PythonPlugin_OutputVariable_EndUseCategory)Enum.Parse(typeof(PythonPlugin_OutputVariable_EndUseCategory), "Baseboard");
        

        [Description(@"This field is always optional. For regular output variables with ""Type of Data in Variable"" set to either Averaged or Summed, this field is completely ignored. For Metered variables, this field is optional, but allows custom categorization of the end-uses in the ABUPS End Uses by Subcategory table. Enter a user-defined subcategory for this metered output")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "";
    }
}