using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Alternate method of describing windows This window material object is used to def" +
                 "ine an entire glazing system using simple performance parameters.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowMaterial_SimpleGlazingSystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter U-Factor including film coefficients Note that the effective upper limit fo" +
                     "r U-factor is 5.8 W/m2-K")]
        [JsonProperty(PropertyName="u_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> UFactor { get; set; } = null;
        

        [Description("SHGC at Normal Incidence")]
        [JsonProperty(PropertyName="solar_heat_gain_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolarHeatGainCoefficient { get; set; } = null;
        

        [Description("VT at Normal Incidence optional")]
        [JsonProperty(PropertyName="visible_transmittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VisibleTransmittance { get; set; } = null;
    }
}