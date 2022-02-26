using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("a list of meters that can be reported are available after a run on the meter dict" +
                 "ionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Transformer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"A transformer can be used to transfer electric energy from utility grid to building (PowerInFromGrid)or from building on-site generation to the grid (PowerOutToGrid) or within a load center to match generation to the facility service main panel (LoadCenterPowerConditioning)")]
        [JsonProperty(PropertyName="transformer_usage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Transformer_TransformerUsage TransformerUsage { get; set; } = (ElectricLoadCenter_Transformer_TransformerUsage)Enum.Parse(typeof(ElectricLoadCenter_Transformer_TransformerUsage), "PowerInFromGrid");
        

        [Description("Enter name of zone to receive transformer losses as heat if blank then transforme" +
                     "r losses are dissipated to outdoors")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RadiativeFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("the unit is VA, instead of kVA as usually shown on transformer nameplates.")]
        [JsonProperty(PropertyName="rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedCapacity { get; set; } = null;
        

        [Description("Must be single or three phase transformer. NOT used in the current model.")]
        [JsonProperty(PropertyName="phase", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Phase { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("Winding material used by the transformer.")]
        [JsonProperty(PropertyName="conductor_material", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Transformer_ConductorMaterial ConductorMaterial { get; set; } = (ElectricLoadCenter_Transformer_ConductorMaterial)Enum.Parse(typeof(ElectricLoadCenter_Transformer_ConductorMaterial), "Aluminum");
        

        [JsonProperty(PropertyName="full_load_temperature_rise", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FullLoadTemperatureRise { get; set; } = Double.Parse("150", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="fraction_of_eddy_current_losses", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfEddyCurrentLosses { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [Description("User can define transformer performance by specifying load and no load losses at " +
                     "rated conditions or nameplate efficiency and maximum efficiency")]
        [JsonProperty(PropertyName="performance_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Transformer_PerformanceInputMethod PerformanceInputMethod { get; set; } = (ElectricLoadCenter_Transformer_PerformanceInputMethod)Enum.Parse(typeof(ElectricLoadCenter_Transformer_PerformanceInputMethod), "RatedLosses");
        

        [Description("Only required when RatedLosses is the performance input method")]
        [JsonProperty(PropertyName="rated_no_load_loss", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedNoLoadLoss { get; set; } = null;
        

        [Description("Only required when RatedLosses is the performance input method")]
        [JsonProperty(PropertyName="rated_load_loss", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedLoadLoss { get; set; } = null;
        

        [Description("Only required when NominalEfficiency is the performance input method")]
        [JsonProperty(PropertyName="nameplate_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NameplateEfficiency { get; set; } = Double.Parse("0.98", CultureInfo.InvariantCulture);
        

        [Description("Percentage of the rated capacity at which the nameplate efficiency is defined Onl" +
                     "y required when NominalEfficiency is the performance input method")]
        [JsonProperty(PropertyName="per_unit_load_for_nameplate_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PerUnitLoadForNameplateEfficiency { get; set; } = Double.Parse("0.35", CultureInfo.InvariantCulture);
        

        [Description("Conductor operating temperature at which the nameplate efficiency is defined Only" +
                     " required when NominalEfficiency is the performance input method")]
        [JsonProperty(PropertyName="reference_temperature_for_nameplate_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReferenceTemperatureForNameplateEfficiency { get; set; } = Double.Parse("75", CultureInfo.InvariantCulture);
        

        [Description("Percentage of the rate capacity at which the maximum efficiency is obtained Only " +
                     "required when NominalEfficiency is the performance input method")]
        [JsonProperty(PropertyName="per_unit_load_for_maximum_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PerUnitLoadForMaximumEfficiency { get; set; } = null;
        

        [Description("Only required when the transformer is used for power in from the utility grid")]
        [JsonProperty(PropertyName="consider_transformer_loss_for_utility_cost", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ConsiderTransformerLossForUtilityCost { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty(PropertyName="meters", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Meters { get; set; } = null;
    }
}