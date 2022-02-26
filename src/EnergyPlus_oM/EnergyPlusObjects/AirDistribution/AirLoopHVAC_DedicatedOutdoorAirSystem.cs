using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Defines a central forced air system to provide dedicated outdoor air to multiple " +
                 "AirLoopHVACs.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_DedicatedOutdoorAirSystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of an AirLoopHVAC:OutdoorAirSystem object.")]
        [JsonProperty(PropertyName="airloophvac_outdoorairsystem_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirloophvacOutdoorairsystemName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Name of AirLoopHVAC:Mixer.")]
        [JsonProperty(PropertyName="airloophvac_mixer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirloophvacMixerName { get; set; } = "";
        

        [Description("Name of AirLoopHVAC:Splitter.")]
        [JsonProperty(PropertyName="airloophvac_splitter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirloophvacSplitterName { get; set; } = "";
        

        [JsonProperty(PropertyName="preheat_design_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PreheatDesignTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="preheat_design_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PreheatDesignHumidityRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="precool_design_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PrecoolDesignTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="precool_design_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PrecoolDesignHumidityRatio { get; set; } = null;
        

        [Description("Enter the number of the AirLoopHAVC served by AirLoopHVAC:DedicatedOutdoorAirSyst" +
                     "em")]
        [JsonProperty(PropertyName="number_of_airloophvac", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfAirloophvac { get; set; } = null;
        

        [Description("This list is the AirPrimaryLoops object-list")]
        [JsonProperty(PropertyName="airloophvacs", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Airloophvacs { get; set; } = null;
    }
}