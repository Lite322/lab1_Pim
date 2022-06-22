using System;

namespace lab1_Pim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления по формулам");
            Console.WriteLine("z1 = ((3m + 2)^2 - 24m)^(-0,5) / 3 * (m)^(-0,5) - 2 / (m)^(-0,5)");
            Console.WriteLine("z2 = -(m)^(-0,5)");
            Console.WriteLine("Введите m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат первой формулы:");
            Console.WriteLine(Formuly.Form1(m));
            Console.WriteLine("Результат второй формулы:");
            Console.WriteLine(Formuly.Form2(m));
            Console.ReadLine();
        }
    }
}
