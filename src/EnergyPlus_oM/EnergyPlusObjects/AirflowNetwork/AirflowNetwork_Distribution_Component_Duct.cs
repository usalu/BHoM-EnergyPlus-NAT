using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the relationship between pressure and air flow through the du" +
                 "ct.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_Distribution_Component_Duct : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the length of the duct.")]
        [JsonProperty(PropertyName="duct_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DuctLength { get; set; } = null;
        

        [Description("Enter the hydraulic diameter of the duct. Hydraulic diameter is defined as 4 mult" +
                     "iplied by cross section area divided by perimeter")]
        [JsonProperty(PropertyName="hydraulic_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HydraulicDiameter { get; set; } = null;
        

        [Description("Enter the cross section area of the duct.")]
        [JsonProperty(PropertyName="cross_section_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrossSectionArea { get; set; } = null;
        

        [Description("Enter the inside surface roughness of the duct.")]
        [JsonProperty(PropertyName="surface_roughness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SurfaceRoughness { get; set; } = Double.Parse("0.0009", CultureInfo.InvariantCulture);
        

        [Description("Enter the coefficient used to calculate dynamic losses of fittings (e.g. elbows)." +
                     "")]
        [JsonProperty(PropertyName="coefficient_for_local_dynamic_loss_due_to_fitting", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoefficientForLocalDynamicLossDueToFitting { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("conduction only Default value of 0.943 is equivalent to 1.06 m2-K/W (R6) duct ins" +
                     "ulation.")]
        [JsonProperty(PropertyName="heat_transmittance_coefficient_u_factor_for_duct_wall_construction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatTransmittanceCoefficientUFactorForDuctWallConstruction { get; set; } = Double.Parse("0.943", CultureInfo.InvariantCulture);
        

        [Description("Enter the overall moisture transmittance coefficient including moisture film coef" +
                     "ficients at both surfaces.")]
        [JsonProperty(PropertyName="overall_moisture_transmittance_coefficient_from_air_to_air", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OverallMoistureTransmittanceCoefficientFromAirToAir { get; set; } = Double.Parse("0.001", CultureInfo.InvariantCulture);
        

        [Description("optional. convection coefficient calculated automatically, unless specified")]
        [JsonProperty(PropertyName="outside_convection_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutsideConvectionCoefficient { get; set; } = null;
        

        [Description("optional. convection coefficient calculated automatically, unless specified")]
        [JsonProperty(PropertyName="inside_convection_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideConvectionCoefficient { get; set; } = null;
    }
}