using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject
{
    public class StringHelper
    {
        public string LeftFirstSymbol(string value)
        {
            var firstSymbol = value.FirstOrDefault().ToString();
            return firstSymbol;
        }
    }
}
