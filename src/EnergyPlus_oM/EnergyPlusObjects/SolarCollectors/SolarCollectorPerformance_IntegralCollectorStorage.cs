using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SolarCollectors
{
    [Description("Thermal and optical performance parameters for a single glazed solar collector wi" +
                 "th integral storage unit.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SolarCollectorPerformance_IntegralCollectorStorage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Currently only RectangularTank ICS collector type is available.")]
        [JsonProperty(PropertyName="ics_collector_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType IcsCollectorType { get; set; } = (SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType)Enum.Parse(typeof(SolarCollectorPerformance_IntegralCollectorStorage_IcsCollectorType), "RectangularTank");
        

        [JsonProperty(PropertyName="gross_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GrossArea { get; set; } = null;
        

        [JsonProperty(PropertyName="collector_water_volume", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CollectorWaterVolume { get; set; } = null;
        

        [Description("Heat loss conductance of the collector bottom insulation")]
        [JsonProperty(PropertyName="bottom_heat_loss_conductance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BottomHeatLossConductance { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description("heat loss conductance of the collector side insulation")]
        [JsonProperty(PropertyName="side_heat_loss_conductance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SideHeatLossConductance { get; set; } = Double.Parse("0.6", CultureInfo.InvariantCulture);
        

        [Description("This value is ratio of the width (short side) to length (long side of) of the col" +
                     "lector. Used to calculate the perimeter of the collector")]
        [JsonProperty(PropertyName="aspect_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AspectRatio { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("This value is used to estimate collector side area for the heat loss calculation " +
                     "through the collector side")]
        [JsonProperty(PropertyName="collector_side_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CollectorSideHeight { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Calculated from the specific heat, density and thickness of the absorber plate.")]
        [JsonProperty(PropertyName="thermal_mass_of_absorber_plate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalMassOfAbsorberPlate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Number of transparent covers. Common practice is to use low-iron glass as the out" +
                     "er cover and very thin transparent sheet such as Teflon as the inner cover.")]
        [JsonProperty(PropertyName="number_of_covers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCovers { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("The gap between the transparent covers and between the inner cover and the absorb" +
                     "er plate")]
        [JsonProperty(PropertyName="cover_spacing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoverSpacing { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [Description("Refractive index of outer cover. Typically low-iron glass is used as the outer co" +
                     "ver material, and used as the default outer cover with a value of 1.526.")]
        [JsonProperty(PropertyName="refractive_index_of_outer_cover", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RefractiveIndexOfOuterCover { get; set; } = Double.Parse("1.526", CultureInfo.InvariantCulture);
        

        [Description("Clear glass has extinction coefficient of about 15 [1/m] and with thickness of 3." +
                     "0mm, the product of the extinction coefficient and thickness becomes 0.045 (=15 " +
                     "* 0.003)")]
        [JsonProperty(PropertyName="extinction_coefficient_times_thickness_of_outer_cover", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExtinctionCoefficientTimesThicknessOfOuterCover { get; set; } = Double.Parse("0.045", CultureInfo.InvariantCulture);
        

        [Description("Thermal emissivity of the outer cover, commonly glass is used as the out collecto" +
                     "r cover material.")]
        [JsonProperty(PropertyName="emissivity_of_outer_cover", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EmissivityOfOuterCover { get; set; } = Double.Parse("0.88", CultureInfo.InvariantCulture);
        

        [Description("Typical material is very thin sheet of Teflon (PTFE). The default value is refrac" +
                     "tive index of Teflon.")]
        [JsonProperty(PropertyName="refractive_index_of_inner_cover", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RefractiveIndexOfInnerCover { get; set; } = Double.Parse("1.37", CultureInfo.InvariantCulture);
        

        [Description("Default inner cover is very thin sheet of Teflon with extinction coefficient of a" +
                     "pproximately 40.0 and a thickness 0.2mm yields a default value of 0.008.")]
        [JsonProperty(PropertyName="extinction_coefficient_times_thickness_of_the_inner_cover", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExtinctionCoefficientTimesThicknessOfTheInnerCover { get; set; } = Double.Parse("0.008", CultureInfo.InvariantCulture);
        

        [Description("Thermal emissivity of the inner cover material")]
        [JsonProperty(PropertyName="emissivity_of_inner_cover", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EmissivityOfInnerCover { get; set; } = Double.Parse("0.88", CultureInfo.InvariantCulture);
        

        [Description("The absorber plate solar absorptance. Copper is assumed as the default absorber p" +
                     "late.")]
        [JsonProperty(PropertyName="absorptance_of_absorber_plate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AbsorptanceOfAbsorberPlate { get; set; } = Double.Parse("0.96", CultureInfo.InvariantCulture);
        

        [Description("Thermal emissivity of the absorber plate")]
        [JsonProperty(PropertyName="emissivity_of_absorber_plate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EmissivityOfAbsorberPlate { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
    }
}