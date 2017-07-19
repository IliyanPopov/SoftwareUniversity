namespace OOPExamMinedCraft.Commands
{
    using System;
    using System.Collections.Generic;
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;
    using Models.Factories;
    using Models.Models.Providers;

    public class RegisterProviderCommand : Command
    {
        private readonly ProviderFactory _providerFactory;

        public RegisterProviderCommand(MinedraftRepository minedraftRepository, List<string> data, OutputWriter outputWriter)
            : base(minedraftRepository, data, outputWriter)
        {
            this._providerFactory = new ProviderFactory();
        }

        public override void Execute()
        {
            try
            {
                string providerType = this.Arguments[0];
                string id = this.Arguments[1];
                Provider provider = this._providerFactory.CreateProvider(this.Arguments);
                this.MinedraftRepository.Providers.Add(provider);
                this.OutputWriter.WriteMessageOnNewLine($"Successfully registered {providerType} Provider - {id}");
            }
            catch (Exception e)
            {
                this.OutputWriter.DisplayException(e.Message);
            }
        }
    }
}