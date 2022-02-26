using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Direct expansion (DX) cooling coil and condensing unit (includes electric compressor and condenser fan), two-stage with humidity control mode (e.g. sub-cool or hot gas reheat). Optional inputs for moisture evaporation from wet coil when compressor cycles off with continuous fan operation. Requires two to four sets of performance data, see CoilPerformance:DX:Cooling. Stages are modeled as a face-split coil.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX_TwoStageWithHumidityControlMode : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="crankcase_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CrankcaseHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_crankcase_heater_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForCrankcaseHeaterOperation { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="number_of_capacity_stages", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCapacityStages { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="number_of_enhanced_dehumidification_modes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfEnhancedDehumidificationModes { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="normal_mode_stage_1_coil_performance_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType NormalModeStage1CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage1CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty(PropertyName="normal_mode_stage_1_coil_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalModeStage1CoilPerformanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="normal_mode_stage_1_2_coil_performance_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType NormalModeStage12CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_NormalModeStage12CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty(PropertyName="normal_mode_stage_1_2_coil_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalModeStage12CoilPerformanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="dehumidification_mode_1_stage_1_coil_performance_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType DehumidificationMode1Stage1CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage1CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty(PropertyName="dehumidification_mode_1_stage_1_coil_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DehumidificationMode1Stage1CoilPerformanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="dehumidification_mode_1_stage_1_2_coil_performance_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType DehumidificationMode1Stage12CoilPerformanceObjectType { get; set; } = (Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType)Enum.Parse(typeof(Coil_Cooling_DX_TwoStageWithHumidityControlMode_DehumidificationMode1Stage12CoilPerformanceObjectType), "CoilPerformanceDXCooling");
        

        [JsonProperty(PropertyName="dehumidification_mode_1_stage_1_2_coil_performance_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DehumidificationMode1Stage12CoilPerformanceName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyWaterStorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="condensate_collection_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_outdoor_dry_bulb_temperature_for_compressor_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumOutdoorDryBulbTemperatureForCompressorOperation { get; set; } = Double.Parse("-25", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, the heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the DX coil is off.")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty(PropertyName="basin_heater_operating_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
    }
}