using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the properties of air flow through windows and doors (windo" +
                 "w, door and glass door heat transfer subsurfaces) when they are closed or open.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Component_SimpleOpening : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Defined at 1 Pa pressure difference. Enter the coefficient used in the following " +
                     "equation: Mass Flow Rate = Air Mass Flow Coefficient * (dP)^Air Mass Flow Expone" +
                     "nt. Used only when opening (window or door) is closed.")]
        [JsonProperty(PropertyName="air_mass_flow_coefficient_when_opening_is_closed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowCoefficientWhenOpeningIsClosed { get; set; } = null;
        

        [Description("Enter the exponent used in the following equation: Mass Flow Rate = Air Mass Flow" +
                     " Coefficient * (dP)^Air Mass Flow Exponent. Used only when opening (window or do" +
                     "or) is closed.")]
        [JsonProperty(PropertyName="air_mass_flow_exponent_when_opening_is_closed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> AirMassFlowExponentWhenOpeningIsClosed { get; set; } = Double.Parse("0.65", CultureInfo.InvariantCulture);
        

        [Description("Enter the minimum density difference above which two-way flow may occur due to st" +
                     "ack effect.")]
        [JsonProperty(PropertyName="minimum_density_difference_for_two_way_flow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumDensityDifferenceForTwoWayFlow { get; set; } = null;
        

        [Description("The Discharge Coefficient indicates the fractional effectiveness for air flow thr" +
                     "ough a window or door at that Opening Factor.")]
        [JsonProperty(PropertyName="discharge_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DischargeCoefficient { get; set; } = null;
    }
}