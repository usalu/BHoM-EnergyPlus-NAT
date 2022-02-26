using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("Hardware portion of EMS used to set up actuators in the model that are dynamicall" +
                 "y updated from the FMU.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitImport_To_Actuator : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="actuated_component_unique_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActuatedComponentUniqueName { get; set; } = "";
        

        [JsonProperty(PropertyName="actuated_component_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActuatedComponentType { get; set; } = "";
        

        [JsonProperty(PropertyName="actuated_component_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActuatedComponentControlType { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuFileName { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_instance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuInstanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuVariableName { get; set; } = "";
        

        [Description("Used during the first call of EnergyPlus.")]
        [JsonProperty(PropertyName="initial_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialValue { get; set; } = null;
    }
}