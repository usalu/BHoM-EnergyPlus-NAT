using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Multiplier altering the relative capacitance of the air compared to an empty zone" +
                 "")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneCapacitanceMultiplier_ResearchSpecial : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If this field is left blank, the multipliers are applied to all the zones not spe" +
                     "cified")]
        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("Used to alter the capacitance of zone air with respect to heat or temperature")]
        [JsonProperty(PropertyName="temperature_capacity_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureCapacityMultiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to alter the capacitance of zone air with respect to moisture or humidity ra" +
                     "tio")]
        [JsonProperty(PropertyName="humidity_capacity_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HumidityCapacityMultiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to alter the capacitance of zone air with respect to zone air carbon dioxide" +
                     " concentration")]
        [JsonProperty(PropertyName="carbon_dioxide_capacity_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CarbonDioxideCapacityMultiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to alter the capacitance of zone air with respect to zone air generic contam" +
                     "inant concentration")]
        [JsonProperty(PropertyName="generic_contaminant_capacity_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GenericContaminantCapacityMultiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}