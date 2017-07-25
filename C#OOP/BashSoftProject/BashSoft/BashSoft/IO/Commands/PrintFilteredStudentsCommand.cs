namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;

    public class PrintFilteredStudentsCommand : Command, IExecutable
    {
        public PrintFilteredStudentsCommand(string input, List<string> data, IContentComparer judge, IDatabase repository, IDirecoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 5)
            {
                this.DisplayInvalidCommandMessage(this.Input);
            }
            else
            {
                string courseName = this.Data[1];
                string filter = this.Data[2].ToLower();
                string takeCommand = this.Data[3].ToLower();
                string takeQuantity = this.Data[4].ToLower();

                this.TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
            }
        }


        private void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity,
            string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.Repository.FilterAndTake(courseName, filter);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.Repository.FilterAndTake(courseName, filter, studentsToTake);
                    }
                    else
                    {
                        OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidTakeQuantityParameter);
            }
        }
    }
}
