using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Thermal Zones and Surfaces")]
    public class ThermalZonesandSurfaces_Objects : BHoMObject
    {
        

        [JsonProperty(PropertyName="GlobalGeometryRules", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlobalGeometryRules GlobalGeometryRules { get; set; } = null;
        

        [JsonProperty(PropertyName="GeometryTransform", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GeometryTransform GeometryTransform { get; set; } = null;
        
        public bool ShouldSerializeZone_List()
        {
            return (Zone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Zone> Zone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Zone> ();
        
        public bool ShouldSerializeZoneList_List()
        {
            return (ZoneList_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneList", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneList> ZoneList_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneList> ();
        
        public bool ShouldSerializeZoneGroup_List()
        {
            return (ZoneGroup_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneGroup", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneGroup> ZoneGroup_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ZoneGroup> ();
        
        public bool ShouldSerializeBuildingSurface_Detailed_List()
        {
            return (BuildingSurface_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="BuildingSurface:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.BuildingSurface_Detailed> BuildingSurface_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.BuildingSurface_Detailed> ();
        
        public bool ShouldSerializeWall_Detailed_List()
        {
            return (Wall_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Wall:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Detailed> Wall_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Detailed> ();
        
        public bool ShouldSerializeRoofCeiling_Detailed_List()
        {
            return (RoofCeiling_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="RoofCeiling:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.RoofCeiling_Detailed> RoofCeiling_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.RoofCeiling_Detailed> ();
        
        public bool ShouldSerializeFloor_Detailed_List()
        {
            return (Floor_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Floor:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Detailed> Floor_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Detailed> ();
        
        public bool ShouldSerializeWall_Exterior_List()
        {
            return (Wall_Exterior_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Wall:Exterior", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Exterior> Wall_Exterior_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Exterior> ();
        
        public bool ShouldSerializeWall_Adiabatic_List()
        {
            return (Wall_Adiabatic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Wall:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Adiabatic> Wall_Adiabatic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Adiabatic> ();
        
        public bool ShouldSerializeWall_Underground_List()
        {
            return (Wall_Underground_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Wall:Underground", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Underground> Wall_Underground_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Underground> ();
        
        public bool ShouldSerializeWall_Interzone_List()
        {
            return (Wall_Interzone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Wall:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Interzone> Wall_Interzone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Wall_Interzone> ();
        
        public bool ShouldSerializeRoof_List()
        {
            return (Roof_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Roof", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Roof> Roof_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Roof> ();
        
        public bool ShouldSerializeCeiling_Adiabatic_List()
        {
            return (Ceiling_Adiabatic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Ceiling:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Adiabatic> Ceiling_Adiabatic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Adiabatic> ();
        
        public bool ShouldSerializeCeiling_Interzone_List()
        {
            return (Ceiling_Interzone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Ceiling:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Interzone> Ceiling_Interzone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Ceiling_Interzone> ();
        
        public bool ShouldSerializeFloor_GroundContact_List()
        {
            return (Floor_GroundContact_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Floor:GroundContact", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_GroundContact> Floor_GroundContact_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_GroundContact> ();
        
        public bool ShouldSerializeFloor_Adiabatic_List()
        {
            return (Floor_Adiabatic_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Floor:Adiabatic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Adiabatic> Floor_Adiabatic_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Adiabatic> ();
        
        public bool ShouldSerializeFloor_Interzone_List()
        {
            return (Floor_Interzone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Floor:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Interzone> Floor_Interzone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Floor_Interzone> ();
        
        public bool ShouldSerializeFenestrationSurface_Detailed_List()
        {
            return (FenestrationSurface_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FenestrationSurface:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.FenestrationSurface_Detailed> FenestrationSurface_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.FenestrationSurface_Detailed> ();
        
        public bool ShouldSerializeWindow_List()
        {
            return (Window_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window> Window_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window> ();
        
        public bool ShouldSerializeDoor_List()
        {
            return (Door_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Door", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door> Door_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door> ();
        
        public bool ShouldSerializeGlazedDoor_List()
        {
            return (GlazedDoor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GlazedDoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor> GlazedDoor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor> ();
        
        public bool ShouldSerializeWindow_Interzone_List()
        {
            return (Window_Interzone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Window:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window_Interzone> Window_Interzone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Window_Interzone> ();
        
        public bool ShouldSerializeDoor_Interzone_List()
        {
            return (Door_Interzone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Door:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door_Interzone> Door_Interzone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Door_Interzone> ();
        
        public bool ShouldSerializeGlazedDoor_Interzone_List()
        {
            return (GlazedDoor_Interzone_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GlazedDoor:Interzone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor_Interzone> GlazedDoor_Interzone_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.GlazedDoor_Interzone> ();
        
        public bool ShouldSerializeWindowShadingControl_List()
        {
            return (WindowShadingControl_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowShadingControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowShadingControl> WindowShadingControl_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowShadingControl> ();
        
        public bool ShouldSerializeWindowProperty_FrameAndDivider_List()
        {
            return (WindowProperty_FrameAndDivider_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowProperty:FrameAndDivider", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_FrameAndDivider> WindowProperty_FrameAndDivider_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_FrameAndDivider> ();
        
        public bool ShouldSerializeWindowProperty_AirflowControl_List()
        {
            return (WindowProperty_AirflowControl_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowProperty:AirflowControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_AirflowControl> WindowProperty_AirflowControl_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_AirflowControl> ();
        
        public bool ShouldSerializeWindowProperty_StormWindow_List()
        {
            return (WindowProperty_StormWindow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WindowProperty:StormWindow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_StormWindow> WindowProperty_StormWindow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.WindowProperty_StormWindow> ();
        
        public bool ShouldSerializeInternalMass_List()
        {
            return (InternalMass_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="InternalMass", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.InternalMass> InternalMass_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.InternalMass> ();
        
        public bool ShouldSerializeShading_Site_List()
        {
            return (Shading_Site_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Site", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site> Shading_Site_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site> ();
        
        public bool ShouldSerializeShading_Building_List()
        {
            return (Shading_Building_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Building", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building> Shading_Building_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building> ();
        
        public bool ShouldSerializeShading_Site_Detailed_List()
        {
            return (Shading_Site_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Site:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site_Detailed> Shading_Site_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Site_Detailed> ();
        
        public bool ShouldSerializeShading_Building_Detailed_List()
        {
            return (Shading_Building_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Building:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building_Detailed> Shading_Building_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Building_Detailed> ();
        
        public bool ShouldSerializeShading_Overhang_List()
        {
            return (Shading_Overhang_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Overhang", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang> Shading_Overhang_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang> ();
        
        public bool ShouldSerializeShading_Overhang_Projection_List()
        {
            return (Shading_Overhang_Projection_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Overhang:Projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang_Projection> Shading_Overhang_Projection_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Overhang_Projection> ();
        
        public bool ShouldSerializeShading_Fin_List()
        {
            return (Shading_Fin_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Fin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin> Shading_Fin_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin> ();
        
        public bool ShouldSerializeShading_Fin_Projection_List()
        {
            return (Shading_Fin_Projection_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Fin:Projection", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin_Projection> Shading_Fin_Projection_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Fin_Projection> ();
        
        public bool ShouldSerializeShading_Zone_Detailed_List()
        {
            return (Shading_Zone_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Shading:Zone:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Zone_Detailed> Shading_Zone_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.Shading_Zone_Detailed> ();
        
        public bool ShouldSerializeShadingProperty_Reflectance_List()
        {
            return (ShadingProperty_Reflectance_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ShadingProperty:Reflectance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ShadingProperty_Reflectance> ShadingProperty_Reflectance_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces.ShadingProperty_Reflectance> ();
    }
}