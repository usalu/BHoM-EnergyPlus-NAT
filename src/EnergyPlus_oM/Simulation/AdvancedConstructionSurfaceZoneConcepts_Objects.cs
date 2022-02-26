using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Advanced Construction, Surface, Zone " +
                 "Concepts")]
    public class AdvancedConstructionSurfaceZoneConcepts_Objects : BHoMObject
    {
        
        public bool ShouldSerializeSurfaceProperty_HeatTransferAlgorithm_List()
        {
            return (SurfaceProperty_HeatTransferAlgorithm_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm> SurfaceProperty_HeatTransferAlgorithm_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm> ();
        
        public bool ShouldSerializeSurfaceProperty_HeatTransferAlgorithm_MultipleSurface_List()
        {
            return (SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm:MultipleSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_MultipleSurface> SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_MultipleSurface> ();
        
        public bool ShouldSerializeSurfaceProperty_HeatTransferAlgorithm_SurfaceList_List()
        {
            return (SurfaceProperty_HeatTransferAlgorithm_SurfaceList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm:SurfaceList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_SurfaceList> SurfaceProperty_HeatTransferAlgorithm_SurfaceList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_SurfaceList> ();
        
        public bool ShouldSerializeSurfaceProperty_HeatTransferAlgorithm_Construction_List()
        {
            return (SurfaceProperty_HeatTransferAlgorithm_Construction_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:HeatTransferAlgorithm:Construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_Construction> SurfaceProperty_HeatTransferAlgorithm_Construction_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatTransferAlgorithm_Construction> ();
        
        public bool ShouldSerializeSurfaceProperty_HeatBalanceSourceTerm_List()
        {
            return (SurfaceProperty_HeatBalanceSourceTerm_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:HeatBalanceSourceTerm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatBalanceSourceTerm> SurfaceProperty_HeatBalanceSourceTerm_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_HeatBalanceSourceTerm> ();
        
        public bool ShouldSerializeSurfaceControl_MovableInsulation_List()
        {
            return (SurfaceControl_MovableInsulation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceControl:MovableInsulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceControl_MovableInsulation> SurfaceControl_MovableInsulation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceControl_MovableInsulation> ();
        
        public bool ShouldSerializeSurfaceProperty_OtherSideCoefficients_List()
        {
            return (SurfaceProperty_OtherSideCoefficients_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:OtherSideCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideCoefficients> SurfaceProperty_OtherSideCoefficients_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideCoefficients> ();
        
        public bool ShouldSerializeSurfaceProperty_OtherSideConditionsModel_List()
        {
            return (SurfaceProperty_OtherSideConditionsModel_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:OtherSideConditionsModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideConditionsModel> SurfaceProperty_OtherSideConditionsModel_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_OtherSideConditionsModel> ();
        
        public bool ShouldSerializeSurfaceProperty_Underwater_List()
        {
            return (SurfaceProperty_Underwater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:Underwater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_Underwater> SurfaceProperty_Underwater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_Underwater> ();
        
        public bool ShouldSerializeFoundation_Kiva_List()
        {
            return (Foundation_Kiva_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Foundation:Kiva", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva> Foundation_Kiva_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva> ();
        
        public bool ShouldSerializeFoundation_Kiva_Settings_List()
        {
            return (Foundation_Kiva_Settings_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Foundation:Kiva:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva_Settings> Foundation_Kiva_Settings_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva_Settings> ();
        
        public bool ShouldSerializeSurfaceProperty_ExposedFoundationPerimeter_List()
        {
            return (SurfaceProperty_ExposedFoundationPerimeter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:ExposedFoundationPerimeter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExposedFoundationPerimeter> SurfaceProperty_ExposedFoundationPerimeter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExposedFoundationPerimeter> ();
        

        [JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Inside:AdaptiveModelSelections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections { get; set; } = null;
        

        [JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Outside:AdaptiveModelSelections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections SurfaceConvectionAlgorithm_Outside_AdaptiveModelSelections { get; set; } = null;
        
        public bool ShouldSerializeSurfaceConvectionAlgorithm_Inside_UserCurve_List()
        {
            return (SurfaceConvectionAlgorithm_Inside_UserCurve_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Inside:UserCurve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_UserCurve> SurfaceConvectionAlgorithm_Inside_UserCurve_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Inside_UserCurve> ();
        
        public bool ShouldSerializeSurfaceConvectionAlgorithm_Outside_UserCurve_List()
        {
            return (SurfaceConvectionAlgorithm_Outside_UserCurve_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceConvectionAlgorithm:Outside:UserCurve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_UserCurve> SurfaceConvectionAlgorithm_Outside_UserCurve_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceConvectionAlgorithm_Outside_UserCurve> ();
        
        public bool ShouldSerializeSurfaceProperty_ConvectionCoefficients_List()
        {
            return (SurfaceProperty_ConvectionCoefficients_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:ConvectionCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients> SurfaceProperty_ConvectionCoefficients_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients> ();
        
        public bool ShouldSerializeSurfaceProperty_ConvectionCoefficients_MultipleSurface_List()
        {
            return (SurfaceProperty_ConvectionCoefficients_MultipleSurface_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:ConvectionCoefficients:MultipleSurface", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients_MultipleSurface> SurfaceProperty_ConvectionCoefficients_MultipleSurface_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ConvectionCoefficients_MultipleSurface> ();
        
        public bool ShouldSerializeSurfaceProperties_VaporCoefficients_List()
        {
            return (SurfaceProperties_VaporCoefficients_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperties:VaporCoefficients", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperties_VaporCoefficients> SurfaceProperties_VaporCoefficients_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperties_VaporCoefficients> ();
        
        public bool ShouldSerializeSurfaceProperty_ExteriorNaturalVentedCavity_List()
        {
            return (SurfaceProperty_ExteriorNaturalVentedCavity_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:ExteriorNaturalVentedCavity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExteriorNaturalVentedCavity> SurfaceProperty_ExteriorNaturalVentedCavity_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_ExteriorNaturalVentedCavity> ();
        
        public bool ShouldSerializeSurfaceProperty_SolarIncidentInside_List()
        {
            return (SurfaceProperty_SolarIncidentInside_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:SolarIncidentInside", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SolarIncidentInside> SurfaceProperty_SolarIncidentInside_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SolarIncidentInside> ();
        
        public bool ShouldSerializeSurfaceProperty_LocalEnvironment_List()
        {
            return (SurfaceProperty_LocalEnvironment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:LocalEnvironment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_LocalEnvironment> SurfaceProperty_LocalEnvironment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_LocalEnvironment> ();
        
        public bool ShouldSerializeZoneProperty_LocalEnvironment_List()
        {
            return (ZoneProperty_LocalEnvironment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneProperty:LocalEnvironment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_LocalEnvironment> ZoneProperty_LocalEnvironment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_LocalEnvironment> ();
        
        public bool ShouldSerializeSurfaceProperty_SurroundingSurfaces_List()
        {
            return (SurfaceProperty_SurroundingSurfaces_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceProperty:SurroundingSurfaces", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SurroundingSurfaces> SurfaceProperty_SurroundingSurfaces_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.SurfaceProperty_SurroundingSurfaces> ();
        
        public bool ShouldSerializeComplexFenestrationProperty_SolarAbsorbedLayers_List()
        {
            return (ComplexFenestrationProperty_SolarAbsorbedLayers_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ComplexFenestrationProperty:SolarAbsorbedLayers", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ComplexFenestrationProperty_SolarAbsorbedLayers> ComplexFenestrationProperty_SolarAbsorbedLayers_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ComplexFenestrationProperty_SolarAbsorbedLayers> ();
        
        public bool ShouldSerializeZoneProperty_UserViewFactors_BySurfaceName_List()
        {
            return (ZoneProperty_UserViewFactors_BySurfaceName_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneProperty:UserViewFactors:BySurfaceName", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_UserViewFactors_BySurfaceName> ZoneProperty_UserViewFactors_BySurfaceName_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.ZoneProperty_UserViewFactors_BySurfaceName> ();
    }
}