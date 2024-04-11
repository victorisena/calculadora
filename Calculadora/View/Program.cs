using Calculadora.Model;
using Calculadora.Services;

class Program
{
    static void Main(string[] args)
    {
        Queue<Operation> operations = new Queue<Operation>();
        operations.Enqueue(new Operation { ValueA = 14, ValueB = 8, Operator = '-' });
        operations.Enqueue(new Operation { ValueA = 5, ValueB = 6, Operator = '*' });
        operations.Enqueue(new Operation { ValueA = 2147483647, ValueB = 2, Operator = '+' });
        operations.Enqueue(new Operation { ValueA = 18, ValueB = 3, Operator = '/' });
        operations.Enqueue(new Operation { ValueA = 2, ValueB = 3, Operator = '+' });

        SimpleCalculator calculator = new SimpleCalculator();
        Stack<decimal> results = new Stack<decimal>();

        Printer.PrintOperations(operations);

        while (operations.Count > 0)
        {
            Operation operation = operations.Dequeue();
            decimal result = calculator.Calculate(operation);
            results.Push(result);

            Console.WriteLine($"Current Operation: {operation.ValueA} {operation.Operator} {operation.ValueB} = {result}");
            Console.WriteLine($"\n");
            if (operations.Count == 0)
            {
                Console.WriteLine("The queue is empty!");
                break;
            }
            Printer.PrintOperations(operations);
        }

        Printer.PrintResults(results);
    }
}