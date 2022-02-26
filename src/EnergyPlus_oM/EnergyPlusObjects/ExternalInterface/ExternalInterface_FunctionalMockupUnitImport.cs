using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This object declares an FMU")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitImport : BHoMObject
    {
        

        [JsonProperty(PropertyName="fmu_file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuFileName { get; set; } = "";
        

        [Description("in milli-seconds")]
        [JsonProperty(PropertyName="fmu_timeout", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FmuTimeout { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fmu_loggingon", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FmuLoggingon { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}