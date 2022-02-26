using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object sets the other side conditions for a surface in a variety of ways.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_OtherSideCoefficients : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"if>0, this field becomes the exterior convective/radiative film coefficient and the other fields are used to calculate the outdoor air temperature then exterior surface temperature based on outdoor air and specified coefficient if<=0, then remaining fields calculate the outside surface temperature The following fields are used in the equation: OtherSideTemp=N2*N3 + N4*OutdoorDry-bulb + N5*GroundTemp + N6*WindSpeed*OutdoorDry-bulb + N7*TempZone + N9*TempPrev")]
        [JsonProperty(PropertyName="combined_convective_radiative_film_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CombinedConvectiveRadiativeFilmCoefficient { get; set; } = null;
        

        [Description("This parameter will be overwritten by the values from the Constant Temperature Sc" +
                     "hedule Name (below) if one is present")]
        [JsonProperty(PropertyName="constant_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantTemperature { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This coefficient is used even with a Schedule. It should normally be 1.0 in that " +
                     "case. This field is ignored if Sinusoidal Variation of Constant Temperature Coef" +
                     "ficient = Yes.")]
        [JsonProperty(PropertyName="constant_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantTemperatureCoefficient { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="external_dry_bulb_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExternalDryBulbTemperatureCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="ground_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GroundTemperatureCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="wind_speed_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindSpeedCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_air_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneAirTemperatureCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Name of schedule for values of constant temperature. Schedule values replace any " +
                     "value specified in the field Constant Temperature.")]
        [JsonProperty(PropertyName="constant_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstantTemperatureScheduleName { get; set; } = "";
        

        [Description("Optionally used to vary Constant Temperature Coefficient with unitary sine wave")]
        [JsonProperty(PropertyName="sinusoidal_variation_of_constant_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes SinusoidalVariationOfConstantTemperatureCoefficient { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Use with sinusoidal variation to define the time period")]
        [JsonProperty(PropertyName="period_of_sinusoidal_variation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PeriodOfSinusoidalVariation { get; set; } = Double.Parse("24", CultureInfo.InvariantCulture);
        

        [Description("This coefficient multiplies the other side temperature result from the previous z" +
                     "one timestep")]
        [JsonProperty(PropertyName="previous_other_side_temperature_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PreviousOtherSideTemperatureCoefficient { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field specifies a lower limit for the other side temperature result. Blank i" +
                     "ndicates no limit")]
        [JsonProperty(PropertyName="minimum_other_side_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOtherSideTemperatureLimit { get; set; } = null;
        

        [Description("This field specifies an upper limit for the other side temperature result. Blank " +
                     "indicates no limit")]
        [JsonProperty(PropertyName="maximum_other_side_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOtherSideTemperatureLimit { get; set; } = null;
    }
}