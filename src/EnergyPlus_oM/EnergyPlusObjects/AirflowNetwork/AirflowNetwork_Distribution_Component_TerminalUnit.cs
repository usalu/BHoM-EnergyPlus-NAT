using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of a terminal unit in an air loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_TerminalUnit : BHoMObject
    {
        

        [Description("Enter the name of a terminal unit in the AirLoopHVAC.")]
        [JsonProperty(PropertyName="terminal_unit_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TerminalUnitName { get; set; } = "";
        

        [Description("Select the type of terminal unit corresponding to the name entered in the field a" +
                     "bove.")]
        [JsonProperty(PropertyName="terminal_unit_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType TerminalUnitObjectType { get; set; } = (AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_TerminalUnit_TerminalUnitObjectType), "AirTerminalSingleDuctConstantVolumeReheat");
        

        [Description("Enter the air path length (depth) for the terminal unit.")]
        [JsonProperty(PropertyName="air_path_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirPathLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of this terminal unit. The hydraulic diameter is def" +
                     "ined as 4 multiplied by the cross section area divided by perimeter.")]
        [JsonProperty(PropertyName="air_path_hydraulic_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirPathHydraulicDiameter { get; set; } = null;
    }
}