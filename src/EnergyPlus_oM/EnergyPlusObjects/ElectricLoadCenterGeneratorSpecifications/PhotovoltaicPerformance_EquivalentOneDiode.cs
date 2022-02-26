using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes the performance characteristics of Photovoltaic (PV) modules to be mode" +
                 "led using an equivalent one-diode circuit. This model is also known as the 4- or" +
                 " 5-parameter TRNSYS model for photovoltaics.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PhotovoltaicPerformance_EquivalentOneDiode : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="cell_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PhotovoltaicPerformance_EquivalentOneDiode_CellType CellType { get; set; } = (PhotovoltaicPerformance_EquivalentOneDiode_CellType)Enum.Parse(typeof(PhotovoltaicPerformance_EquivalentOneDiode_CellType), "AmorphousSilicon");
        

        [JsonProperty(PropertyName="number_of_cells_in_series", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCellsInSeries { get; set; } = Double.Parse("36", CultureInfo.InvariantCulture);
        

        [Description("The total power output of the array is determined by the number of modules (see a" +
                     "bove). The Active Area is only used to calculate the PV Array Efficiency output " +
                     "variable.")]
        [JsonProperty(PropertyName="active_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ActiveArea { get; set; } = Double.Parse("0.89", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="transmittance_absorptance_product", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TransmittanceAbsorptanceProduct { get; set; } = Double.Parse("0.95", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="semiconductor_bandgap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SemiconductorBandgap { get; set; } = Double.Parse("1.12", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="shunt_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShuntResistance { get; set; } = Double.Parse("1000000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="short_circuit_current", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShortCircuitCurrent { get; set; } = Double.Parse("6.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="open_circuit_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OpenCircuitVoltage { get; set; } = Double.Parse("21.6", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceTemperature { get; set; } = Double.Parse("25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="reference_insolation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceInsolation { get; set; } = Double.Parse("1000", CultureInfo.InvariantCulture);
        

        [Description("Single module current at the maximum power point and reference conditions. Module" +
                     " Current, Module Voltage, Number of Modules in Parallel and Number of Modules in" +
                     " Series determine the maximum power output of the array.")]
        [JsonProperty(PropertyName="module_current_at_maximum_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModuleCurrentAtMaximumPower { get; set; } = Double.Parse("5.9", CultureInfo.InvariantCulture);
        

        [Description("Single module voltage at the maximum power point and reference conditions. Module" +
                     " Current, Module Voltage, Number of Modules in Parallel and Number of Modules in" +
                     " Series determine the maximum power output of the array.")]
        [JsonProperty(PropertyName="module_voltage_at_maximum_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModuleVoltageAtMaximumPower { get; set; } = Double.Parse("17", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="temperature_coefficient_of_short_circuit_current", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureCoefficientOfShortCircuitCurrent { get; set; } = Double.Parse("0.02", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="temperature_coefficient_of_open_circuit_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureCoefficientOfOpenCircuitVoltage { get; set; } = Double.Parse("-0.079", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_operating_cell_temperature_test_ambient_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalOperatingCellTemperatureTestAmbientTemperature { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_operating_cell_temperature_test_cell_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalOperatingCellTemperatureTestCellTemperature { get; set; } = Double.Parse("40", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_operating_cell_temperature_test_insolation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalOperatingCellTemperatureTestInsolation { get; set; } = Double.Parse("800", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="module_heat_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModuleHeatLossCoefficient { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="total_heat_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TotalHeatCapacity { get; set; } = Double.Parse("50000", CultureInfo.InvariantCulture);
    }
}