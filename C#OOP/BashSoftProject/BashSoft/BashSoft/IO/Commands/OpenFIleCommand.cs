namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Exceptions;

    public class OpenFIleCommand : Command
    {
        public OpenFIleCommand(string input, List<string> data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            string fileName = this.Data[1];
            Process.Start(SessionData.CurrentPath + "\\" + fileName);
        }
    }
}
