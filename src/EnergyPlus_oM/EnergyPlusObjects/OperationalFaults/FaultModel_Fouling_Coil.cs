using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OperationalFaults
{
    [Description("This object describes fouling water heating or cooling coils")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FaultModel_Fouling_Coil : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoilName { get; set; } = "";
        

        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="severity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeverityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="fouling_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FaultModel_Fouling_Coil_FoulingInputMethod FoulingInputMethod { get; set; } = (FaultModel_Fouling_Coil_FoulingInputMethod)Enum.Parse(typeof(FaultModel_Fouling_Coil_FoulingInputMethod), "FouledUARated");
        

        [Description("Fouling coil UA value under rating conditions For Fouling Input Method: FouledUAR" +
                     "ated")]
        [JsonProperty(PropertyName="uafouled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Uafouled { get; set; } = null;
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty(PropertyName="water_side_fouling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterSideFoulingFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty(PropertyName="air_side_fouling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirSideFoulingFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty(PropertyName="outside_coil_surface_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutsideCoilSurfaceArea { get; set; } = null;
        

        [Description("For Fouling Input Method: FoulingFactor")]
        [JsonProperty(PropertyName="inside_to_outside_coil_surface_area_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InsideToOutsideCoilSurfaceAreaRatio { get; set; } = Double.Parse("0.07", CultureInfo.InvariantCulture);
    }
}