using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of coil supply air temperature sensor offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_TemperatureSensorOffset_CoilSupplyAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [Description("Enter the type of the coil affected")]
        [JsonProperty(PropertyName="coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType CoilObjectType { get; set; } = (FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType)Enum.Parse(typeof(FaultModel_TemperatureSensorOffset_CoilSupplyAir_CoilObjectType), "AirLoopHVACUnitarySystem");
        

        [Description("Enter the name of the coil affected")]
        [JsonProperty(PropertyName="coil_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilObjectName { get; set; } = "";
        

        [Description("Enter the name of controller for the water coil affected Required for water coils" +
                     "")]
        [JsonProperty(PropertyName="water_coil_controller_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterCoilControllerName { get; set; } = "";
        

        [JsonProperty(PropertyName="reference_sensor_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceSensorOffset { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}