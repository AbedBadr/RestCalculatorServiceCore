using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCalculatorServiceCore.Model
{
    public class Data
    {
        public int A { get; set; }
        public int B { get; set; }

        public Data(int a, int b)
        {
            A = a;
            B = b;
        }

        public Data()
        {
            
        }
    }
}
