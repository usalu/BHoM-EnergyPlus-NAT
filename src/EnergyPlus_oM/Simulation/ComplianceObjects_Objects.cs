using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Compliance Objects")]
    public class ComplianceObjects_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="Compliance:Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.ComplianceObjects.Compliance_Building Compliance_Building { get; set; } = null;
    }
}