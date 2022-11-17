using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UgeCase2.Codes
{
    internal interface IShowResult
    {
        public string[] ShowResult(List<List<object>> list, string? ChoosenEnum, string? searchValue);
    }
}
