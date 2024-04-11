using Calculadora.Model.Interfaces;

namespace Calculadora.Model
{
    public class Addition : OperationStrategy
    {
        public decimal Calculate(decimal valueA, decimal valueB)
        {
            return valueA + valueB;
        }
    }
}