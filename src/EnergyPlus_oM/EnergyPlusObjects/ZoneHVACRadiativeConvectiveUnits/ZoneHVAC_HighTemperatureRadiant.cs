using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description("The number of surfaces can be expanded beyond 100, if necessary, by adding more g" +
                 "roups to the end of the list")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_HighTemperatureRadiant : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of zone system is serving")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description(@"Enter the method used to determine the maximum heating power input capacity. HeatingDesignCapacity = > selected when the design heating capacity value or autosize is specified. CapacityPerFloorArea = > selected when the design heating capacity is determine from user specified heating capacity per floor area and zone floor area. FractionOfAutosizedHeatingCapacity = > is selected when the design heating capacity is determined from a user specified fraction and the auto-sized design heating capacity.")]
        [JsonProperty(PropertyName="heating_design_capacity_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod HeatingDesignCapacityMethod { get; set; } = (ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_HeatingDesignCapacityMethod), "HeatingDesignCapacity");
        

        [Description("Enter the design heating capacity. Required field when the heating design capacit" +
                     "y method HeatingDesignCapacity.")]
        [JsonProperty(PropertyName="heating_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingDesignCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Enter the heating design capacity per zone floor area. Required field when the he" +
                     "ating design capacity method field is CapacityPerFloorArea.")]
        [JsonProperty(PropertyName="heating_design_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingDesignCapacityPerFloorArea { get; set; } = null;
        

        [Description("Enter the fraction of autosized heating design capacity. Required field when capa" +
                     "city the heating design capacity method field is FractionOfAutosizedHeatingCapac" +
                     "ity.")]
        [JsonProperty(PropertyName="fraction_of_autosized_heating_design_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfAutosizedHeatingDesignCapacity { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Natural gas or electricity")]
        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HighTemperatureRadiant_FuelType FuelType { get; set; } = (ZoneHVAC_HighTemperatureRadiant_FuelType)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_FuelType), "Electricity");
        

        [Description("Not used for non-gas radiant heaters")]
        [JsonProperty(PropertyName="combustion_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CombustionEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Radiant+latent+lost fractions must sum to 1 or less, remainder is considered conv" +
                     "ective heat")]
        [JsonProperty(PropertyName="fraction_of_input_converted_to_radiant_energy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfInputConvertedToRadiantEnergy { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_of_input_converted_to_latent_energy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfInputConvertedToLatentEnergy { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Fraction of input vented to outdoor environment")]
        [JsonProperty(PropertyName="fraction_of_input_that_is_lost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfInputThatIsLost { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Temperature type used to control unit")]
        [JsonProperty(PropertyName="temperature_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HighTemperatureRadiant_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_HighTemperatureRadiant_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_HighTemperatureRadiant_TemperatureControlType), "OperativeTemperature");
        

        [JsonProperty(PropertyName="heating_throttling_range", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingThrottlingRange { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("This setpoint is an \"operative temperature\" setpoint")]
        [JsonProperty(PropertyName="heating_setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingSetpointTemperatureScheduleName { get; set; } = "";
        

        [Description("This will affect thermal comfort but from an energy balance standpoint this value" +
                     " gets added to the convective gains from the radiant heater")]
        [JsonProperty(PropertyName="fraction_of_radiant_energy_incident_on_people", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfRadiantEnergyIncidentOnPeople { get; set; } = null;
        

        [JsonProperty(PropertyName="surface_fractions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits.ZoneHVAC_HighTemperatureRadiant_SurfaceFractions_Item> SurfaceFractions { get; set; } = null;
    }
}