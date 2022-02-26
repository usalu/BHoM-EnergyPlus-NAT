using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object references a detailed boiler object and adds it to an HVACTemplate:Pl" +
                 "ant:HotWaterLoop or MixedWaterLoop. The user must create a complete detailed boi" +
                 "ler object with all required curve or performance objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_Boiler_ObjectReference : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="boiler_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType BoilerObjectType { get; set; } = (HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_ObjectReference_BoilerObjectType), "Empty");
        

        [Description("The name of the detailed boiler object.")]
        [JsonProperty(PropertyName="boiler_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BoilerName { get; set; } = "";
        

        [Description("If Hot Water Plant Operation Scheme Type=Default in HVACTemplate:Plant:HotWaterLo" +
                     "op or MixedWaterLoop, then equipment operates in Priority order, 1, 2, 3, etc.")]
        [JsonProperty(PropertyName="priority", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Priority { get; set; } = null;
        

        [Description("Specifies if this boiler serves a template hot water loop or mixed water loop If " +
                     "left blank, will serve a hot water loop if present, or a mixed water loop (if no" +
                     " hot water loop is present).")]
        [JsonProperty(PropertyName="template_plant_loop_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_ObjectReference_TemplatePlantLoopType), "HotWater");
    }
}