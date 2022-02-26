using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("This input syntax is intended to describe a thermal storage system that includes " +
                 "smaller containers filled with water that are placed in a larger tank or series " +
                 "of tanks. The model uses polynomial equations to describe the system performance" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ThermalStorage_Ice_Detailed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("This includes only the latent storage capacity")]
        [JsonProperty(PropertyName="capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Capacity { get; set; } = null;
        

        [JsonProperty(PropertyName="inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="discharging_curve_variable_specifications", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications DischargingCurveVariableSpecifications { get; set; } = (ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_DischargingCurveVariableSpecifications), "FractionChargedLMTD");
        

        [JsonProperty(PropertyName="discharging_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DischargingCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="charging_curve_variable_specifications", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications ChargingCurveVariableSpecifications { get; set; } = (ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_ChargingCurveVariableSpecifications), "FractionChargedLMTD");
        

        [JsonProperty(PropertyName="charging_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChargingCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="timestep_of_the_curve_data", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TimestepOfTheCurveData { get; set; } = null;
        

        [JsonProperty(PropertyName="parasitic_electric_load_during_discharging", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ParasiticElectricLoadDuringDischarging { get; set; } = null;
        

        [JsonProperty(PropertyName="parasitic_electric_load_during_charging", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ParasiticElectricLoadDuringCharging { get; set; } = null;
        

        [Description("This is the fraction the total storage capacity that is lost or melts each hour")]
        [JsonProperty(PropertyName="tank_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TankLossCoefficient { get; set; } = null;
        

        [Description("This temperature is typically 0C for water. Simply changing this temperature with" +
                     "out adjusting the performance parameters input above is inappropriate and not ad" +
                     "vised.")]
        [JsonProperty(PropertyName="freezing_temperature_of_storage_medium", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FreezingTemperatureOfStorageMedium { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field determines whether the system uses internal or external melt during di" +
                     "scharging. This will then have an impact on charging performance.")]
        [JsonProperty(PropertyName="thaw_process_indicator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ThermalStorage_Ice_Detailed_ThawProcessIndicator ThawProcessIndicator { get; set; } = (ThermalStorage_Ice_Detailed_ThawProcessIndicator)Enum.Parse(typeof(ThermalStorage_Ice_Detailed_ThawProcessIndicator), "OutsideMelt");
    }
}