using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces
{
    [Description("Used to control forced airflow through a gap between glass layers")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WindowProperty_AirflowControl : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="airflow_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowProperty_AirflowControl_AirflowSource AirflowSource { get; set; } = (WindowProperty_AirflowControl_AirflowSource)Enum.Parse(typeof(WindowProperty_AirflowControl_AirflowSource), "IndoorAir");
        

        [Description("If ReturnAir is selected, the name of the Return Air Node may be specified below." +
                     "")]
        [JsonProperty(PropertyName="airflow_destination", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowProperty_AirflowControl_AirflowDestination AirflowDestination { get; set; } = (WindowProperty_AirflowControl_AirflowDestination)Enum.Parse(typeof(WindowProperty_AirflowControl_AirflowDestination), "OutdoorAir");
        

        [Description("Above is m3/s per m of glazing width")]
        [JsonProperty(PropertyName="maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("ScheduledOnly requires that Airflow Has Multiplier Schedule Name = Yes and that A" +
                     "irflow Multiplier Schedule Name is specified.")]
        [JsonProperty(PropertyName="airflow_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WindowProperty_AirflowControl_AirflowControlType AirflowControlType { get; set; } = (WindowProperty_AirflowControl_AirflowControlType)Enum.Parse(typeof(WindowProperty_AirflowControl_AirflowControlType), "AlwaysOnAtMaximumFlow");
        

        [Description("If Yes, then Airflow Multiplier Schedule Name must be specified")]
        [JsonProperty(PropertyName="airflow_is_scheduled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes AirflowIsScheduled { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Required if Airflow Is Scheduled = Yes. Schedule values are 0.0 or 1.0 and multip" +
                     "ly Maximum Air Flow.")]
        [JsonProperty(PropertyName="airflow_multiplier_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirflowMultiplierScheduleName { get; set; } = "";
        

        [Description("Name of the return air node for this airflow window if the Airflow Destination is" +
                     " ReturnAir. If left blank, defaults to the first return air node for the zone of" +
                     " the window surface.")]
        [JsonProperty(PropertyName="airflow_return_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirflowReturnAirNodeName { get; set; } = "";
    }
}