using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    [Description("fluid properties for water/other fluid mixtures")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Concentration : BHoMObject
    {
        

        [Description("should not be any of the defaults (Water, EthyleneGlycol, or PropyleneGlycol)")]
        [JsonProperty(PropertyName="fluid_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FluidName { get; set; } = "";
        

        [Description("Density Units are kg/m3 SpecificHeat Units are J/kg-K Conductivity Units are W/m-" +
                     "K Viscosity Units are N-s/m2")]
        [JsonProperty(PropertyName="fluid_property_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FluidProperties_Concentration_FluidPropertyType FluidPropertyType { get; set; } = (FluidProperties_Concentration_FluidPropertyType)Enum.Parse(typeof(FluidProperties_Concentration_FluidPropertyType), "Conductivity");
        

        [Description("Enter the name of a FluidProperties:Temperatures object.")]
        [JsonProperty(PropertyName="temperature_values_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemperatureValuesName { get; set; } = "";
        

        [Description("Glycol concentration for this list of properties entered as a fraction")]
        [JsonProperty(PropertyName="concentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Concentration { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue1 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue2 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue3 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue4 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue5 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue6 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue7 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue8 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue9 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue10 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue11 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue12 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue13 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue14 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue15 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue16 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue17 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue18 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue19 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue20 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue21 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue22 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue23 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue24 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue25 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_26", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue26 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_27", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue27 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_28", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue28 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_29", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue29 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_30", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue30 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_31", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue31 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_32", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue32 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_33", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue33 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_34", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue34 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_35", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue35 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_36", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue36 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_37", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue37 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_38", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue38 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_39", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue39 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_40", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue40 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_41", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue41 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_42", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue42 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_43", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue43 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_44", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue44 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_45", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue45 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_46", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue46 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_47", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue47 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_48", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue48 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_49", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue49 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_50", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue50 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_51", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue51 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_52", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue52 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_53", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue53 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_54", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue54 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_55", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue55 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_56", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue56 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_57", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue57 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_58", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue58 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_59", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue59 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_60", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue60 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_61", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue61 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_62", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue62 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_63", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue63 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_64", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue64 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_65", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue65 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_66", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue66 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_67", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue67 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_68", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue68 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_69", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue69 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_70", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue70 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_71", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue71 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_72", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue72 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_73", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue73 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_74", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue74 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_75", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue75 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_76", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue76 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_77", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue77 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_78", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue78 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_79", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue79 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_80", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue80 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_81", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue81 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_82", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue82 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_83", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue83 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_84", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue84 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_85", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue85 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_86", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue86 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_87", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue87 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_88", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue88 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_89", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue89 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_90", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue90 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_91", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue91 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_92", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue92 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_93", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue93 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_94", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue94 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_95", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue95 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_96", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue96 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_97", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue97 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_98", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue98 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_99", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue99 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_100", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue100 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_101", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue101 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_102", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue102 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_103", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue103 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_104", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue104 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_105", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue105 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_106", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue106 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_107", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue107 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_108", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue108 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_109", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue109 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_110", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue110 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_111", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue111 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_112", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue112 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_113", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue113 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_114", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue114 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_115", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue115 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_116", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue116 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_117", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue117 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_118", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue118 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_119", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue119 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_120", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue120 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_121", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue121 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_122", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue122 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_123", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue123 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_124", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue124 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_125", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue125 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_126", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue126 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_127", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue127 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_128", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue128 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_129", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue129 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_130", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue130 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_131", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue131 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_132", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue132 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_133", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue133 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_134", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue134 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_135", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue135 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_136", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue136 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_137", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue137 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_138", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue138 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_139", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue139 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_140", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue140 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_141", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue141 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_142", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue142 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_143", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue143 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_144", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue144 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_145", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue145 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_146", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue146 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_147", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue147 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_148", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue148 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_149", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue149 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_150", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue150 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_151", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue151 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_152", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue152 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_153", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue153 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_154", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue154 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_155", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue155 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_156", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue156 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_157", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue157 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_158", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue158 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_159", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue159 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_160", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue160 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_161", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue161 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_162", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue162 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_163", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue163 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_164", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue164 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_165", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue165 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_166", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue166 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_167", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue167 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_168", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue168 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_169", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue169 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_170", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue170 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_171", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue171 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_172", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue172 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_173", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue173 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_174", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue174 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_175", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue175 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_176", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue176 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_177", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue177 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_178", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue178 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_179", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue179 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_180", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue180 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_181", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue181 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_182", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue182 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_183", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue183 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_184", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue184 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_185", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue185 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_186", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue186 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_187", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue187 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_188", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue188 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_189", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue189 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_190", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue190 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_191", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue191 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_192", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue192 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_193", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue193 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_194", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue194 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_195", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue195 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_196", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue196 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_197", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue197 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_198", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue198 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_199", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue199 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_200", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue200 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_201", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue201 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_202", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue202 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_203", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue203 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_204", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue204 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_205", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue205 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_206", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue206 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_207", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue207 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_208", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue208 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_209", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue209 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_210", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue210 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_211", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue211 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_212", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue212 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_213", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue213 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_214", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue214 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_215", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue215 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_216", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue216 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_217", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue217 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_218", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue218 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_219", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue219 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_220", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue220 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_221", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue221 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_222", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue222 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_223", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue223 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_224", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue224 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_225", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue225 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_226", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue226 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_227", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue227 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_228", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue228 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_229", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue229 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_230", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue230 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_231", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue231 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_232", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue232 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_233", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue233 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_234", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue234 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_235", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue235 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_236", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue236 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_237", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue237 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_238", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue238 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_239", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue239 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_240", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue240 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_241", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue241 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_242", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue242 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_243", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue243 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_244", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue244 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_245", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue245 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_246", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue246 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_247", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue247 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_248", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue248 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_249", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue249 { get; set; } = null;
        

        [JsonProperty(PropertyName="property_value_250", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PropertyValue250 { get; set; } = null;
    }
}