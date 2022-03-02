
using CalcClassLibrary;

namespace Caliculator;
public class Program
{
	public static void Main(string[] args)


	{
        Algebra alg = new Algebra();
		Console.WriteLine("Enter two numbers");
		int a = Convert.ToInt32(Console.ReadLine());
		int b = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Sum "+alg.Add(a, b));
		Console.WriteLine("Substract "+ alg.Substract(a, b));
		Console.WriteLine("multiply" + alg.Multiply(a, b));
		Console.WriteLine("Divide " + alg.Divide(a, b));

	}
}

