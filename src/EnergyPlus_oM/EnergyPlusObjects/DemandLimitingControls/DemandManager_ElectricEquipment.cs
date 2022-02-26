using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DemandLimitingControls
{
    [Description("used for demand limiting ElectricEquipment objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class DemandManager_ElectricEquipment : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="limit_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DemandManager_ElectricEquipment_LimitControl LimitControl { get; set; } = (DemandManager_ElectricEquipment_LimitControl)Enum.Parse(typeof(DemandManager_ElectricEquipment_LimitControl), "Fixed");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty(PropertyName="minimum_limit_duration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumLimitDuration { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_limit_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumLimitFraction { get; set; } = null;
        

        [Description("Not yet implemented")]
        [JsonProperty(PropertyName="limit_step_change", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LimitStepChange { get; set; } = null;
        

        [JsonProperty(PropertyName="selection_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DemandManager_ElectricEquipment_SelectionControl SelectionControl { get; set; } = (DemandManager_ElectricEquipment_SelectionControl)Enum.Parse(typeof(DemandManager_ElectricEquipment_SelectionControl), "All");
        

        [Description("If blank, duration defaults to the timestep")]
        [JsonProperty(PropertyName="rotation_duration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RotationDuration { get; set; } = null;
        

        [Description("This list is the ElectricEquipmentNames object-list")]
        [JsonProperty(PropertyName="equipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Equipment { get; set; } = null;
    }
}