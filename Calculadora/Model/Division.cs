using Calculadora.Model.Interfaces;

namespace Calculadora.Model
{
    public class Division : OperationStrategy
    {
        public decimal Calculate(decimal valueA, decimal valueB)
        {
            try
            {
                if (valueB == 0) throw new DivideByZeroException("Division by zero is not allowed.");
                return valueA / valueB;
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException($"Division by zero: {valueA} / {valueB}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred during division: {valueA} / {valueB}", ex);
            }
        }
    }
}
