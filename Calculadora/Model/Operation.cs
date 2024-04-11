using Calculadora.Model.Interfaces;

namespace Calculadora.Model
{
    public class Operation : OperationEngine
    {
        public decimal ValueA { get; set; }
        public decimal ValueB { get; set; }
        public char Operator { get; set; }
        public decimal Result { get; set; }
    }
}