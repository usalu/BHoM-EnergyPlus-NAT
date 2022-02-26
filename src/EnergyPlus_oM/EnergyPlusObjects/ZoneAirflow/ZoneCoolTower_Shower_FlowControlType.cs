namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    public enum ZoneCoolTower_Shower_FlowControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="WaterFlowSchedule")]
        WaterFlowSchedule = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="WindDrivenFlow")]
        WindDrivenFlow = 2,
    }
}