using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("This object contains the material properties for the materials used in the model." +
                 " The fields are mostly self explanatory.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Slab_MatlProps : BHoMObject
    {
        

        [Description("Density of Slab Material typical value= 2300.0")]
        [JsonProperty(PropertyName="rho_slab_material_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RhoSlabMaterialDensity { get; set; } = Double.Parse("2300", CultureInfo.InvariantCulture);
        

        [Description("Density of Soil Material typical value= 1200.0")]
        [JsonProperty(PropertyName="rho_soil_density", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RhoSoilDensity { get; set; } = Double.Parse("1200", CultureInfo.InvariantCulture);
        

        [Description("Specific Heat of Slab Material typical value=650.0")]
        [JsonProperty(PropertyName="cp_slab_cp", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CpSlabCp { get; set; } = Double.Parse("650", CultureInfo.InvariantCulture);
        

        [Description("Specific Heat of Soil Material typical value= 1200.0")]
        [JsonProperty(PropertyName="cp_soil_cp", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CpSoilCp { get; set; } = Double.Parse("1200", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of Slab Material typical value= .9")]
        [JsonProperty(PropertyName="tcon_slab_k", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TconSlabK { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("Conductivity of Soil Material typical value= 1.0")]
        [JsonProperty(PropertyName="tcon_soil_k", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TconSoilK { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}