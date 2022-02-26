using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Adds a multiplier to a ZoneList. This can be used to reduce the amount of input n" +
                 "ecessary for simulating repetitive structures, such as the identical floors of a" +
                 " multi-story building.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneGroup : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneListName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_list_multiplier", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneListMultiplier { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}