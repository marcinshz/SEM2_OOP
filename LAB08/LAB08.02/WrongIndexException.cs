using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB08._03.TabMax
{
    class WrongIndexException : Exception
    {
        public WrongIndexException(string message) : base(message) { }
    }
}
