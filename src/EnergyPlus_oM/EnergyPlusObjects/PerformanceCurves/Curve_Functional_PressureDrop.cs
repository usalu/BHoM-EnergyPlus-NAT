using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PerformanceCurves
{
    [Description("Sets up curve information for minor loss and/or friction calculations in plant pr" +
                 "essure simulations Expression: DeltaP = {K + f*(L/D)} * (rho * V^2) / 2")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Curve_Functional_PressureDrop : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("\"D\" in above expression, used to also calculate local velocity")]
        [JsonProperty(PropertyName="diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Diameter { get; set; } = null;
        

        [Description("\"K\" in above expression")]
        [JsonProperty(PropertyName="minor_loss_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinorLossCoefficient { get; set; } = null;
        

        [Description("\"L\" in above expression")]
        [JsonProperty(PropertyName="length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Length { get; set; } = null;
        

        [Description("This will be used to calculate \"f\" from Moody-chart approximations")]
        [JsonProperty(PropertyName="roughness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Roughness { get; set; } = null;
        

        [Description("Optional way to set a constant value for \"f\", instead of using internal Moody-cha" +
                     "rt approximations")]
        [JsonProperty(PropertyName="fixed_friction_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FixedFrictionFactor { get; set; } = null;
    }
}