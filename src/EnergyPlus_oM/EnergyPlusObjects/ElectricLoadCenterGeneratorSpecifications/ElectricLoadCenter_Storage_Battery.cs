using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Uses the kinetic battery model (KiBaM) to simulate rechargeable battery banks in an electrical load center. The battery bank is a collection of one or more individual battery modules. Given the surplus or deficit power from the electrical system and the state of charge from the previous time step, this object can model the voltage, current, and energy losses with charging and discharging during each time step. The cumulative battery damage can be also modeled and reported at the end of each simulation run.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Storage_Battery : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter name of zone to receive electrical storage losses as heat if blank then ele" +
                     "ctrical storage losses are dissipated to outdoors")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RadiativeFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("A module usually consists of several cells. The total number of modules in the ba" +
                     "ttery bank is equal to number of modules in parallel times number of modules in " +
                     "series.")]
        [JsonProperty(PropertyName="number_of_battery_modules_in_parallel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBatteryModulesInParallel { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("A module usually consists of several cells. The total number of modules in the ba" +
                     "ttery bank is equal to number of modules in parallel times number of modules in " +
                     "series.")]
        [JsonProperty(PropertyName="number_of_battery_modules_in_series", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBatteryModulesInSeries { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The capacity is for each module. A model parameter from manufacturer\'s data or te" +
                     "st data.")]
        [JsonProperty(PropertyName="maximum_module_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumModuleCapacity { get; set; } = null;
        

        [Description("The state of charge is evaluated based on the maximum capacity defined in the nex" +
                     "t field.")]
        [JsonProperty(PropertyName="initial_fractional_state_of_charge", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialFractionalStateOfCharge { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("A model parameter usually derived from test data by curve fitting.")]
        [JsonProperty(PropertyName="fraction_of_available_charge_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfAvailableChargeCapacity { get; set; } = null;
        

        [Description("A model parameter usually derived from test data by curve fitting.")]
        [JsonProperty(PropertyName="change_rate_from_bound_charge_to_available_charge", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChangeRateFromBoundChargeToAvailableCharge { get; set; } = null;
        

        [Description("The voltage is for each battery module.")]
        [JsonProperty(PropertyName="fully_charged_module_open_circuit_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FullyChargedModuleOpenCircuitVoltage { get; set; } = null;
        

        [Description("The voltage is for each battery module.")]
        [JsonProperty(PropertyName="fully_discharged_module_open_circuit_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FullyDischargedModuleOpenCircuitVoltage { get; set; } = null;
        

        [Description("Determines how the open circuit voltage change with state of charge relative to t" +
                     "he fully discharged state.")]
        [JsonProperty(PropertyName="voltage_change_curve_name_for_charging", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VoltageChangeCurveNameForCharging { get; set; } = "";
        

        [Description("Determines how the open circuit voltage change with state of charge relative to t" +
                     "he fully charged state.")]
        [JsonProperty(PropertyName="voltage_change_curve_name_for_discharging", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VoltageChangeCurveNameForDischarging { get; set; } = "";
        

        [Description("A model parameter from manufacture or derived from test data. Internal resistance" +
                     " is assumed to be constant. The internal resistance is for each battery module.")]
        [JsonProperty(PropertyName="module_internal_electrical_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModuleInternalElectricalResistance { get; set; } = null;
        

        [Description("The constraint on discharging current is for each battery module.")]
        [JsonProperty(PropertyName="maximum_module_discharging_current", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumModuleDischargingCurrent { get; set; } = null;
        

        [Description("The voltage constraint is for each battery module.")]
        [JsonProperty(PropertyName="module_cut_off_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModuleCutOffVoltage { get; set; } = null;
        

        [Description("units 1/hr Charge rate limit is the division between charging current the remaini" +
                     "ng capacity. The constraint on charging current is for each module.")]
        [JsonProperty(PropertyName="module_charge_rate_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModuleChargeRateLimit { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="battery_life_calculation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes BatteryLifeCalculation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Only required when battery life calculation is activated")]
        [JsonProperty(PropertyName="number_of_cycle_bins", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCycleBins { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Determines the number of cycles to failure in relation to cycle range. Only requi" +
                     "red when battery life calculation is activated.")]
        [JsonProperty(PropertyName="battery_life_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BatteryLifeCurveName { get; set; } = "";
    }
}