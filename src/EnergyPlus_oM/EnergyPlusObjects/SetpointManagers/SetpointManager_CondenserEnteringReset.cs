using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager uses one curve to determine the optimum condenser entering " +
                 "water temperature for a given timestep and two other curves to place boundary co" +
                 "nditions on the setpoint value.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_CondenserEnteringReset : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_CondenserEnteringReset_ControlVariable ControlVariable { get; set; } = (SetpointManager_CondenserEnteringReset_ControlVariable)Enum.Parse(typeof(SetpointManager_CondenserEnteringReset_ControlVariable), "Temperature");
        

        [Description("This scheduled setpoint value is only used in a given timestep if the \"Optimized\"" +
                     " Condenser Entering Temperature does not fall within the prescribed boundary con" +
                     "ditions.")]
        [JsonProperty(PropertyName="default_condenser_entering_water_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DefaultCondenserEnteringWaterTemperatureScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_design_wetbulb_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumDesignWetbulbTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_outside_air_wetbulb_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutsideAirWetbulbTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="optimized_cond_entering_water_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OptimizedCondEnteringWaterTemperatureCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_lift", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumLift { get; set; } = Double.Parse("11.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_condenser_entering_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumCondenserEnteringWaterTemperature { get; set; } = Double.Parse("32", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_tower_design_inlet_air_wet_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingTowerDesignInletAirWetBulbTemperature { get; set; } = Double.Parse("25.56", CultureInfo.InvariantCulture);
        

        [Description("Node(s) at which control variable will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
    }
}