using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity.Client.Core.Commands
{
    using Contracts;

    public class EndCommand : Command
    {

        public EndCommand(IList<string> data, IWriter outputWriter) : base(data, outputWriter)
        {
        }
        public override void Execute()
        {
            this.OutputWriter.WriteLine("Terminating the program...");
        }
    }
}
