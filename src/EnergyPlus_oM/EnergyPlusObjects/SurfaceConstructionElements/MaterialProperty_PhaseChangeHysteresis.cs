using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Additional properties for temperature dependent thermal conductivity and enthalpy for Phase Change Materials (PCM) with separate melting and freezing curves. HeatBalanceAlgorithm = CondFD (ConductionFiniteDifference) solution algorithm only. Constructions with this should use the detailed CondFD process. Has no effect with other HeatBalanceAlgorithm solution algorithms.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class MaterialProperty_PhaseChangeHysteresis : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The total latent heat absorbed or rejected during the transition from solid to li" +
                     "quid, or back")]
        [JsonProperty(PropertyName="latent_heat_during_the_entire_phase_change_process", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LatentHeatDuringTheEntirePhaseChangeProcess { get; set; } = null;
        

        [Description("The thermal conductivity used by this material when the material is fully liquid")]
        [JsonProperty(PropertyName="liquid_state_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidStateThermalConductivity { get; set; } = null;
        

        [Description("The density used by this material when the material is fully liquid")]
        [JsonProperty(PropertyName="liquid_state_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidStateDensity { get; set; } = null;
        

        [Description("The constant specific heat used for the fully melted (liquid) state")]
        [JsonProperty(PropertyName="liquid_state_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidStateSpecificHeat { get; set; } = null;
        

        [Description("The total melting range of the material is the sum of low and high temperature di" +
                     "fference of melting curve.")]
        [JsonProperty(PropertyName="high_temperature_difference_of_melting_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

        [Description("The temperature at which the melting curve peaks")]
        [JsonProperty(PropertyName="peak_melting_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PeakMeltingTemperature { get; set; } = null;
        

        [Description("The total melting range of the material is the sum of low and high temperature di" +
                     "fference of melting curve.")]
        [JsonProperty(PropertyName="low_temperature_difference_of_melting_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowTemperatureDifferenceOfMeltingCurve { get; set; } = null;
        

        [Description("The thermal conductivity used by this material when the material is fully solid")]
        [JsonProperty(PropertyName="solid_state_thermal_conductivity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolidStateThermalConductivity { get; set; } = null;
        

        [Description("The density used by this material when the material is fully solid")]
        [JsonProperty(PropertyName="solid_state_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolidStateDensity { get; set; } = null;
        

        [Description("The constant specific heat used for the fully frozen (crystallized) state")]
        [JsonProperty(PropertyName="solid_state_specific_heat", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SolidStateSpecificHeat { get; set; } = null;
        

        [Description("The total freezing range of the material is the sum of low and high temperature d" +
                     "ifference of freezing curve.")]
        [JsonProperty(PropertyName="high_temperature_difference_of_freezing_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighTemperatureDifferenceOfFreezingCurve { get; set; } = null;
        

        [Description("The temperature at which the freezing curve peaks")]
        [JsonProperty(PropertyName="peak_freezing_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PeakFreezingTemperature { get; set; } = null;
        

        [Description("The total freezing range of the material is the sum of low and high temperature d" +
                     "ifference of freezing curve.")]
        [JsonProperty(PropertyName="low_temperature_difference_of_freezing_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowTemperatureDifferenceOfFreezingCurve { get; set; } = null;
    }
}