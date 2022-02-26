using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description("A thermal chimney is a vertical shaft utilizing solar radiation to enhance natura" +
                 "l ventilation. It consists of an absorber wall, air gap and glass cover with hig" +
                 "h solar transmissivity.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneThermalChimney : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of zone that is the thermal chimney")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="width_of_the_absorber_wall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WidthOfTheAbsorberWall { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_area_of_air_channel_outlet", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreaOfAirChannelOutlet { get; set; } = null;
        

        [JsonProperty(PropertyName="discharge_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeCoefficient { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet1 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone1 { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet1 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet2 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone2 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet2 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet3 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone3 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet3 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet4 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone4 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet4 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet5 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone5 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet5 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet6 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone6 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet6 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet7 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone7 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet7 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet8 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone8 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet8 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone9Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet9 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone9 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet9 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone10Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet10 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone10 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet10 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_11_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone11Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet11 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone11 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet11 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_12_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone12Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet12 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone12 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet12 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_13_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone13Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet13 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone13 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet13 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_14_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone14Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet14 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone14 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet14 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_15_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone15Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet15 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone15 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet15 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_16_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone16Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet16 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone16 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet16 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_17_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone17Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet17 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone17 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet17 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_18_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone18Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet18 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone18 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet18 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_19_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone19Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet19 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone19 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet19 { get; set; } = null;
        

        [JsonProperty(PropertyName="zone_20_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone20Name { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_from_top_of_thermal_chimney_to_inlet_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromTopOfThermalChimneyToInlet20 { get; set; } = null;
        

        [JsonProperty(PropertyName="relative_ratios_of_air_flow_rates_passing_through_zone_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RelativeRatiosOfAirFlowRatesPassingThroughZone20 { get; set; } = null;
        

        [JsonProperty(PropertyName="cross_sectional_areas_of_air_channel_inlet_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionalAreasOfAirChannelInlet20 { get; set; } = null;
    }
}