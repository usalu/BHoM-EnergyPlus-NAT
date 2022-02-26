using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("OSU parameter estimation model")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HeatPump_WaterToWater_ParameterEstimation_Heating : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="source_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadSideInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="load_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LoadSideOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="nominal_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCop { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="minimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OptimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="load_side_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoadSideFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="source_side_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideFlowRate { get; set; } = null;
        

        [JsonProperty(PropertyName="load_side_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoadSideHeatTransferCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="source_side_heat_transfer_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SourceSideHeatTransferCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="piston_displacement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> PistonDisplacement { get; set; } = null;
        

        [JsonProperty(PropertyName="compressor_clearance_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorClearanceFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="compressor_suction_and_discharge_pressure_drop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CompressorSuctionAndDischargePressureDrop { get; set; } = null;
        

        [JsonProperty(PropertyName="superheating", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Superheating { get; set; } = null;
        

        [JsonProperty(PropertyName="constant_part_of_electromechanical_power_losses", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConstantPartOfElectromechanicalPowerLosses { get; set; } = null;
        

        [Description("Used to define electromechanical loss that is proportional to the theoretical pow" +
                     "er %")]
        [JsonProperty(PropertyName="loss_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LossFactor { get; set; } = null;
        

        [JsonProperty(PropertyName="high_pressure_cut_off", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighPressureCutOff { get; set; } = Double.Parse("500000000", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="low_pressure_cut_off", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LowPressureCutOff { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}