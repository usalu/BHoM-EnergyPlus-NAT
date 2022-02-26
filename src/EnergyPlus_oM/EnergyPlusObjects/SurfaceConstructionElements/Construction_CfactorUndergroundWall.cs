using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing underground wall constructions")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_CfactorUndergroundWall : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter C-Factor without film coefficients or soil")]
        [JsonProperty(PropertyName="c_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CFactor { get; set; } = null;
        

        [Description("Enter height of the underground wall")]
        [JsonProperty(PropertyName="height", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Height { get; set; } = null;
    }
}