using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers
{
    [Description("Natural gas fired steam humidifier with optional blower fan.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Humidifier_Steam_Gas : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Capacity is m3/s of water at 5.05 C The nominal full capacity water addition rate" +
                     " in m3/s of water at 5.05 C")]
        [JsonProperty(PropertyName="rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"if auto-sized, the rated gas use rate is calculated from the rated capacity and enthalpy rise of water from 20.0C to 100.0C steam and user input thermal efficiency value specified in the next input field. If this input field is hard-sized and Inlet Water Temperature Option input field is selected as FixedInletWaterTemperature, then the thermal efficiency input field will not be used or else if the Inlet Water Temperature Option input field is selected as VariableInletWaterTemperature, then the thermal efficiency input value is overridden by a value calculated from the capacity, rated gas use rate and design condition.")]
        [JsonProperty(PropertyName="rated_gas_use_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RatedGasUseRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Based on the higher heating value of fuel. If ""Rated Gas Use Rate"" in the field above is not auto-sized and the Inlet Water Temperature Option input field is specified as FixedInletWaterTemperature, then the thermal efficiency specified will not be used in the calculation, or else if the Inlet Water Temperature Option input field is selected as VariableInletWaterTemperature, then the thermal efficiency value is overridden by a value calculated from the capacity, rated gas use rate and design condition.")]
        [JsonProperty(PropertyName="thermal_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalEfficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description(@"Linear, Quadratic and Cubic efficiency curves are solely a function of PLR. Linear = C1 + C2*PLR Quadratic = C1 + C2*PLR + C3*PLR^2 Cubic = C1 + C2*PLR + C3*PLR^2 + C4*PLR^3 This is thermal efficiency modifier curve name of gas fired steam humidifier. This curve is normalized, i.e., curve output value at rated condition is 1.0.")]
        [JsonProperty(PropertyName="thermal_efficiency_modifier_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThermalEfficiencyModifierCurveName { get; set; } = "";
        

        [Description("The nominal full capacity electric power input to the blower fan in Watts. If no " +
                     "blower fan is required to inject the dry steam to the supply air stream, then th" +
                     "is input field is set to zero.")]
        [JsonProperty(PropertyName="rated_fan_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedFanPower { get; set; } = null;
        

        [Description("The auxiliary electric power input in watts. This amount of power will be consume" +
                     "d whenever the unit is available (as defined by the availability schedule). This" +
                     " electric power is used for control purpose only.")]
        [JsonProperty(PropertyName="auxiliary_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AuxiliaryElectricPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterStorageTankName { get; set; } = "";
        

        [Description(@"The inlet water temperature can be fixed at 20C as it is done for electric steam humidifier or it can be allowed to vary with temperature of the water source. Currently allowed water sources are main water or water storage tank in water use objects. if FixedInletWaterTemperature is specified, then a fixed 20C water temperature will be used, or else if VariableInletWaterTemperature is specified, then inlet water will vary depending the source water temperature. If this input field is left blank, then fixed inlet water temperature of 20C will be assumed.")]
        [JsonProperty(PropertyName="inlet_water_temperature_option", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Humidifier_Steam_Gas_InletWaterTemperatureOption InletWaterTemperatureOption { get; set; } = (Humidifier_Steam_Gas_InletWaterTemperatureOption)Enum.Parse(typeof(Humidifier_Steam_Gas_InletWaterTemperatureOption), "FixedInletWaterTemperature");
    }
}