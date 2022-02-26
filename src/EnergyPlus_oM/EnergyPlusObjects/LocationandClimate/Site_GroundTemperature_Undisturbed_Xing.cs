using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Undisturbed ground temperature object using the Xing 2014 2 harmonic parameter mo" +
                 "del.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Site_GroundTemperature_Undisturbed_Xing : BHoMObject, IEnergyPlusNode
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
        

        [JsonProperty(PropertyName="average_soil_surface_tempeature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AverageSoilSurfaceTempeature { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_surface_temperature_amplitude_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSurfaceTemperatureAmplitude1 { get; set; } = null;
        

        [JsonProperty(PropertyName="soil_surface_temperature_amplitude_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SoilSurfaceTemperatureAmplitude2 { get; set; } = null;
        

        [JsonProperty(PropertyName="phase_shift_of_temperature_amplitude_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PhaseShiftOfTemperatureAmplitude1 { get; set; } = null;
        

        [JsonProperty(PropertyName="phase_shift_of_temperature_amplitude_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PhaseShiftOfTemperatureAmplitude2 { get; set; } = null;
    }
}