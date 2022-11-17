using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeCase2.Codes
{
    internal class TeacherStudentSubject
    {
        public string[]? result { get; set; }
        public TeacherStudentSubject(IShowResult teacherStudentSubject, List<List<object>> list, string? ChoosenEnum, string? searchValue)
        {
            if (teacherStudentSubject != null)
            {
                if (teacherStudentSubject.GetType() == typeof(GetTeachers))
                {
                    result = new GetTeachers().ShowResult(list, ChoosenEnum, searchValue);
                }
                else if (teacherStudentSubject.GetType() == typeof(GetStudents))
                {
                    result = new GetStudents().ShowResult(list, ChoosenEnum, searchValue);
                }
            }
        }
    }
}
