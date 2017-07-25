using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts.Repository
{
    public interface IRequester
    {
        void GetStudentScoresFromCouse(string courseName, string username);

        void GetAllStudentFromCourse(string courseName);
    }
}
