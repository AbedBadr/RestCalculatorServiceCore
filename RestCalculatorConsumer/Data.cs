using System;
using System.Collections.Generic;
using System.Text;

namespace RestCalculatorConsumer
{
    class Data
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

        public override string ToString()
        {
            return $"{nameof(A)}: {A}, {nameof(B)}: {B}";
        }
    }
}
