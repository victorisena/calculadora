using Calculadora.Model.Interfaces;

namespace Calculadora.Model
{
    public class Subtraction : OperationStrategy
    {
        public decimal Calculate(decimal valueA, decimal valueB)
        {
            return valueA - valueB;
        }
    }
}