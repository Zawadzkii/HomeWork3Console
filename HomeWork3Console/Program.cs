using System;

class Program
{
	static void Main()
	{
		// Input the width of the rectangle
		Console.Write("Enter the width of the rectangle: ");
		double width = Convert.ToDouble(Console.ReadLine());

		// Input the length of the rectangle
		Console.Write("Enter the length of the rectangle: ");
		double length = Convert.ToDouble(Console.ReadLine());

		// Calculate the length of the diagonal
		double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));

		// Display the length of the diagonal
		Console.WriteLine("The length of the diagonal of the rectangle is: " + diagonal);

		Console.ReadKey();
	}
}