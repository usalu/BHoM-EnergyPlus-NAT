using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"New general DX cooling coil supporting on or more speeds and one or or operating  modes. Includes DX evaporator coil, compressor, and condenser. Object is currently only supported by the AIRLOOPHVAC:UNITARYSYSTEM object. Remaining Coil:Cooling:DX* objects will be deprecated at a future date, after which, this object will replace all other Coil:Cooling:DX* objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="evaporator_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporatorInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="evaporator_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporatorOutletNodeName { get; set; } = "";
        

        [Description("Schedule value > 0 means the coil is available. If this field is blank, the coil " +
                     "is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"This input field is name of a conditioned or unconditioned zone where the secondary coil (condenser) of a DX system or heat pump is to be placed. This is an optional input field specified only when the user desires to reject the condenser heat into a zone. The heat rejected is modeled as internal sensible heat gain of the zone.")]
        [JsonProperty(PropertyName="condenser_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserZoneName { get; set; } = "";
        

        [Description("This is the name of an air node in the simulation. This may be an explicitly defi" +
                     "ned outdoor air node, or it may be a separate air node.")]
        [JsonProperty(PropertyName="condenser_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserInletNodeName { get; set; } = "";
        

        [Description("This is the name of an air node in the simulation.")]
        [JsonProperty(PropertyName="condenser_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="performance_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PerformanceObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="condensate_collection_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondensateCollectionWaterStorageTankName { get; set; } = "";
        

        [JsonProperty(PropertyName="evaporative_condenser_supply_water_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EvaporativeCondenserSupplyWaterStorageTankName { get; set; } = "";
    }
}