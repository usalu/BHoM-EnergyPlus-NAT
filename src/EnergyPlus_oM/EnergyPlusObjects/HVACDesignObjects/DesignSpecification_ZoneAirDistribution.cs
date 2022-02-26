using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("This object is used to describe zone air distribution in terms of air distributio" +
                 "n effectiveness and secondary recirculation fraction. It is referenced by Sizing" +
                 ":Zone and Controller:MechanicalVentilation objects")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DesignSpecification_ZoneAirDistribution : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_air_distribution_effectiveness_in_cooling_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneAirDistributionEffectivenessInCoolingMode { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_air_distribution_effectiveness_in_heating_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneAirDistributionEffectivenessInHeatingMode { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("optionally used to replace Zone Air Distribution Effectiveness in Cooling and Hea" +
                     "ting Mode")]
        [JsonProperty(PropertyName="zone_air_distribution_effectiveness_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneAirDistributionEffectivenessScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_secondary_recirculation_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneSecondaryRecirculationFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_zone_ventilation_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumZoneVentilationEfficiency { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}