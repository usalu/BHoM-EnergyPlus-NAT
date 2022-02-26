using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus
{
    [Description("This a wrapper for all object in the group: Coils")]
    public class Coils_Objects : BHoMObject
    {
        
        public bool ShouldSerializeCoil_Cooling_Water_List()
        {
            return (Coil_Cooling_Water_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water> Coil_Cooling_Water_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water> ();
        
        public bool ShouldSerializeCoil_Cooling_Water_DetailedGeometry_List()
        {
            return (Coil_Cooling_Water_DetailedGeometry_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:Water:DetailedGeometry", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water_DetailedGeometry> Coil_Cooling_Water_DetailedGeometry_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_Water_DetailedGeometry> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_List()
        {
            return (Coil_Cooling_DX_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX> Coil_Cooling_DX_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_CurveFit_Performance_List()
        {
            return (Coil_Cooling_DX_CurveFit_Performance_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:CurveFit:Performance", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Performance> Coil_Cooling_DX_CurveFit_Performance_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Performance> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_CurveFit_OperatingMode_List()
        {
            return (Coil_Cooling_DX_CurveFit_OperatingMode_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:CurveFit:OperatingMode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_OperatingMode> Coil_Cooling_DX_CurveFit_OperatingMode_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_OperatingMode> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_CurveFit_Speed_List()
        {
            return (Coil_Cooling_DX_CurveFit_Speed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:CurveFit:Speed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Speed> Coil_Cooling_DX_CurveFit_Speed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_CurveFit_Speed> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_SingleSpeed_List()
        {
            return (Coil_Cooling_DX_SingleSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed> Coil_Cooling_DX_SingleSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_TwoSpeed_List()
        {
            return (Coil_Cooling_DX_TwoSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:TwoSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoSpeed> Coil_Cooling_DX_TwoSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoSpeed> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_MultiSpeed_List()
        {
            return (Coil_Cooling_DX_MultiSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_MultiSpeed> Coil_Cooling_DX_MultiSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_MultiSpeed> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_VariableSpeed_List()
        {
            return (Coil_Cooling_DX_VariableSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableSpeed> Coil_Cooling_DX_VariableSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableSpeed> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_TwoStageWithHumidityControlMode_List()
        {
            return (Coil_Cooling_DX_TwoStageWithHumidityControlMode_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:TwoStageWithHumidityControlMode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoStageWithHumidityControlMode> Coil_Cooling_DX_TwoStageWithHumidityControlMode_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_TwoStageWithHumidityControlMode> ();
        
        public bool ShouldSerializeCoilPerformance_DX_Cooling_List()
        {
            return (CoilPerformance_DX_Cooling_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoilPerformance:DX:Cooling", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilPerformance_DX_Cooling> CoilPerformance_DX_Cooling_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilPerformance_DX_Cooling> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_VariableRefrigerantFlow_List()
        {
            return (Coil_Cooling_DX_VariableRefrigerantFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow> Coil_Cooling_DX_VariableRefrigerantFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow> ();
        
        public bool ShouldSerializeCoil_Heating_DX_VariableRefrigerantFlow_List()
        {
            return (Coil_Heating_DX_VariableRefrigerantFlow_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:DX:VariableRefrigerantFlow", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow> Coil_Heating_DX_VariableRefrigerantFlow_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl_List()
        {
            return (Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl> Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_VariableRefrigerantFlow_FluidTemperatureControl> ();
        
        public bool ShouldSerializeCoil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl_List()
        {
            return (Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:DX:VariableRefrigerantFlow:FluidTemperatureControl", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl> Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableRefrigerantFlow_FluidTemperatureControl> ();
        
        public bool ShouldSerializeCoil_Heating_Water_List()
        {
            return (Coil_Heating_Water_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Water> Coil_Heating_Water_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Water> ();
        
        public bool ShouldSerializeCoil_Heating_Steam_List()
        {
            return (Coil_Heating_Steam_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Steam", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Steam> Coil_Heating_Steam_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Steam> ();
        
        public bool ShouldSerializeCoil_Heating_Electric_List()
        {
            return (Coil_Heating_Electric_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Electric", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric> Coil_Heating_Electric_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric> ();
        
        public bool ShouldSerializeCoil_Heating_Electric_MultiStage_List()
        {
            return (Coil_Heating_Electric_MultiStage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Electric:MultiStage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric_MultiStage> Coil_Heating_Electric_MultiStage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Electric_MultiStage> ();
        
        public bool ShouldSerializeCoil_Heating_Fuel_List()
        {
            return (Coil_Heating_Fuel_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Fuel", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Fuel> Coil_Heating_Fuel_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Fuel> ();
        
        public bool ShouldSerializeCoil_Heating_Gas_MultiStage_List()
        {
            return (Coil_Heating_Gas_MultiStage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Gas:MultiStage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Gas_MultiStage> Coil_Heating_Gas_MultiStage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Gas_MultiStage> ();
        
        public bool ShouldSerializeCoil_Heating_Desuperheater_List()
        {
            return (Coil_Heating_Desuperheater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:Desuperheater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Desuperheater> Coil_Heating_Desuperheater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_Desuperheater> ();
        
        public bool ShouldSerializeCoil_Heating_DX_SingleSpeed_List()
        {
            return (Coil_Heating_DX_SingleSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:DX:SingleSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_SingleSpeed> Coil_Heating_DX_SingleSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_SingleSpeed> ();
        
        public bool ShouldSerializeCoil_Heating_DX_MultiSpeed_List()
        {
            return (Coil_Heating_DX_MultiSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:DX:MultiSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_MultiSpeed> Coil_Heating_DX_MultiSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_MultiSpeed> ();
        
        public bool ShouldSerializeCoil_Heating_DX_VariableSpeed_List()
        {
            return (Coil_Heating_DX_VariableSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:DX:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableSpeed> Coil_Heating_DX_VariableSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_DX_VariableSpeed> ();
        
        public bool ShouldSerializeCoil_Cooling_WaterToAirHeatPump_ParameterEstimation_List()
        {
            return (Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:WaterToAirHeatPump:ParameterEstimation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_ParameterEstimation> Coil_Cooling_WaterToAirHeatPump_ParameterEstimation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_ParameterEstimation> ();
        
        public bool ShouldSerializeCoil_Heating_WaterToAirHeatPump_ParameterEstimation_List()
        {
            return (Coil_Heating_WaterToAirHeatPump_ParameterEstimation_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:WaterToAirHeatPump:ParameterEstimation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_ParameterEstimation> Coil_Heating_WaterToAirHeatPump_ParameterEstimation_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_ParameterEstimation> ();
        
        public bool ShouldSerializeCoil_Cooling_WaterToAirHeatPump_EquationFit_List()
        {
            return (Coil_Cooling_WaterToAirHeatPump_EquationFit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:WaterToAirHeatPump:EquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_EquationFit> Coil_Cooling_WaterToAirHeatPump_EquationFit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_EquationFit> ();
        
        public bool ShouldSerializeCoil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit_List()
        {
            return (Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:WaterToAirHeatPump:VariableSpeedEquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit> Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_WaterToAirHeatPump_VariableSpeedEquationFit> ();
        
        public bool ShouldSerializeCoil_Heating_WaterToAirHeatPump_EquationFit_List()
        {
            return (Coil_Heating_WaterToAirHeatPump_EquationFit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:WaterToAirHeatPump:EquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_EquationFit> Coil_Heating_WaterToAirHeatPump_EquationFit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_EquationFit> ();
        
        public bool ShouldSerializeCoil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit_List()
        {
            return (Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Heating:WaterToAirHeatPump:VariableSpeedEquationFit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit> Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Heating_WaterToAirHeatPump_VariableSpeedEquationFit> ();
        
        public bool ShouldSerializeCoil_WaterHeating_AirToWaterHeatPump_Pumped_List()
        {
            return (Coil_WaterHeating_AirToWaterHeatPump_Pumped_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:WaterHeating:AirToWaterHeatPump:Pumped", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Pumped> Coil_WaterHeating_AirToWaterHeatPump_Pumped_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Pumped> ();
        
        public bool ShouldSerializeCoil_WaterHeating_AirToWaterHeatPump_Wrapped_List()
        {
            return (Coil_WaterHeating_AirToWaterHeatPump_Wrapped_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:WaterHeating:AirToWaterHeatPump:Wrapped", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Wrapped> Coil_WaterHeating_AirToWaterHeatPump_Wrapped_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_Wrapped> ();
        
        public bool ShouldSerializeCoil_WaterHeating_AirToWaterHeatPump_VariableSpeed_List()
        {
            return (Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:WaterHeating:AirToWaterHeatPump:VariableSpeed", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed> Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_AirToWaterHeatPump_VariableSpeed> ();
        
        public bool ShouldSerializeCoil_WaterHeating_Desuperheater_List()
        {
            return (Coil_WaterHeating_Desuperheater_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:WaterHeating:Desuperheater", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_Desuperheater> Coil_WaterHeating_Desuperheater_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_WaterHeating_Desuperheater> ();
        
        public bool ShouldSerializeCoilSystem_Cooling_DX_List()
        {
            return (CoilSystem_Cooling_DX_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoilSystem:Cooling:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX> CoilSystem_Cooling_DX_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX> ();
        
        public bool ShouldSerializeCoilSystem_Heating_DX_List()
        {
            return (CoilSystem_Heating_DX_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoilSystem:Heating:DX", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Heating_DX> CoilSystem_Heating_DX_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Heating_DX> ();
        
        public bool ShouldSerializeCoilSystem_Cooling_Water_HeatExchangerAssisted_List()
        {
            return (CoilSystem_Cooling_Water_HeatExchangerAssisted_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoilSystem:Cooling:Water:HeatExchangerAssisted", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_Water_HeatExchangerAssisted> CoilSystem_Cooling_Water_HeatExchangerAssisted_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_Water_HeatExchangerAssisted> ();
        
        public bool ShouldSerializeCoilSystem_Cooling_DX_HeatExchangerAssisted_List()
        {
            return (CoilSystem_Cooling_DX_HeatExchangerAssisted_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoilSystem:Cooling:DX:HeatExchangerAssisted", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX_HeatExchangerAssisted> CoilSystem_Cooling_DX_HeatExchangerAssisted_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_Cooling_DX_HeatExchangerAssisted> ();
        
        public bool ShouldSerializeCoilSystem_IntegratedHeatPump_AirSource_List()
        {
            return (CoilSystem_IntegratedHeatPump_AirSource_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="CoilSystem:IntegratedHeatPump:AirSource", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_IntegratedHeatPump_AirSource> CoilSystem_IntegratedHeatPump_AirSource_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.CoilSystem_IntegratedHeatPump_AirSource> ();
        
        public bool ShouldSerializeCoil_Cooling_DX_SingleSpeed_ThermalStorage_List()
        {
            return (Coil_Cooling_DX_SingleSpeed_ThermalStorage_List.Count > 0);
        }
        

        [JsonProperty(PropertyName="Coil:Cooling:DX:SingleSpeed:ThermalStorage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed_ThermalStorage> Coil_Cooling_DX_SingleSpeed_ThermalStorage_List { get; set; } = new System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.Coils.Coil_Cooling_DX_SingleSpeed_ThermalStorage> ();
    }
}