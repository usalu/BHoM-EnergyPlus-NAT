using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("This object adds a chiller to an HVACTemplate:Plant:ChilledWaterLoop.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Plant_Chiller : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="chiller_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Chiller_ChillerType ChillerType { get; set; } = (HVACTemplate_Plant_Chiller_ChillerType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_ChillerType), "DistrictChilledWater");
        

        [JsonProperty(PropertyName="capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Capacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Not applicable if Chiller Type is DistrictChilledWater Electric Reciprocating Chi" +
                     "ller")]
        [JsonProperty(PropertyName="nominal_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCop { get; set; } = null;
        

        [Description("Not applicable if Chiller Type is DistrictChilledWater")]
        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Plant_Chiller_CondenserType CondenserType { get; set; } = (HVACTemplate_Plant_Chiller_CondenserType)Enum.Parse(typeof(HVACTemplate_Plant_Chiller_CondenserType), "WaterCooled");
        

        [Description("If Chiller Plant Operation Scheme Type=Default in HVACTemplate:Plant:ChilledWater" +
                     "Loop, then equipment operates in Priority order, 1, 2, 3, etc.")]
        [JsonProperty(PropertyName="priority", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Priority { get; set; } = "";
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Part load ratio below which the chiller starts cycling on/off to meet the load. M" +
                     "ust be less than or equal to Maximum Part Load Ratio.")]
        [JsonProperty(PropertyName="minimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPartLoadRatio { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Maximum allowable part load ratio. Must be greater than or equal to Minimum Part " +
                     "Load Ratio.")]
        [JsonProperty(PropertyName="maximum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Optimum part load ratio where the chiller is most efficient. Must be greater than" +
                     " or equal to the Minimum Part Load Ratio and less than or equal to the Maximum P" +
                     "art Load Ratio.")]
        [JsonProperty(PropertyName="optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OptimumPartLoadRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Part load ratio where the chiller can no longer unload and false loading begins. " +
                     "Minimum unloading ratio must be greater than or equal to the Minimum Part Load R" +
                     "atio and less than or equal to the Maximum Part Load Ratio.")]
        [JsonProperty(PropertyName="minimum_unloading_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumUnloadingRatio { get; set; } = Double.Parse("0.25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="leaving_chilled_water_lower_temperature_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeavingChilledWaterLowerTemperatureLimit { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
    }
}