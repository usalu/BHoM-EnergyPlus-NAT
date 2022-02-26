using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal gains for lights in the zone. If you use a ZoneList in the Zone or " +
                 "ZoneList name field then this definition applies to all the zones in the ZoneLis" +
                 "t.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Lights : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("units in schedule should be fraction applied to design level of lights, generally" +
                     " (0.0 - 1.0)")]
        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of lights for this set of attributes Choices: LightingLevel => Lighting Level -- simply enter watts of lights Watts/Area => Watts per Zone Floor Area -- enter the number to apply. Value * Floor Area = Lights Watts/Person => Watts per Person -- enter the number to apply. Value * Occupants = Lights")]
        [JsonProperty(PropertyName="design_level_calculation_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Lights_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (Lights_DesignLevelCalculationMethod)Enum.Parse(typeof(Lights_DesignLevelCalculationMethod), "LightingLevel");
        

        [JsonProperty(PropertyName="lighting_level", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LightingLevel { get; set; } = null;
        

        [JsonProperty(PropertyName="watts_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WattsPerZoneFloorArea { get; set; } = null;
        

        [JsonProperty(PropertyName="watts_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WattsPerPerson { get; set; } = null;
        

        [Description("Used only for sizing calculation if return-air-fraction coefficients are specifie" +
                     "d.")]
        [JsonProperty(PropertyName="return_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnAirFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_radiant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionRadiant { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_visible", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionVisible { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("For Daylighting:Controls must be 0 or 1:  0 = no dimming control, 1 = full dimmin" +
                     "g control")]
        [JsonProperty(PropertyName="fraction_replaceable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionReplaceable { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [JsonProperty(PropertyName="return_air_fraction_calculated_from_plenum_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ReturnAirFractionCalculatedFromPlenumTemperature { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes Equa" +
                     "tion is Return Air Fraction = Coefficient#1 - Coefficient#2 X PlenumTemp(degC)")]
        [JsonProperty(PropertyName="return_air_fraction_function_of_plenum_temperature_coefficient_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnAirFractionFunctionOfPlenumTemperatureCoefficient1 { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Used only if Return Air Fraction Is Calculated from Plenum Temperature = Yes Equa" +
                     "tion is Return Air Fraction = Coefficient#1 - Coefficient#2 X PlenumTemp(degC)")]
        [JsonProperty(PropertyName="return_air_fraction_function_of_plenum_temperature_coefficient_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnAirFractionFunctionOfPlenumTemperatureCoefficient2 { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Name of the return air node for this heat gain. If left blank, defaults to the fi" +
                     "rst return air node for the zone. Leave this field blank when using a ZoneList n" +
                     "ame.")]
        [JsonProperty(PropertyName="return_air_heat_gain_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnAirHeatGainNodeName { get; set; } = "";
    }
}