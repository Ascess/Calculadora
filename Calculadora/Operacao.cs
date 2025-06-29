using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacao
{

    public class OperacaoMatematica
    {


        internal class Soma
        {
            public static double calcular(double a, double b)
            {
                return a + b;
            }
        }



        internal class Subtracao
        {
            public static double calcular(double a, double b)
            {
                return a - b;
            }
        }

        internal class Multiplicacao
        {
            public static double calcular(double a, double b)
            {
                return a * b;
            }
        }

        internal class Divisao
        {
            public static double calcular(double a, double b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Divisão por zero não é permitida, Pois todo número que se dividir por 0 vai dar 0");
                }
                return (double)a / b;
            }
        }
    }
}
