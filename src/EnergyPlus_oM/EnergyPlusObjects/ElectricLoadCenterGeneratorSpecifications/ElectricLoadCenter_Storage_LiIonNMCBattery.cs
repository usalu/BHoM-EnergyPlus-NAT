using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Uses Lithium Ion NMC model to simulate rechargeable battery banks in an electrical load center. The battery bank is a collection of one or more individual battery modules. Given the surplus or deficit power from the electrical system and the state of charge from the previous time step, this object can model the voltage, current, and energy losses with charging and discharging during each time step. The cumulative battery damage can be also modeled and reported at the end of each simulation run.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Storage_LiIonNMCBattery : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty(PropertyName="lifetime_model", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Storage_LiIonNMCBattery_LifetimeModel LifetimeModel { get; set; } = (ElectricLoadCenter_Storage_LiIonNMCBattery_LifetimeModel)Enum.Parse(typeof(ElectricLoadCenter_Storage_LiIonNMCBattery_LifetimeModel), "KandlerSmith");
        

        [Description("Battery voltage is calculated by multiplying this field by the nominal cell volta" +
                     "ge (N13, default 3.342V)")]
        [JsonProperty(PropertyName="number_of_cells_in_series", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCellsInSeries { get; set; } = null;
        

        [Description("Capacity (Ah) is determined by multiplying this field by the cell capacity (N14, " +
                     "default 3.2 Ah)")]
        [JsonProperty(PropertyName="number_of_strings_in_parallel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfStringsInParallel { get; set; } = null;
        

        [Description("The state of charge is evaluated based on the maximum capacity defined in the nex" +
                     "t field.")]
        [JsonProperty(PropertyName="initial_fractional_state_of_charge", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialFractionalStateOfCharge { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="dc_to_dc_charging_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DcToDcChargingEfficiency { get; set; } = Double.Parse("0.95", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="battery_mass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BatteryMass { get; set; } = null;
        

        [JsonProperty(PropertyName="battery_surface_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BatterySurfaceArea { get; set; } = null;
        

        [JsonProperty(PropertyName="battery_specific_heat_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BatterySpecificHeatCapacity { get; set; } = Double.Parse("1500", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_transfer_coefficient_between_battery_and_ambient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatTransferCoefficientBetweenBatteryAndAmbient { get; set; } = Double.Parse("7.5", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="fully_charged_cell_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FullyChargedCellVoltage { get; set; } = Double.Parse("4.2", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="cell_voltage_at_end_of_exponential_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CellVoltageAtEndOfExponentialZone { get; set; } = Double.Parse("3.53", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="cell_voltage_at_end_of_nominal_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CellVoltageAtEndOfNominalZone { get; set; } = Double.Parse("3.342", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="default_nominal_cell_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DefaultNominalCellVoltage { get; set; } = Double.Parse("3.342", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="fully_charged_cell_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FullyChargedCellCapacity { get; set; } = Double.Parse("3.2", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="fraction_of_cell_capacity_removed_at_the_end_of_exponential_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfCellCapacityRemovedAtTheEndOfExponentialZone { get; set; } = Double.Parse("0.8075", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="fraction_of_cell_capacity_removed_at_the_end_of_nominal_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfCellCapacityRemovedAtTheEndOfNominalZone { get; set; } = Double.Parse("0.976875", CultureInfo.InvariantCulture);
        

        [Description("Most users should not need to change this value.")]
        [JsonProperty(PropertyName="charge_rate_at_which_voltage_vs_capacity_curve_was_generated", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChargeRateAtWhichVoltageVsCapacityCurveWasGenerated { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("for a single cell Most users should not need to change this value.")]
        [JsonProperty(PropertyName="battery_cell_internal_electrical_resistance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BatteryCellInternalElectricalResistance { get; set; } = Double.Parse("0.09", CultureInfo.InvariantCulture);
    }
}