using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object adds a boiler to an HVACTemplate:Plant:HotWaterLoop or MixedWaterLoop" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_Boiler : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="boiler_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_BoilerType BoilerType { get; set; } = (HVACTemplate_Plant_Boiler_BoilerType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_BoilerType), "CondensingHotWaterBoiler");
        

        [JsonProperty(PropertyName="capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Capacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Not applicable  if Boiler Type is DistrictHotWater")]
        [JsonProperty(PropertyName="efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Efficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Not applicable  if Boiler Type is DistrictHotWater")]
        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_FuelType FuelType { get; set; } = (HVACTemplate_Plant_Boiler_FuelType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_FuelType), "Coal");
        

        [Description("If Hot Water Plant Operation Scheme Type=Default in HVACTemplate:Plant:HotWaterLo" +
                     "op, then equipment operates in priority order, 1, 2, 3, etc.")]
        [JsonProperty(PropertyName="priority", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Priority { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPartLoadRatio { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPartLoadRatio { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OptimumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="water_outlet_upper_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterOutletUpperTemperatureLimit { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("Specifies if this boiler serves a template hot water loop or mixed water loop If " +
                     "left blank, will serve a hot water loop if present, or a mixed water loop (if no" +
                     " hot water loop is present).")]
        [JsonProperty(PropertyName="template_plant_loop_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Boiler_TemplatePlantLoopType TemplatePlantLoopType { get; set; } = (HVACTemplate_Plant_Boiler_TemplatePlantLoopType)Enum.Parse(typeof(HVACTemplate_Plant_Boiler_TemplatePlantLoopType), "HotWater");
    }
}