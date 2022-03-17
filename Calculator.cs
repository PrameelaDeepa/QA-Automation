//using CalcClassLibrary;


namespace QAAutomation
{

    public class Calculator
    {
         public static void Main(string[] args)


          {
            
            int A;
            int B;

            //int[] C;

            Console.WriteLine(" ------------------TASK 1 ------------------");
            Console.WriteLine("Enter the first number ");
            while (!int.TryParse(Console.ReadLine(), out A))                       
               
              { 
                
                Console.WriteLine("Please enter an Interger");
                Console.WriteLine("Enter the first number ");
              }

           
            Console.WriteLine("Enter the second number ");

            //var B = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out B))
            {
                
                Console.WriteLine("Please enter an Interger");
                Console.WriteLine("Enter the second number ");

            }


            //instantiating parametarized constructor object 

            var alg1 = new Algebra(A , B);

            Console.WriteLine("ADD : " + alg1.Add());
            Console.WriteLine("Substract : " + alg1.Substract());
            Console.WriteLine("Multiply : " + alg1.Multiply());
            Console.WriteLine("Divide : " + alg1.Divide());
                     
            
            int n;
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine(" ------------------TASK 2 ------------------");
            Console.Write("Enter the size of the array :");
           //n = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out n))

            {

                Console.WriteLine("Please enter an Interger for array size");
                
            }
            int[] C = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("element - {0} : ", i);
                
                int temp;
                
                while (!int.TryParse(Console.ReadLine(), out temp))

                {

                    Console.WriteLine("Please enter an Interger");
                    Console.WriteLine("Enter the first number ");
                }
                C[i] = temp;
            }
           

            var alg3 = new Algebra(C);

                       
            Console.WriteLine("ADD : " + alg3.ArrayAdd());
            
            
            Console.WriteLine("Substract : " + alg3.ArraySub());
            Console.WriteLine("Multiply : " + alg3.ArrayMul());

            //Console.WriteLine("Divide : " + alg3.Divide());

            var fib = new MathematicalWonders();
            

        }
        
    }
}

