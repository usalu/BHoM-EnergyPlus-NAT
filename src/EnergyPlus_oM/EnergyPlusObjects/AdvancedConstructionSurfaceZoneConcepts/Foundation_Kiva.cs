using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Refined definition of the foundation surface construction used to inform two-dime" +
                 "nsional heat transfer calculated using the Kiva ground heat transfer methodology" +
                 ".")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Foundation_Kiva : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Indoor air temperature used for Kiva initialization (prior to warmup period) If l" +
                     "eft blank, indoor air temperature will be determined based on zone setpoints")]
        [JsonProperty(PropertyName="initial_indoor_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialIndoorAirTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="interior_horizontal_insulation_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InteriorHorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("Distance from the slab bottom to the top of interior horizontal insulation")]
        [JsonProperty(PropertyName="interior_horizontal_insulation_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InteriorHorizontalInsulationDepth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Extent of insulation as measured from the wall interior")]
        [JsonProperty(PropertyName="interior_horizontal_insulation_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InteriorHorizontalInsulationWidth { get; set; } = null;
        

        [JsonProperty(PropertyName="interior_vertical_insulation_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InteriorVerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Extent of insulation as measured from the wall top to the bottom edge of the inte" +
                     "rior vertical insulation")]
        [JsonProperty(PropertyName="interior_vertical_insulation_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InteriorVerticalInsulationDepth { get; set; } = null;
        

        [JsonProperty(PropertyName="exterior_horizontal_insulation_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExteriorHorizontalInsulationMaterialName { get; set; } = "";
        

        [Description("Distance from the exterior grade to the top of exterior horizontal insulation")]
        [JsonProperty(PropertyName="exterior_horizontal_insulation_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExteriorHorizontalInsulationDepth { get; set; } = null;
        

        [Description("Extent of insulation as measured from the wall exterior")]
        [JsonProperty(PropertyName="exterior_horizontal_insulation_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExteriorHorizontalInsulationWidth { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="exterior_vertical_insulation_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExteriorVerticalInsulationMaterialName { get; set; } = "";
        

        [Description("Extent of insulation as measured from the wall top to the bottom edge of the exte" +
                     "rior vertical insulation")]
        [JsonProperty(PropertyName="exterior_vertical_insulation_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExteriorVerticalInsulationDepth { get; set; } = null;
        

        [Description("Distance from the exterior grade to the wall top")]
        [JsonProperty(PropertyName="wall_height_above_grade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WallHeightAboveGrade { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Distance from the slab bottom to the bottom of the foundation wall")]
        [JsonProperty(PropertyName="wall_depth_below_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WallDepthBelowSlab { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Defines the below-grade surface construction for slabs. Required if foundation wa" +
                     "ll is not exposed to the zone.")]
        [JsonProperty(PropertyName="footing_wall_construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FootingWallConstructionName { get; set; } = "";
        

        [JsonProperty(PropertyName="footing_material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FootingMaterialName { get; set; } = "";
        

        [Description("Top-to-bottom dimension of the footing (not to be confused with its depth in the " +
                     "ground). The width of the footing is defined by the material\'s thickness.")]
        [JsonProperty(PropertyName="footing_depth", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FootingDepth { get; set; } = Double.Parse("0.3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="blocks", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts.Foundation_Kiva_Blocks_Item> Blocks { get; set; } = null;
    }
}