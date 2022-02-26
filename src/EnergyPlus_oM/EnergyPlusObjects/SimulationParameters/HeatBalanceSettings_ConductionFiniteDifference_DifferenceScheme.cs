namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    public enum HeatBalanceSettings_ConductionFiniteDifference_DifferenceScheme
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CrankNicholsonSecondOrder")]
        CrankNicholsonSecondOrder = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="FullyImplicitFirstOrder")]
        FullyImplicitFirstOrder = 2,
    }
}