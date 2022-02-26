using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fault of dirty air filters")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_Fouling_AirFilter : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Choose the type of the fan Support for Fan:SystemModel is pending")]
        [JsonProperty(PropertyName="fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_Fouling_AirFilter_FanObjectType FanObjectType { get; set; } = (FaultModel_Fouling_AirFilter_FanObjectType)Enum.Parse(typeof(FaultModel_Fouling_AirFilter_FanObjectType), "FanConstantVolume");
        

        [Description("Enter the name of a fan object")]
        [JsonProperty(PropertyName="fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of a schedule describing the variations of the fan pressure rise i" +
                     "n terms of multipliers to the fan design pressure rise")]
        [JsonProperty(PropertyName="pressure_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PressureFractionScheduleName { get; set; } = "";
        

        [Description("The curve describes the relationship between the fan pressure rise and air flow r" +
                     "ate")]
        [JsonProperty(PropertyName="fan_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanCurveName { get; set; } = "";
    }
}