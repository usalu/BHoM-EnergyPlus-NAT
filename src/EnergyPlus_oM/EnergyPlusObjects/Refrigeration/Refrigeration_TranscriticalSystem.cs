using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Detailed transcritical carbon dioxide (CO2) booster refrigeration systems used in" +
                 " supermarkets. The object allows for modeling either a single stage system with " +
                 "medium-temperature loads or a two stage system with both medium- and low-tempera" +
                 "ture loads.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_TranscriticalSystem : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="system_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_TranscriticalSystem_SystemType SystemType { get; set; } = (Refrigeration_TranscriticalSystem_SystemType)Enum.Parse(typeof(Refrigeration_TranscriticalSystem_SystemType), "SingleStage");
        

        [Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only medium temperature cases and walk-ins served directly by the system should be included in this list.")]
        [JsonProperty(PropertyName="medium_temperature_refrigerated_case_or_walkin_or_caseandwalkinlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MediumTemperatureRefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only low temperature cases and walkins served directly by the system should be included in this list.")]
        [JsonProperty(PropertyName="low_temperature_refrigerated_case_or_walkin_or_caseandwalkinlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LowTemperatureRefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [JsonProperty(PropertyName="refrigeration_gas_cooler_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationGasCoolerName { get; set; } = "";
        

        [JsonProperty(PropertyName="high_pressure_compressor_or_compressorlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HighPressureCompressorOrCompressorlistName { get; set; } = "";
        

        [JsonProperty(PropertyName="low_pressure_compressor_or_compressorlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LowPressureCompressorOrCompressorlistName { get; set; } = "";
        

        [JsonProperty(PropertyName="receiver_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReceiverPressure { get; set; } = Double.Parse("4000000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="subcooler_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SubcoolerEffectiveness { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [Description(@"Fluid property data for the refrigerant must be entered. The fluid property data, including the objects: FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated and FluidProperties:Superheated can be copied from the FluidPropertiesRefData.idf dataset")]
        [JsonProperty(PropertyName="refrigeration_system_working_fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationSystemWorkingFluidType { get; set; } = "";
        

        [Description("Use only if you want to include suction piping heat gain in refrigeration load")]
        [JsonProperty(PropertyName="sum_ua_suction_piping_for_medium_temperature_loads", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SumUaSuctionPipingForMediumTemperatureLoads { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain and the pipe heat gains as cooling credit for the zone. Required only if Su" +
                     "m UA Distribution Piping for Medium Temperature Loads > 0.0")]
        [JsonProperty(PropertyName="medium_temperature_suction_piping_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MediumTemperatureSuctionPipingZoneName { get; set; } = "";
        

        [Description("Use only if you want to include suction piping heat gain in refrigeration load")]
        [JsonProperty(PropertyName="sum_ua_suction_piping_for_low_temperature_loads", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SumUaSuctionPipingForLowTemperatureLoads { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain and the pipe heat gains as cooling credit for the zone. Required only if Su" +
                     "m UA Distribution Piping for Low Temperature Loads > 0.0")]
        [JsonProperty(PropertyName="low_temperature_suction_piping_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LowTemperatureSuctionPipingZoneName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}