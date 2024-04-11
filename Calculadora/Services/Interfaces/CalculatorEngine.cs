using Calculadora.Model;

namespace Calculadora.Services.Interfaces
{
    public interface CalculatorEngine
    {
        decimal Calculate(Operation operation);
    }
}
