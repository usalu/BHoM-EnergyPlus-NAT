using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal gains and contaminant rates for gas equipment in the zone. If you u" +
                 "se a ZoneList in the Zone name field then this definition applies to all those z" +
                 "ones.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GasEquipment : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("units in Schedule should be fraction applied to design level of gas equipment, ge" +
                     "nerally (0.0 - 1.0)")]
        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of gas equipment for this set of attributes Choices: EquipmentLevel => Design Level -- simply enter power input of equipment Watts/Area or Power/Area => Power per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person or Power/Person => Power per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
        [JsonProperty(PropertyName="design_level_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GasEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (GasEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(GasEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

        [JsonProperty(PropertyName="design_level", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignLevel { get; set; } = null;
        

        [JsonProperty(PropertyName="power_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerPerZoneFloorArea { get; set; } = null;
        

        [JsonProperty(PropertyName="power_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PowerPerPerson { get; set; } = null;
        

        [JsonProperty(PropertyName="fraction_latent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionLatent { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_radiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionRadiant { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_lost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionLost { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"CO2 generation rate per unit of power input The default value assumes the equipment is fully vented. For unvented equipment, a suggested value is 3.45E-8 m3/s-W. This value is converted from a natural gas CO2 emission rate of 117 lbs CO2 per million Btu. The maximum value assumes to be 10 times of the recommended value.")]
        [JsonProperty(PropertyName="carbon_dioxide_generation_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CarbonDioxideGenerationRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}