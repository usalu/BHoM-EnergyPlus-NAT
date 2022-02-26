using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes the fouling fault of the wetted coil evaporative cooler")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_Fouling_EvaporativeCooler : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of a Evaporative Cooler object The fault applies to the wetted coi" +
                     "l evaporative cooler The fault does not apply to direct evaporative coolers or t" +
                     "he dry coil indirect evaporative coolers")]
        [JsonProperty(PropertyName="evaporative_cooler_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType EvaporativeCoolerObjectType { get; set; } = (FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType)Enum.Parse(typeof(FaultModel_Fouling_EvaporativeCooler_EvaporativeCoolerObjectType), "EvaporativeCoolerIndirectWetCoil");
        

        [Description("Enter the name of aN Evaporative Cooler object")]
        [JsonProperty(PropertyName="evaporative_cooler_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeCoolerObjectName { get; set; } = "";
        

        [Description("The factor indicates the decrease of the indirect stage efficiency It is the rati" +
                     "o between the indirect stage efficiency at fouling case and that at fault free c" +
                     "ase")]
        [JsonProperty(PropertyName="fouling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FoulingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}