using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    [Description(null)]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"This parameter identifies how the heat transfer between fluid being circulated through the radiant system and the radiant system (slab) is modeled. ConvectionOnly means that only convection between the fluid and the inside surface of the pipe is modeled using a conventional equation for flow inside a pipe. ISOStandard models convection between the fluid and the inside of of the pipe and conduction through the pipe material using equations specific to ISO Standard 11855-2.")]
        [JsonProperty(PropertyName="fluid_to_radiant_surface_heat_transfer_model", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel FluidToRadiantSurfaceHeatTransferModel { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_FluidToRadiantSurfaceHeatTransferModel), "ConvectionOnly");
        

        [JsonProperty(PropertyName="hydronic_tubing_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingInsideDiameter { get; set; } = Double.Parse("0.013", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="hydronic_tubing_outside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingOutsideDiameter { get; set; } = Double.Parse("0.016", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of the tubing/piping material")]
        [JsonProperty(PropertyName="hydronic_tubing_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydronicTubingConductivity { get; set; } = Double.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Temperature used to control system")]
        [JsonProperty(PropertyName="temperature_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType TemperatureControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType), "MeanAirTemperature");
        

        [Description(@"this is the weighting factor in the equation that calculate the running mean outdoor dry-bulb temperature as a weighted average of the previous dayâ€™s running mean outdoor dry-bulb temperature and the previous dayâ€™s average outdoor dry-bulb temperature this value is only used by EnergyPlus when the user elects to use the RunningMeanOutdoorDryBulbTemperature control type")]
        [JsonProperty(PropertyName="running_mean_outdoor_dry_bulb_temperature_weighting_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RunningMeanOutdoorDryBulbTemperatureWeightingFactor { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_of_motor_inefficiencies_to_fluid_stream", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfMotorInefficienciesToFluidStream { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="condensation_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType CondensationControlType { get; set; } = (ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType)Enum.Parse(typeof(ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_CondensationControlType), "SimpleOff");
        

        [JsonProperty(PropertyName="condensation_control_dewpoint_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondensationControlDewpointOffset { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Changeover delay schedule name for this system. Schedule value <= 0 allows change" +
                     "over with no delay The schedule values are interpretted as hours. If this field " +
                     "is blank, the system allows changeover with no delay")]
        [JsonProperty(PropertyName="changeover_delay_time_period_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChangeoverDelayTimePeriodSchedule { get; set; } = "";
    }
}