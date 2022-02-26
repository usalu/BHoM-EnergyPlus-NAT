using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the conditions under which the air mass flow coefficient wa" +
                 "s measured.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_ReferenceCrackConditions : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the reference temperature under which the surface crack data were obtained." +
                     "")]
        [JsonProperty(PropertyName="reference_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceTemperature { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description("Enter the reference barometric pressure under which the surface crack data were o" +
                     "btained.")]
        [JsonProperty(PropertyName="reference_barometric_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceBarometricPressure { get; set; } = Double.Parse("101325", CultureInfo.InvariantCulture);
        

        [Description("Enter the reference humidity ratio under which the surface crack data were obtain" +
                     "ed.")]
        [JsonProperty(PropertyName="reference_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceHumidityRatio { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}