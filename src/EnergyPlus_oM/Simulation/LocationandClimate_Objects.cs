using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Location and Climate")]
    public class LocationandClimate_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="Site:Location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Location Site_Location { get; set; } = null;
        

        [JsonProperty(PropertyName="Site:VariableLocation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_VariableLocation Site_VariableLocation { get; set; } = null;
        
        public bool ShouldSerializeSizingPeriod_DesignDay_List()
        {
            return (SizingPeriod_DesignDay_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SizingPeriod:DesignDay", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_DesignDay> SizingPeriod_DesignDay_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_DesignDay> ();
        
        public bool ShouldSerializeSizingPeriod_WeatherFileDays_List()
        {
            return (SizingPeriod_WeatherFileDays_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SizingPeriod:WeatherFileDays", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileDays> SizingPeriod_WeatherFileDays_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileDays> ();
        
        public bool ShouldSerializeSizingPeriod_WeatherFileConditionType_List()
        {
            return (SizingPeriod_WeatherFileConditionType_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SizingPeriod:WeatherFileConditionType", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileConditionType> SizingPeriod_WeatherFileConditionType_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.SizingPeriod_WeatherFileConditionType> ();
        
        public bool ShouldSerializeRunPeriod_List()
        {
            return (RunPeriod_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RunPeriod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriod> RunPeriod_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriod> ();
        
        public bool ShouldSerializeRunPeriodControl_SpecialDays_List()
        {
            return (RunPeriodControl_SpecialDays_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RunPeriodControl:SpecialDays", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_SpecialDays> RunPeriodControl_SpecialDays_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_SpecialDays> ();
        

        [JsonProperty(PropertyName="RunPeriodControl:DaylightSavingTime", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.RunPeriodControl_DaylightSavingTime RunPeriodControl_DaylightSavingTime { get; set; } = null;
        
        public bool ShouldSerializeWeatherProperty_SkyTemperature_List()
        {
            return (WeatherProperty_SkyTemperature_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WeatherProperty:SkyTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.WeatherProperty_SkyTemperature> WeatherProperty_SkyTemperature_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.WeatherProperty_SkyTemperature> ();
        

        [JsonProperty(PropertyName="Site:WeatherStation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WeatherStation Site_WeatherStation { get; set; } = null;
        

        [JsonProperty(PropertyName="Site:HeightVariation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_HeightVariation Site_HeightVariation { get; set; } = null;
        

        [JsonProperty(PropertyName="Site:GroundTemperature:BuildingSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_BuildingSurface Site_GroundTemperature_BuildingSurface { get; set; } = null;
        

        [JsonProperty(PropertyName="Site:GroundTemperature:FCfactorMethod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_FCfactorMethod Site_GroundTemperature_FCfactorMethod { get; set; } = null;
        

        [JsonProperty(PropertyName="Site:GroundTemperature:Shallow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Shallow Site_GroundTemperature_Shallow { get; set; } = null;
        

        [JsonProperty(PropertyName="Site:GroundTemperature:Deep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Deep Site_GroundTemperature_Deep { get; set; } = null;
        
        public bool ShouldSerializeSite_GroundTemperature_Undisturbed_FiniteDifference_List()
        {
            return (Site_GroundTemperature_Undisturbed_FiniteDifference_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:GroundTemperature:Undisturbed:FiniteDifference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_FiniteDifference> Site_GroundTemperature_Undisturbed_FiniteDifference_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_FiniteDifference> ();
        
        public bool ShouldSerializeSite_GroundTemperature_Undisturbed_KusudaAchenbach_List()
        {
            return (Site_GroundTemperature_Undisturbed_KusudaAchenbach_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:GroundTemperature:Undisturbed:KusudaAchenbach", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_KusudaAchenbach> Site_GroundTemperature_Undisturbed_KusudaAchenbach_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_KusudaAchenbach> ();
        
        public bool ShouldSerializeSite_GroundTemperature_Undisturbed_Xing_List()
        {
            return (Site_GroundTemperature_Undisturbed_Xing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:GroundTemperature:Undisturbed:Xing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_Xing> Site_GroundTemperature_Undisturbed_Xing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundTemperature_Undisturbed_Xing> ();
        
        public bool ShouldSerializeSite_GroundDomain_Slab_List()
        {
            return (Site_GroundDomain_Slab_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:GroundDomain:Slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Slab> Site_GroundDomain_Slab_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Slab> ();
        
        public bool ShouldSerializeSite_GroundDomain_Basement_List()
        {
            return (Site_GroundDomain_Basement_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:GroundDomain:Basement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Basement> Site_GroundDomain_Basement_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundDomain_Basement> ();
        

        [JsonProperty(PropertyName="Site:GroundReflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance Site_GroundReflectance { get; set; } = null;
        
        public bool ShouldSerializeSite_GroundReflectance_SnowModifier_List()
        {
            return (Site_GroundReflectance_SnowModifier_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:GroundReflectance:SnowModifier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance_SnowModifier> Site_GroundReflectance_SnowModifier_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_GroundReflectance_SnowModifier> ();
        
        public bool ShouldSerializeSite_WaterMainsTemperature_List()
        {
            return (Site_WaterMainsTemperature_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:WaterMainsTemperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WaterMainsTemperature> Site_WaterMainsTemperature_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_WaterMainsTemperature> ();
        
        public bool ShouldSerializeSite_Precipitation_List()
        {
            return (Site_Precipitation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:Precipitation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Precipitation> Site_Precipitation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_Precipitation> ();
        
        public bool ShouldSerializeRoofIrrigation_List()
        {
            return (RoofIrrigation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoofIrrigation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RoofIrrigation> RoofIrrigation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.RoofIrrigation> ();
        

        [JsonProperty(PropertyName="Site:SolarAndVisibleSpectrum", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SolarAndVisibleSpectrum Site_SolarAndVisibleSpectrum { get; set; } = null;
        
        public bool ShouldSerializeSite_SpectrumData_List()
        {
            return (Site_SpectrumData_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Site:SpectrumData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SpectrumData> Site_SpectrumData_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.LocationandClimate.Site_SpectrumData> ();
    }
}