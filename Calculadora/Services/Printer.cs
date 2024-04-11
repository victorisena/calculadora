using Calculadora.Model;

namespace Calculadora.Services
{
    public static class Printer
    {
        public static void PrintOperations(IEnumerable<Operation> operations)
        {
            Console.WriteLine("Operations to be processed:");
            foreach (var operation in operations)
            {
                Console.WriteLine($"{operation.ValueA} {operation.Operator} {operation.ValueB}");
            }
        }

        public static void PrintResults(IEnumerable<decimal> results)
        {
            Console.WriteLine("Results:");
            foreach (var result in results)
            {
                Console.Write($"{result} | ");
            }
            Console.WriteLine("\n");
        }
    }
}
