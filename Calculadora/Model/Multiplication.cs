using Calculadora.Model.Interfaces;

namespace Calculadora.Model
{
    public class Multiplication : OperationStrategy
    {
        public decimal Calculate(decimal valueA, decimal valueB)
        {
            return valueA * valueB;
        }
    }
}
