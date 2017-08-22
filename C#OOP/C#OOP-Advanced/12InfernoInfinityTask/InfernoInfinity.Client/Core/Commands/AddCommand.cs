namespace InfernoInfinity.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common.Utilities;
    using Data.Repositories;
    using Models.Contracts.Gems;
    using Models.Enumerations;

    public class AddCommand : Command
    {
        public AddCommand(IList<string> data, InfernoInMemoryRepository repository)
            : base(data, repository)
        {
        }

        public override void Execute()
        {
            string weaponNameToAddGemTo = this.Data[1];
            int gemInsertIndex = int.Parse(this.Data[2]);
            var gemClarityTypeAndGemType = this.Data[3].Split();
            string gemType = gemClarityTypeAndGemType[1];

            GemClarityType gemClarityType;
            Enum.TryParse(gemClarityTypeAndGemType[0], out gemClarityType);

            var weaponResultAddGem = this.Repository.Weapons
                .FirstOrDefault(w => w.Name == weaponNameToAddGemTo);
            var gemResult = this.Repository.Gems
                .FirstOrDefault(g => g.GetType().Name.ToString() == gemType && g.ClarityType == gemClarityType);

            if (weaponResultAddGem != null &&
                Validator<IGem>.ValidateRange(weaponResultAddGem.GemSockets, gemInsertIndex))
            {
                weaponResultAddGem.GemSockets[gemInsertIndex] = gemResult;
            }
        }
    }
}