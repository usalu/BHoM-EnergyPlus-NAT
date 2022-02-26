using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to allow user-defined view factors to be used for duct-surfac" +
                 "e radiation calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_DuctViewFactors : BHoMObject
    {
        

        [JsonProperty(PropertyName="linkage_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LinkageName { get; set; } = "";
        

        [JsonProperty(PropertyName="duct_surface_exposure_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DuctSurfaceExposureFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="duct_surface_emittance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DuctSurfaceEmittance { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="surfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AirflowNetwork.AirflowNetwork_Distribution_DuctViewFactors_Surfaces_Item> Surfaces { get; set; } = null;
    }
}