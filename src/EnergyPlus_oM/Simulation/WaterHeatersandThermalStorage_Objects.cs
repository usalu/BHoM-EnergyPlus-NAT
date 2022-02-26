using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Water Heaters and Thermal Storage")]
    public class WaterHeatersandThermalStorage_Objects : BHoMObject
    {
        
        public bool ShouldSerializeWaterHeater_Mixed_List()
        {
            return (WaterHeater_Mixed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterHeater:Mixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Mixed> WaterHeater_Mixed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Mixed> ();
        
        public bool ShouldSerializeWaterHeater_Stratified_List()
        {
            return (WaterHeater_Stratified_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterHeater:Stratified", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Stratified> WaterHeater_Stratified_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Stratified> ();
        
        public bool ShouldSerializeWaterHeater_Sizing_List()
        {
            return (WaterHeater_Sizing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterHeater:Sizing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Sizing> WaterHeater_Sizing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_Sizing> ();
        
        public bool ShouldSerializeWaterHeater_HeatPump_PumpedCondenser_List()
        {
            return (WaterHeater_HeatPump_PumpedCondenser_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterHeater:HeatPump:PumpedCondenser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_PumpedCondenser> WaterHeater_HeatPump_PumpedCondenser_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_PumpedCondenser> ();
        
        public bool ShouldSerializeWaterHeater_HeatPump_WrappedCondenser_List()
        {
            return (WaterHeater_HeatPump_WrappedCondenser_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="WaterHeater:HeatPump:WrappedCondenser", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_WrappedCondenser> WaterHeater_HeatPump_WrappedCondenser_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.WaterHeater_HeatPump_WrappedCondenser> ();
        
        public bool ShouldSerializeThermalStorage_Ice_Simple_List()
        {
            return (ThermalStorage_Ice_Simple_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermalStorage:Ice:Simple", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Simple> ThermalStorage_Ice_Simple_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Simple> ();
        
        public bool ShouldSerializeThermalStorage_Ice_Detailed_List()
        {
            return (ThermalStorage_Ice_Detailed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermalStorage:Ice:Detailed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Detailed> ThermalStorage_Ice_Detailed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_Ice_Detailed> ();
        
        public bool ShouldSerializeThermalStorage_ChilledWater_Mixed_List()
        {
            return (ThermalStorage_ChilledWater_Mixed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermalStorage:ChilledWater:Mixed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Mixed> ThermalStorage_ChilledWater_Mixed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Mixed> ();
        
        public bool ShouldSerializeThermalStorage_ChilledWater_Stratified_List()
        {
            return (ThermalStorage_ChilledWater_Stratified_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="ThermalStorage:ChilledWater:Stratified", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Stratified> ThermalStorage_ChilledWater_Stratified_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage.ThermalStorage_ChilledWater_Stratified> ();
    }
}