using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"Refrigeration Door Mixing is used for an opening between two zones that are at the same elevation but have different air temperatures. In this case, the mixing air flow between the two zones is determined by the density difference between the two zones. This would typically be used between two zones in a refrigerated warehouse that are controlled at different temperatures. It could also be used to model a door to a walk-in refrigerated space if that space were modeled as a zone instead of using the object Refrigeration:WalkIn.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneRefrigerationDoorMixing : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone1Name { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Zone2Name { get; set; } = "";
        

        [Description(@"This schedule defines the fraction of the time the refrigeration door is open For example, if the warehouse is closed at night and there are no door openings between two zones, the value for that time period would be 0. If doors were propped open, the value  over that time period would be 1.0 If the doors were open about 20% of the time, the value over that period would be 0.2 Schedule values must lie between 0 and 1.0")]
        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="door_height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DoorHeight { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="door_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DoorArea { get; set; } = Double.Parse("9", CultureInfo.InvariantCulture);
        

        [Description("Door protection can reduce the air flow through a refrigeration door The default " +
                     "value is \"None\" Choices: \"None\", \"AirCurtain\", and \"StripCurtain\" A strip curtai" +
                     "n reduces the air flow more than an air curtain")]
        [JsonProperty(PropertyName="door_protection_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneRefrigerationDoorMixing_DoorProtectionType DoorProtectionType { get; set; } = (ZoneRefrigerationDoorMixing_DoorProtectionType)Enum.Parse(typeof(ZoneRefrigerationDoorMixing_DoorProtectionType), "None");
    }
}