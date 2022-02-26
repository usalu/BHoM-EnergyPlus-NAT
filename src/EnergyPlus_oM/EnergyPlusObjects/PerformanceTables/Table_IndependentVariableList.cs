using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceTables
{
    [Description("A sorted list of independent variables used by one or more Table:Lookup objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Table_IndependentVariableList : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This list is the IndependentVariableName object-list")]
        [JsonProperty(PropertyName="independent_variables", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> IndependentVariables { get; set; } = null;
    }
}