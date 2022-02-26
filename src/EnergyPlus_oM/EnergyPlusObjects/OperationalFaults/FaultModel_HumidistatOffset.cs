using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of humidistat offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_HumidistatOffset : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a ZoneControl:Humidistat object.")]
        [JsonProperty(PropertyName="humidistat_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidistatName { get; set; } = "";
        

        [Description("Two types are available: Type ThermostatOffsetIndependent Type ThermostatOffsetDe" +
                     "pendent")]
        [JsonProperty(PropertyName="humidistat_offset_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_HumidistatOffset_HumidistatOffsetType HumidistatOffsetType { get; set; } = (FaultModel_HumidistatOffset_HumidistatOffsetType)Enum.Parse(typeof(FaultModel_HumidistatOffset_HumidistatOffsetType), "ThermostatOffsetIndependent");
        

        [Description("This field is applicable for Type ThermostatOffsetIndependent")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This field is applicable for Type ThermostatOffsetIndependent")]
        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Required field for Type ThermostatOffsetIndependent")]
        [JsonProperty(PropertyName="reference_humidistat_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHumidistatOffset { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of a FaultModel:ThermostatOffset object Required field for Type Th" +
                     "ermostatOffsetDependent")]
        [JsonProperty(PropertyName="related_thermostat_offset_fault_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RelatedThermostatOffsetFaultName { get; set; } = "";
    }
}