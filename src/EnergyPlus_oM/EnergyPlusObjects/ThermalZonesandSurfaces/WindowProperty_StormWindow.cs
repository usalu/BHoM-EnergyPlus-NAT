using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("This is a movable exterior glass layer that is usually applied in the winter and " +
                 "removed in the summer.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowProperty_StormWindow : BHoMObject
    {
        

        [Description("Must be the name of a FenestrationSurface:Detailed object with Surface Type = WIN" +
                     "DOW. The WindowProperty:StormWindow object can only be used with exterior window" +
                     "s.")]
        [JsonProperty(PropertyName="window_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WindowName { get; set; } = "";
        

        [Description("Must be a WindowMaterial:Glazing or WindowMaterial:Glazing:RefractionExtinctionMe" +
                     "thod Gap between storm glass layer and adjacent glass layer is assumed to be fil" +
                     "led with Air")]
        [JsonProperty(PropertyName="storm_glass_layer_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StormGlassLayerName { get; set; } = "";
        

        [JsonProperty(PropertyName="distance_between_storm_glass_layer_and_adjacent_glass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceBetweenStormGlassLayerAndAdjacentGlass { get; set; } = Double.Parse("0.05", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="month_that_storm_glass_layer_is_put_on", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MonthThatStormGlassLayerIsPutOn { get; set; } = null;
        

        [JsonProperty(PropertyName="day_of_month_that_storm_glass_layer_is_put_on", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DayOfMonthThatStormGlassLayerIsPutOn { get; set; } = null;
        

        [JsonProperty(PropertyName="month_that_storm_glass_layer_is_taken_off", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MonthThatStormGlassLayerIsTakenOff { get; set; } = null;
        

        [JsonProperty(PropertyName="day_of_month_that_storm_glass_layer_is_taken_off", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DayOfMonthThatStormGlassLayerIsTakenOff { get; set; } = null;
    }
}