namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    public enum SetpointManager_WarmestTemperatureFlow_Strategy
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="FlowFirst")]
        FlowFirst = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="TemperatureFirst")]
        TemperatureFirst = 2,
    }
}