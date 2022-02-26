using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes performance input data needed for specific makes and models of producti" +
                 "on PV panels using the empirical coefficients assembled by Sandia National Labor" +
                 "atory.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PhotovoltaicPerformance_Sandia : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("(m2, single module)")]
        [JsonProperty(PropertyName="active_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ActiveArea { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="number_of_cells_in_series", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCellsInSeries { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="number_of_cells_in_parallel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCellsInParallel { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("(Amps)")]
        [JsonProperty(PropertyName="short_circuit_current", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShortCircuitCurrent { get; set; } = null;
        

        [Description("(Volts)")]
        [JsonProperty(PropertyName="open_circuit_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OpenCircuitVoltage { get; set; } = null;
        

        [Description("(Amps)")]
        [JsonProperty(PropertyName="current_at_maximum_power_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CurrentAtMaximumPowerPoint { get; set; } = null;
        

        [Description("(Volts)")]
        [JsonProperty(PropertyName="voltage_at_maximum_power_point", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VoltageAtMaximumPowerPoint { get; set; } = null;
        

        [Description("(1/degC)")]
        [JsonProperty(PropertyName="sandia_database_parameter_aisc", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterAisc { get; set; } = null;
        

        [Description("(1/degC)")]
        [JsonProperty(PropertyName="sandia_database_parameter_aimp", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterAimp { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC0 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC1 { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty(PropertyName="sandia_database_parameter_bvoc0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterBvoc0 { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty(PropertyName="sandia_database_parameter_mbvoc", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterMbvoc { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty(PropertyName="sandia_database_parameter_bvmp0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterBvmp0 { get; set; } = null;
        

        [Description("(Volts/degC)")]
        [JsonProperty(PropertyName="sandia_database_parameter_mbvmp", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterMbvmp { get; set; } = null;
        

        [JsonProperty(PropertyName="diode_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DiodeFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC2 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC3 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_a0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterA0 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_a1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterA1 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_a2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterA2 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_a3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterA3 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_a4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterA4 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB0 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB1 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB2 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB3 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB4 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB5 { get; set; } = null;
        

        [Description("(deg C)")]
        [JsonProperty(PropertyName="sandia_database_parameter_delta_tc_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterDeltaTc { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_fd", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterFd { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterA { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_b", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterB { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC4 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC5 { get; set; } = null;
        

        [Description("(Amps)")]
        [JsonProperty(PropertyName="sandia_database_parameter_ix0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterIx0 { get; set; } = null;
        

        [Description("(Amps)")]
        [JsonProperty(PropertyName="sandia_database_parameter_ixx0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterIxx0 { get; set; } = null;
        

        [JsonProperty(PropertyName="sandia_database_parameter_c6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC6 { get; set; } = null;
        

        [Description("(non-dimensional)")]
        [JsonProperty(PropertyName="sandia_database_parameter_c7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SandiaDatabaseParameterC7 { get; set; } = null;
    }
}