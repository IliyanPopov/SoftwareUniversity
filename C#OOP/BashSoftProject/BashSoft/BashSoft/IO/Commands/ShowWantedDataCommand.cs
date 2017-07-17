namespace BashSoft.IO.Commands
{
    using System.Collections.Generic;

    public class ShowWantedDataCommand : Command
    {
        public ShowWantedDataCommand(string input, List<string> data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Count != 2 && this.Data.Count != 3)
            {
                this.DisplayInvalidCommandMessage(this.Input);
            }
            else if (this.Data.Count == 2)
            {
                string courseName = this.Data[1];
                this.Repository.GetAllStudentFromCourse(courseName);
            }
            else if (this.Data.Count == 3)
            {
                string courseName = this.Data[1];
                string userName = this.Data[2];
                this.Repository.GetStudentScoresFromCouse(courseName, userName);
            }
        }
    }
}
