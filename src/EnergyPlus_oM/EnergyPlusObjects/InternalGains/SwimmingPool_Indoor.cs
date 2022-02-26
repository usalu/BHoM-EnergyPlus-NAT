using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Specifies an indoor swimming pools linked to a floor surface. The pool is assumed" +
                 " to cover the entire floor to which it is linked.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SwimmingPool_Indoor : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of the floor surface where the pool is located.")]
        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [JsonProperty(PropertyName="average_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="activity_factor_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActivityFactorScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="make_up_water_supply_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MakeUpWaterSupplyScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cover_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoverScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cover_evaporation_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoverEvaporationFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cover_convection_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoverConvectionFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cover_short_wavelength_radiation_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoverShortWavelengthRadiationFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cover_long_wavelength_radiation_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoverLongWavelengthRadiationFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="pool_water_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PoolWaterInletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="pool_water_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PoolWaterOutletNode { get; set; } = "";
        

        [JsonProperty(PropertyName="pool_heating_system_maximum_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PoolHeatingSystemMaximumWaterFlowRate { get; set; } = null;
        

        [Description("Power input per pool water flow rate")]
        [JsonProperty(PropertyName="pool_miscellaneous_equipment_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PoolMiscellaneousEquipmentPower { get; set; } = null;
        

        [JsonProperty(PropertyName="setpoint_temperature_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointTemperatureSchedule { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_number_of_people", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumNumberOfPeople { get; set; } = null;
        

        [JsonProperty(PropertyName="people_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PeopleSchedule { get; set; } = "";
        

        [JsonProperty(PropertyName="people_heat_gain_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PeopleHeatGainSchedule { get; set; } = "";
    }
}