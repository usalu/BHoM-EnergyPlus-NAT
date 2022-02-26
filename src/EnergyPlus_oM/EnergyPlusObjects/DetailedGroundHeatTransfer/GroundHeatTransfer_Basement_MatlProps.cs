using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Specifies the material properties for the Basement preprocessor ground heat trans" +
                 "fer simulation. Only the Foundation Wall, Floor Slab, Soil, and Gravel propertie" +
                 "s are currently used.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_MatlProps : BHoMObject
    {
        

        [JsonProperty(PropertyName="nmat_number_of_materials_in_this_domain", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NmatNumberOfMaterialsInThisDomain { get; set; } = null;
        

        [JsonProperty(PropertyName="density_for_foundation_wall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityForFoundationWall { get; set; } = Double.Parse("2243", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="density_for_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityForFloorSlab { get; set; } = Double.Parse("2243", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="density_for_ceiling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityForCeiling { get; set; } = Double.Parse("311", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="density_for_soil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityForSoil { get; set; } = Double.Parse("1500", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="density_for_gravel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityForGravel { get; set; } = Double.Parse("2000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="density_for_wood", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DensityForWood { get; set; } = Double.Parse("449", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="specific_heat_for_foundation_wall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatForFoundationWall { get; set; } = Double.Parse("880", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="specific_heat_for_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatForFloorSlab { get; set; } = Double.Parse("880", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="specific_heat_for_ceiling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatForCeiling { get; set; } = Double.Parse("1530", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="specific_heat_for_soil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatForSoil { get; set; } = Double.Parse("840", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="specific_heat_for_gravel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatForGravel { get; set; } = Double.Parse("720", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="specific_heat_for_wood", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SpecificHeatForWood { get; set; } = Double.Parse("1530", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="thermal_conductivity_for_foundation_wall", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivityForFoundationWall { get; set; } = Double.Parse("1.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="thermal_conductivity_for_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivityForFloorSlab { get; set; } = Double.Parse("1.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="thermal_conductivity_for_ceiling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivityForCeiling { get; set; } = Double.Parse("0.09", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="thermal_conductivity_for_soil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivityForSoil { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="thermal_conductivity_for_gravel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivityForGravel { get; set; } = Double.Parse("1.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="thermal_conductivity_for_wood", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivityForWood { get; set; } = Double.Parse("0.12", CultureInfo.InvariantCulture);
    }
}