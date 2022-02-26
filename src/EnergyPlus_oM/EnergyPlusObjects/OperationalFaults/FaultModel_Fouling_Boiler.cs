using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes the fouling fault of boilers with water-based heat exchange" +
                 "rs")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_Fouling_Boiler : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of a boiler object The fault applies to the hot-water boilers")]
        [JsonProperty(PropertyName="boiler_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_Fouling_Boiler_BoilerObjectType BoilerObjectType { get; set; } = (FaultModel_Fouling_Boiler_BoilerObjectType)Enum.Parse(typeof(FaultModel_Fouling_Boiler_BoilerObjectType), "BoilerHotWater");
        

        [Description("Enter the name of a Boiler object")]
        [JsonProperty(PropertyName="boiler_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BoilerObjectName { get; set; } = "";
        

        [Description("The factor indicates the decrease of the nominal capacity of the boiler It is the" +
                     " ratio between the nominal capacity at fouling case and that at fault free case")]
        [JsonProperty(PropertyName="fouling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FoulingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}