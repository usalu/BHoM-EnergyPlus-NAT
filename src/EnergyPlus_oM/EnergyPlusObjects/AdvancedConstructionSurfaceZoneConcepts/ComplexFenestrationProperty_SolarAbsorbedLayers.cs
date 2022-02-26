using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to provide solar radiation absorbed in fenestration layers. References surfa" +
                 "ce-construction pair and if that pair is used in a simulation, then program will" +
                 " use value provided in schedules instead of calculating it.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ComplexFenestrationProperty_SolarAbsorbedLayers : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="fenestration_surface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FenestrationSurface { get; set; } = "";
        

        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty(PropertyName="layer_1_solar_radiation_absorbed_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer1SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty(PropertyName="layer_2_solar_radiation_absorbed_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer2SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty(PropertyName="layer_3_solar_radiation_absorbed_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer3SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty(PropertyName="layer_4_solar_radiation_absorbed_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer4SolarRadiationAbsorbedScheduleName { get; set; } = "";
        

        [Description("Values in schedule are expected to be in W/m2")]
        [JsonProperty(PropertyName="layer_5_solar_radiation_absorbed_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Layer5SolarRadiationAbsorbedScheduleName { get; set; } = "";
    }
}