   //using CalcClassLibrary;

namespace QAAutomation
{

    public class Calculator
    {
         public static void Main(string[] args)


         {
            
            Console.WriteLine("Enter two numbers ");
            int A = Convert.ToInt32(Console.ReadLine());
           int B = Convert.ToInt32(Console.ReadLine());

            var alg1 = new Algebra(A , B);

            Console.WriteLine("ADD : " + alg1.Add(A,B));
            Console.WriteLine("Substract : " + alg1.Substract(A,B));
            Console.WriteLine("Multiply : " + alg1.Multiply(A,B));
            Console.WriteLine("Divide : " + alg1.Divide(A,B));



        }
        
    }
}

