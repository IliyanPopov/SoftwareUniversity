namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;

    public class DropDatabaseCommand : Command
    {
        public DropDatabaseCommand(string input, List<string> data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {

            if (this.Data.Count != 1)
            {
                this.DisplayInvalidCommandMessage(this.Input);
                return;
            }
            this.Repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}
