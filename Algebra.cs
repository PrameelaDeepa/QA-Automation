using System;
using System.Collections.Generic;
using System.Text;
namespace QAAutomation
{
    public class Algebra
    {
        int A;
        int B;
        public Algebra(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        
            public   int Add(int a, int b)
            { return a + b; }
            public  int Substract(int a, int b)
            { return a - b; }
            public int Multiply(int a, int b)
            { return a * b; }
             public float Divide(int a, int b)
            { return a / b; }

        
    }

}
