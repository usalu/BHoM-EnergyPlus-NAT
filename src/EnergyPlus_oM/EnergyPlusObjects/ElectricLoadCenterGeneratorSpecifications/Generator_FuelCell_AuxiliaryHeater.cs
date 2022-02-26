using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description(@"Intended for modeling an auxiliary heater for a fuel cell power generator, however this portion of the model is not yet available. The program still requires one of these objects be included even though the data are not yet used (so that internal data structures can be allocated).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_AuxiliaryHeater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="excess_air_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExcessAirRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="ancillary_power_constant_term", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryPowerConstantTerm { get; set; } = null;
        

        [JsonProperty(PropertyName="ancillary_power_linear_term", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AncillaryPowerLinearTerm { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_u_factor_times_area_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SkinLossUFactorTimesAreaValue { get; set; } = null;
        

        [JsonProperty(PropertyName="skin_loss_destination", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AuxiliaryHeater_SkinLossDestination SkinLossDestination { get; set; } = (Generator_FuelCell_AuxiliaryHeater_SkinLossDestination)Enum.Parse(typeof(Generator_FuelCell_AuxiliaryHeater_SkinLossDestination), "AirInletForFuelCell");
        

        [JsonProperty(PropertyName="zone_name_to_receive_skin_losses", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneNameToReceiveSkinLosses { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_capacity_units", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits HeatingCapacityUnits { get; set; } = (Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits)Enum.Parse(typeof(Generator_FuelCell_AuxiliaryHeater_HeatingCapacityUnits), "Watts");
        

        [JsonProperty(PropertyName="maximum_heating_capacity_in_watts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumHeatingCapacityInWatts { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_heating_capacity_in_watts", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumHeatingCapacityInWatts { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_heating_capacity_in_kmol_per_second", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumHeatingCapacityInKmolPerSecond { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_heating_capacity_in_kmol_per_second", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumHeatingCapacityInKmolPerSecond { get; set; } = null;
    }
}