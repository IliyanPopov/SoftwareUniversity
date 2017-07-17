namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Exceptions;

    public class MakeDirectoryCommand : Command
    {
        public MakeDirectoryCommand(string input, List<string> data, Tester judge, StudentsRepository repository,
            IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string folderName = this.Data[1];
            this.InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
}