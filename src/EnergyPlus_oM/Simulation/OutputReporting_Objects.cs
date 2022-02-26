using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Output Reporting")]
    public class OutputReporting_Objects : BHoMObject
    {
        
        public bool ShouldSerializeOutput_VariableDictionary_List()
        {
            return (Output_VariableDictionary_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:VariableDictionary", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_VariableDictionary> Output_VariableDictionary_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_VariableDictionary> ();
        
        public bool ShouldSerializeOutput_Surfaces_List_List()
        {
            return (Output_Surfaces_List_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Surfaces:List", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_List> Output_Surfaces_List_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_List> ();
        
        public bool ShouldSerializeOutput_Surfaces_Drawing_List()
        {
            return (Output_Surfaces_Drawing_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Surfaces:Drawing", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_Drawing> Output_Surfaces_Drawing_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Surfaces_Drawing> ();
        
        public bool ShouldSerializeOutput_Schedules_List()
        {
            return (Output_Schedules_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Schedules", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Schedules> Output_Schedules_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Schedules> ();
        
        public bool ShouldSerializeOutput_Constructions_List()
        {
            return (Output_Constructions_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Constructions", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Constructions> Output_Constructions_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Constructions> ();
        

        [JsonProperty(PropertyName="Output:EnergyManagementSystem", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnergyManagementSystem Output_EnergyManagementSystem { get; set; } = null;
        
        public bool ShouldSerializeOutputControl_SurfaceColorScheme_List()
        {
            return (OutputControl_SurfaceColorScheme_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="OutputControl:SurfaceColorScheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_SurfaceColorScheme> OutputControl_SurfaceColorScheme_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_SurfaceColorScheme> ();
        

        [JsonProperty(PropertyName="Output:Table:SummaryReports", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_SummaryReports Output_Table_SummaryReports { get; set; } = null;
        
        public bool ShouldSerializeOutput_Table_TimeBins_List()
        {
            return (Output_Table_TimeBins_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Table:TimeBins", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_TimeBins> Output_Table_TimeBins_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_TimeBins> ();
        
        public bool ShouldSerializeOutput_Table_Monthly_List()
        {
            return (Output_Table_Monthly_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Table:Monthly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Monthly> Output_Table_Monthly_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Monthly> ();
        
        public bool ShouldSerializeOutput_Table_Annual_List()
        {
            return (Output_Table_Annual_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Table:Annual", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Annual> Output_Table_Annual_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Table_Annual> ();
        

        [JsonProperty(PropertyName="OutputControl:Table:Style", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_Table_Style OutputControl_Table_Style { get; set; } = null;
        

        [JsonProperty(PropertyName="OutputControl:ReportingTolerances", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_ReportingTolerances OutputControl_ReportingTolerances { get; set; } = null;
        
        public bool ShouldSerializeOutput_Variable_List()
        {
            return (Output_Variable_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Variable> Output_Variable_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Variable> ();
        
        public bool ShouldSerializeOutput_Meter_List()
        {
            return (Output_Meter_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Meter", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter> Output_Meter_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter> ();
        
        public bool ShouldSerializeOutput_Meter_MeterFileOnly_List()
        {
            return (Output_Meter_MeterFileOnly_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Meter:MeterFileOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_MeterFileOnly> Output_Meter_MeterFileOnly_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_MeterFileOnly> ();
        
        public bool ShouldSerializeOutput_Meter_Cumulative_List()
        {
            return (Output_Meter_Cumulative_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Meter:Cumulative", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative> Output_Meter_Cumulative_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative> ();
        
        public bool ShouldSerializeOutput_Meter_Cumulative_MeterFileOnly_List()
        {
            return (Output_Meter_Cumulative_MeterFileOnly_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:Meter:Cumulative:MeterFileOnly", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative_MeterFileOnly> Output_Meter_Cumulative_MeterFileOnly_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Meter_Cumulative_MeterFileOnly> ();
        
        public bool ShouldSerializeMeter_Custom_List()
        {
            return (Meter_Custom_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Meter:Custom", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_Custom> Meter_Custom_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_Custom> ();
        
        public bool ShouldSerializeMeter_CustomDecrement_List()
        {
            return (Meter_CustomDecrement_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Meter:CustomDecrement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_CustomDecrement> Meter_CustomDecrement_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Meter_CustomDecrement> ();
        

        [JsonProperty(PropertyName="OutputControl:Files", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.OutputControl_Files OutputControl_Files { get; set; } = null;
        

        [JsonProperty(PropertyName="Output:JSON", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_JSON Output_JSON { get; set; } = null;
        

        [JsonProperty(PropertyName="Output:SQLite", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_SQLite Output_SQLite { get; set; } = null;
        
        public bool ShouldSerializeOutput_EnvironmentalImpactFactors_List()
        {
            return (Output_EnvironmentalImpactFactors_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:EnvironmentalImpactFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnvironmentalImpactFactors> Output_EnvironmentalImpactFactors_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_EnvironmentalImpactFactors> ();
        
        public bool ShouldSerializeEnvironmentalImpactFactors_List()
        {
            return (EnvironmentalImpactFactors_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="EnvironmentalImpactFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.EnvironmentalImpactFactors> EnvironmentalImpactFactors_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.EnvironmentalImpactFactors> ();
        
        public bool ShouldSerializeFuelFactors_List()
        {
            return (FuelFactors_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="FuelFactors", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.FuelFactors> FuelFactors_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.FuelFactors> ();
        

        [JsonProperty(PropertyName="Output:Diagnostics", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_Diagnostics Output_Diagnostics { get; set; } = null;
        

        [JsonProperty(PropertyName="Output:DebuggingData", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public BH.oM.Adapters.EnergyPlus.OutputReporting.Output_DebuggingData Output_DebuggingData { get; set; } = null;
        
        public bool ShouldSerializeOutput_PreprocessorMessage_List()
        {
            return (Output_PreprocessorMessage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Output:PreprocessorMessage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_PreprocessorMessage> Output_PreprocessorMessage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.OutputReporting.Output_PreprocessorMessage> ();
    }
}