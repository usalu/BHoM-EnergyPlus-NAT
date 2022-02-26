using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("HeatBalanceAlgorithm = CombinedHeatAndMoistureFiniteElement solution algorithm on" +
                 "ly. Relationship between thermal conductivity and moisture content Has no effect" +
                 " with other HeatBalanceAlgorithm solution algorithms")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_HeatAndMoistureTransfer_ThermalConductivity : BHoMObject
    {
        

        [Description("Moisture Material Name that the Thermal Conductivity will be added to.")]
        [JsonProperty(PropertyName="material_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaterialName { get; set; } = "";
        

        [Description("number of data coordinates")]
        [JsonProperty(PropertyName="number_of_thermal_coordinates", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfThermalCoordinates { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent1 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity1 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent2 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity2 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent3 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity3 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent4 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_4", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity4 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent5 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_5", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity5 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent6 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_6", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity6 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent7 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_7", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity7 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent8 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_8", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity8 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent9 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_9", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity9 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent10 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_10", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity10 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent11 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_11", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity11 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent12 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_12", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity12 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent13 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_13", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity13 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent14 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_14", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity14 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent15 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_15", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity15 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent16 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_16", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity16 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent17 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_17", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity17 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent18 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_18", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity18 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent19 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_19", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity19 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent20 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_20", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity20 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent21 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_21", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity21 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent22 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_22", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity22 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent23 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_23", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity23 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent24 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_24", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity24 { get; set; } = null;
        

        [JsonProperty(PropertyName="moisture_content_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MoistureContent25 { get; set; } = null;
        

        [JsonProperty(PropertyName="thermal_conductivity_25", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalConductivity25 { get; set; } = null;
    }
}