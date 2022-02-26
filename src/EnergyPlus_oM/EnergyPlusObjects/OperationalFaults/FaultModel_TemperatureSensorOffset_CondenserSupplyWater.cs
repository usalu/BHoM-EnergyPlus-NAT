using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of condenser supply water temperature sensor offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_TemperatureSensorOffset_CondenserSupplyWater : BHoMObject, IEnergyPlusNode
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
        public FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType CoolingTowerObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_CondenserSupplyWater_CoolingTowerObjectType), "CoolingTowerSingleSpeed");
        

        [Description("Enter the name of the cooling tower affected")]
        [JsonProperty(PropertyName="cooling_tower_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingTowerObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_sensor_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceSensorOffset { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}