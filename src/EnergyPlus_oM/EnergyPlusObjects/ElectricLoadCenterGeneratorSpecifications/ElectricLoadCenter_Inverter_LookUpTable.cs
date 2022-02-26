using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("California Energy Commission tests and publishes data on inverters This inverter " +
                 "model interpolates using CEC test data Input data are at http://www.gosolarcalif" +
                 "ornia.org/equipment/inverter_tests/summaries")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Inverter_LookUpTable : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter name of zone to receive inverter losses as heat if blank then inverter is a" +
                     "ssumed to be outdoors")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [JsonProperty(PropertyName="radiative_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RadiativeFraction { get; set; } = null;
        

        [JsonProperty(PropertyName="rated_maximum_continuous_output_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedMaximumContinuousOutputPower { get; set; } = null;
        

        [JsonProperty(PropertyName="night_tare_loss_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NightTareLossPower { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_voltage_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalVoltageInput { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_at_10_power_and_nominal_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EfficiencyAt10PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_at_20_power_and_nominal_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EfficiencyAt20PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_at_30_power_and_nominal_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EfficiencyAt30PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_at_50_power_and_nominal_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EfficiencyAt50PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_at_75_power_and_nominal_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EfficiencyAt75PowerAndNominalVoltage { get; set; } = null;
        

        [JsonProperty(PropertyName="efficiency_at_100_power_and_nominal_voltage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EfficiencyAt100PowerAndNominalVoltage { get; set; } = null;
    }
}