using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Interfaces
{
    public class OperationEngine
    {
        decimal ValueA { get; set; }
        decimal ValueB { get; set; }
        char Operator { get; set; }
        decimal Result { get; set; }
    }
}