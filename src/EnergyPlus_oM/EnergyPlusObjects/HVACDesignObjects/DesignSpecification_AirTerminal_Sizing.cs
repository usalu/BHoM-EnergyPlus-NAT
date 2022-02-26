using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("This object is used to scale the sizing of air terminal units.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DesignSpecification_AirTerminal_Sizing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The fraction of the design sensible cooling load to be met by this terminal unit." +
                     " This fraction is applied after the Zone Cooling Sizing Factor (see Sizing:Zone)" +
                     ".")]
        [JsonProperty(PropertyName="fraction_of_design_cooling_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfDesignCoolingLoad { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This ratio adjusts the supply air temperature difference used to calculate the co" +
                     "oling design supply air flow rate for this terminal unit.")]
        [JsonProperty(PropertyName="cooling_design_supply_air_temperature_difference_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingDesignSupplyAirTemperatureDifferenceRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The fraction of the design sensible heating load to be met by this terminal unit." +
                     " This fraction is applied after the Zone Heating Sizing Factor (see Sizing:Zone)" +
                     ".")]
        [JsonProperty(PropertyName="fraction_of_design_heating_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfDesignHeatingLoad { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("This ratio adjusts the supply air temperature difference used to calculate the he" +
                     "ating design supply air flow rate for this terminal unit.")]
        [JsonProperty(PropertyName="heating_design_supply_air_temperature_difference_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingDesignSupplyAirTemperatureDifferenceRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The fraction of the zone minimum outdoor air requirement to be met by this termin" +
                     "al unit.")]
        [JsonProperty(PropertyName="fraction_of_minimum_outdoor_air_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfMinimumOutdoorAirFlow { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}