namespace OOPExamMinedCraft.Common.Utilities
{
    public static class Constants
    {
        // Harvester constants
        public const int MinHarvesterOreOutput = 0;
        public const int MinHarvesterEnergyOutput = 0;
        public const int MaxHarvesterEnergyOutput = 20000;
        public const int InitialHammerHarvesterOreOutputMultipiyer = 3;
        public const int InitialHammerHarvesterEnergyRequirementMultipiyer = 2;

        // Provider constants
        public const int MinProviderOreOutput = 0;
        public const int MinProviderEnergyOutput = 0;
        public const int MaxProviderEnergyOutput = 10000;
        public const double InitialPressureProviderEneryOutputMultipliyer = 1.5;

        // Mode constants
        public const double FullModeHarvesterEnergyRequirementMultiplyer = 1;
        public const double FullModeHarvesterOreOutputMultiplyer = 1;
        public const double HalfModeHarvesterEnergyRequirementMultiplyer = 0.6;
        public const double HalfModeHarvesterOreOutputMultiplyer = 0.5;
        public const double EnergyModeHarvesterEnergyRequirementMultiplyer = 0;
        public const double EnergyModeHarvesterOreOutputMultiplyer = 0;
    }
}
