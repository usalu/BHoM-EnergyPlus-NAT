using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Additional material properties for surfaces. Has no effect with other HeatBa" +
                 "lanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_Settings : BHoMObject
    {
        

        [Description("Material Name that the moisture properties will be added to. This augments materi" +
                     "al properties needed for combined heat and moisture transfer for surfaces.")]
        [JsonProperty(PropertyName="material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaterialName { get; set; } = "";
        

        [JsonProperty(PropertyName="porosity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Porosity { get; set; } = null;
        

        [Description("units are the water/material density ratio at the beginning of each run period.")]
        [JsonProperty(PropertyName="initial_water_content_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialWaterContentRatio { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
    }
}