using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts.Repository
{
    public interface IFilteredTaker
    {
        void FilterAndTake(string courseName, string givenFIlter, int? studentsToTake = null);
    }
}
