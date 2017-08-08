namespace InfernoInfinity.Client.Core.Commands
{
    using System.Collections.Generic;
    using System.Linq;
    using Common.CustomAttributes;
    using Contracts;
    using Models.Models.Weapons;

    public class ReviewersCommand : Command
    {
        public ReviewersCommand(IList<string> data, IWriter outputWriter) : base(data, outputWriter)
        {
        }

        public override void Execute()
        {
            var type = typeof(Weapon);
            var customAttributes = type.GetCustomAttributes(false);
            foreach (DescriptionAttribute customAttribute in customAttributes.Where(
                c => c.GetType() == typeof(DescriptionAttribute)))
            {
                this.OutputWriter.WriteLine($"Reviewers: {string.Join(", ", customAttribute.Reviewers)}");
            }
        }
    }
}