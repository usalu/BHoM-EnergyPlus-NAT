using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description("Internal heat source to be attached to a construction layer")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ConstructionProperty_InternalHeatSource : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="construction_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConstructionName { get; set; } = "";
        

        [Description("refers to the list of materials which follows")]
        [JsonProperty(PropertyName="thermal_source_present_after_layer_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ThermalSourcePresentAfterLayerNumber { get; set; } = null;
        

        [Description("refers to the list of materials which follows")]
        [JsonProperty(PropertyName="temperature_calculation_requested_after_layer_number", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureCalculationRequestedAfterLayerNumber { get; set; } = null;
        

        [Description("1 = 1-dimensional calculation, 2 = 2-dimensional calculation")]
        [JsonProperty(PropertyName="dimensions_for_the_ctf_calculation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DimensionsForTheCtfCalculation { get; set; } = null;
        

        [Description("uniform spacing between tubes or resistance wires in direction perpendicular to m" +
                     "ain intended direction of heat transfer")]
        [JsonProperty(PropertyName="tube_spacing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TubeSpacing { get; set; } = null;
        

        [Description(@"used in conjunction with field Temperature Calculation Requested After Layer Number this field is the location perpendicular to the main direction of heat transfer 0.0 means in line with the tubing, 1.0 means at the midpoint between two adjacent pipes this field is ignored for 1-D calculations")]
        [JsonProperty(PropertyName="two_dimensional_temperature_calculation_position", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TwoDimensionalTemperatureCalculationPosition { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}