using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of a coil used in an air loop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Coil : BHoMObject
    {
        

        [Description("Enter the name of a cooling or heating coil in the primary Air loop.")]
        [JsonProperty(PropertyName="coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilName { get; set; } = "";
        

        [Description("Select the type of coil corresponding to the name entered in the field above.")]
        [JsonProperty(PropertyName="coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_Distribution_Component_Coil_CoilObjectType CoilObjectType { get; set; } = (AirflowNetwork_Distribution_Component_Coil_CoilObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_Coil_CoilObjectType), "CoilCoolingDX");
        

        [Description("Enter the air path length (depth) for the coil.")]
        [JsonProperty(PropertyName="air_path_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirPathLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of this coil. The hydraulic diameter is defined as 4" +
                     " multiplied by the cross section area divided by perimeter.")]
        [JsonProperty(PropertyName="air_path_hydraulic_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirPathHydraulicDiameter { get; set; } = null;
    }
}