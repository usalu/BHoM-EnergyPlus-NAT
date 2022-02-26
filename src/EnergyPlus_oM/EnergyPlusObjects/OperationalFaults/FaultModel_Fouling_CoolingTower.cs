using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes the fault of fouling cooling towers")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_Fouling_CoolingTower : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of the cooling tower affected")]
        [JsonProperty(PropertyName="cooling_tower_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_Fouling_CoolingTower_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (FaultModel_Fouling_CoolingTower_CoolingTowerObjectType)Enum.Parse(typeof(FaultModel_Fouling_CoolingTower_CoolingTowerObjectType), "CoolingTowerSingleSpeed");
        

        [Description("Enter the name of the cooling tower affected")]
        [JsonProperty(PropertyName="cooling_tower_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingTowerObjectName { get; set; } = "";
        

        [Description("Factor describing the tower UA reduction due to fouling It is the ratio between t" +
                     "he UA value at fouling case and that at fault free case It is applicable to both" +
                     " the Design UA and Free Convection UA of the tower")]
        [JsonProperty(PropertyName="reference_ua_reduction_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceUaReductionFactor { get; set; } = null;
    }
}