using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Provides the information needed to simulate the inside boundary conditions for th" +
                 "e Basement preprocessor ground heat transfer simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_Interior : BHoMObject
    {
        

        [Description("for EnergyPlus this should be TRUE")]
        [JsonProperty(PropertyName="cond_flag_is_the_basement_conditioned_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned CondFlagIsTheBasementConditioned { get; set; } = (GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned)Enum.Parse(typeof(GroundHeatTransfer_Basement_Interior_CondFlagIsTheBasementConditioned), "TRUE");
        

        [JsonProperty(PropertyName="hin_downward_convection_only_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinDownwardConvectionOnlyHeatTransferCoefficient { get; set; } = Double.Parse("0.92", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="hin_upward_convection_only_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinUpwardConvectionOnlyHeatTransferCoefficient { get; set; } = Double.Parse("4.04", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="hin_horizontal_convection_only_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinHorizontalConvectionOnlyHeatTransferCoefficient { get; set; } = Double.Parse("3.08", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="hin_downward_combined_convection_and_radiation_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinDownwardCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = Double.Parse("6.13", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="hin_upward_combined_convection_and_radiation_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinUpwardCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = Double.Parse("9.26", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="hin_horizontal_combined_convection_and_radiation_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HinHorizontalCombinedConvectionAndRadiationHeatTransferCoefficient { get; set; } = Double.Parse("8.29", CultureInfo.InvariantCulture);
    }
}