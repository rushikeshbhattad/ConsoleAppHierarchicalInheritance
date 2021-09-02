using System;

namespace HierarchicalInheritance
{
    class Operation
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation");
        }
    }
    class Addition : Operation
    {
        public void PerformAddition(int a, int b)
        {
            base.PerformOperation();
            Console.WriteLine("Addition is: " + (a + b));
        }
    }
    class Substraction : Operation
    {
        public void PerformSubstraction(int a, int b)
        {
            Console.WriteLine("Substraction is: " + (a - b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter any 2 integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Addition add = new Addition();
            add.PerformAddition(a, b);
            Substraction sub = new Substraction();
            sub.PerformOperation();
            sub.PerformSubstraction(a, b);
            Console.ReadKey();
        }
    }
}