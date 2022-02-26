using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the name of an air-to-air heat exchanger used in an air loop." +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_HeatExchanger : BHoMObject
    {
        

        [Description("Enter the name of an air-to-air heat exchanger in the primary Air loop.")]
        [JsonProperty(PropertyName="heatexchanger_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatexchangerName { get; set; } = "";
        

        [Description("Select the type of heat exchanger corresponding to the name entered in the field " +
                     "above.")]
        [JsonProperty(PropertyName="heatexchanger_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType HeatexchangerObjectType { get; set; } = (AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType)Enum.Parse(typeof(AirflowNetwork_Distribution_Component_HeatExchanger_HeatexchangerObjectType), "HeatExchangerAirToAirFlatPlate");
        

        [Description("Enter the air path length (depth) for the heat exchanger.")]
        [JsonProperty(PropertyName="air_path_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirPathLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of this heat exchanger. The hydraulic diameter is de" +
                     "fined as 4 multiplied by the cross section area divided by perimeter.")]
        [JsonProperty(PropertyName="air_path_hydraulic_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirPathHydraulicDiameter { get; set; } = null;
    }
}