namespace InfernoInfinity.Client.Core.Commands
{
    using System.Collections.Generic;
    using Data.Repositories;
    using Models.Contracts.Weapons;
    using Models.Factories;

    public class CreateCommand : Command
    {
        public CreateCommand(IList<string> data,
            InfernoInMemoryRepository repository, WeaponFactory weaponFactory)
            : base(data, repository, weaponFactory)
        {
        }

        public override void Execute()
        {
            IWeapon weapon = this.WeaponFactory.CreateWeapon(this.Data);
            this.Repository.Weapons.Add(weapon);
        }
    }
}