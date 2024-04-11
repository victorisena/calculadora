using Calculadora.Model;
using Calculadora.Model.Interfaces;
using Calculadora.Services.Interfaces;

namespace Calculadora.Services
{
    public class SimpleCalculator : CalculatorEngine
    {
        private readonly Dictionary<char, OperationStrategy> Operations;

        public SimpleCalculator()
        {
            Operations = new Dictionary<char, OperationStrategy>
            {
                {'+', new Addition()},
                {'-', new Subtraction()},
                {'*', new Multiplication()},
                {'/', new Division()}
            };
        }

        public decimal Calculate(Operation operation)
        {
            if (!Operations.ContainsKey(operation.Operator))
                throw new ArgumentException("Invalid Operator.");

            return Operations[operation.Operator].Calculate(operation.ValueA, operation.ValueB);
        }
    }
}
