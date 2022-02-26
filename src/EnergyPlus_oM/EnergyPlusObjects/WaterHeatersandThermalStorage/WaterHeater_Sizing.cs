using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description("This input object is used with WaterHeater:Mixed or with WaterHeater:Stratified t" +
                 "o autosize tank volume and heater capacity This object is not needed if water he" +
                 "aters are not autosized.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterHeater_Sizing : BHoMObject
    {
        

        [JsonProperty(PropertyName="waterheater_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterheaterName { get; set; } = "";
        

        [JsonProperty(PropertyName="design_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_Sizing_DesignMode DesignMode { get; set; } = (WaterHeater_Sizing_DesignMode)Enum.Parse(typeof(WaterHeater_Sizing_DesignMode), "PeakDraw");
        

        [Description("Only used for Design Mode = PeakDraw")]
        [JsonProperty(PropertyName="time_storage_can_meet_peak_draw", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TimeStorageCanMeetPeakDraw { get; set; } = null;
        

        [Description("Only used for Design Mode = PeakDraw")]
        [JsonProperty(PropertyName="time_for_tank_recovery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TimeForTankRecovery { get; set; } = null;
        

        [Description("Only used if Design Mode = PeakDraw and the water heater also has autosized flow " +
                     "rates for connections on the demand side of a plant loop")]
        [JsonProperty(PropertyName="nominal_tank_volume_for_autosizing_plant_connections", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalTankVolumeForAutosizingPlantConnections { get; set; } = null;
        

        [Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
        [JsonProperty(PropertyName="number_of_bedrooms", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBedrooms { get; set; } = null;
        

        [Description("Only used for Design Mode = ResidentialHUD-FHAMinimum")]
        [JsonProperty(PropertyName="number_of_bathrooms", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfBathrooms { get; set; } = null;
        

        [Description("Only used for Design Mode = PerPerson")]
        [JsonProperty(PropertyName="storage_capacity_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageCapacityPerPerson { get; set; } = null;
        

        [Description("Only used for Design Mode = PerPerson")]
        [JsonProperty(PropertyName="recovery_capacity_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RecoveryCapacityPerPerson { get; set; } = null;
        

        [Description("Only used for Design Mode = PerFloorArea")]
        [JsonProperty(PropertyName="storage_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageCapacityPerFloorArea { get; set; } = null;
        

        [Description("Only used for Design Mode = PerFloorArea")]
        [JsonProperty(PropertyName="recovery_capacity_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RecoveryCapacityPerFloorArea { get; set; } = null;
        

        [Description("Only used for Design Mode = PerUnit")]
        [JsonProperty(PropertyName="number_of_units", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfUnits { get; set; } = null;
        

        [Description("Only used for Design Mode = PerUnit")]
        [JsonProperty(PropertyName="storage_capacity_per_unit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageCapacityPerUnit { get; set; } = null;
        

        [Description("Only used for Design Mode = PerUnit")]
        [JsonProperty(PropertyName="recovery_capacity_perunit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RecoveryCapacityPerunit { get; set; } = null;
        

        [Description("Only used for Design Mode = PerSolarCollectorArea")]
        [JsonProperty(PropertyName="storage_capacity_per_collector_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageCapacityPerCollectorArea { get; set; } = null;
        

        [Description("only used if for WaterHeater:Stratified")]
        [JsonProperty(PropertyName="height_aspect_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeightAspectRatio { get; set; } = null;
    }
}