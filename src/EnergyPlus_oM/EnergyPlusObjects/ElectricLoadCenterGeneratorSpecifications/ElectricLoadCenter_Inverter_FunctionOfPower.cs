using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Electric power inverter to convert from direct current (DC) to alternating curren" +
                 "t (AC) in an electric load center that contains photovoltaic modules. This input" +
                 " object is for an inverter model where efficiency is a function of normalized po" +
                 "wer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Inverter_FunctionOfPower : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter name of zone to receive inverter losses as heat if blank then inverter is a" +
                     "ssumed to be outdoors")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RadiativeFraction { get; set; } = null;
        

        [Description("curve describes efficiency as a function of power curve is normalized relative to" +
                     " rated power in next field")]
        [JsonProperty(PropertyName="efficiency_function_of_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EfficiencyFunctionOfPowerCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="rated_maximum_continuous_input_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedMaximumContinuousInputPower { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPowerOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPowerOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="ancillary_power_consumed_in_standby", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryPowerConsumedInStandby { get; set; } = null;
    }
}