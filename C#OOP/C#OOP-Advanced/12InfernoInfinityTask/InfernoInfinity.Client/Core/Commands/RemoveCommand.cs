namespace InfernoInfinity.Client.Core.Commands
{
    using System.Collections.Generic;
    using System.Linq;
    using Common.Utilities;
    using Data.Repositories;
    using Models.Contracts.Gems;

    public class RemoveCommand : Command
    {
        public RemoveCommand(IList<string> data, InfernoInMemoryRepository repository)
            : base(data, repository)
        {
        }

        public override void Execute()
        {
            string weaponNameToRemoveGemFrom = this.Data[1];
            int gemRemoveIndex = int.Parse(this.Data[2]);
            var weaponResultRemoveGem =
                this.Repository.Weapons
                    .FirstOrDefault(w => w.Name == weaponNameToRemoveGemFrom);
            if (weaponResultRemoveGem != null &&
                Validator<IGem>.ValidateRange(weaponResultRemoveGem.GemSockets, gemRemoveIndex))
            {
                weaponResultRemoveGem.GemSockets[gemRemoveIndex] = null;
            }
        }
    }
}