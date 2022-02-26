using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ExternalInterface
{
    [Description("This objects contains only one value, which is used during the first call of Ener" +
                 "gyPlus")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ExternalInterface_FunctionalMockupUnitExport_To_Schedule : BHoMObject
    {
        

        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="schedule_type_limits_names", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleTypeLimitsNames { get; set; } = "";
        

        [JsonProperty(PropertyName="fmu_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FmuVariableName { get; set; } = "";
        

        [Description("Used during the first call of EnergyPlus.")]
        [JsonProperty(PropertyName="initial_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialValue { get; set; } = null;
    }
}