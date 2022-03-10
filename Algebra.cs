using System;
using System.Collections.Generic;
using System.Text;
namespace QAAutomation
{
    public class Algebra
    {
        //Initialization of variables 
        int A;
        int B;

        //default constructor 
        public Algebra()
        {
            
        }
       
        //constructor with 2 parameters 
        public Algebra(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        
        
        // Methods intitialization
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
