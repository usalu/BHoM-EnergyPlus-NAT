using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats
{
    [Description("Define the Thermostat StagedDualSetpoint settings for a zone or list of zones. If" +
                 " you use a ZoneList in the Zone or ZoneList name field then this definition appl" +
                 "ies to all the zones in the ZoneList.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneControl_Thermostat_StagedDualSetpoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_or_zonelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("Enter the number of the following sets of data for heating temperature offset")]
        [JsonProperty(PropertyName="number_of_heating_stages", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfHeatingStages { get; set; } = null;
        

        [JsonProperty(PropertyName="heating_temperature_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingTemperatureSetpointScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="heating_throttling_temperature_range", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatingThrottlingTemperatureRange { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 1 value and greater than Stage 2 value, the stage number is 1.")]
        [JsonProperty(PropertyName="stage_1_heating_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage1HeatingTemperatureOffset { get; set; } = null;
        

        [Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 2 value and greater than Stage 3 value, the stage number is 2. The value of this field has to be less the value at the previous field.")]
        [JsonProperty(PropertyName="stage_2_heating_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage2HeatingTemperatureOffset { get; set; } = null;
        

        [Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 3 value and greater than Stage 4 value, the stage number is 3. The value of this field has to be less the value at the previous field.")]
        [JsonProperty(PropertyName="stage_3_heating_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage3HeatingTemperatureOffset { get; set; } = null;
        

        [Description(@"The heating temperature offset is used to determine heating stage number for multi stage equipment. When the temperature difference of the heating setpoint and the controlled zone temperature at previous time step is less than Stage 4 value, the stage number is 4. The value of this field has to be less the value at the previous field.")]
        [JsonProperty(PropertyName="stage_4_heating_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage4HeatingTemperatureOffset { get; set; } = null;
        

        [Description("Enter the number of the following sets of data for cooling temperature offset")]
        [JsonProperty(PropertyName="number_of_cooling_stages", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NumberOfCoolingStages { get; set; } = null;
        

        [JsonProperty(PropertyName="cooling_temperature_setpoint_base_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingTemperatureSetpointBaseScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="cooling_throttling_temperature_range", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingThrottlingTemperatureRange { get; set; } = Double.Parse("1.1", CultureInfo.InvariantCulture);
        

        [Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 1 value and less than Stage 2 value, the stage number is 1.")]
        [JsonProperty(PropertyName="stage_1_cooling_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage1CoolingTemperatureOffset { get; set; } = null;
        

        [Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 2 value and less than Stage 3 value, the stage number is 2. The value of this field has to be greater than the value at the previous field.")]
        [JsonProperty(PropertyName="stage_2_cooling_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage2CoolingTemperatureOffset { get; set; } = null;
        

        [Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 3 value and less than Stage 4 value, the stage number is 3. The value of this field has to be greater than the value at the previous field.")]
        [JsonProperty(PropertyName="stage_3_cooling_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage3CoolingTemperatureOffset { get; set; } = null;
        

        [Description(@"The cooling temperature offset is used to determine cooling stage number for multi stage equipment. When the temperature difference of the cooling setpoint and the controlled zone temperature at previous time step is greater than Stage 4 value, the stage number is 4. The value of this field has to be greater than the value at the previous field.")]
        [JsonProperty(PropertyName="stage_4_cooling_temperature_offset", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Stage4CoolingTemperatureOffset { get; set; } = null;
    }
}