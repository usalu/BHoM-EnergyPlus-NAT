using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes return air enthalpy sensor offset")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_EnthalpySensorOffset_ReturnAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="controller_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType ControllerObjectType { get; set; } = (FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType)Enum.Parse(typeof(FaultModel_EnthalpySensorOffset_ReturnAir_ControllerObjectType), "ControllerOutdoorAir");
        

        [JsonProperty(PropertyName="controller_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControllerObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="enthalpy_sensor_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EnthalpySensorOffset { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}