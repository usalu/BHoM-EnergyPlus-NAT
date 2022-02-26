using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Specifies limits on HVAC system simulation timesteps and iterations. This item is" +
                 " an advanced feature that should be used only with caution.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ConvergenceLimits : BHoMObject
    {
        

        [Description("0 sets the minimum to the zone timestep (ref: Timestep) 1 is normal (ratchet down" +
                     " to 1 minute) setting greater than zone timestep (in minutes) will effectively s" +
                     "et to zone timestep")]
        [JsonProperty(PropertyName="minimum_system_timestep", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSystemTimestep { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_hvac_iterations", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumHvacIterations { get; set; } = Double.Parse("20", CultureInfo.InvariantCulture);
        

        [Description(@"Controls the minimum number of plant system solver iterations within a single HVAC iteration Larger values will increase runtime but might improve solution accuracy for complicated plant systems Complex plants include: several interconnected loops, heat recovery, thermal load following generators, etc.")]
        [JsonProperty(PropertyName="minimum_plant_iterations", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPlantIterations { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Controls the maximum number of plant system solver iterations within a single HVA" +
                     "C iteration Smaller values might decrease runtime but could decrease solution ac" +
                     "curacy for complicated plant systems")]
        [JsonProperty(PropertyName="maximum_plant_iterations", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPlantIterations { get; set; } = Double.Parse("8", CultureInfo.InvariantCulture);
    }
}