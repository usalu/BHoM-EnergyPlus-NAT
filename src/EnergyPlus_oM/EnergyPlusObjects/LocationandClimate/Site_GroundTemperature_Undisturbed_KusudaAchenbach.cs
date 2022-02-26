using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Undisturbed ground temperature object using the Kusuda-Achenbach 1965 correlation" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_KusudaAchenbach : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="soil_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilThermalConductivity { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilDensity { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSpecificHeat { get; set; } = null;
        

        [Description("Annual average surface temperature If left blank the Site:GroundTemperature:Shall" +
                     "ow object must be included in the input The soil temperature, amplitude, and pha" +
                     "se shift must all be included or omitted together")]
        [JsonProperty(PropertyName="average_soil_surface_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageSoilSurfaceTemperature { get; set; } = null;
        

        [Description("Annual average surface temperature variation from average. If left blank the Site" +
                     ":GroundTemperature:Shallow object must be included in the input The soil tempera" +
                     "ture, amplitude, and phase shift must all be included or omitted together")]
        [JsonProperty(PropertyName="average_amplitude_of_surface_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageAmplitudeOfSurfaceTemperature { get; set; } = null;
        

        [Description(@"The phase shift of minimum surface temperature, or the day of the year when the minimum surface temperature occurs. If left blank the Site:GroundTemperature:Shallow object must be included in the input The soil temperature, amplitude, and phase shift must all be included or omitted together")]
        [JsonProperty(PropertyName="phase_shift_of_minimum_surface_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PhaseShiftOfMinimumSurfaceTemperature { get; set; } = null;
    }
}