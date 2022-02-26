using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Refrigeration
{
    [Description(@"Two types of subcoolers are modeled by the detailed refrigeration system. The liquid suction heat exchanger uses cool suction gas to subcool the hot condensate after it leaves the condenser and before it reaches the thermal expansion valve. A mechanical subcooler is used to transfer cooling capacity from one refrigeration system to another.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Refrigeration_Subcooler : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("plan to add ambient subcoolers at future time")]
        [JsonProperty(PropertyName="subcooler_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Refrigeration_Subcooler_SubcoolerType SubcoolerType { get; set; } = (Refrigeration_Subcooler_SubcoolerType)Enum.Parse(typeof(Refrigeration_Subcooler_SubcoolerType), "LiquidSuction");
        

        [Description("Applicable only and required for liquid suction heat exchangers design liquid suc" +
                     "tion subcooling")]
        [JsonProperty(PropertyName="liquid_suction_design_subcooling_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LiquidSuctionDesignSubcoolingTemperatureDifference { get; set; } = null;
        

        [Description("design inlet temperature on liquid side Applicable only and required for liquid s" +
                     "uction heat exchangers (LSHX)")]
        [JsonProperty(PropertyName="design_liquid_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignLiquidInletTemperature { get; set; } = null;
        

        [Description("design inlet temperature on vapor side Applicable only and required for liquid su" +
                     "ction heat exchangers (LSHX) Design vapor inlet temperature must be less than or" +
                     " equal to the Liquid inlet design temp")]
        [JsonProperty(PropertyName="design_vapor_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignVaporInletTemperature { get; set; } = null;
        

        [Description("Name of the Detailed Refrigeration System providing cooling capacity Applicable o" +
                     "nly and required for mechanical subcoolers")]
        [JsonProperty(PropertyName="capacity_providing_system", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CapacityProvidingSystem { get; set; } = "";
        

        [Description("Control Temperature Out for subcooled liquid Applicable only and required for mec" +
                     "hanical subcoolers")]
        [JsonProperty(PropertyName="outlet_control_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutletControlTemperature { get; set; } = null;
    }
}