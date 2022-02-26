using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This object supplies the information about insulation used around the slab. There" +
                 " are two possible configurations: under the slab or vertical insulation around t" +
                 "he slab.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_Insulation : BHoMObject
    {
        

        [Description("This field provides the thermal resistance value of the under slab insulation. It" +
                     " should be zero if the vertical insulation configuration is selected. typical va" +
                     "lue= 0-2.0")]
        [JsonProperty(PropertyName="rins_r_value_of_under_slab_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RinsRValueOfUnderSlabInsulation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This specifies the width of the perimeter strip of insulation under the slab. It " +
                     "should be zero if for the vertical insulation configuration is selected. typical" +
                     " value= 0-2.0")]
        [JsonProperty(PropertyName="dins_width_of_strip_of_under_slab_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DinsWidthOfStripOfUnderSlabInsulation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field specifies the thermal resistance of the vertical insulation. It should" +
                     " be zero if the under slab insulation configuration is selected. typical value= " +
                     "0-3.0")]
        [JsonProperty(PropertyName="rvins_r_value_of_vertical_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RvinsRValueOfVerticalInsulation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"This field specifies the depth of the vertical insulation into the ground in meters. It starts at the slab upper surface and extends into the ground. It should be zero if the under slab insulation configuration is selected. only use values= .2 .4 .6 .8 1.0 1.5 2.0 2.5 3.0")]
        [JsonProperty(PropertyName="zvins_depth_of_vertical_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZvinsDepthOfVerticalInsulation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Specifies if the vertical insulation configuration is being used. values: 1=yes v" +
                     "ertical insulation 0=no under-slab insulation")]
        [JsonProperty(PropertyName="ivins_flag_is_there_vertical_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IvinsFlagIsThereVerticalInsulation { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}