using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers
{
    [Description("Response factor definitions from third-party tool, commonly referred to a \"g-func" +
                 "tions\"")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatExchanger_ResponseFactors : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="ghe_vertical_properties_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GheVerticalPropertiesObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="number_of_boreholes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBoreholes { get; set; } = null;
        

        [JsonProperty(PropertyName="g_function_reference_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GFunctionReferenceRatio { get; set; } = Double.Parse("0.0005", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="g_functions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers.GroundHeatExchanger_ResponseFactors_GFunctions_Item> GFunctions { get; set; } = null;
    }
}