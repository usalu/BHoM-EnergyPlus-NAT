using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Internal Gains")]
    public class InternalGains_Objects : BHoMObject
    {
        
        public bool ShouldSerializePeople_List()
        {
            return (People_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="People", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.People> People_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.People> ();
        
        public bool ShouldSerializeComfortViewFactorAngles_List()
        {
            return (ComfortViewFactorAngles_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ComfortViewFactorAngles", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ComfortViewFactorAngles> ComfortViewFactorAngles_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ComfortViewFactorAngles> ();
        
        public bool ShouldSerializeLights_List()
        {
            return (Lights_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Lights", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.Lights> Lights_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.Lights> ();
        
        public bool ShouldSerializeElectricEquipment_List()
        {
            return (ElectricEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment> ElectricEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment> ();
        
        public bool ShouldSerializeGasEquipment_List()
        {
            return (GasEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="GasEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.GasEquipment> GasEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.GasEquipment> ();
        
        public bool ShouldSerializeHotWaterEquipment_List()
        {
            return (HotWaterEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="HotWaterEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.HotWaterEquipment> HotWaterEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.HotWaterEquipment> ();
        
        public bool ShouldSerializeSteamEquipment_List()
        {
            return (SteamEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SteamEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SteamEquipment> SteamEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SteamEquipment> ();
        
        public bool ShouldSerializeOtherEquipment_List()
        {
            return (OtherEquipment_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="OtherEquipment", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.OtherEquipment> OtherEquipment_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.OtherEquipment> ();
        
        public bool ShouldSerializeElectricEquipment_ITE_AirCooled_List()
        {
            return (ElectricEquipment_ITE_AirCooled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ElectricEquipment:ITE:AirCooled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment_ITE_AirCooled> ElectricEquipment_ITE_AirCooled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ElectricEquipment_ITE_AirCooled> ();
        
        public bool ShouldSerializeZoneBaseboard_OutdoorTemperatureControlled_List()
        {
            return (ZoneBaseboard_OutdoorTemperatureControlled_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneBaseboard:OutdoorTemperatureControlled", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneBaseboard_OutdoorTemperatureControlled> ZoneBaseboard_OutdoorTemperatureControlled_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneBaseboard_OutdoorTemperatureControlled> ();
        
        public bool ShouldSerializeSwimmingPool_Indoor_List()
        {
            return (SwimmingPool_Indoor_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SwimmingPool:Indoor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SwimmingPool_Indoor> SwimmingPool_Indoor_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SwimmingPool_Indoor> ();
        
        public bool ShouldSerializeZoneContaminantSourceAndSink_CarbonDioxide_List()
        {
            return (ZoneContaminantSourceAndSink_CarbonDioxide_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneContaminantSourceAndSink:CarbonDioxide", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_CarbonDioxide> ZoneContaminantSourceAndSink_CarbonDioxide_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_CarbonDioxide> ();
        
        public bool ShouldSerializeZoneContaminantSourceAndSink_Generic_Constant_List()
        {
            return (ZoneContaminantSourceAndSink_Generic_Constant_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:Constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_Constant> ZoneContaminantSourceAndSink_Generic_Constant_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_Constant> ();
        
        public bool ShouldSerializeSurfaceContaminantSourceAndSink_Generic_PressureDriven_List()
        {
            return (SurfaceContaminantSourceAndSink_Generic_PressureDriven_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceContaminantSourceAndSink:Generic:PressureDriven", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_PressureDriven> SurfaceContaminantSourceAndSink_Generic_PressureDriven_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_PressureDriven> ();
        
        public bool ShouldSerializeZoneContaminantSourceAndSink_Generic_CutoffModel_List()
        {
            return (ZoneContaminantSourceAndSink_Generic_CutoffModel_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:CutoffModel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_CutoffModel> ZoneContaminantSourceAndSink_Generic_CutoffModel_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_CutoffModel> ();
        
        public bool ShouldSerializeZoneContaminantSourceAndSink_Generic_DecaySource_List()
        {
            return (ZoneContaminantSourceAndSink_Generic_DecaySource_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:DecaySource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DecaySource> ZoneContaminantSourceAndSink_Generic_DecaySource_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DecaySource> ();
        
        public bool ShouldSerializeSurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion_List()
        {
            return (SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceContaminantSourceAndSink:Generic:BoundaryLayerDiffusion", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion> SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_BoundaryLayerDiffusion> ();
        
        public bool ShouldSerializeSurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink_List()
        {
            return (SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="SurfaceContaminantSourceAndSink:Generic:DepositionVelocitySink", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink> SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.SurfaceContaminantSourceAndSink_Generic_DepositionVelocitySink> ();
        
        public bool ShouldSerializeZoneContaminantSourceAndSink_Generic_DepositionRateSink_List()
        {
            return (ZoneContaminantSourceAndSink_Generic_DepositionRateSink_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ZoneContaminantSourceAndSink:Generic:DepositionRateSink", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DepositionRateSink> ZoneContaminantSourceAndSink_Generic_DepositionRateSink_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.InternalGains.ZoneContaminantSourceAndSink_Generic_DepositionRateSink> ();
    }
}