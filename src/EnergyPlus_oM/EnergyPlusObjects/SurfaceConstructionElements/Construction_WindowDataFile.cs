using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Initiates search of the Window data file for a window called Name.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_WindowDataFile : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("default file name is \"Window5DataFile.dat\" limit on this field is 100 characters." +
                     "")]
        [JsonProperty(PropertyName="file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; } = "";
    }
}