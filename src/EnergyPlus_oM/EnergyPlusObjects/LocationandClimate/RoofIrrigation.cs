using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("Used to describe the amount of irrigation on the ecoroof surface over the course " +
                 "of the simulation runperiod.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RoofIrrigation : BHoMObject
    {
        

        [Description("SmartSchedule will not allow irrigation when soil is already moist. Current thres" +
                     "hold set at 30% of saturation.")]
        [JsonProperty(PropertyName="irrigation_model_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RoofIrrigation_IrrigationModelType IrrigationModelType { get; set; } = (RoofIrrigation_IrrigationModelType)Enum.Parse(typeof(RoofIrrigation_IrrigationModelType), "Schedule");
        

        [Description("Schedule values in meters of water per hour values should be non-negative")]
        [JsonProperty(PropertyName="irrigation_rate_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IrrigationRateScheduleName { get; set; } = "";
        

        [Description("Used with SmartSchedule to set the saturation level at which no irrigation is all" +
                     "owed.")]
        [JsonProperty(PropertyName="irrigation_maximum_saturation_threshold", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IrrigationMaximumSaturationThreshold { get; set; } = Double.Parse("40", CultureInfo.InvariantCulture);
    }
}