using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description("Simulates the performance of a supermarket refrigeration system when used along w" +
                 "ith other objects to define the refrigeration load(s), the compressor(s), and th" +
                 "e condenser.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_System : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"Enter the name of a Refrigeration:Case or Refrigeration:WalkIn object. If there is more than one refrigerated case or walk-in served by this system, enter the name of a Refrigeration:CaseAndWalkInList object. Only cases and walkins served directly by the system should be included in this list. Any cases served indirectly via a secondary chiller should NOT be included in this list")]
        [JsonProperty(PropertyName="refrigerated_case_or_walkin_or_caseandwalkinlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigeratedCaseOrWalkinOrCaseandwalkinlistName { get; set; } = "";
        

        [Description(@"Enter the name of a Refrigeration:SecondarySystem object OR a Refrigeration:Condenser:Cascade object OR, a Refrigeration:TransferLoadList object. A transfer load is identified as one which moves the load from one system to another. So if you have more than one such load (including cascade condensers and secondary loops) served by the same system, use a TransferLoadList object.")]
        [JsonProperty(PropertyName="refrigeration_transfer_load_or_transferload_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationTransferLoadOrTransferloadListName { get; set; } = "";
        

        [JsonProperty(PropertyName="refrigeration_condenser_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationCondenserName { get; set; } = "";
        

        [JsonProperty(PropertyName="compressor_or_compressorlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompressorOrCompressorlistName { get; set; } = "";
        

        [Description("related to the proper operation of the thermal expansion valves and compressors")]
        [JsonProperty(PropertyName="minimum_condensing_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumCondensingTemperature { get; set; } = null;
        

        [Description(@"Fluid property data for the refrigerant must be entered. The fluid property data, including the objects: FluidProperties:Name, FluidProperties:Temperatures, FluidProperties:Saturated and FluidProperties:Superheated can be copied from the FluidPropertiesRefData.idf dataset")]
        [JsonProperty(PropertyName="refrigeration_system_working_fluid_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RefrigerationSystemWorkingFluidType { get; set; } = "";
        

        [JsonProperty(PropertyName="suction_temperature_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_System_SuctionTemperatureControlType SuctionTemperatureControlType { get; set; } = (Refrigeration_System_SuctionTemperatureControlType)Enum.Parse(typeof(Refrigeration_System_SuctionTemperatureControlType), "ConstantSuctionTemperature");
        

        [Description("Optional Field Recipient of refrigeration capacity, that is receives cool liquid " +
                     "from another refrigeration system to help meet aggregate case loads")]
        [JsonProperty(PropertyName="mechanical_subcooler_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalSubcoolerName { get; set; } = "";
        

        [Description("Optional Field Liquid Suction Heat Exchanger Name, or leave blank")]
        [JsonProperty(PropertyName="liquid_suction_heat_exchanger_subcooler_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LiquidSuctionHeatExchangerSubcoolerName { get; set; } = "";
        

        [Description("Use only if you want to include suction piping heat gain in refrigeration load")]
        [JsonProperty(PropertyName="sum_ua_suction_piping", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SumUaSuctionPiping { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This will be used to determine the temperature used for distribution piping heat " +
                     "gain and the pipe heat gains  as cooling credit for the zone. Required only if S" +
                     "um UA Distribution Piping >0.0")]
        [JsonProperty(PropertyName="suction_piping_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SuctionPipingZoneName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
        

        [JsonProperty(PropertyName="number_of_compressor_stages", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCompressorStages { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="intercooler_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_System_IntercoolerType IntercoolerType { get; set; } = (Refrigeration_System_IntercoolerType)Enum.Parse(typeof(Refrigeration_System_IntercoolerType), "None");
        

        [JsonProperty(PropertyName="shell_and_coil_intercooler_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ShellAndCoilIntercoolerEffectiveness { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="high_stage_compressor_or_compressorlist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HighStageCompressorOrCompressorlistName { get; set; } = "";
    }
}