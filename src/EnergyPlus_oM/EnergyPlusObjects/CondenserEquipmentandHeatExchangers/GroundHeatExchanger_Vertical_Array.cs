using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description(null)]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_Vertical_Array : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="ghe_vertical_properties_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GheVerticalPropertiesObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_boreholes_in_x_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBoreholesInXDirection { get; set; } = null;
        

        [JsonProperty(PropertyName="number_of_boreholes_in_y_direction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBoreholesInYDirection { get; set; } = null;
        

        [JsonProperty(PropertyName="borehole_spacing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BoreholeSpacing { get; set; } = null;
    }
}