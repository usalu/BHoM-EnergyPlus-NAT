using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This model is for converting AC to DC for grid-supplied charging of DC storage")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Storage_Converter : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the converter is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("SimpleFixed indicates power conversion losses are based on Simple Fixed Efficienc" +
                     "y FunctionOfPower indicates power conversion losses are a function of normalized" +
                     " power using a curve or table.")]
        [JsonProperty(PropertyName="power_conversion_efficiency_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod PowerConversionEfficiencyMethod { get; set; } = (ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod)Enum.Parse(typeof(ElectricLoadCenter_Storage_Converter_PowerConversionEfficiencyMethod), "SimpleFixed");
        

        [Description("Constant efficiency for conversion of AC to DC at all power levels. Field is only" +
                     " used when Power Conversion Efficiency Method is set to SimpleFixed.")]
        [JsonProperty(PropertyName="simple_fixed_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SimpleFixedEfficiency { get; set; } = Double.Parse("0.95", CultureInfo.InvariantCulture);
        

        [Description("Required field when Power Conversion Efficiency Method is set to FunctionOfPower." +
                     "")]
        [JsonProperty(PropertyName="design_maximum_continuous_input_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignMaximumContinuousInputPower { get; set; } = null;
        

        [Description(@"Curve or table with a single independent variable that describes efficiency as a function of normalized power. The ""x"" input for curve or table is the ratio of current input power divided by design power in the previous field Required field when Power Conversion Efficiency Method is set to FunctionOfPower.")]
        [JsonProperty(PropertyName="efficiency_function_of_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EfficiencyFunctionOfPowerCurveName { get; set; } = "";
        

        [Description("Optional standby power consumed when converter is available but no power is being" +
                     " conditioned.")]
        [JsonProperty(PropertyName="ancillary_power_consumed_in_standby", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryPowerConsumedInStandby { get; set; } = null;
        

        [Description("enter name of zone to receive converter losses as heat if blank then converter is" +
                     " assumed to be outdoors")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("fraction of zone heat gains treated as thermal radiation")]
        [JsonProperty(PropertyName="radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RadiativeFraction { get; set; } = null;
    }
}