using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description(@"Simulates an object of pre-determined (constant or scheduled) source temperature The object introduces fluid into the plant loop at the specified temperature and at the same flow rate as the fluid enters the component Fluid entering the component vanishes equivalent to the relief air in an air system")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantComponent_TemperatureSource : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of the source inlet node")]
        [JsonProperty(PropertyName="inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletNode { get; set; } = "";
        

        [Description("Name of the source outlet node")]
        [JsonProperty(PropertyName="outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletNode { get; set; } = "";
        

        [Description("The design volumetric flow rate for this source")]
        [JsonProperty(PropertyName="design_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignVolumeFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="temperature_specification_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantComponent_TemperatureSource_TemperatureSpecificationType TemperatureSpecificationType { get; set; } = (PlantComponent_TemperatureSource_TemperatureSpecificationType)Enum.Parse(typeof(PlantComponent_TemperatureSource_TemperatureSpecificationType), "Constant");
        

        [Description("Used if Temperature Specification Type = Constant")]
        [JsonProperty(PropertyName="source_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceTemperature { get; set; } = null;
        

        [Description("Used if Temperature Specification Type = Scheduled")]
        [JsonProperty(PropertyName="source_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceTemperatureScheduleName { get; set; } = "";
    }
}