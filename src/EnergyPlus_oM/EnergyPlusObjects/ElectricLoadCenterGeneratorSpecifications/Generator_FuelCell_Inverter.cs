using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to describe the power condition unit subsystem of a fuel cell power generato" +
                 "r. This object models an inverter system contained within a fuel cell system tha" +
                 "t converts from direct current (DC) to alternating current (AC).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_Inverter : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="inverter_efficiency_calculation_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode InverterEfficiencyCalculationMode { get; set; } = (Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode)Enum.Parse(typeof(Generator_FuelCell_Inverter_InverterEfficiencyCalculationMode), "Constant");
        

        [JsonProperty(PropertyName="inverter_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InverterEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_function_of_dc_power_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EfficiencyFunctionOfDcPowerCurveName { get; set; } = "";
    }
}