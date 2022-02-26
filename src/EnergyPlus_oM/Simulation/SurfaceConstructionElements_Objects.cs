using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Surface Construction Elements")]
    public class SurfaceConstructionElements_Objects : BHoMObject
    {
        
        public bool ShouldSerializeMaterial_List()
        {
            return (Material_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Material", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material> Material_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material> ();
        
        public bool ShouldSerializeMaterial_NoMass_List()
        {
            return (Material_NoMass_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Material:NoMass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_NoMass> Material_NoMass_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_NoMass> ();
        
        public bool ShouldSerializeMaterial_InfraredTransparent_List()
        {
            return (Material_InfraredTransparent_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Material:InfraredTransparent", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_InfraredTransparent> Material_InfraredTransparent_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_InfraredTransparent> ();
        
        public bool ShouldSerializeMaterial_AirGap_List()
        {
            return (Material_AirGap_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Material:AirGap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_AirGap> Material_AirGap_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_AirGap> ();
        
        public bool ShouldSerializeMaterial_RoofVegetation_List()
        {
            return (Material_RoofVegetation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Material:RoofVegetation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_RoofVegetation> Material_RoofVegetation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Material_RoofVegetation> ();
        
        public bool ShouldSerializeWindowMaterial_SimpleGlazingSystem_List()
        {
            return (WindowMaterial_SimpleGlazingSystem_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:SimpleGlazingSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_SimpleGlazingSystem> WindowMaterial_SimpleGlazingSystem_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_SimpleGlazingSystem> ();
        
        public bool ShouldSerializeWindowMaterial_Glazing_List()
        {
            return (WindowMaterial_Glazing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Glazing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing> WindowMaterial_Glazing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing> ();
        
        public bool ShouldSerializeWindowMaterial_GlazingGroup_Thermochromic_List()
        {
            return (WindowMaterial_GlazingGroup_Thermochromic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:GlazingGroup:Thermochromic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GlazingGroup_Thermochromic> WindowMaterial_GlazingGroup_Thermochromic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GlazingGroup_Thermochromic> ();
        
        public bool ShouldSerializeWindowMaterial_Glazing_RefractionExtinctionMethod_List()
        {
            return (WindowMaterial_Glazing_RefractionExtinctionMethod_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Glazing:RefractionExtinctionMethod", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_RefractionExtinctionMethod> WindowMaterial_Glazing_RefractionExtinctionMethod_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_RefractionExtinctionMethod> ();
        
        public bool ShouldSerializeWindowMaterial_Gas_List()
        {
            return (WindowMaterial_Gas_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Gas", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gas> WindowMaterial_Gas_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gas> ();
        
        public bool ShouldSerializeWindowGap_SupportPillar_List()
        {
            return (WindowGap_SupportPillar_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowGap:SupportPillar", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_SupportPillar> WindowGap_SupportPillar_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_SupportPillar> ();
        
        public bool ShouldSerializeWindowGap_DeflectionState_List()
        {
            return (WindowGap_DeflectionState_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowGap:DeflectionState", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_DeflectionState> WindowGap_DeflectionState_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowGap_DeflectionState> ();
        
        public bool ShouldSerializeWindowMaterial_GasMixture_List()
        {
            return (WindowMaterial_GasMixture_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:GasMixture", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GasMixture> WindowMaterial_GasMixture_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_GasMixture> ();
        
        public bool ShouldSerializeWindowMaterial_Gap_List()
        {
            return (WindowMaterial_Gap_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Gap", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap> WindowMaterial_Gap_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap> ();
        
        public bool ShouldSerializeWindowMaterial_Shade_List()
        {
            return (WindowMaterial_Shade_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Shade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade> WindowMaterial_Shade_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade> ();
        
        public bool ShouldSerializeWindowMaterial_ComplexShade_List()
        {
            return (WindowMaterial_ComplexShade_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:ComplexShade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_ComplexShade> WindowMaterial_ComplexShade_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_ComplexShade> ();
        
        public bool ShouldSerializeWindowMaterial_Blind_List()
        {
            return (WindowMaterial_Blind_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Blind", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind> WindowMaterial_Blind_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind> ();
        
        public bool ShouldSerializeWindowMaterial_Screen_List()
        {
            return (WindowMaterial_Screen_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Screen", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen> WindowMaterial_Screen_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen> ();
        
        public bool ShouldSerializeWindowMaterial_Shade_EquivalentLayer_List()
        {
            return (WindowMaterial_Shade_EquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Shade:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade_EquivalentLayer> WindowMaterial_Shade_EquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Shade_EquivalentLayer> ();
        
        public bool ShouldSerializeWindowMaterial_Drape_EquivalentLayer_List()
        {
            return (WindowMaterial_Drape_EquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Drape:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Drape_EquivalentLayer> WindowMaterial_Drape_EquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Drape_EquivalentLayer> ();
        
        public bool ShouldSerializeWindowMaterial_Blind_EquivalentLayer_List()
        {
            return (WindowMaterial_Blind_EquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Blind:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind_EquivalentLayer> WindowMaterial_Blind_EquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Blind_EquivalentLayer> ();
        
        public bool ShouldSerializeWindowMaterial_Screen_EquivalentLayer_List()
        {
            return (WindowMaterial_Screen_EquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Screen:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen_EquivalentLayer> WindowMaterial_Screen_EquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Screen_EquivalentLayer> ();
        
        public bool ShouldSerializeWindowMaterial_Glazing_EquivalentLayer_List()
        {
            return (WindowMaterial_Glazing_EquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Glazing:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_EquivalentLayer> WindowMaterial_Glazing_EquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Glazing_EquivalentLayer> ();
        
        public bool ShouldSerializeWindowMaterial_Gap_EquivalentLayer_List()
        {
            return (WindowMaterial_Gap_EquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowMaterial:Gap:EquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap_EquivalentLayer> WindowMaterial_Gap_EquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowMaterial_Gap_EquivalentLayer> ();
        
        public bool ShouldSerializeMaterialProperty_MoisturePenetrationDepth_Settings_List()
        {
            return (MaterialProperty_MoisturePenetrationDepth_Settings_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:MoisturePenetrationDepth:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_MoisturePenetrationDepth_Settings> MaterialProperty_MoisturePenetrationDepth_Settings_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_MoisturePenetrationDepth_Settings> ();
        
        public bool ShouldSerializeMaterialProperty_PhaseChange_List()
        {
            return (MaterialProperty_PhaseChange_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:PhaseChange", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChange> MaterialProperty_PhaseChange_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChange> ();
        
        public bool ShouldSerializeMaterialProperty_PhaseChangeHysteresis_List()
        {
            return (MaterialProperty_PhaseChangeHysteresis_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:PhaseChangeHysteresis", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChangeHysteresis> MaterialProperty_PhaseChangeHysteresis_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_PhaseChangeHysteresis> ();
        
        public bool ShouldSerializeMaterialProperty_VariableThermalConductivity_List()
        {
            return (MaterialProperty_VariableThermalConductivity_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:VariableThermalConductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_VariableThermalConductivity> MaterialProperty_VariableThermalConductivity_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_VariableThermalConductivity> ();
        
        public bool ShouldSerializeMaterialProperty_HeatAndMoistureTransfer_Settings_List()
        {
            return (MaterialProperty_HeatAndMoistureTransfer_Settings_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Settings", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Settings> MaterialProperty_HeatAndMoistureTransfer_Settings_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Settings> ();
        
        public bool ShouldSerializeMaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm_List()
        {
            return (MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:SorptionIsotherm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm> MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_SorptionIsotherm> ();
        
        public bool ShouldSerializeMaterialProperty_HeatAndMoistureTransfer_Suction_List()
        {
            return (MaterialProperty_HeatAndMoistureTransfer_Suction_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Suction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Suction> MaterialProperty_HeatAndMoistureTransfer_Suction_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Suction> ();
        
        public bool ShouldSerializeMaterialProperty_HeatAndMoistureTransfer_Redistribution_List()
        {
            return (MaterialProperty_HeatAndMoistureTransfer_Redistribution_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Redistribution", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Redistribution> MaterialProperty_HeatAndMoistureTransfer_Redistribution_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Redistribution> ();
        
        public bool ShouldSerializeMaterialProperty_HeatAndMoistureTransfer_Diffusion_List()
        {
            return (MaterialProperty_HeatAndMoistureTransfer_Diffusion_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:Diffusion", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Diffusion> MaterialProperty_HeatAndMoistureTransfer_Diffusion_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_Diffusion> ();
        
        public bool ShouldSerializeMaterialProperty_HeatAndMoistureTransfer_ThermalConductivity_List()
        {
            return (MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:HeatAndMoistureTransfer:ThermalConductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity> MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity> ();
        
        public bool ShouldSerializeMaterialProperty_GlazingSpectralData_List()
        {
            return (MaterialProperty_GlazingSpectralData_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="MaterialProperty:GlazingSpectralData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_GlazingSpectralData> MaterialProperty_GlazingSpectralData_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.MaterialProperty_GlazingSpectralData> ();
        
        public bool ShouldSerializeConstruction_List()
        {
            return (Construction_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction> Construction_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction> ();
        
        public bool ShouldSerializeConstruction_CfactorUndergroundWall_List()
        {
            return (Construction_CfactorUndergroundWall_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction:CfactorUndergroundWall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_CfactorUndergroundWall> Construction_CfactorUndergroundWall_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_CfactorUndergroundWall> ();
        
        public bool ShouldSerializeConstruction_FfactorGroundFloor_List()
        {
            return (Construction_FfactorGroundFloor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction:FfactorGroundFloor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_FfactorGroundFloor> Construction_FfactorGroundFloor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_FfactorGroundFloor> ();
        
        public bool ShouldSerializeConstructionProperty_InternalHeatSource_List()
        {
            return (ConstructionProperty_InternalHeatSource_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ConstructionProperty:InternalHeatSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.ConstructionProperty_InternalHeatSource> ConstructionProperty_InternalHeatSource_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.ConstructionProperty_InternalHeatSource> ();
        
        public bool ShouldSerializeConstruction_AirBoundary_List()
        {
            return (Construction_AirBoundary_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction:AirBoundary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_AirBoundary> Construction_AirBoundary_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_AirBoundary> ();
        
        public bool ShouldSerializeWindowThermalModel_Params_List()
        {
            return (WindowThermalModel_Params_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowThermalModel:Params", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowThermalModel_Params> WindowThermalModel_Params_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowThermalModel_Params> ();
        
        public bool ShouldSerializeWindowsCalculationEngine_List()
        {
            return (WindowsCalculationEngine_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowsCalculationEngine", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowsCalculationEngine> WindowsCalculationEngine_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.WindowsCalculationEngine> ();
        
        public bool ShouldSerializeConstruction_ComplexFenestrationState_List()
        {
            return (Construction_ComplexFenestrationState_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction:ComplexFenestrationState", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_ComplexFenestrationState> Construction_ComplexFenestrationState_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_ComplexFenestrationState> ();
        
        public bool ShouldSerializeConstruction_WindowEquivalentLayer_List()
        {
            return (Construction_WindowEquivalentLayer_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction:WindowEquivalentLayer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowEquivalentLayer> Construction_WindowEquivalentLayer_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowEquivalentLayer> ();
        
        public bool ShouldSerializeConstruction_WindowDataFile_List()
        {
            return (Construction_WindowDataFile_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Construction:WindowDataFile", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowDataFile> Construction_WindowDataFile_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements.Construction_WindowDataFile> ();
    }
}