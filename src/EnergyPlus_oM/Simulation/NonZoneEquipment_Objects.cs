using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Non-Zone Equipment")]
    public class NonZoneEquipment_Objects : BHoMObject
    {
        
        public bool ShouldSerializeLoadProfile_Plant_List()
        {
            return (LoadProfile_Plant_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="LoadProfile:Plant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NonZoneEquipment.LoadProfile_Plant> LoadProfile_Plant_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.NonZoneEquipment.LoadProfile_Plant> ();
    }
}