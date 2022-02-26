using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Determines which Heat Balance Algorithm will be used for a group of surface types Allows selectively overriding the global setting in HeatBalanceAlgorithm CTF (Conduction Transfer Functions), EMPD (Effective Moisture Penetration Depth with Conduction Transfer Functions). Advanced/Research Usage: CondFD (Conduction Finite Difference) Advanced/Research Usage: HAMT (Combined Heat And Moisture Finite Element)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_HeatTransferAlgorithm_MultipleSurface : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="surface_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType SurfaceType { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_SurfaceType), "AllExteriorFloors");
        

        [JsonProperty(PropertyName="algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm Algorithm { get; set; } = (SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm)Enum.Parse(typeof(SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm), "ConductionTransferFunction");
    }
}