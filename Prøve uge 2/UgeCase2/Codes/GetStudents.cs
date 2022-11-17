using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeCase2.Codes
{
    internal class GetStudents : IShowResult
    {
        public string[] ShowResult(List<List<object>> list, string? choosenEnum, string? searchValue)
        {
            if (choosenEnum.Equals(EnumForTeacherStudents.Elev.ToString()))
            {
                Collection getStudent = new();
                string[]? result = getStudent.StudentSearch(list, searchValue);
                return result;
            }
            return null;
        }
    }
}
