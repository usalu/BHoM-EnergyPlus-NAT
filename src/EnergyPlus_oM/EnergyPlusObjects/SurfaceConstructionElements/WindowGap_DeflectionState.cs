using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Used to enter data describing deflection state of the gap. It is referenced from " +
                 "WindowMaterial:Gap object only and it is used only when deflection model is set " +
                 "to MeasuredDeflection, otherwise it is ignored.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowGap_DeflectionState : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If left blank will be considered that gap has no deflection.")]
        [JsonProperty(PropertyName="deflected_thickness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeflectedThickness { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="initial_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialTemperature { get; set; } = Double.Parse("25", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="initial_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialPressure { get; set; } = Double.Parse("101325", CultureInfo.InvariantCulture);
    }
}