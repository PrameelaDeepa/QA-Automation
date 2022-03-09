   //using CalcClassLibrary;

namespace QAAutomation
{

    public class Program
    {
         public static void Main(string[] args)


        {

            Algebra alg1 = new Algebra(20, 10); 


            Console.WriteLine("ADD : " + alg1.Add());
            Console.WriteLine("Substract : " + alg1.Substract());
            Console.WriteLine("Multiply : " + alg1.Multiply());
            Console.WriteLine("Divide : " + alg1.Divide());



        }
        
    }
}

