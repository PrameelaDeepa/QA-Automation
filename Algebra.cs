using System;
using System.Collections.Generic;
using System.Text;
namespace QAAutomation
{
    public class Algebra

    {
        int A = 30;
         int B = 10;

        public Algebra (int a, int b)
        { 
        
           A = a;
           B = b ;
            
        }
       public int Add()
        { return A + B; }

        public int Substract()
        { return A - B; }
        public int Multiply()
        { return A * B; }
        public float Divide()
        { return A / B; }




    }
    
}


            
            


