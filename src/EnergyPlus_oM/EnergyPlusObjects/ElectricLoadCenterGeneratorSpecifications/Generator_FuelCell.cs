using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("This generator model is the FC model from IEA Annex 42")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Generator_FuelCell : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:PowerModule object.")]
        [JsonProperty(PropertyName="power_module_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PowerModuleName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:AirSupply object.")]
        [JsonProperty(PropertyName="air_supply_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirSupplyName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelSupply object.")]
        [JsonProperty(PropertyName="fuel_supply_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FuelSupplyName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:WaterSupply object.")]
        [JsonProperty(PropertyName="water_supply_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterSupplyName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:AuxiliaryHeater object.")]
        [JsonProperty(PropertyName="auxiliary_heater_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuxiliaryHeaterName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:ExhaustGasToWaterHeatExchanger object.")]
        [JsonProperty(PropertyName="heat_exchanger_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatExchangerName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:ElectricalStorage object.")]
        [JsonProperty(PropertyName="electrical_storage_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricalStorageName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:Inverter object.")]
        [JsonProperty(PropertyName="inverter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InverterName { get; set; } = "";
        

        [Description("Enter the name of a Generator:FuelCell:StackCooler object. optional, used for PEM" +
                     "FC")]
        [JsonProperty(PropertyName="stack_cooler_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StackCoolerName { get; set; } = "";
    }
}