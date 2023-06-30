using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Csharp
{
    internal class Calculadora
    {

        public int Operar(string operation, int a, int b)
        {
            if (operation == "suma")
            {
                return Suma(a, b);
            } else if(operation == "resta")
            {
                return Resta(a, b);
            } else if (operation == "multi")
            {
                return Multiplicacion(a, b);
            } else
            {
                return Division(a, b);
            }

            return 0;
        }

        private int Suma(int a, int b)
        {
            return a + b;
        }

        private int Resta(int a, int b)
        {
            return a - b;
        }

        private int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        private int Division(int a, in int b)
        {
            return a / b;
        }
    }
}
