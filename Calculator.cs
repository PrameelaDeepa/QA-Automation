   //using CalcClassLibrary;

namespace QAAutomation
{

    public class Calculator
    {
         public static void Main(string[] args)


         {
            Console.WriteLine("Enter the first number ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int B = Convert.ToInt32(Console.ReadLine());


            //instantiating parametarized constructor object 
            var alg1 = new Algebra();
            Console.WriteLine(alg1.Add(A,B));
            Console.WriteLine(alg1.Substract(A,B));

            // var alg2 = new Algebra(A , B);

            

            // Array constructor
            Algebra[] alg2 = new Algebra[2];
            alg2[0] = new Algebra();
            alg2[1] = new Algebra(A,B);
 
            Console.WriteLine("ADD : " + alg1.Add(A,B));
            Console.WriteLine("Substract : " + alg1.Substract(A,B));
            Console.WriteLine("Multiply : " + alg1.Multiply(A,B));
            Console.WriteLine("Divide : " + alg1.Divide(A,B));

            Console.WriteLine("USing array constructor ");

            Console.WriteLine("ADD : " + alg2[1].Add(A, B));
            Console.WriteLine("Substract : " + alg2[1].Substract(A, B));
            Console.WriteLine("Multiply : " + alg2[1].Multiply(A, B));
            Console.WriteLine("Divide : " + alg2[1].Divide(A, B));



        }
        
    }
}

