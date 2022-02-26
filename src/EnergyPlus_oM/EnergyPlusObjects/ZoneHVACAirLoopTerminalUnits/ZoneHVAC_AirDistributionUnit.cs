using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system air distribution unit, serves as a wrapper for a specific type" +
                 " of air terminal unit. This object is referenced in a ZoneHVAC:EquipmentList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_AirDistributionUnit : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_distribution_unit_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirDistributionUnitOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_terminal_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_AirDistributionUnit_AirTerminalObjectType AirTerminalObjectType { get; set; } = (ZoneHVAC_AirDistributionUnit_AirTerminalObjectType)Enum.Parse(typeof(ZoneHVAC_AirDistributionUnit_AirTerminalObjectType), "AirTerminalDualDuctConstantVolume");
        

        [JsonProperty(PropertyName="air_terminal_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirTerminalName { get; set; } = "";
        

        [Description("fraction at system design Flow; leakage Flow constant, leakage fraction varies wi" +
                     "th variable system Flow Rate.")]
        [JsonProperty(PropertyName="nominal_upstream_leakage_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalUpstreamLeakageFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="constant_downstream_leakage_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantDownstreamLeakageFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This optional field is the name of a DesignSpecification:AirTerminal:Sizing objec" +
                     "t which specifies sizing adjustments to be made for this terminal unit.")]
        [JsonProperty(PropertyName="design_specification_air_terminal_sizing_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationAirTerminalSizingObjectName { get; set; } = "";
    }
}