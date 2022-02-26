using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    [Description(@"This object is used in conjunction with Controller:OutdoorAir to specify outdoor ventilation air based on outdoor air specified in the DesignSpecification:OutdoorAir object The Controller:OutdoorAir object is associated with a specific air loop, so the outdoor air flow rates specified in Controller:MechanicalVentilation correspond to the zones attached to that specific air loop. Duplicate groups of Zone name, Design Specification Outdoor Air Object Name, and Design Specification Zone Air Distribution Object Name to increase allowable number of entries")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Controller_MechanicalVentilation : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("If this field is blank, the controller uses the values from the associated Contro" +
                     "ller:OutdoorAir. Schedule values greater than 0 indicate mechanical ventilation " +
                     "is enabled")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="demand_controlled_ventilation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes DemandControlledVentilation { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty(PropertyName="system_outdoor_air_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Controller_MechanicalVentilation_SystemOutdoorAirMethod SystemOutdoorAirMethod { get; set; } = (Controller_MechanicalVentilation_SystemOutdoorAirMethod)Enum.Parse(typeof(Controller_MechanicalVentilation_SystemOutdoorAirMethod), "VentilationRateProcedure");
        

        [JsonProperty(PropertyName="zone_maximum_outdoor_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneMaximumOutdoorAirFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="zone_specifications", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Controllers.Controller_MechanicalVentilation_ZoneSpecifications_Item> ZoneSpecifications { get; set; } = null;
    }
}