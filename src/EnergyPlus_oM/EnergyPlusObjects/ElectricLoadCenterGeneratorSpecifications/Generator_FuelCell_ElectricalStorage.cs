using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Used to describe the electrical storage subsystem for a fuel cell power generator" +
                 ". The electrical storage model is a very simple \"constrained bucket\" model. Note" +
                 " that this electrical storage is embedded within the FC device.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell_ElectricalStorage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="choice_of_model", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Generator_FuelCell_ElectricalStorage_ChoiceOfModel ChoiceOfModel { get; set; } = (Generator_FuelCell_ElectricalStorage_ChoiceOfModel)Enum.Parse(typeof(Generator_FuelCell_ElectricalStorage_ChoiceOfModel), "SimpleEfficiencyWithConstraints");
        

        [JsonProperty(PropertyName="nominal_charging_energetic_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalChargingEnergeticEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="nominal_discharging_energetic_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalDischargingEnergeticEfficiency { get; set; } = null;
        

        [JsonProperty(PropertyName="simple_maximum_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SimpleMaximumCapacity { get; set; } = null;
        

        [JsonProperty(PropertyName="simple_maximum_power_draw", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SimpleMaximumPowerDraw { get; set; } = null;
        

        [JsonProperty(PropertyName="simple_maximum_power_store", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SimpleMaximumPowerStore { get; set; } = null;
        

        [JsonProperty(PropertyName="initial_charge_state", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InitialChargeState { get; set; } = null;
    }
}