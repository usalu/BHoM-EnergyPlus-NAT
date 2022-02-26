using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description(@"This setpoint manager is used to place a temperature setpoint on a plant supply outlet node based on a target return water setpoint. The setpoint manager attempts to achieve the desired return water temperature by adjusting the supply temperature setpoint based on the plant conditions at each system time step.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_ReturnTemperature_HotWater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"This is the name of the supply outlet node for the plant being controlled by this setpoint manager. Typically this is where the setpoint will be actuated for supply equipment to control to, but not necessarily. This setpoint manager will mine that information from the internal plant data structures.")]
        [JsonProperty(PropertyName="plant_loop_supply_outlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantLoopSupplyOutletNode { get; set; } = "";
        

        [Description("This is the name of the supply inlet node for the plant being controlled with thi" +
                     "s setpoint manager. The temperature on this node is controlled by actuating the " +
                     "supply setpoint.")]
        [JsonProperty(PropertyName="plant_loop_supply_inlet_node", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantLoopSupplyInletNode { get; set; } = "";
        

        [Description("This is the minimum reset temperature for the hot water supply.")]
        [JsonProperty(PropertyName="minimum_supply_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSupplyTemperatureSetpoint { get; set; } = Double.Parse("77", CultureInfo.InvariantCulture);
        

        [Description("This is the maximum hot water supply temperature setpoint. This is also used as t" +
                     "he default setpoint during no-load or negative-load conditions and during initia" +
                     "lization.")]
        [JsonProperty(PropertyName="maximum_supply_temperature_setpoint", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSupplyTemperatureSetpoint { get; set; } = Double.Parse("82", CultureInfo.InvariantCulture);
        

        [Description("This defines whether the hot water return temperature target is constant, schedul" +
                     "ed, or specified on the supply inlet node by a separate setpoint manager.")]
        [JsonProperty(PropertyName="return_temperature_setpoint_input_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType ReturnTemperatureSetpointInputType { get; set; } = (SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType)Enum.Parse(typeof(SetpointManager_ReturnTemperature_HotWater_ReturnTemperatureSetpointInputType), "Constant");
        

        [Description("This is the desired return temperature target, which is met by adjusting the supp" +
                     "ly temperature setpoint. This constant value is only used if the Design Hot Wate" +
                     "r Return Temperature Input Type is Constant")]
        [JsonProperty(PropertyName="return_temperature_setpoint_constant_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ReturnTemperatureSetpointConstantValue { get; set; } = Double.Parse("71", CultureInfo.InvariantCulture);
        

        [Description(@"This is the desired return temperature target, which is met by adjusting the supply temperature setpoint. This is a schedule name to allow the return temperature target value to be scheduled. This field is only used if the Design Hot Water Return Temperature Input Type is Scheduled")]
        [JsonProperty(PropertyName="return_temperature_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnTemperatureSetpointScheduleName { get; set; } = "";
    }
}