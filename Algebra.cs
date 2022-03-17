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
         int[] X;
        

        //constructor with 2 parameters     
        public Algebra(int a, int b)

        {
            Console.WriteLine(" parameterized constructor ");
            A = a;
            B = b;
        }

        //constructor with array 
        public Algebra(int[] c)

        {
            Console.WriteLine(" constructor array ");
            X = c;
            
        }
        
        // Methods intitialization
        public   int Add()
            { return A + B; }
            public  int Substract()
            { return A - B; }
            public int Multiply()
            { return A * B; }
             public double Divide()
            { 
            return (double)A / (double)B; 
             }


        public int ArrayAdd()
        {
            
            int sum = 0;
            for (int i = 0; i < X.Length; i++)
            {
                sum += X[i];
            }
            return sum;
        }
        public int ArraySub()
        {

            int minus = 0;
           // int minus2 = 0;
           
            for (int i = 0; i < X.Length; i++)
            {
                 minus -= X[i];
                //minus1 = X[i] - X[i + 1];
                //minus2 =  minus1 - X[i + 1];
               
              
            }
            return minus;
        }
        public int ArrayMul()
        {
            int prod = 1;

            foreach (int value in X)
            {
                prod *= value;
            }

            return prod;
        }



    }

}
