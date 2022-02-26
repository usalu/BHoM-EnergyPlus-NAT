using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Adds a report to the eio output file which shows details for each construction, i" +
                 "ncluding overall properties, a list of material layers, and calculated results r" +
                 "elated to conduction transfer functions.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Constructions : BHoMObject
    {
        

        [JsonProperty(PropertyName="details_type_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Constructions_DetailsType1 DetailsType1 { get; set; } = (Output_Constructions_DetailsType1)Enum.Parse(typeof(Output_Constructions_DetailsType1), "Constructions");
        

        [JsonProperty(PropertyName="details_type_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Constructions_DetailsType2 DetailsType2 { get; set; } = (Output_Constructions_DetailsType2)Enum.Parse(typeof(Output_Constructions_DetailsType2), "Constructions");
    }
}