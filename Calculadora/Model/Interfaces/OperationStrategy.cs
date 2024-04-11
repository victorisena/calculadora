using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model.Interfaces
{
    public interface OperationStrategy
    {
        decimal Calculate(decimal valueA, decimal valueB);
    }
}