namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;

    public class ChangePathAbsoluteCommand : Command
    {
        public ChangePathAbsoluteCommand(string input, List<string> data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count!= 2)
            {
                this.DisplayInvalidCommandMessage(this.Input);
            }
            else
            {
                string absolutePath = this.Data[1];
                this.InputOutputManager.ChangeCurrentDirectoryAbsolute(absolutePath);
            }
        }
    }
}
