using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class TextService
    {
        //Quest12
        public string AddText(string previousResult, int numAdd)
        {
            string result = $"{previousResult}{numAdd}";
            return result;
        }
    }
}
