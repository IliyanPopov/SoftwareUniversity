namespace InfernoInfinity.Models.Contracts.Gems
{
    using Enumerations;
    using Models;

    public interface IGem
    {
        GemClarityType ClarityType { get; set; }

        int Strenght { get; }

        int Agility { get; }

        int Vitality { get; }
    }
}