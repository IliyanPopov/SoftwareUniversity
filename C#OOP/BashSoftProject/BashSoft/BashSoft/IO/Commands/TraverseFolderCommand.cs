namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;

    public class TraverseFolderCommand : Command
    {
        public TraverseFolderCommand(string input, List<string> data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count== 1)
            {
                this.InputOutputManager.TraverseDirectory(0);
            }
            else if (this.Data.Count == 2)
            {
                int depth;
                bool hasParsed = int.TryParse(this.Data[1], out depth);
                if (hasParsed)
                {
                    this.InputOutputManager.TraverseDirectory(depth);
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToParseNumber);
                }
            }
            else
            {
                this.DisplayInvalidCommandMessage(this.Input);
            }
        }
    }
}
