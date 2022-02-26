using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Fans
{
    [Description("A detailed fan type for constant-air-volume (CAV) and variable-air-volume (VAV) s" +
                 "ystems. It includes inputs that describe the air-distribution system as well as " +
                 "the fan, drive belt (if used), motor, and variable-frequency-drive (if used).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Fan_ComponentModel : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="minimum_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Applied to specified or autosized max fan airflow")]
        [JsonProperty(PropertyName="fan_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanSizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Diameter of wheel outer circumference")]
        [JsonProperty(PropertyName="fan_wheel_diameter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanWheelDiameter { get; set; } = null;
        

        [Description("Area at fan outlet plane for determining discharge velocity pressure")]
        [JsonProperty(PropertyName="fan_outlet_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanOutletArea { get; set; } = null;
        

        [Description("Maximum ratio between power delivered to air and fan shaft input power Determined" +
                     " from fan performance data")]
        [JsonProperty(PropertyName="maximum_fan_static_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumFanStaticEfficiency { get; set; } = null;
        

        [Description("Euler number (Eu) determined from fan performance data")]
        [JsonProperty(PropertyName="euler_number_at_maximum_fan_static_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EulerNumberAtMaximumFanStaticEfficiency { get; set; } = null;
        

        [Description("Corresponds to maximum ratio between fan airflow and fan shaft rotational speed f" +
                     "or specified fan wheel diameter Determined from fan performance data")]
        [JsonProperty(PropertyName="maximum_dimensionless_fan_airflow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumDimensionlessFanAirflow { get; set; } = null;
        

        [Description("Ratio of motor pulley diameter to fan pulley diameter")]
        [JsonProperty(PropertyName="motor_fan_pulley_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MotorFanPulleyRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Maximum torque transmitted by belt")]
        [JsonProperty(PropertyName="belt_maximum_torque", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> BeltMaximumTorque { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Applied to specified or autosized max torque transmitted by belt")]
        [JsonProperty(PropertyName="belt_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeltSizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Region 1 to 2 curve transition for belt normalized efficiency")]
        [JsonProperty(PropertyName="belt_fractional_torque_transition", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BeltFractionalTorqueTransition { get; set; } = Double.Parse("0.167", CultureInfo.InvariantCulture);
        

        [Description("Maximum rotational speed of fan motor shaft")]
        [JsonProperty(PropertyName="motor_maximum_speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorMaximumSpeed { get; set; } = null;
        

        [Description("Maximum power input to drive belt by motor")]
        [JsonProperty(PropertyName="maximum_motor_output_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumMotorOutputPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Applied to specified or autosized motor output power")]
        [JsonProperty(PropertyName="motor_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorSizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("0.0 means motor outside air stream 1.0 means motor inside air stream")]
        [JsonProperty(PropertyName="motor_in_airstream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MotorInAirstreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Efficiency depends on fraction of full-load motor speed Efficiency depends on  fr" +
                     "action of full-load motor input power If field blank, then assumes constant VFD " +
                     "efficiency (0.97)")]
        [JsonProperty(PropertyName="vfd_efficiency_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Fan_ComponentModel_VfdEfficiencyType VfdEfficiencyType { get; set; } = (Fan_ComponentModel_VfdEfficiencyType)Enum.Parse(typeof(Fan_ComponentModel_VfdEfficiencyType), "Power");
        

        [Description("Maximum power input to motor by VFD")]
        [JsonProperty(PropertyName="maximum_vfd_output_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumVfdOutputPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Applied to specified or autosized VFD output power")]
        [JsonProperty(PropertyName="vfd_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> VfdSizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Pressure rise depends on volumetric flow, system resistances, system leakage, and" +
                     " duct static pressure set point")]
        [JsonProperty(PropertyName="fan_pressure_rise_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanPressureRiseCurveName { get; set; } = "";
        

        [Description("Function of fan volumetric flow Minimum and maximum fan airflows correspond respe" +
                     "ctively to minimum and maximum duct static pressure set points")]
        [JsonProperty(PropertyName="duct_static_pressure_reset_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DuctStaticPressureResetCurveName { get; set; } = "";
        

        [Description("xfan <= 0 Curve should have maximum of 1.0")]
        [JsonProperty(PropertyName="normalized_fan_static_efficiency_curve_name_non_stall_region", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedFanStaticEfficiencyCurveNameNonStallRegion { get; set; } = "";
        

        [Description("xfan > 0 Curve should have maximum of 1.0")]
        [JsonProperty(PropertyName="normalized_fan_static_efficiency_curve_name_stall_region", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedFanStaticEfficiencyCurveNameStallRegion { get; set; } = "";
        

        [Description("xspd <= 0 Curve should have maximum of 1.0")]
        [JsonProperty(PropertyName="normalized_dimensionless_airflow_curve_name_non_stall_region", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedDimensionlessAirflowCurveNameNonStallRegion { get; set; } = "";
        

        [Description("xspd > 0 Curve should have maximum of 1.0")]
        [JsonProperty(PropertyName="normalized_dimensionless_airflow_curve_name_stall_region", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedDimensionlessAirflowCurveNameStallRegion { get; set; } = "";
        

        [Description("Determines maximum fan drive belt efficiency in log space as function of xbelt,ma" +
                     "x Curve should have minimum of -4.6 and maximum of 0.0 If field blank, assumes o" +
                     "utput of curve is always 1.0")]
        [JsonProperty(PropertyName="maximum_belt_efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumBeltEfficiencyCurveName { get; set; } = "";
        

        [Description("Region 1 (0 <= xbelt < xbelt,trans) Curve should have minimum > 0.0 and maximum o" +
                     "f 1.0 If field blank, assumes output of curve is always 1.0 in Region 1")]
        [JsonProperty(PropertyName="normalized_belt_efficiency_curve_name_region_1", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedBeltEfficiencyCurveNameRegion1 { get; set; } = "";
        

        [Description("Region 2 (xbelt,trans <= xbelt <= 1) Curve should have minimum > 0.0 and maximum " +
                     "of 1.0 If field blank, assumes output of curve is always 1.0 in Region 2")]
        [JsonProperty(PropertyName="normalized_belt_efficiency_curve_name_region_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedBeltEfficiencyCurveNameRegion2 { get; set; } = "";
        

        [Description("Determines normalized drive belt efficiency Region 3 (xbelt > 1) Curve should hav" +
                     "e minimum > 0.0 and maximum of 1.0 If field blank, assumes output of curve is al" +
                     "ways 1.0 in Region 3")]
        [JsonProperty(PropertyName="normalized_belt_efficiency_curve_name_region_3", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedBeltEfficiencyCurveNameRegion3 { get; set; } = "";
        

        [Description("Curve should have minimum > 0.0 and maximum of 1.0 If field blank, assumes output" +
                     " of curve is always 1.0")]
        [JsonProperty(PropertyName="maximum_motor_efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumMotorEfficiencyCurveName { get; set; } = "";
        

        [Description("Curve should have minimum > 0.0 and maximum of 1.0 If field blank, assumes output" +
                     " of curve is always 1.0")]
        [JsonProperty(PropertyName="normalized_motor_efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NormalizedMotorEfficiencyCurveName { get; set; } = "";
        

        [Description("Determines VFD efficiency as function of motor load or speed fraction Curve shoul" +
                     "d have minimum > 0.0 and maximum of 1.0 If field blank, assumes constant VFD eff" +
                     "iciency (0.97)")]
        [JsonProperty(PropertyName="vfd_efficiency_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VfdEfficiencyCurveName { get; set; } = "";
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty(PropertyName="end_use_subcategory", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndUseSubcategory { get; set; } = "General";
    }
}