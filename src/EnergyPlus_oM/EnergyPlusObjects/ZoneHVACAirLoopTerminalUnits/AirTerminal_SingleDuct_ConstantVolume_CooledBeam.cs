using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description("Central air system terminal unit, single duct, constant volume, with cooled beam " +
                 "(active or passive).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_ConstantVolume_CooledBeam : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooled_beam_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType CooledBeamType { get; set; } = (AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType)Enum.Parse(typeof(AirTerminal_SingleDuct_ConstantVolume_CooledBeam_CooledBeamType), "Active");
        

        [JsonProperty(PropertyName="supply_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="chilled_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="chilled_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_air_volumetric_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplyAirVolumetricFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_total_chilled_water_volumetric_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumTotalChilledWaterVolumetricFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Number of individual beam units in the zone")]
        [JsonProperty(PropertyName="number_of_beams", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NumberOfBeams { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Length of an individual beam unit")]
        [JsonProperty(PropertyName="beam_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> BeamLength { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_inlet_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignInletWaterTemperature { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="design_outlet_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignOutletWaterTemperature { get; set; } = Double.Parse("17", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coil_surface_area_per_coil_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoilSurfaceAreaPerCoilLength { get; set; } = Double.Parse("5.422", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="model_parameter_a", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterA { get; set; } = Double.Parse("15.3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="model_parameter_n1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterN1 { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="model_parameter_n2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterN2 { get; set; } = Double.Parse("0.84", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="model_parameter_n3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterN3 { get; set; } = Double.Parse("0.12", CultureInfo.InvariantCulture);
        

        [Description("Free area of the coil in plan view per unit beam length")]
        [JsonProperty(PropertyName="model_parameter_a0", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterA0 { get; set; } = Double.Parse("0.171", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="model_parameter_k1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterK1 { get; set; } = Double.Parse("0.0057", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="model_parameter_n", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ModelParameterN { get; set; } = Double.Parse("0.4", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coefficient_of_induction_kin", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CoefficientOfInductionKin { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="leaving_pipe_inside_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LeavingPipeInsideDiameter { get; set; } = Double.Parse("0.0145", CultureInfo.InvariantCulture);
    }
}